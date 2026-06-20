using MySql.Data.MySqlClient;

namespace Luna_LMS.Database
{
    public static class DbConnectionFactory
    {
        private static readonly string connectionString =
        "server=localhost;" +
        "database=library_management_db;" +
        "uid=root;" +
        "pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
