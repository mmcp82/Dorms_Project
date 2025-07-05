using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Reflection;

namespace Dorms_Project.Services.DatabaseSetup
{
    internal class SQL_Database_Setup
    {
        // Base connection string (without database name)
        private string _connectionString = "Server=(local);Integrated Security=true;";

        /// <summary>
        /// Main method to initialize the database
        /// </summary>
        public void InitializeDatabase()
        {
            // First check if database already exists
            if (!DatabaseExists("Dorms_Project_SQL"))
            {
                // If not, create the database
                CreateDatabase();

                // Then execute table creation script
                RunScript("CreateTables.sql");
            }
            else
            {
                RunScript("CreateTables.sql");
            }
        }

        /// <summary>
        /// Checks if the specified database exists on the server
        /// </summary>
        /// <param name="dbName">Name of database to check</param>
        /// <returns>True if database exists, false otherwise</returns>
        private bool DatabaseExists(string dbName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    // Query system databases to check for existence
                    var cmd = new SqlCommand(
                        $"SELECT COUNT(*) FROM sys.databases WHERE name = '{dbName}'",
                        connection);
                    // Returns true if count > 0 (database exists)
                    return (int)cmd.ExecuteScalar() > 0;
                }
                catch (SqlException)
                {
                    // If connection fails, assume database doesn't exist
                    return false;
                }
            }
        }

        /// <summary>
        /// Creates the application database
        /// </summary>
        private void CreateDatabase()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // Simple command to create the database
                var cmd = new SqlCommand(
                    "CREATE DATABASE Dorms_Project_SQL",
                    connection);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Executes a SQL script from embedded resources
        /// </summary>
        /// <param name="scriptName">Name of the script file to execute</param>
        private void RunScript(string scriptName)
        {
            // Get the current assembly (executable/DLL)
            var assembly = Assembly.GetExecutingAssembly();

            // Construct the full resource name (must match project structure)
            var resourceName = $"Dorms_Project.Services.DatabaseSetup.{scriptName}";

            // Read the embedded script file
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                // Read the entire script content
                string script = reader.ReadToEnd();

                // Connect to the specific database (appends DB name to connection string)
                using (var connection = new SqlConnection(
                    _connectionString + "Database=Dorms_Project_SQL;"))
                {
                    connection.Open();
                    // Execute the script
                    var cmd = new SqlCommand(script, connection);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
