using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyApp.Configuration.Dto;

namespace MyApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
