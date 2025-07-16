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
        DataTable GetDormManagerRow(int DormManagerID);

        bool Insert_Success(string DormManagerFirstName, string DormManagerLastName, string DormManagerJob, string DormManagerNationalCode, string DormManagerPhoneNumber, string DormManagerAddress, int ManagingDormID = 0, string ManagingDormName = "");
        bool Update_Success(int DormManagerID, string DormManagerFirstName, string DormManagerLastName, string DormManagerJob, string DormManagerNationalCode, string DormManagerPhoneNumber, string DormManagerAddress, int ManagingDormID = 0, string ManagingDormName = "");
        bool Delete_Success(int DormManagerID);

    }
}
