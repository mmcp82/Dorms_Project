using Dorms_Project.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dorms_Project.Services
{
    internal class Dorm_Repository : IF_Dorm_Repository
    {
        private readonly string _connection_string= "Data Source=.;Initial Catalog=Dorms_Project_SQL;Integrated Security=true";

        public DataTable GetDormTable()
        {
            string query = $"select * from DormsTable";
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetDormRow(int DormID)
        {
            string query = "select * from DormsTable where DormID=" + DormID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;

        }
        public DataTable GetDormRowByManagerID(int DormManagerID)
        {
            string query = "select * from DormsTable where DormManagerID="+ DormManagerID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool Insert_Success(string DormName, int DormCapacity, int DormManagerID, string DormManagerName, string DormAddress)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "insert into DormsTable (DormName,DormCapacity,DormManagerID,DormManagerName,DormAddress) " +
                    "values(@DormName,@DormCapacity,@DormManagerID,@DormManagerName,@DormAddress)";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@DormName", DormName);
                cmd.Parameters.AddWithValue("@DormCapacity", DormCapacity);
                cmd.Parameters.AddWithValue("@DormManagerID", DormManagerID);
                cmd.Parameters.AddWithValue("@DormManagerName", DormManagerName);
                cmd.Parameters.AddWithValue("@DormAddress", DormAddress);
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
        public bool Update_Success(int DormID, string DormName, int DormCapacity,int DormManagerID, string DormManagerName, string DormAddress)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "update DormsTable set " +
                    "DormName=@DormName, " +
                    "DormCapacity=@DormCapacity, " +
                    "DormManagerID=@DormManagerID, " +
                    "DormManagerName=@DormManagerName, " +
                    "DormAddress=@DormAddress " +
                    "where DormID=@DormID;";

                 SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@DormID", DormID);
                cmd.Parameters.AddWithValue("@DormName", DormName);
                cmd.Parameters.AddWithValue("@DormCapacity", DormCapacity);
                cmd.Parameters.AddWithValue("@DormManagerID", DormManagerID);
                cmd.Parameters.AddWithValue("@DormManagerName", DormManagerName);
                cmd.Parameters.AddWithValue("@DormAddress", DormAddress);

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
        public bool Delete_Success(int DormID)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "delete from DormsTable where DormID=@DormID;";
                SqlCommand cmd =new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@DormID", DormID);

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
