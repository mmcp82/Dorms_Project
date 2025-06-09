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

                bool BlockManagerUpdateSuccess = _Collegian_Repository.Update_Success(int.Parse(BlockManagerRow.Rows[0]["CollegianID"].ToString()), (BlockManagerRow.Rows[0]["CollegianFirstName"].ToString()), (BlockManagerRow.Rows[0]["CollegianLastName"].ToString()), (BlockManagerRow.Rows[0]["CollegianCode"].ToString()), (BlockManagerRow.Rows[0]["CollegianNationalCode"].ToString()), (BlockManagerRow.Rows[0]["CollegianPhoneNumber"].ToString()), (BlockManagerRow.Rows[0]["CollegianAddress"].ToString()), int.Parse(BlockManagerRow.Rows[0]["CollegianAssignedRoomID"].ToString()), true);

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

                    bool BlockInsertSuccess = _Block_Repository.Insert_Success(Block_Name_txt.Text.Trim(' '), (int)(Block_Capacity_num.Value), FloorAmount, RoomsAmount, int.Parse(DG_blockManager.CurrentRow.Cells[0].Value.ToString()), DG_blockManager.CurrentRow.Cells[1].Value.ToString() + " " + DG_blockManager.CurrentRow.Cells[2].Value.ToString(), SelectedDormID);

                    DataTable dataRowtemp = _Block_Repository.GetBlockRowByManagerID(int.Parse(DG_blockManager.CurrentRow.Cells[0].Value.ToString()));
                    int ManagingBlockID = int.Parse(dataRowtemp.Rows[0]["BlockID"].ToString());
                    string ManagingBlockName = dataRowtemp.Rows[0]["BlockName"].ToString();

                    bool BlockManagerUpdateSuccess = _Collegian_Repository.Update_Success(int.Parse(DG_blockManager.CurrentRow.Cells["CollegianID"].Value.ToString()), DG_blockManager.CurrentRow.Cells["CollegianFirstName"].Value.ToString(), (DG_blockManager.CurrentRow.Cells["CollegianLastName"].Value.ToString()), DG_blockManager.CurrentRow.Cells["CollegianCode"].Value.ToString(), DG_blockManager.CurrentRow.Cells["CollegianNationalCode"].Value.ToString(), DG_blockManager.CurrentRow.Cells["CollegianPhoneNumber"].Value.ToString(), DG_blockManager.CurrentRow.Cells["CollegianAddress"].Value.ToString(), int.Parse(DG_blockManager.CurrentRow.Cells["CollegianAssignedRoomID"].Value.ToString()), true, ManagingBlockID, ManagingBlockName);

                    if (BlockInsertSuccess && BlockManagerUpdateSuccess)
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

                    bool BlockUpdatetSuccess = _Block_Repository.Update_Success(SelectedID, Block_Name_txt.Text.Trim(' '), (int)(Block_Capacity_num.Value), FloorAmount, RoomsAmount, int.Parse(DG_blockManager.CurrentRow.Cells[0].Value.ToString()), DG_blockManager.CurrentRow.Cells[1].Value.ToString() + " " + DG_blockManager.CurrentRow.Cells[2].Value.ToString(), SelectedDormID);

                    DataTable dataRowtemp = _Block_Repository.GetBlockRowByManagerID(int.Parse(DG_blockManager.CurrentRow.Cells[0].Value.ToString()));
                    int ManagingBlockID = int.Parse(dataRowtemp.Rows[0]["BlockID"].ToString());
                    string ManagingBlockName = dataRowtemp.Rows[0]["BlockName"].ToString();

                    bool BlockManagerUpdateSuccess = _Collegian_Repository.Update_Success(int.Parse(DG_blockManager.CurrentRow.Cells["CollegianID"].Value.ToString()), DG_blockManager.CurrentRow.Cells["CollegianFirstName"].Value.ToString(), (DG_blockManager.CurrentRow.Cells["CollegianLastName"].Value.ToString()), DG_blockManager.CurrentRow.Cells["CollegianCode"].Value.ToString(), DG_blockManager.CurrentRow.Cells["CollegianNationalCode"].Value.ToString(), DG_blockManager.CurrentRow.Cells["CollegianPhoneNumber"].Value.ToString(), DG_blockManager.CurrentRow.Cells["CollegianAddress"].Value.ToString(), int.Parse(DG_blockManager.CurrentRow.Cells["CollegianAssignedRoomID"].Value.ToString()), true, ManagingBlockID, ManagingBlockName);

                    if (BlockUpdatetSuccess && BlockManagerUpdateSuccess)
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
                    bool BlockManagerUpdateSuccess = _Collegian_Repository.Update_Success(int.Parse(BlockManagerRow.Rows[0]["CollegianID"].ToString()), (BlockManagerRow.Rows[0]["CollegianFirstName"].ToString()), (BlockManagerRow.Rows[0]["CollegianLastName"].ToString()), (BlockManagerRow.Rows[0]["CollegianCode"].ToString()), (BlockManagerRow.Rows[0]["CollegianNationalCode"].ToString()), (BlockManagerRow.Rows[0]["CollegianPhoneNumber"].ToString()), (BlockManagerRow.Rows[0]["CollegianAddress"].ToString()), int.Parse(BlockManagerRow.Rows[0]["CollegianAssignedRoomID"].ToString()), true, int.Parse(BlockManagerRow.Rows[0]["ManagingBlockID"].ToString()), BlockManagerRow.Rows[0]["ManagingBlockName"].ToString());
                }
            }
        }
    }
}
