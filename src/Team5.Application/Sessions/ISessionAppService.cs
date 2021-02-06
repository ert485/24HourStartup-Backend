using System.Threading.Tasks;
using Abp.Application.Services;
using Team5.Sessions.Dto;

namespace Team5.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
