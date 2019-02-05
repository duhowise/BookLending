using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace BookLending.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BookLendingControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}