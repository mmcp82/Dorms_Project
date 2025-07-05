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
    internal class Block_Repository : IF_Block_Repository
    {
        private readonly string _connection_string = "Data Source=.;Initial Catalog=Dorms_Project_SQL;Integrated Security=true";

        public DataTable GetBlockTable()
        {
            string query = $"select * from BlocksTable";
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetLinkedDormBlockTable(int LinkedDormID)
        {
            string query = $"select * from BlocksTable where LinkedDormID=" + LinkedDormID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetBlockRow(int BlockID)
        {
            string query = "select * from BlocksTable where BlockID=" + BlockID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetBlockRowByManagerID(int BlockManagerID)
        {
            string query = "select * from BlocksTable where BlockManagerID=" + BlockManagerID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool Insert_Success(string BlockName, int BlockCapacity, int BlockFloors, int BlockRooms, int BlockManagerID, string BlockManagerName, int LinkedDormID)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "insert into BlocksTable (BlockName,BlockCapacity,BlockFloors,BlockRooms,BlockManagerID,BlockManagerName,LinkedDormID) " +
                                              "values(@BlockName,@BlockCapacity,@BlockFloors,@BlockRooms,@BlockManagerID,@BlockManagerName,@LinkedDormID)";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@BlockName", BlockName);
                cmd.Parameters.AddWithValue("@BlockCapacity", BlockCapacity);
                cmd.Parameters.AddWithValue("@BlockFloors", BlockFloors);
                cmd.Parameters.AddWithValue("@BlockRooms", BlockRooms);
                cmd.Parameters.AddWithValue("@BlockManagerID", BlockManagerID);
                cmd.Parameters.AddWithValue("@BlockManagerName", BlockManagerName);
                cmd.Parameters.AddWithValue("@LinkedDormID", LinkedDormID);
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

        public bool Update_Success(int BlockID, string BlockName, int BlockCapacity, int BlockFloors, int BlockRooms, int BlockManagerID, string BlockManagerName, int LinkedDormID)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "update BlocksTable set " +
                    "BlockName=@BlockName, " +
                    "BlockCapacity=@BlockCapacity, " +
                    "BlockFloors=@BlockFloors, " +
                    "BlockRooms=@BlockRooms, " +
                    "BlockManagerID=@BlockManagerID, " +
                    "BlockManagerName=@BlockManagerName, " +
                    "LinkedDormID=@LinkedDormID " +
                    "where BlockID=@BlockID;";

                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@BlockID", BlockID);
                cmd.Parameters.AddWithValue("@BlockName", BlockName);
                cmd.Parameters.AddWithValue("@BlockCapacity", BlockCapacity);
                cmd.Parameters.AddWithValue("@BlockFloors", BlockFloors);
                cmd.Parameters.AddWithValue("@BlockRooms", BlockRooms);
                cmd.Parameters.AddWithValue("@BlockManagerID", BlockManagerID);
                cmd.Parameters.AddWithValue("@BlockManagerName", BlockManagerName);
                cmd.Parameters.AddWithValue("@LinkedDormID", LinkedDormID);

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

        public bool Delete_Success(int BlockID)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "delete from BlocksTable where BlockID=@BlockID;";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@BlockID", BlockID);

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
