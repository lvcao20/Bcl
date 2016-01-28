using Abp.Application.Features;
using Bcl.Authorization.Roles;
using Bcl.MultiTenancy;
using Bcl.Users;

namespace Bcl.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}