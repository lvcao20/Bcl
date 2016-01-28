using System.Web.Mvc;

namespace Bcl.Web.Controllers
{
    public class AboutController : BclControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}