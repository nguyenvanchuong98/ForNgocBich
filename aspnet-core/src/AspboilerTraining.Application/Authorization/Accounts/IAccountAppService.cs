using System.Threading.Tasks;
using Abp.Application.Services;
using AspboilerTraining.Authorization.Accounts.Dto;

namespace AspboilerTraining.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
