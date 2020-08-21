using System.Threading.Tasks;
using MyApp.Configuration.Dto;

namespace MyApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
