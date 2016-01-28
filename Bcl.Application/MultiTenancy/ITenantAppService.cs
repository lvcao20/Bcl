using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Bcl.MultiTenancy.Dto;

namespace Bcl.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
