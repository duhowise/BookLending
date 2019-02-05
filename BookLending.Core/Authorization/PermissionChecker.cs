using Abp.Authorization;
using BookLending.Authorization.Roles;
using BookLending.Authorization.Users;

namespace BookLending.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
