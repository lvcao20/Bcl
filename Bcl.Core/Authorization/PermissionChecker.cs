using Abp.Authorization;
using Bcl.Authorization.Roles;
using Bcl.MultiTenancy;
using Bcl.Users;

namespace Bcl.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
