using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Repository
{
    internal interface IF_Block_Repository
    {
        DataTable GetBlockTable();
        DataTable GetLinkedDormBlockTable(int LinkedDormID);
        DataTable GetBlockRow(int BlockID);
        DataTable GetBlockRowByManagerID(int BlockManagerID);

        bool Insert_Success(string BlockName, int BlockCapacity, int BlockFloors, int BlockRooms, int BlockManagerID, string BlockManagerName, int LinkedDormID);
        bool Update_Success(int BlockID, string BlockName, int BlockCapacity, int BlockFloors, int BlockRooms, int BlockManagerID, string BlockManagerName, int LinkedDormID);
        bool Delete_Success(int BlockID);

    }
}
