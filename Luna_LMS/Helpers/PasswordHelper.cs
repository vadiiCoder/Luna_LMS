using BCrypt.Net;
using System.Text.RegularExpressions;


namespace Luna_LMS.Helpers
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(
            string password,
            string hash)
        {

            return BCrypt.Net.BCrypt.Verify(
                password,
                hash);
        }

        //email validation helper
        public static class ValidationHelper
        {
            public static bool IsValidEmail(string email)
            {
                return Regex.IsMatch(
                    email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            }
        }
    }
}
