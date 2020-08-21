using System.Threading.Tasks;
using Abp.Application.Services;
using MyApp.Sessions.Dto;

namespace MyApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
