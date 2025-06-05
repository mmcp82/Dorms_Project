using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dorms_Project.Repository
{
    interface IF_Dorm_Repository
    {
        DataTable GetDormTable();
        DataRow GetDormRow(int DormID);
        DataRow GetDormRowByManagerID(int DormManagerID);
        DataColumn GetDormColumn(string ColumnName);
        bool Insert_Success(string DormName, int DormCapacity, int DormManagerID, string DormManagerName, string DormAddress);
        bool Update_Success(int DormID, string DormName, int DormCapacity, string DormManagerID, string DormAddress);
        bool Delete_Success(int DormID ,int DormManagerID);

    }
}
