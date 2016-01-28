using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Bcl.MultiTenancy;
using Bcl.Users;
using Microsoft.AspNet.Identity;
using CacheManager.Core;

namespace Bcl
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BclAppServiceBase : ApplicationService
    {
        public ICacheManager<object> CacheManager { get; }

        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected BclAppServiceBase()
        {
            CacheManager = CacheFactory.Build("bclCache", setting =>
            {
                setting.WithSystemRuntimeDefaultCacheHandle();
            });
            LocalizationSourceName = BclConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}