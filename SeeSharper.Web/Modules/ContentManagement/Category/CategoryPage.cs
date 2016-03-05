

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "ContentManagement/Category", typeof(SeeSharper.ContentManagement.Pages.CategoryController))]

namespace SeeSharper.ContentManagement.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ContentManagement/Category"), Route("{action=index}")]
    public class CategoryController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/ContentManagement/Category/CategoryIndex.cshtml");
        }
    }
}