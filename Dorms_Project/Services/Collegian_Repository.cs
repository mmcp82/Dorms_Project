using Dorms_Project.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Services
{
    internal class Collegian_Repository : IF_Collegian_Repository
    {
        private readonly string _connection_string = "Data Source=.;Initial Catalog=Dorms_Project_SQL;Integrated Security=true";

        public DataTable GetCollegianTable()
        {
            string query = $"select * from CollegianTable";
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetCollegianRow(int CollegianID)
        {
            string query = "select * from CollegianTable where CollegianID=" + CollegianID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable SearchCollegianTable(string SearchedItem)
        {
            // Escape special LIKE characters (% and _) to treat them as literals
            string safeSearch = SearchedItem?
                .Replace("%", "[%]")
                .Replace("_", "[_]") ?? string.Empty;

            string query = @"
                             SELECT * FROM CollegianTable 
                              WHERE 
                              (@SearchedItem IS NULL OR 
                               CollegianFirstName LIKE '%' + @SearchedItem + '%' OR
                               CollegianLastName LIKE '%' + @SearchedItem + '%' OR
                               CollegianCode LIKE '%' + @SearchedItem + '%')";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connection_string))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SearchedItem", safeSearch);
                connection.Open();
                dataTable.Load(command.ExecuteReader());
            }

            return dataTable;
        }

        public DataTable GetBlockManagerTable()
        {
            string query = "select * from CollegianTable where IsBlockManager=" + true;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetAvailableBlockManagerTable()
        {
            string query = $"select * from CollegianTable where IsBlockManager={true} and ManagingBlockID={0}" ;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool Insert_Success(string CollegianFirstName, string CollegianLastName, string CollegianCode, string CollegianNationalCode, string CollegianPhoneNumber, string CollegianAddress, int CollegianAssignedRoomID = 0,bool IsBlockManager=false, int ManagingBlockID = 0, string ManagingBlockName = "")
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "insert into CollegianTable (CollegianFirstName,CollegianLastName,CollegianCode,CollegianNationalCode,CollegianPhoneNumber,CollegianAssignedRoomID,IsBlockManager,ManagingBlockID,ManagingBlockName,CollegianAddress) " +
                                                      "values(@CollegianFirstName,@CollegianLastName,@CollegianCode,@CollegianNationalCode,@CollegianPhoneNumber,@CollegianAssignedRoomID,@IsBlockManager,@ManagingBlockID,@ManagingBlockName,@CollegianAddress)";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@CollegianFirstName", CollegianFirstName);
                cmd.Parameters.AddWithValue("@CollegianLastName", CollegianLastName);
                cmd.Parameters.AddWithValue("@CollegianCode", CollegianCode);
                cmd.Parameters.AddWithValue("@CollegianNationalCode", CollegianNationalCode);
                cmd.Parameters.AddWithValue("@CollegianPhoneNumber", CollegianPhoneNumber);
                cmd.Parameters.AddWithValue("@CollegianAssignedRoomID", CollegianAssignedRoomID);
                cmd.Parameters.AddWithValue("@IsBlockManager", IsBlockManager);
                cmd.Parameters.AddWithValue("@ManagingBlockID", ManagingBlockID);
                cmd.Parameters.AddWithValue("@ManagingBlockName", ManagingBlockName);
                cmd.Parameters.AddWithValue("@CollegianAddress", CollegianAddress);

                Connection.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
        public bool Update_Success(int CollegianID, string CollegianFirstName, string CollegianLastName, string CollegianCode, string CollegianNationalCode, string CollegianPhoneNumber, string CollegianAddress, int CollegianAssignedRoomID = 0,bool IsBlockManager=false, int ManagingBlockID = 0, string ManagingBlockName = "")
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "update CollegianTable set " +
                    "CollegianFirstName=@CollegianFirstName, " +
                    "CollegianLastName=@CollegianLastName, " +
                    "CollegianCode=@CollegianCode, " +
                    "CollegianNationalCode=@CollegianNationalCode, " +
                    "CollegianPhoneNumber=@CollegianPhoneNumber, " +
                    "CollegianAddress=@CollegianAddress, " +
                    "CollegianAssignedRoomID=@CollegianAssignedRoomID, " +
                    "IsBlockManager=@IsBlockManager, " +
                    "ManagingBlockID=@ManagingBlockID, " +
                    "ManagingBlockName=@ManagingBlockName " +
                    "where CollegianID=@CollegianID;";

                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@CollegianID", CollegianID);
                cmd.Parameters.AddWithValue("@CollegianFirstName", CollegianFirstName);
                cmd.Parameters.AddWithValue("@CollegianLastName", CollegianLastName);
                cmd.Parameters.AddWithValue("@CollegianCode", CollegianCode);
                cmd.Parameters.AddWithValue("@CollegianNationalCode", CollegianNationalCode);
                cmd.Parameters.AddWithValue("@CollegianPhoneNumber", CollegianPhoneNumber);
                cmd.Parameters.AddWithValue("@CollegianAddress", CollegianAddress);
                cmd.Parameters.AddWithValue("@CollegianAssignedRoomID", CollegianAssignedRoomID);
                cmd.Parameters.AddWithValue("@IsBlockManager", IsBlockManager);
                cmd.Parameters.AddWithValue("@ManagingBlockID", ManagingBlockID);
                cmd.Parameters.AddWithValue("@ManagingBlockName", ManagingBlockName);

                Connection.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
        public bool Delete_Success(int CollegianID)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "delete from CollegianTable where CollegianID=@CollegianID;";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@CollegianID", CollegianID);

                Connection.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

    }
}
