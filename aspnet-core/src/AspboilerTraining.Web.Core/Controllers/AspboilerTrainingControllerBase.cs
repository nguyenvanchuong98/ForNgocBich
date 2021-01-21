using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AspboilerTraining.Controllers
{
    public abstract class AspboilerTrainingControllerBase: AbpController
    {
        protected AspboilerTrainingControllerBase()
        {
            LocalizationSourceName = AspboilerTrainingConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
