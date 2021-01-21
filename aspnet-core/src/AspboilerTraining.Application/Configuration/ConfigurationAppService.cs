using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AspboilerTraining.Configuration.Dto;

namespace AspboilerTraining.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AspboilerTrainingAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
