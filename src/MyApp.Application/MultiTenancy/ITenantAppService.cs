using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyApp.MultiTenancy.Dto;

namespace MyApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

