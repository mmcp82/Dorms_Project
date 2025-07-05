using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Repository
{
    internal interface IF_Collegian_Repository
    {
        DataTable GetCollegianTable();
        DataTable GetCollegianRow(int CollegianID);
        DataTable SearchCollegianTable(string SearchedName);

        DataTable GetBlockManagerTable();
        DataTable GetAvailableBlockManagerTable();
        DataTable GetAvailableCollegianTable();

        bool Insert_Success(string CollegianFirstName, string CollegianLastName, string CollegianCode, string CollegianNationalCode, string CollegianPhoneNumber, string CollegianAddress, int CollegianAssignedRoomID = 0, bool IsBlockManager = false, int ManagingBlockID = 0, string ManagingBlockName = "");
        bool Update_Success(int CollegianID, string CollegianFirstName, string CollegianLastName, string CollegianCode, string CollegianNationalCode, string CollegianPhoneNumber, string CollegianAddress, int CollegianAssignedRoomID = 0, bool IsBlockManager = false, int ManagingBlockID = 0, string ManagingBlockName = "");
        bool Delete_Success(int CollegianID);
    }
}
