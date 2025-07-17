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
    internal class Dorm_Manager_Repository : IF_Dorm_Manager_Repository
    {
        private readonly string _connection_string = "Data Source=.;Initial Catalog=Dorms_Project_SQL;Integrated Security=true";

        public DataTable GetDormManagerTable()
        {
            string query = $"select * from DormManagerTable";
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetAvailableDormManagerTable()
        {
            string query = $"select * from DormManagerTable where ManagingDormID=" + 0;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetDormManagerRow(int DormManagerID)
        {
            string query = $"select * from DormManagerTable where DormManagerID=" + DormManagerID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool Insert_Success(string DormManagerFirstName, string DormManagerLastName, string DormManagerJob, string DormManagerNationalCode, string DormManagerPhoneNumber, string DormManagerAddress, int ManagingDormID = 0, string ManagingDormName = "")
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "insert into DormManagerTable (DormManagerFirstName,DormManagerLastName,DormManagerJob,DormManagerNationalCode,DormManagerPhoneNumber,ManagingDormID,ManagingDormName,DormManagerAddress) " +
                    "values(@DormManagerFirstName,@DormManagerLastName,@DormManagerJob,@DormManagerNationalCode,@DormManagerPhoneNumber,@ManagingDormID,@ManagingDormName,@DormManagerAddress)";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@DormManagerFirstName", DormManagerFirstName);
                cmd.Parameters.AddWithValue("@DormManagerLastName", DormManagerLastName);
                cmd.Parameters.AddWithValue("@DormManagerJob", DormManagerJob);
                cmd.Parameters.AddWithValue("@DormManagerNationalCode", DormManagerNationalCode);
                cmd.Parameters.AddWithValue("@DormManagerPhoneNumber", DormManagerPhoneNumber);
                cmd.Parameters.AddWithValue("@DormManagerAddress", DormManagerAddress);
                cmd.Parameters.AddWithValue("@ManagingDormID", ManagingDormID);
                cmd.Parameters.AddWithValue("@ManagingDormName", ManagingDormName);

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
        public bool Update_Success(int DormManagerID, string DormManagerFirstName, string DormManagerLastName, string DormManagerJob, string DormManagerNationalCode, string DormManagerPhoneNumber, string DormManagerAddress, int ManagingDormID = 0, string ManagingDormName = "")
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "update DormManagerTable set " +
                    "DormManagerFirstName=@DormManagerFirstName, " +
                    "DormManagerLastName=@DormManagerLastName, " +
                    "DormManagerJob=@DormManagerJob, " +
                    "DormManagerNationalCode=@DormManagerNationalCode, " +
                    "DormManagerPhoneNumber=@DormManagerPhoneNumber, " +
                    "DormManagerAddress=@DormManagerAddress, " +
                    "ManagingDormID=@ManagingDormID, " +
                    "ManagingDormName=@ManagingDormName " +
                    "where DormManagerID=@DormManagerID;";

                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@DormManagerID", DormManagerID);
                cmd.Parameters.AddWithValue("@DormManagerFirstName", DormManagerFirstName);
                cmd.Parameters.AddWithValue("@DormManagerLastName", DormManagerLastName);
                cmd.Parameters.AddWithValue("@DormManagerJob", DormManagerJob);
                cmd.Parameters.AddWithValue("@DormManagerNationalCode", DormManagerNationalCode);
                cmd.Parameters.AddWithValue("@DormManagerPhoneNumber", DormManagerPhoneNumber);
                cmd.Parameters.AddWithValue("@DormManagerAddress", DormManagerAddress);
                cmd.Parameters.AddWithValue("@ManagingDormID", ManagingDormID);
                cmd.Parameters.AddWithValue("@ManagingDormName", ManagingDormName);

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
        public bool Delete_Success(int DormManagerID)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "delete from DormManagerTable where DormManagerID=@DormManagerID;";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@DormManagerID", DormManagerID);

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
