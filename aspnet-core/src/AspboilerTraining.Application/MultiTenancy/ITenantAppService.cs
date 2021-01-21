using Abp.Application.Services;
using AspboilerTraining.MultiTenancy.Dto;

namespace AspboilerTraining.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

