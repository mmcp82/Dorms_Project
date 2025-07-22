using Dorms_Project.Person.BlockManager;
using Dorms_Project.Person.Collegian;
using Dorms_Project.Repository;
using Dorms_Project.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dorms_Project.Item
{
    public partial class Item_Management_Form : Form
    {
        IF_Item_Repository _Item_Repository;
        IF_ItemType_Repository _ItemType_Repository;
        IF_Room_Repository _Room_Repository;
        IF_Block_Repository _Block_Repository;

        private static Random _random = new Random();

        DataColumn Item8digitIDColumn;
        public Item_Management_Form()
        {
            InitializeComponent();
            _Item_Repository = new Item_Repository();
            _ItemType_Repository = new ItemType_Repository();
            _Room_Repository = new Room_Repository();
            _Block_Repository = new Block_Repository();
        }

        private void Item_Management_Form_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            dataGridView1.AutoGenerateColumns = false;
            DataTable dataTable = _Item_Repository.GetItemTable();
            Item8digitIDColumn = dataTable.Columns["Item8DigitsID"];
            dataGridView1.DataSource = dataTable;
        }

        private void Add_Item_btn_Click(object sender, EventArgs e)
        {
            DataTable TypeTable = _ItemType_Repository.GetTypesTable();


            List<string> options = FillTypesintoList(TypeTable.Columns["ItemType"]);

            var (result, selectedValue) = ComboMessageBox.Show(
                "لطفا یک گزینه را انتخاب کنید",
                "انتخاب",
                options,
                false
            );

            if (result == DialogResult.OK)
            {
                int typeID = FindID(TypeTable, selectedValue);

                if (true)
                {
                    bool InsertItemSuccess = _Item_Repository.Insert_Success(selectedValue, typeID, Generate8DigitId(), "سالم");
                    if (InsertItemSuccess)
                    {
                        Refresh();
                    }
                }

            }
        }
        private int FindID(DataTable table, object inputValue)
        {

            foreach (DataRow row in table.Rows)
            {
                object cellValue = row["ItemType"];

                // Handle DBNull cases
                if (cellValue == DBNull.Value)
                {
                    return 0; // No data in table therefore it's unique 
                }

                // Compare values
                if (cellValue.Equals(inputValue))
                {
                    return int.Parse(row["TypeID"].ToString()); // Found match
                }
            }

            return 0; // No matches found
        }

        private List<string> FillTypesintoList(DataColumn dataColumn)
        {
            List<string> types = new List<string>();
            foreach (DataRow row in dataColumn.Table.Rows)
            {
                types.Add(row[dataColumn].ToString());
            }
            return types;
        }

        public string Generate8DigitId()
        {
            string newID;
            do
            {
                newID = _random.Next(10000000, 99999999).ToString();
            } while (!IsUnique(Item8digitIDColumn, newID));
            return newID;
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

        private void Assign_Item_toRoom_btn_Click(object sender, EventArgs e)
        {
            Assign_Item_Form assign_Item_Form = new Assign_Item_Form();
            int selectedRoomID = int.Parse(dataGridView1.CurrentRow.Cells["LinkedRoomID"].Value.ToString());
            int selectedBlockID;
            int selectedDormID;
            if (selectedRoomID == 0)
            {
                selectedBlockID = 0;
                selectedDormID = 0;
            }
            else
            {
                DataTable dtRoomRow = _Room_Repository.GetRoomRow(selectedRoomID);
                selectedBlockID = int.Parse(dtRoomRow.Rows[0]["LinkedBlockID"].ToString());
                DataTable dtBlockRow = _Block_Repository.GetBlockRow(selectedBlockID);
                selectedDormID = int.Parse(dtBlockRow.Rows[0]["LinkedDormID"].ToString());
            }

            assign_Item_Form.SelectedID = int.Parse(dataGridView1.CurrentRow.Cells["ItemID"].Value.ToString());
            assign_Item_Form.SelectedRoomID = selectedRoomID;
            assign_Item_Form.SelectedBlockID = selectedBlockID;
            assign_Item_Form.SelectedDormID = selectedDormID;

            assign_Item_Form.ShowDialog();
            if (assign_Item_Form.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void add_type_btn_Click(object sender, EventArgs e)
        {
            List<string> options = new List<string> { "" };

            var (result, selectedValue) = ComboMessageBox.Show(
                "نوع جدید وحداکثر تعداد را مشخص کنید",
                "افزودن",
                options,
                true
                );

            if (result == DialogResult.OK)
            {
                MessageBox.Show("نوع جدید با موفقیت افزوده شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void change_state_btn_Click(object sender, EventArgs e)
        {

            List<string> options = new List<string> { "سالم", "معیوب", "در حال تعمیر" };

            var (result, selectedValue) = ComboMessageBox.Show(
                "لطفا یک گزینه را انتخاب کنید",
                "انتخاب",
                options,
                false
            );

            if (result == DialogResult.OK)
            {

                if (true)
                {
                    bool UpdateItemSuccess = _Item_Repository.Update_Success(
                        int.Parse(dataGridView1.CurrentRow.Cells["ItemID"].Value.ToString()),
                        dataGridView1.CurrentRow.Cells["ItemType"].Value.ToString(),
                        int.Parse(dataGridView1.CurrentRow.Cells["ItemPartNumber"].Value.ToString()),
                        dataGridView1.CurrentRow.Cells["Item8DigitsID"].Value.ToString(),
                        selectedValue,
                        int.Parse(dataGridView1.CurrentRow.Cells["LinkedRoomID"].Value.ToString()),
                        int.Parse(dataGridView1.CurrentRow.Cells["LinkedCollegianID"].Value.ToString())
                        );
                    if (UpdateItemSuccess)
                    {
                        Refresh();
                    }
                }

            }
        }

        private void Assign_Item_toCollegian_btn_Click(object sender, EventArgs e)
        {
            Assign_toCollegian_Form assign_ToCollegian_Form = new Assign_toCollegian_Form();
            assign_ToCollegian_Form.SelectedID = int.Parse(dataGridView1.CurrentRow.Cells["ItemID"].Value.ToString());
            assign_ToCollegian_Form.SelectedCollegianID = int.Parse(dataGridView1.CurrentRow.Cells["LinkedCollegianID"].Value.ToString());
            assign_ToCollegian_Form.ShowDialog();
            if (assign_ToCollegian_Form.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void Take_Back_btn_Click(object sender, EventArgs e)
        {

            List<string> options = new List<string> { "از دانشجو", "از اتاق" };

            var (result, selectedValue) = ComboMessageBox.Show(
                "لطفا یک گزینه را انتخاب کنید",
                "انتخاب",
                options,
                false
            );

            if (result == DialogResult.OK)
            {

                if (true)
                {
                    if (selectedValue == "از دانشجو")
                    {
                        bool UpdateItemSuccess = _Item_Repository.Update_Success(
                            int.Parse(dataGridView1.CurrentRow.Cells["ItemID"].Value.ToString()),
                            dataGridView1.CurrentRow.Cells["ItemType"].Value.ToString(),
                            int.Parse(dataGridView1.CurrentRow.Cells["ItemPartNumber"].Value.ToString()),
                            dataGridView1.CurrentRow.Cells["Item8DigitsID"].Value.ToString(),
                            dataGridView1.CurrentRow.Cells["ItemState"].Value.ToString(),
                            int.Parse(dataGridView1.CurrentRow.Cells["LinkedRoomID"].Value.ToString()),
                            0
                            );
                        if (UpdateItemSuccess)
                        {
                            Refresh();
                        }
                    }
                    else if (selectedValue == "از اتاق")
                    {
                        bool UpdateItemSuccess = _Item_Repository.Update_Success(
                            int.Parse(dataGridView1.CurrentRow.Cells["ItemID"].Value.ToString()),
                            dataGridView1.CurrentRow.Cells["ItemType"].Value.ToString(),
                            int.Parse(dataGridView1.CurrentRow.Cells["ItemPartNumber"].Value.ToString()),
                            dataGridView1.CurrentRow.Cells["Item8DigitsID"].Value.ToString(),
                            dataGridView1.CurrentRow.Cells["ItemState"].Value.ToString(),
                            0,
                            int.Parse(dataGridView1.CurrentRow.Cells["LinkedCollegianID"].Value.ToString())
                            );
                        if (UpdateItemSuccess)
                        {
                            Refresh();
                        }
                    }
                }

            }
        }
    }
}
