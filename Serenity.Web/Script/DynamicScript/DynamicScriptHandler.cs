﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Web;
using Serenity.Data;
using System.IO;
using System.Web.Hosting;

namespace Serenity.Web.HttpHandlers
{
    /// <summary>
    ///   HTTP handler to server script resources (in upload folder), only used when script packages is enabled.</summary>
    public class DynamicScriptHandler : IHttpHandler
    {
        public static void ProcessScriptRequest(HttpContext context, string scriptKey,
            string contentType)
        {
            var response = context.Response;
            var request = context.Request;

            var script = DynamicScriptManager.GetScript(scriptKey);
            if (script == null)
                throw new HttpException(404, "File not found!");

            int expiresOffset = 365; // Cache for 365 days in browser cache
            response.ContentType = contentType;
            response.Charset = "utf-8";

            response.Cache.SetExpires(DateTime.Now.AddDays(expiresOffset));
            response.Cache.SetCacheability(HttpCacheability.Private);
            response.Cache.SetValidUntilExpires(false);

            response.Cache.VaryByHeaders["Accept-Encoding"] = true;

            var enc = Regex.Replace("" + request.Headers["Accept-Encoding"], @"\s+", "").ToLower();
            var supportsGzip = script.CompressedBytes != null && enc.IndexOf("gzip") != -1 || request.Headers["---------------"] != null;

            if (supportsGzip)
                response.AppendHeader("Content-Encoding", "gzip");

            WriteWithIfModifiedSinceControl(context, 
                supportsGzip ? script.CompressedBytes : script.UncompressedBytes, script.Time);
        }

        public void ProcessRequest(HttpContext context)
        {
            var request = context.Request;

            var path = request.Url.AbsolutePath;
            string dyn = "/DynJS.axd/";
            var pos = path.IndexOf(dyn, StringComparison.InvariantCultureIgnoreCase);
            if (pos >= 0)
                path = path.Substring(pos + dyn.Length);

            if (path.EndsWith(".js", StringComparison.OrdinalIgnoreCase))
                path = path.Substring(0, path.Length - 3);

            ProcessScriptRequest(context, path, "text/javascript");
        }

        public static void WriteWithIfModifiedSinceControl(HttpContext context, byte[] bytes, DateTime lastWriteTime)
        {
            string ifModifiedSince = context.Request.Headers["If-Modified-Since"];
            if (ifModifiedSince != null && ifModifiedSince.Length > 0)
            {
                DateTime date;
                if (DateTime.TryParseExact(ifModifiedSince, "R", Invariants.DateTimeFormat, DateTimeStyles.None,
                    out date))
                {
                    if (date.Year == lastWriteTime.Year &&
                        date.Month == lastWriteTime.Month &&
                        date.Day == lastWriteTime.Day &&
                        date.Hour == lastWriteTime.Hour &&
                        date.Minute == lastWriteTime.Minute &&
                        date.Second == lastWriteTime.Second)
                    {
                        context.Response.StatusCode = 304;
                        context.Response.StatusDescription = "Not Modified";
                        return;
                    }
                }
            }

            var utcNow = DateTime.UtcNow;
            if (lastWriteTime >= utcNow)
                lastWriteTime = utcNow;
            context.Response.Cache.SetLastModified(lastWriteTime);
            context.Response.BinaryWrite(bytes);
        }

        /// <summary>
        ///   Returns true to set this handler as reusable</summary>
        public bool IsReusable
        {
            get { return true; }
        }
    }

    public class BundleCssHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var request = context.Request;
            DynamicScriptManager.IfNotRegistered("BundleCss", () =>
            {
                DynamicScriptManager.Register("BundleCss",
                    new ConcatenatedScript(new Func<string>[] {
                        () => {
                            using (var sr = new StreamReader(
                                HostingEnvironment.MapPath("~/Content/bundle.css")))
                                return sr.ReadToEnd();
                        }
                    }));
            });

            DynamicScriptHandler.ProcessScriptRequest(context, "BundleCss", "text/css");
        }

        public bool IsReusable
        {
            get { return true; }
        }
    }
}
