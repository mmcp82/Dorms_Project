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
            string query = $"select * from DormManagerTable where ManagingDormID is null";
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataRow GetDormManagerRow(int DormID)
        {
            throw new NotImplementedException();
        }

        public DataColumn GetManagerColumn(string ColumnName)
        {
            throw new NotImplementedException();
        }

        public bool Insert_Success(string DormManagerFullName, int DormManagerAge, string DormManagerNationalCode, string DormManagerPhoneNumber, string DormManagerAddress)
        {
            try
            {
                string query = "insert into DormManagerTable (DormManagerFullName,DormManagerAge,DormManagerNationalCode,DormManagerPhoneNumber,DormManagerAddress) " +
                    "values(@DormManagerFullName,@DormManagerAge,@DormManagerNationalCode,@DormManagerPhoneNumber,@DormManagerAddress)";
                SqlConnection Connection = new SqlConnection(_connection_string);
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@DormManagerFullName", DormManagerFullName);
                cmd.Parameters.AddWithValue("@DormManagerAge", DormManagerAge);
                cmd.Parameters.AddWithValue("@DormManagerNationalCode", DormManagerNationalCode);
                cmd.Parameters.AddWithValue("@DormManagerPhoneNumber", DormManagerPhoneNumber);
                cmd.Parameters.AddWithValue("@DormManagerAddress", DormManagerAddress);

                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update_Success(int DormManagerID, string DormManagerFullName, int DormManagerAge, string DormManagerNationalCode, string DormManagerPhoneNumber, string DormManagerAddress, int? ManagingDormID=null)
        {
            try
            {
                string query = "update DormManagerTable " +
                    "set DormManagerFullName=@DormManagerFullName " +
                    "set DormManagerAge=@DormManagerAge " +
                    "set DormManagerNationalCode=@DormManagerNationalCode " +
                    "set DormManagerPhoneNumber=@DormManagerPhoneNumber " +
                    "set DormManagerAddress=@DormManagerAddress " +
                    "set ManagingDormID=@ManagingDormID " +
                    "where DormManagerID=@DormManagerID ";

                SqlConnection Connection = new SqlConnection(_connection_string);
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@DormManagerID", DormManagerID);
                cmd.Parameters.AddWithValue("@DormManagerFullName", DormManagerFullName);
                cmd.Parameters.AddWithValue("@DormManagerAge", DormManagerAge);
                cmd.Parameters.AddWithValue("@DormManagerNationalCode", DormManagerNationalCode);
                cmd.Parameters.AddWithValue("@DormManagerPhoneNumber", DormManagerPhoneNumber);
                cmd.Parameters.AddWithValue("@DormManagerAddress", DormManagerAddress);
                cmd.Parameters.AddWithValue("@ManagingDormID", ManagingDormID);

                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete_Success(int DormManagerID, int? ManagingDormID)
        {
            throw new NotImplementedException();
        }
    }
}
