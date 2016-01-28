using System.Threading.Tasks;
using Abp.Application.Services;
using Bcl.Roles.Dto;

namespace Bcl.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
