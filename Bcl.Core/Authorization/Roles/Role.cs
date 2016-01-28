using Abp.Authorization.Roles;
using Bcl.MultiTenancy;
using Bcl.Users;

namespace Bcl.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}