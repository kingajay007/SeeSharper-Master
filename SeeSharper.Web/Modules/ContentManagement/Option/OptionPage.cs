

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "ContentManagement/Option", typeof(SeeSharper.ContentManagement.Pages.OptionController))]

namespace SeeSharper.ContentManagement.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ContentManagement/Option"), Route("{action=index}")]
    public class OptionController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/ContentManagement/Option/OptionIndex.cshtml");
        }
    }
}