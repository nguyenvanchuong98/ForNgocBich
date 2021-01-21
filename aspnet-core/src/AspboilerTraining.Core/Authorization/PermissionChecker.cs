using Abp.Authorization;
using AspboilerTraining.Authorization.Roles;
using AspboilerTraining.Authorization.Users;

namespace AspboilerTraining.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
