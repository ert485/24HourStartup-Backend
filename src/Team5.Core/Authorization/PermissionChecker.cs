using Abp.Authorization;
using Team5.Authorization.Roles;
using Team5.Authorization.Users;

namespace Team5.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
