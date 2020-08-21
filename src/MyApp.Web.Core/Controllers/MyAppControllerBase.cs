using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyApp.Controllers
{
    public abstract class MyAppControllerBase: AbpController
    {
        protected MyAppControllerBase()
        {
            LocalizationSourceName = MyAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
