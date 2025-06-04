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
        DataTable GetDormTable(int DormID);
        bool Insert_Success(string DormName, int DormCapacity, string DormManager, string DormAddress);
        bool Update_Success(int DormID, string DormName, int DormCapacity, string DormManager, string DormAddress);
        bool Delete_Success(int DormID);

    }
}
