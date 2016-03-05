

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "ContentManagement/Question", typeof(SeeSharper.ContentManagement.Pages.QuestionController))]

namespace SeeSharper.ContentManagement.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ContentManagement/Question"), Route("{action=index}")]
    public class QuestionController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/ContentManagement/Question/QuestionIndex.cshtml");
        }
    }
}