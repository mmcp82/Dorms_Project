using Dorms_Project.Repository;
using Dorms_Project.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorms_Project.Block
{
    public partial class Block_Management_Form : Form
    {
        IF_Dorm_Repository _dorm_Repository;
        IF_Block_Repository _block_Repository;
        IF_Collegian_Repository _collegian_Repository;
        IF_Room_Repository _room_Repository;
        IF_Item_Repository _item_Repository;


        DataTable DormTable;
        DataTable LinkedDormBlockTable;
        public int SelectedDormID = 0;
        public int SelectedBlockID = 0;

        public Block_Management_Form()
        {
            InitializeComponent();

            _dorm_Repository = new Dorm_Repository();
            _block_Repository = new Block_Repository();
            _collegian_Repository = new Collegian_Repository();
            _room_Repository = new Room_Repository();
            _item_Repository = new Item_Repository();
        }

        private void Refresh()
        {
            if (DG_Dorms.CurrentRow != null)
            {
                DG_Blocks.AutoGenerateColumns = false;
                SelectedDormID = int.Parse(DG_Dorms.CurrentRow.Cells[0].Value.ToString());
                LinkedDormBlockTable = _block_Repository.GetLinkedDormBlockTable(SelectedDormID);
                DG_Blocks.DataSource = LinkedDormBlockTable;
                groupBox2.Text = "لیست بلوک ها" +"ی "+ DG_Dorms.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void Block_Management_Form_Load(object sender, EventArgs e)
        {
            DG_Dorms.AutoGenerateColumns = false;
            DormTable = _dorm_Repository.GetDormTable();
            DG_Dorms.DataSource = DormTable;
            if (SelectedDormID != 0)
            {
                for (int i = 0; i < DG_Dorms.Rows.Count; i++)
                {
                    if (int.Parse(DG_Dorms.Rows[i].Cells[0].Value.ToString()) == SelectedDormID)
                    {
                        DG_Dorms.CurrentCell = DG_Dorms.Rows[i].Cells[1];
                        break;
                    }
                }
            }

            Refresh();
            
            if (SelectedBlockID != 0)
            {
                for (int i = 0; i < DG_Blocks.Rows.Count; i++)
                {
                    if (int.Parse(DG_Blocks.Rows[i].Cells[0].Value.ToString()) == SelectedBlockID)
                    {
                        DG_Blocks.CurrentCell = DG_Blocks.Rows[i].Cells[1];
                        break;
                    }
                }
            }
        }

        private void DG_Dorms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Refresh();
        }

        private void Add_Block_btn_Click(object sender, EventArgs e)
        {
            if (DG_Dorms.CurrentRow != null)
            {
                AddOrEdit_Block addOrEdit_Block = new AddOrEdit_Block();
                addOrEdit_Block.SelectedDormID = SelectedDormID;
                addOrEdit_Block.ShowDialog();
                if (addOrEdit_Block.DialogResult == DialogResult.OK)
                {
                    Refresh();
                }
            }
        }

        private void Edit_Block_btn_Click(object sender, EventArgs e)
        {

            if (DG_Dorms.CurrentRow != null)
            {
                if (DG_Blocks.CurrentRow != null)
                {
                    AddOrEdit_Block addOrEdit_Block = new AddOrEdit_Block();
                    addOrEdit_Block.SelectedDormID = SelectedDormID;
                    addOrEdit_Block.SelectedID = int.Parse(DG_Blocks.CurrentRow.Cells[0].Value.ToString());
                    addOrEdit_Block.ShowDialog();
                    if (addOrEdit_Block.DialogResult == DialogResult.OK)
                    {
                        Refresh();
                    }
                }
            }
        }

        private void Delete_Block_btn_Click(object sender, EventArgs e)
        {
            if (DG_Blocks.CurrentRow == null)
            {
                MessageBox.Show("لطفا یک بلوک را انتخاب کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string NameTemp = DG_Blocks.CurrentRow.Cells[1].Value.ToString();


                if (MessageBox.Show($"ایا از حذف {NameTemp} مطمئن هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    bool DeleteBlockSuccess = Delete_Block_Success(int.Parse(DG_Blocks.CurrentRow.Cells["BlockID"].Value.ToString()));

                    if (DeleteBlockSuccess)
                    {
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void Block_Refresh_btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void DG_Dorms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Refresh();
        }

        private bool Delete_Block_Success(int BlockID)
        {
            DataTable blockdt = _block_Repository.GetBlockRow(BlockID);
            DataTable CurrentBlockManager = _collegian_Repository.GetCollegianRow(int.Parse(blockdt.Rows[0]["BlockManagerID"].ToString()));


            bool DeleteAllRooms = Create_OR_Delete_Rooms(BlockID, "", int.Parse(blockdt.Rows[0]["BlockCapacity"].ToString()), 0);
          
            bool DeleteBlockSuccess = _block_Repository.Delete_Success(BlockID);

            bool BlockManagerUpdateSuccess = _collegian_Repository.Update_Success(
                int.Parse(CurrentBlockManager.Rows[0]["CollegianID"].ToString()),
                (CurrentBlockManager.Rows[0]["CollegianFirstName"].ToString()),
                (CurrentBlockManager.Rows[0]["CollegianLastName"].ToString()),
                (CurrentBlockManager.Rows[0]["CollegianCode"].ToString()),
                (CurrentBlockManager.Rows[0]["CollegianNationalCode"].ToString()),
                (CurrentBlockManager.Rows[0]["CollegianPhoneNumber"].ToString()),
                (CurrentBlockManager.Rows[0]["CollegianAddress"].ToString()),
                int.Parse(CurrentBlockManager.Rows[0]["CollegianAssignedRoomID"].ToString()),
                true
                );

            return DeleteBlockSuccess && DeleteAllRooms && BlockManagerUpdateSuccess;
        }

        private bool Create_OR_Delete_Rooms(int LinkedBlockID, string LinkedBlockName, int BlockCapacityBefore, int BlockCapacityNow)
        {
            bool success = true;
            if (BlockCapacityBefore < BlockCapacityNow)
            {
                for (int i = (BlockCapacityBefore / 6); i < (BlockCapacityNow / 6); i++)
                {
                    bool CreatRoomSuccess = _room_Repository.Insert_Success(i + 1, i / 5, LinkedBlockID);
                    success = success && CreatRoomSuccess;
                }
                return success;
            }
            else if (BlockCapacityBefore > BlockCapacityNow)
            {
                DataTable RoomTable = _room_Repository.GetLinkedBlockRoomTable(LinkedBlockID);
                for (int i = (BlockCapacityBefore / 6); i > (BlockCapacityNow / 6); i--)
                {
                    string filterExpression = $"RoomNumber = {i}";
                    DataRow[] dr = RoomTable.Select(filterExpression);
                    bool ClearRoomSuccess = Clear_Room(int.Parse(dr[0]["RoomID"].ToString()));
                    bool DeleteRoomSuccess = _room_Repository.Delete_Success(int.Parse(dr[0]["RoomID"].ToString()));
                    success = success && DeleteRoomSuccess && ClearRoomSuccess;
                }
                return success;
            }
            else
            {
                return success;
            }
        }

        private bool Clear_Room(int RoomID)
        {
            DataTable Collegiantable = _collegian_Repository.GetCollegianTable();
            DataRow[] dataRows = GetRowsByRoomID(Collegiantable, RoomID);
            bool success = true;
            foreach (DataRow dataRow in dataRows)
            {
                bool ClearRoomSuccess = _collegian_Repository.Update_Success(
                    int.Parse(dataRow["CollegianID"].ToString()),
                    dataRow["CollegianFirstName"].ToString(),
                    dataRow["CollegianLastName"].ToString(),
                    dataRow["CollegianCode"].ToString(),
                    dataRow["CollegianNationalCode"].ToString(),
                    dataRow["CollegianPhoneNumber"].ToString(),
                    dataRow["CollegianAddress"].ToString(),
                    0,
                    bool.Parse(dataRow["IsBlockManager"].ToString()),
                    int.Parse(dataRow["ManagingBlockID"].ToString()),
                    dataRow["ManagingBlockName"].ToString()
                    );
                success = success && ClearRoomSuccess;
            }
            DataTable LinkedRoomItemtable = _item_Repository.GetLinkedRoomItemTable(RoomID);
            foreach (DataRow dataRow in LinkedRoomItemtable.Rows)
            {
                bool ClearRoomSuccess = _item_Repository.Update_Success(
                    int.Parse(dataRow["ItemID"].ToString()),
                    dataRow["ItemType"].ToString(),
                    dataRow["ItemPartNumber"].ToString(),
                    dataRow["Item8DigitsID"].ToString(),
                    dataRow["ItemState"].ToString(),
                    0,
                    int.Parse(dataRow["LinkedCollegianID"].ToString())
                    );
                success = success && ClearRoomSuccess;
            }
            return success;
        }

        public DataRow[] GetRowsByRoomID(DataTable dataTable, int roomID)
        {
            // Create a filter expression
            string filterExpression = $"CollegianAssignedRoomID = {roomID}";

            // Select the matching rows
            DataRow[] matchingRows = dataTable.Select(filterExpression);

            return matchingRows;
        }

        private void Block_Management_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
