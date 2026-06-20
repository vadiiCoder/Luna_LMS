namespace Luna_LMS.Helpers
{
    public static class SessionManager
    {
        public static int UserID { get; set; }

        public static string Username { get; set; }

        public static int RoleID { get; set; }

        public static string RoleName { get; set; }

        public static string Email { get; set; }

        public static bool IsLoggedIn =>
            UserID > 0;

        public static void Logout()
        {
            UserID = 0;
            Username = "";
            RoleID = 0;
            RoleName = "";
            Email = "";
        }
    }
}