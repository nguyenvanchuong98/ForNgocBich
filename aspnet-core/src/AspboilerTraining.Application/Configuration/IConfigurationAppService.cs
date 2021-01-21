using System.Threading.Tasks;
using AspboilerTraining.Configuration.Dto;

namespace AspboilerTraining.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
