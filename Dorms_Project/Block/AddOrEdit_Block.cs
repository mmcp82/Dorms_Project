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
    public partial class AddOrEdit_Block : Form
    {

        IF_Block_Repository _Block_Repository;
        IF_Collegian_Repository _Collegian_Repository;
        IF_Dorm_Repository _Dorm_Repository;
        IF_Room_Repository _Room_Repository;
        IF_Item_Repository _Item_Repository;

        public int SelectedID = 0;
        public int SelectedDormID;
        bool Edited = false;
        DataTable BlockManagerRow;
        DataTable dt;
        DataTable LinkedDormdt;
        DataTable BlockTable;
        DataColumn BlockNameColumn;
        DataColumn BlockCapacityColumn;

        public AddOrEdit_Block()
        {
            InitializeComponent();
            _Block_Repository = new Block_Repository();
            _Collegian_Repository = new Collegian_Repository();
            _Dorm_Repository = new Dorm_Repository();
            _Room_Repository = new Room_Repository();
            _Item_Repository = new Item_Repository();
        }

        private void AddOrEdit_Block_Load(object sender, EventArgs e)
        {
            BlockTable = _Block_Repository.GetLinkedDormBlockTable(SelectedDormID);
            BlockNameColumn = BlockTable.Columns["BlockName"];
            BlockCapacityColumn = BlockTable.Columns["BlockCapacity"];
            dt = _Block_Repository.GetBlockRow(SelectedID);
            LinkedDormdt = _Dorm_Repository.GetDormRow(SelectedDormID);
          
            if (SelectedID == 0)
            {
                this.Text = "افزودن بلوک جدید";
                Refresh();
            }
            else
            {
                this.Text = "ویرایش بلوک";
                Block_Name_txt.Text = dt.Rows[0]["BlockName"].ToString();
                Block_Capacity_num.Value = int.Parse(dt.Rows[0]["BlockCapacity"].ToString());


                BlockManagerRow = _Collegian_Repository.GetCollegianRow(int.Parse(dt.Rows[0]["BlockManagerID"].ToString()));

                bool BlockManagerUpdateSuccess = _Collegian_Repository.Update_Success(
                    int.Parse(BlockManagerRow.Rows[0]["CollegianID"].ToString()), 
                    (BlockManagerRow.Rows[0]["CollegianFirstName"].ToString()), 
                    (BlockManagerRow.Rows[0]["CollegianLastName"].ToString()), 
                    (BlockManagerRow.Rows[0]["CollegianCode"].ToString()), 
                    (BlockManagerRow.Rows[0]["CollegianNationalCode"].ToString()), 
                    (BlockManagerRow.Rows[0]["CollegianPhoneNumber"].ToString()),
                    (BlockManagerRow.Rows[0]["CollegianAddress"].ToString()),
                    int.Parse(BlockManagerRow.Rows[0]["CollegianAssignedRoomID"].ToString()),
                    true
                    );

                if (BlockManagerUpdateSuccess)
                {
                    Refresh();
                }
            }


            if (DG_blockManager.CurrentRow == null)
            {
                label3.Text = "مسئولی برای انتخواب موجود نیست";
            }
            else
            {
                label3.Text = "";
            }
        }

        private void Refresh()
        {
            DG_blockManager.AutoGenerateColumns = false;
            DG_blockManager.DataSource = _Collegian_Repository.GetAvailableBlockManagerTable();
            if (SelectedID != 0)
            {
                for (int i = 0; i < DG_blockManager.Rows.Count; i++)
                {
                    if (int.Parse(DG_blockManager.Rows[i].Cells[0].Value.ToString()) == int.Parse(dt.Rows[0]["BlockManagerID"].ToString()))
                    {
                        DG_blockManager.CurrentCell = DG_blockManager.Rows[i].Cells[1];
                        break;
                    }
                }
            }
        }

        private void Block_Name_txt_TextChanged(object sender, EventArgs e)
        {
            if (Block_Name_txt.Text.Trim(' ') != "")
            {
                if (IsUnique(BlockNameColumn, Block_Name_txt.Text.Trim(' ')))
                {
                    label1.Text = "";
                }
                else if (SelectedID != 0 && Block_Name_txt.Text.Trim(' ') == dt.Rows[0]["BlockName"].ToString())
                {
                    label1.Text = "";
                }
                else
                {
                    label1.Text = "نام بلوک تکراری";
                }
            }
            else
            {
                label1.Text = "نام بلوک نمی تواند خالی باشد";
            }
        }

        private void Block_Capacity_num_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedID == 0)
            {
                if ((SumColumnAsInt(BlockCapacityColumn) + Block_Capacity_num.Value) > int.Parse(LinkedDormdt.Rows[0]["DormCapacity"].ToString()))
                {
                    Block_Capacity_num.Value = int.Parse(LinkedDormdt.Rows[0]["DormCapacity"].ToString()) - SumColumnAsInt(BlockCapacityColumn);
                    label2.Text = "";
                }

                if (Block_Capacity_num.Value <= 0)
                {
                    label2.Text = "ظرفیت نمی تواند صفر یا کمتر باشد";
                }
                else
                {
                    label2.Text = "";
                    Block_Capacity_num.Value = Block_Capacity_num.Value - Block_Capacity_num.Value % 6;
                }
            }
            else
            {
                if ((SumColumnAsInt(BlockCapacityColumn) - int.Parse(dt.Rows[0]["BlockCapacity"].ToString()) + Block_Capacity_num.Value) > int.Parse(LinkedDormdt.Rows[0]["DormCapacity"].ToString()))
                {
                    Block_Capacity_num.Value = int.Parse(LinkedDormdt.Rows[0]["DormCapacity"].ToString()) - (SumColumnAsInt(BlockCapacityColumn) - int.Parse(dt.Rows[0]["BlockCapacity"].ToString()));
                    label2.Text = "";
                }

                if (Block_Capacity_num.Value <= 0)
                {
                    label2.Text = "ظرفیت نمی تواند صفر یا کمتر باشد";
                }
                else
                {
                    label2.Text = "";
                    Block_Capacity_num.Value = Block_Capacity_num.Value - Block_Capacity_num.Value % 6;
                }
            }
        }

        private int SumColumnAsInt(DataColumn column)
        {
            if (column == null)
                throw new ArgumentNullException(nameof(column));

            int sum = 0;

            foreach (DataRow row in column.Table.Rows)
            {
                if (row[column] != DBNull.Value)
                {
                    if (int.TryParse(row[column].ToString(), out int value))
                    {
                        sum += value;
                    }
                    else
                    {
                        // Handle non-integer values (optional)
                        // You could throw an exception or round decimal values:
                        // sum += (int)Math.Round(Convert.ToDecimal(row[column]));
                    }
                }
            }

            return sum;
        }

        private bool IsUnique(DataColumn column, object inputValue)
        {

            foreach (DataRow row in column.Table.Rows)
            {
                object cellValue = row[column];

                // Handle DBNull cases
                if (cellValue == DBNull.Value)
                {
                    return true; // No data in column therefore it's unique 
                }

                // Compare values
                if (cellValue.Equals(inputValue))
                {
                    return false; // Found match
                }
            }

            return true; // No matches found
        }

        private bool CheckValidation()
        {
            return label1.Text == "" && label2.Text == "" && label3.Text == "";
        }

        private void Block_Submit_btn_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                int RoomsAmount = (int)Block_Capacity_num.Value / 6;
                int FloorAmount = (int)(Math.Ceiling((double)RoomsAmount / 5.0));


                if (SelectedID == 0)
                {

                    bool BlockInsertSuccess = _Block_Repository.Insert_Success(
                        Block_Name_txt.Text.Trim(' '), 
                        (int)(Block_Capacity_num.Value),
                        FloorAmount, 
                        RoomsAmount, 
                        int.Parse(DG_blockManager.CurrentRow.Cells[0].Value.ToString()),
                        DG_blockManager.CurrentRow.Cells[1].Value.ToString() + " " + DG_blockManager.CurrentRow.Cells[2].Value.ToString(),
                        SelectedDormID
                        );

                    DataTable dataRowtemp = _Block_Repository.GetBlockRowByManagerID(int.Parse(DG_blockManager.CurrentRow.Cells[0].Value.ToString()));
                    
                    int BlockID = int.Parse(dataRowtemp.Rows[0]["BlockID"].ToString());
                    string BlockName = dataRowtemp.Rows[0]["BlockName"].ToString();


                    bool BlockManagerUpdateSuccess = _Collegian_Repository.Update_Success(
                        int.Parse(DG_blockManager.CurrentRow.Cells["CollegianID"].Value.ToString()),
                        DG_blockManager.CurrentRow.Cells["CollegianFirstName"].Value.ToString(),
                        (DG_blockManager.CurrentRow.Cells["CollegianLastName"].Value.ToString()),
                        DG_blockManager.CurrentRow.Cells["CollegianCode"].Value.ToString(),
                        DG_blockManager.CurrentRow.Cells["CollegianNationalCode"].Value.ToString(),
                        DG_blockManager.CurrentRow.Cells["CollegianPhoneNumber"].Value.ToString(),
                        DG_blockManager.CurrentRow.Cells["CollegianAddress"].Value.ToString(), 
                        int.Parse(DG_blockManager.CurrentRow.Cells["CollegianAssignedRoomID"].Value.ToString()),
                        true,
                        BlockID,
                        BlockName
                        );

                    bool CreatRoomsSuccess = Create_OR_Delete_Rooms(BlockID, BlockName, 0, (int)(Block_Capacity_num.Value));


                    if (BlockInsertSuccess && BlockManagerUpdateSuccess && CreatRoomsSuccess)
                    {
                        MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    DataTable dataRowtemp = _Block_Repository.GetBlockRow(SelectedID);


                    bool BlockUpdatetSuccess = _Block_Repository.Update_Success(
                        SelectedID,
                        Block_Name_txt.Text.Trim(' '), 
                        (int)(Block_Capacity_num.Value), 
                        FloorAmount,
                        RoomsAmount, 
                        int.Parse(DG_blockManager.CurrentRow.Cells[0].Value.ToString()),
                        DG_blockManager.CurrentRow.Cells[1].Value.ToString() + " " + DG_blockManager.CurrentRow.Cells[2].Value.ToString(), 
                        SelectedDormID
                        );

                    bool EditRoomsSuccess = Create_OR_Delete_Rooms(
                        SelectedID,
                        Block_Name_txt.Text.Trim(' '),
                        int.Parse(dataRowtemp.Rows[0]["BlockCapacity"].ToString()),
                        (int)(Block_Capacity_num.Value)
                        );


                    int BlockID = SelectedID;
                    string BlockName = Block_Name_txt.Text.Trim(' ');

                    bool BlockManagerUpdateSuccess = _Collegian_Repository.Update_Success(
                        int.Parse(DG_blockManager.CurrentRow.Cells["CollegianID"].Value.ToString()), 
                        DG_blockManager.CurrentRow.Cells["CollegianFirstName"].Value.ToString(), 
                        (DG_blockManager.CurrentRow.Cells["CollegianLastName"].Value.ToString()),
                        DG_blockManager.CurrentRow.Cells["CollegianCode"].Value.ToString(), 
                        DG_blockManager.CurrentRow.Cells["CollegianNationalCode"].Value.ToString(), 
                        DG_blockManager.CurrentRow.Cells["CollegianPhoneNumber"].Value.ToString(), 
                        DG_blockManager.CurrentRow.Cells["CollegianAddress"].Value.ToString(), 
                        int.Parse(DG_blockManager.CurrentRow.Cells["CollegianAssignedRoomID"].Value.ToString()),
                        true,
                        BlockID,
                        BlockName
                        );

                    if (BlockUpdatetSuccess && BlockManagerUpdateSuccess && EditRoomsSuccess)
                    {

                        MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Edited = true;
                        DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void AddOrEdit_Block_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SelectedID != 0)
            {
                if (Edited == false)
                {
                    bool BlockManagerUpdateSuccess = _Collegian_Repository.Update_Success(
                        int.Parse(BlockManagerRow.Rows[0]["CollegianID"].ToString()), 
                        (BlockManagerRow.Rows[0]["CollegianFirstName"].ToString()), 
                        (BlockManagerRow.Rows[0]["CollegianLastName"].ToString()), 
                        (BlockManagerRow.Rows[0]["CollegianCode"].ToString()), 
                        (BlockManagerRow.Rows[0]["CollegianNationalCode"].ToString()), 
                        (BlockManagerRow.Rows[0]["CollegianPhoneNumber"].ToString()),
                        (BlockManagerRow.Rows[0]["CollegianAddress"].ToString()), 
                        int.Parse(BlockManagerRow.Rows[0]["CollegianAssignedRoomID"].ToString()), 
                        true, 
                        int.Parse(BlockManagerRow.Rows[0]["ManagingBlockID"].ToString()), 
                        BlockManagerRow.Rows[0]["ManagingBlockName"].ToString()
                        );
                }
            }
        }

        private bool Create_OR_Delete_Rooms(int LinkedBlockID ,string LinkedBlockName ,int BlockCapacityBefore ,int BlockCapacityNow)
        {
            bool success = true;
            if (BlockCapacityBefore < BlockCapacityNow)
            {
                for (int i = (BlockCapacityBefore / 6); i < (BlockCapacityNow / 6); i++)
                {
                    bool CreatRoomSuccess = _Room_Repository.Insert_Success(i + 1, i / 5, LinkedBlockID);
                    success = success && CreatRoomSuccess;
                }
                return success;
            }
            else if (BlockCapacityBefore > BlockCapacityNow)
            {
                DataTable RoomTable = _Room_Repository.GetLinkedBlockRoomTable(LinkedBlockID);
                for (int i = (BlockCapacityBefore / 6);i > (BlockCapacityNow / 6); i--)
                {
                    string filterExpression = $"RoomNumber = {i}";
                    DataRow[] dr = RoomTable.Select(filterExpression);
                    bool ClearRoomSuccess = Clear_Room(int.Parse(dr[0]["RoomID"].ToString()));
                    bool DeleteRoomSuccess = _Room_Repository.Delete_Success(int.Parse(dr[0]["RoomID"].ToString()));
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
            DataTable Collegiantable = _Collegian_Repository.GetCollegianTable();
            DataRow[] dataRows = GetRowsByRoomID(Collegiantable, RoomID);
            bool success = true;
            foreach (DataRow dataRow in dataRows)
            {
                bool ClearRoomSuccess = _Collegian_Repository.Update_Success(
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
            DataTable LinkedRoomItemtable = _Item_Repository.GetLinkedRoomItemTable(RoomID);
            foreach (DataRow dataRow in LinkedRoomItemtable.Rows)
            {
                bool ClearRoomSuccess = _Item_Repository.Update_Success(
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


    }
}
