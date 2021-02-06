using Abp.Application.Services;
using Team5.MultiTenancy.Dto;

namespace Team5.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

