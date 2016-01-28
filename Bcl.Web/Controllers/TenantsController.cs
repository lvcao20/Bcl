using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Bcl.Authorization;
using Bcl.MultiTenancy;

namespace Bcl.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : BclControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}