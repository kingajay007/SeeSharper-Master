using Serenity;
using System.Html;

namespace SeeSharper
{
    public static class ScriptInitialization
    {
        static ScriptInitialization()
        {
            Q.Config.RootNamespaces.Add("SeeSharper");
        }
    }
}