using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Bcl.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BclControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}