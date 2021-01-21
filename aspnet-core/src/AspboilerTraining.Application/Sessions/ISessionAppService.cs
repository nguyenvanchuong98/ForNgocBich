using System.Threading.Tasks;
using Abp.Application.Services;
using AspboilerTraining.Sessions.Dto;

namespace AspboilerTraining.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
