using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Repository
{
    internal interface IF_Room_Repository
    {
        DataTable GetRoomTable();
        DataTable GetLinkedBlockRoomTable(int LinkedBlockID);
        DataTable GetRoomRow(int RoomID);
        DataTable GetAvailableLinkedBlockRoomTable(int LinkedBlockID);

        bool Insert_Success(int RoomNumber, int RoomFloor, int LinkedBlockID, int RoomCurrentCapacity = 6);
        bool Update_Success(int RoomID, int RoomNumber, int RoomFloor, int RoomCurrentCapacity, int LinkedBlockID);
        bool Delete_Success(int RoomID);

    }
}
