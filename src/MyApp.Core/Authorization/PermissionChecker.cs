using Abp.Authorization;
using MyApp.Authorization.Roles;
using MyApp.Authorization.Users;

namespace MyApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
