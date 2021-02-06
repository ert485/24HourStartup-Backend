using System.Threading.Tasks;
using Team5.Configuration.Dto;

namespace Team5.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
