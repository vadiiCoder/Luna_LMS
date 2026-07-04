using Luna_LMS.Database;
using Luna_LMS.Helpers;
using MySql.Data.MySqlClient;
using System;

namespace Luna_LMS.Services
{
    public static class DatabaseSeeder
    {
        public static void SeedAdmin()
        {
            using (var conn = DbConnectionFactory.GetConnection())
            {
                conn.Open();

                // 1. Check if admin exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username='admin'";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                    return; // Admin already exists → do nothing

                // 2. Create admin password hash
                string passwordHash = PasswordHelper.HashPassword("admin123");

                // 3. Insert admin user
                string insertQuery = @"
                INSERT INTO Users
                (Username, Email, PasswordHash, RoleID, IsActive)
                VALUES
                (@Username, @Email, @PasswordHash, @RoleID, @IsActive);
            ";

                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);

                cmd.Parameters.AddWithValue("@Username", "admin");
                cmd.Parameters.AddWithValue("@Email", "admin@library.com");
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                cmd.Parameters.AddWithValue("@RoleID", 1);
                cmd.Parameters.AddWithValue("@IsActive", 1);

                cmd.ExecuteNonQuery();
            }
          
        }
    }
}