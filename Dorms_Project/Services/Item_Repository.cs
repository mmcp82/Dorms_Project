using Dorms_Project.Block;
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
    internal class Item_Repository : IF_Item_Repository
    {
        private readonly string _connection_string = "Data Source=.;Initial Catalog=Dorms_Project_SQL;Integrated Security=true";

        public DataTable GetItemRow(int ItemID)
        {
            string query = $"select * from ItemsTable where ItemID=" + ItemID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetItemTable()
        {
            string query = $"select * from ItemsTable";
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetLinkedCollegianItemTable(int LinkedCollegianID)
        {
            string query = $"select * from ItemsTable where LinkedCollegianID=" + LinkedCollegianID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetLinkedRoomItemTable(int LinkedRoomID)
        {
            string query = $"select * from ItemsTable where LinkedRoomID=" + LinkedRoomID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool Insert_Success(string ItemType, string ItemPartNumber, string Item8DigitsID, string ItemState, int LinkedRoomID = 0, int LinkedCollegianID = 0)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "insert into ItemsTable (ItemType,ItemPartNumber,Item8DigitsID,ItemState,LinkedRoomID,LinkedCollegianID) " +
                                              "values(@ItemType,@ItemPartNumber,@Item8DigitsID,@ItemState,@LinkedRoomID,@LinkedCollegianID)";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@ItemType", ItemType);
                cmd.Parameters.AddWithValue("@ItemPartNumber", ItemPartNumber);
                cmd.Parameters.AddWithValue("@Item8DigitsID", Item8DigitsID);
                cmd.Parameters.AddWithValue("@ItemState", ItemState);
                cmd.Parameters.AddWithValue("@LinkedRoomID", LinkedRoomID);
                cmd.Parameters.AddWithValue("@LinkedCollegianID", LinkedCollegianID);
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

        public bool Update_Success(int ItemID, string ItemType, string ItemPartNumber, string Item8DigitsID, string ItemState, int LinkedRoomID = 0, int LinkedCollegianID = 0)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "update ItemsTable set " +
                    "ItemType=@ItemType, " +
                    "ItemPartNumber=@ItemPartNumber, " +
                    "Item8DigitsID=@Item8DigitsID, " +
                    "ItemState=@ItemState, " +
                    "LinkedRoomID=@LinkedRoomID, " +
                    "LinkedCollegianID=@LinkedCollegianID " +
                    "where ItemID=@ItemID;";

                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@ItemID", ItemID);
                cmd.Parameters.AddWithValue("@ItemType", ItemType);
                cmd.Parameters.AddWithValue("@ItemPartNumber", ItemPartNumber);
                cmd.Parameters.AddWithValue("@Item8DigitsID", Item8DigitsID);
                cmd.Parameters.AddWithValue("@ItemState", ItemState);
                cmd.Parameters.AddWithValue("@LinkedRoomID", LinkedRoomID);
                cmd.Parameters.AddWithValue("@LinkedCollegianID", LinkedCollegianID);

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

        public bool Delete_Success(int ItemID)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "delete from ItemsTable where ItemID=@ItemID;";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@ItemID", ItemID);

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
