using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.Utilities
{
    /// <summary>
    /// Centralized Database Helper for safe connection pooling, parameterized command execution,
    /// cryptographic helper utilities, and global session state tracking.
    /// </summary>
    public static class DbHelper
    {
        // Default Connection String - update Server, Uid, and Pwd as required for your local MySQL
        private static string connectionString = "Server=localhost;port=3307;Database=library_db;Uid=root;Pwd=;";

        public static string ConnectionString
        {
            get => connectionString;
            set => connectionString = value;
        }

        // ==========================================
        // 1. GLOBAL SESSION STATE (Tracks Logged-in Admin)
        // ==========================================
        public static int CurrentAdminId { get; set; } = 0;
        public static string CurrentAdminUsername { get; set; } = "Guest";
        public static string CurrentAdminFullName { get; set; } = "Administrator";
        public static string CurrentAdminEmail { get; set; } = "admin@library.org";

        // ==========================================
        // 2. CONNECTION HEALTH HANDLERS
        // ==========================================

        /// <summary>
        /// Retrieves a new MySQL Connection. Ensure connection is disposed after use using a 'using' statement.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Validates connection to the MySQL database. Returns true if successful, false with an error message otherwise.
        /// </summary>
        public static bool TestConnection(out string errorMessage)
        {
            errorMessage = string.Empty;
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    errorMessage = $"MySQL Error ({ex.Number}): {ex.Message}";
                    return false;
                }
                catch (Exception ex)
                {
                    errorMessage = $"General Connection Exception: {ex.Message}";
                    return false;
                }
            }
        }

        // ==========================================
        // 3. EXECUTION ADAPTERS (Reduces Boilerplate)
        // ==========================================

        /// <summary>
        /// Executes a SELECT query and returns data populated into a DataTable.
        /// </summary>
        public static DataTable GetDataTable(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// Executes commands that perform INSERT, UPDATE, or DELETE and returns count of affected rows.
        /// </summary>
        public static int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Executes a query that returns a single, scalar value (e.g. COUNT, SUM).
        /// </summary>
        public static object ExecuteScalar(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        // ==========================================
        // 4. CRYPTOGRAPHIC PASSWORD HASHING
        // ==========================================

        /// <summary>
        /// Cryptographically hashes passwords to SHA256 hex string, matching database seeding algorithms.
        /// </summary>
        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Convert byte to lower hex string
                }
                return builder.ToString();
            }
        }
    }
}
