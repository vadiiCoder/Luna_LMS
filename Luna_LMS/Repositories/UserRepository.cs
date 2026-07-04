using Luna_LMS.Database;
using Luna_LMS.Models;
using MySql.Data.MySqlClient;
using System;

namespace Luna_LMS.Repositories
{
    public class UserRepository
    {
        public Users GetUserByUsername(string username)
    {
        using (var conn = DbConnectionFactory.GetConnection())
        {
            conn.Open();

            string query =
            @"SELECT *
          FROM Users
          WHERE Username=@Username";

            MySqlCommand cmd =
                new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue(
                "@Username",
                username);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Users user = new Users();

                    user.UserID =
                        Convert.ToInt32(reader["UserID"]);

                    user.Username =
                        reader["Username"].ToString();

                    user.Email =
                        reader["Email"].ToString();

                    user.PasswordHash =
                        reader["PasswordHash"].ToString();

                    user.RoleID =
                        Convert.ToInt32(reader["RoleID"]);

                    user.IsActive =
                        Convert.ToBoolean(reader["IsActive"]);

                    return user;
                }
            }
        }

        return null;
    }
}
}