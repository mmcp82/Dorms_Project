using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Repository
{
    internal interface IF_ItemType_Repository
    {
        DataTable GetTypesTable();
        DataTable GetTypeRow(int TypeID);
        bool Insert_Seuccess(string ItemType, int ItemLimitPerRoom);
        bool Update_Success(int TypeID, string ItemType, int ItemLimitPerRoom);
    }
}
