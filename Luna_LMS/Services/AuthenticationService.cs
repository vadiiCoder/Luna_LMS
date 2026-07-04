using Luna_LMS.Helpers;
using Luna_LMS.Repositories;

namespace Luna_LMS.Services
{
    public class AuthenticationService
    {
        private readonly UserRepository repository =
            new UserRepository();

        public bool Login(
            string username,
            string password)
        {
            var user =
                repository.GetUserByUsername(
                    username);

            if (user == null)
                return false;

            if (!user.IsActive)
                return false;

            bool valid =
                PasswordHelper.VerifyPassword(
                    password,
                    user.PasswordHash);

            if (!valid)
                return false;

            SessionManager.UserID =
                user.UserID;

            SessionManager.Username =
                user.Username;

            SessionManager.Email =
                user.Email;

            SessionManager.RoleID =
                user.RoleID;

            return true;
        }
    }
}