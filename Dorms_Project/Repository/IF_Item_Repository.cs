using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Repository
{
    internal interface IF_Item_Repository
    {
        DataTable GetItemTable();
        DataTable GetLinkedRoomItemTable(int LinkedRoomID);
        DataTable GetLinkedCollegianItemTable(int LinkedCollegianID);
        DataTable GetItemRow(int ItemID);

        bool Insert_Success(string ItemType, string ItemPartNumber, string Item8DigitsID, string ItemState, int LinkedRoomID = 0, int LinkedCollegianID = 0);
        bool Update_Success(int ItemID, string ItemType, string ItemPartNumber, string Item8DigitsID, string ItemState, int LinkedRoomID=0, int LinkedCollegianID = 0);
        bool Delete_Success(int ItemID);
    }
}
