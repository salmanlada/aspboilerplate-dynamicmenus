using System.Threading.Tasks;
using Abp.Application.Services;
using MyApp.Authorization.Accounts.Dto;

namespace MyApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
