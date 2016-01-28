using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Bcl.Authorization.Roles;
using Bcl.Editions;
using Bcl.Users;

namespace Bcl.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}