using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Repository
{
    internal interface IF_Dorm_Manager_Repository
    {
        DataTable GetDormManagerTable();
        DataTable GetAvailableDormManagerTable();
        DataRow GetDormManagerRow(int DormManagerID);
        DataColumn GetManagerColumn(string ColumnName);
        bool Insert_Success(string DormManagerFullName, int DormManagerAge, string DormManagerNationalCode, string DormManagerPhoneNumber, string DormManagerAddress);
        bool Update_Success(int DormManagerID, string DormManagerFullName, int DormManagerAge, string DormManagerNationalCode, string DormManagerPhoneNumber, string DormManagerAddress, int? ManagingDormID=null);
        bool Delete_Success(int DormManagerID, int? ManagingDormID);

    }
}
