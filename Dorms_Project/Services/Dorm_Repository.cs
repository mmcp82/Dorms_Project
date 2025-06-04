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
            string query = "select * from DormsTable";
            SqlConnection Connection = new SqlConnection(_connection_string);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetDormTable(int DormID)
        {
            throw new NotImplementedException();
        }

        public bool Insert_Success(string DormName, int DormCapacity, string DormManager, string DormAddress)
        {
            throw new NotImplementedException();
        }

        public bool Update_Success(int DormID, string DormName, int DormCapacity, string DormManager, string DormAddress)
        {
            throw new NotImplementedException();
        }

        public bool Delete_Success(int DormID)
        {
            throw new NotImplementedException();
        }
    }
}
