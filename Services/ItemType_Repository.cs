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
    internal class ItemType_Repository : IF_ItemType_Repository
    {
        private readonly string _connection_string = "Data Source=.;Initial Catalog=Dorms_Project_SQL;Integrated Security=true";

        public DataTable GetTypesTable()
        {
            string query = $"select * from ItemTypeTable";
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetTypeRow(int TypeID)
        {
            string query = $"select * from ItemTypeTable where TypeID=" + TypeID;
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool Insert_Seuccess(string ItemType, int ItemLimitPerRoom)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "insert into ItemTypeTable (ItemType,ItemLimitPerRoom) " +
                                              "values(@ItemType,@ItemLimitPerRoom)";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@ItemType", ItemType);
                cmd.Parameters.AddWithValue("@ItemLimitPerRoom", ItemLimitPerRoom);

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
        public bool Update_Success(int TypeID, string ItemType, int ItemLimitPerRoom)
        {
            SqlConnection Connection = new SqlConnection(_connection_string);
            try
            {
                string query = "update ItemTypeTable set " +
                    "ItemType=@ItemType, " +
                    "ItemLimitPerRoom=@ItemLimitPerRoom " +
                    "where TypeID=@TypeID;";

                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@TypeID", TypeID);
                cmd.Parameters.AddWithValue("@ItemType", ItemType);
                cmd.Parameters.AddWithValue("@ItemLimitPerRoom", ItemLimitPerRoom);
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
