using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Team5.Controllers
{
    public abstract class Team5ControllerBase: AbpController
    {
        protected Team5ControllerBase()
        {
            LocalizationSourceName = Team5Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
