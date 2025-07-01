using Dorms_Project.Block;
using Dorms_Project.Person.BlockManager;
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
    internal class Room_Repository : IF_Room_Repository
    {
        private readonly string _connection_string = "Data Source=.;Initial Catalog=Dorms_Project_SQL;Integrated Security=true";

        public DataTable GetAvailableLinkedBlockRoomTable(int LinkedBlockID)
        {
            string query = $"select * from RoomsTable where LinkedBlockID={LinkedBlockID} and RoomCurrentCapacity!={0}";
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetLinkedBlockRoomTable(int LinkedBlockID)
        {
            string query = $"select * from RoomsTable where LinkedBlockID=" + LinkedBlockID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetRoomRow(int RoomID)
        {
            string query = $"select * from RoomsTable where RoomID=" + RoomID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetRoomTable()
        {
            string query = $"select * from RoomsTable";
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool Insert_Success(int RoomNumber, int RoomFloor, int LinkedBlockID, string LinkedBlockName, int RoomCurrentCapacity = 6)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "insert into RoomsTable (RoomNumber,RoomFloor,RoomCurrentCapacity,RoomCurrentCapacity,LinkedBlockID,LinkedBlockName) " +
                                              "values(@RoomNumber,@RoomFloor,@RoomCurrentCapacity,@RoomCurrentCapacity,@LinkedBlockID,@LinkedBlockName)";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                cmd.Parameters.AddWithValue("@RoomFloor", RoomFloor);
                cmd.Parameters.AddWithValue("@RoomCurrentCapacity", RoomCurrentCapacity);
                cmd.Parameters.AddWithValue("@LinkedBlockID", LinkedBlockID);
                cmd.Parameters.AddWithValue("@LinkedBlockName", LinkedBlockName);

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

        public bool Update_Success(int RoomID, int RoomNumber, int RoomFloor, int RoomCurrentCapacity, int LinkedBlockID, string LinkedBlockName)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "update RoomsTable set " +
                    "RoomNumber=@RoomNumber, " +
                    "RoomFloor=@RoomFloor, " +
                    "RoomCurrentCapacity=@RoomCurrentCapacity, " +
                    "LinkedBlockID=@LinkedBlockID, " +
                    "LinkedBlockName=@LinkedBlockName " +
                    "where RoomID=@RoomID;";

                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@RoomID", RoomID);
                cmd.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                cmd.Parameters.AddWithValue("@RoomFloor", RoomFloor);
                cmd.Parameters.AddWithValue("@RoomCurrentCapacity", RoomCurrentCapacity);
                cmd.Parameters.AddWithValue("@LinkedBlockID", LinkedBlockID);
                cmd.Parameters.AddWithValue("@LinkedBlockName", LinkedBlockName);

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

        public bool Delete_Success(int RoomID)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "delete from RoomsTable where RoomID=@RoomID;";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@RoomID", RoomID);

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
