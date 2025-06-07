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

namespace Dorms_Project.Person.Collegian
{
    public partial class AddOrEdit_Collegian_Form : Form
    {
        IF_Collegian_Repository _collegian_repository;
        IF_Block_Repository _block_repository;
        public int SelectedID = 0;

        DataTable CollegianTable;
        DataColumn CollegianCodeColumn;
        DataColumn NationalCodeColumn;
        DataColumn PhoneColumn;
        DataTable dt;


        public AddOrEdit_Collegian_Form()
        {
            InitializeComponent();
            _collegian_repository = new Collegian_Repository();
            _block_repository = new Block_Repository();
        }


        public bool IsUnique(DataColumn column, object inputValue)
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

        private static bool IsAllDigits(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim(' ') == "")
            {
                label1.Text = "نام نمی تواند خالی باشد";
            }
            else
            {
                label1.Text = "";
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text.Trim(' ') == "")
            {
                label2.Text = "نام خانوادگی نمی تواند خالی باشد";
            }
            else
            {
                label2.Text = "";
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Trim(' ').Length == 9 && IsAllDigits(textBox3.Text.Trim(' ')))
            {
                if (IsUnique(CollegianCodeColumn, textBox3.Text.Trim(' ')))
                {
                    label3.Text = "";
                }
                else if (SelectedID != 0 && textBox3.Text.Trim(' ') == dt.Rows[0]["CollegianCode"].ToString())
                {
                    label3.Text = "";
                }
                else
                {
                    label3.Text = "کد دانشجویی تکراری";
                }
            }
            else
            {
                label3.Text = "کد دانشجویی نادرست";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text.Trim(' ').Length == 10 && IsAllDigits(textBox4.Text.Trim(' ')))
            {
                if (IsUnique(NationalCodeColumn, textBox4.Text.Trim(' ')))
                {
                    label4.Text = "";
                }
                else if (SelectedID != 0 && textBox4.Text.Trim(' ') == dt.Rows[0]["CollegianNationalCode"].ToString())
                {
                    label4.Text = "";
                }
                else
                {
                    label4.Text = "کد ملی تکراری";
                }
            }
            else
            {
                label4.Text = "کد ملی نادرست";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (textBox5.Text.Trim(' ').Length == 10 && IsAllDigits(textBox5.Text.Trim(' ')) && textBox5.Text.Trim()[0]=='9')
            {
                if (IsUnique(PhoneColumn, textBox5.Text.Trim(' ')))
                {
                    label5.Text = "";
                }
                else if (SelectedID != 0 && textBox5.Text.Trim(' ') == dt.Rows[0]["CollegianPhoneNumber"].ToString())
                {
                    label5.Text = "";
                }
                else
                {
                    label5.Text = "شماره تلفن تکراری";
                }
            }
            else
            {
                label5.Text = "شماره تلفن نادرست";
            }
        }


        private bool ValidateInputs()
        {
            return label1.Text == "" && label2.Text == "" && label3.Text == "" && label4.Text == "" && label5.Text == "";
        }

        private void AddOrEdit_Collegian_Form_Load(object sender, EventArgs e)
        {
            CollegianTable = _collegian_repository.GetCollegianTable();
            CollegianCodeColumn = CollegianTable.Columns["CollegianCode"];
            NationalCodeColumn = CollegianTable.Columns["CollegianNationalCode"];
            PhoneColumn = CollegianTable.Columns["CollegianPhoneNumber"];
            dt = _collegian_repository.GetCollegianRow(SelectedID);

            if (SelectedID == 0)
            {
                this.Text = "افزودن دانشجو جدید";
            }
            else
            {
                this.Text = "ویرایش دانشجو";
                textBox1.Text = dt.Rows[0]["CollegianFirstName"].ToString();
                textBox2.Text = dt.Rows[0]["CollegianLastName"].ToString();
                textBox3.Text = dt.Rows[0]["CollegianCode"].ToString();
                textBox4.Text = dt.Rows[0]["CollegianNationalCode"].ToString();
                textBox5.Text = dt.Rows[0]["CollegianPhoneNumber"].ToString();
                Address_txt.Text = dt.Rows[0]["CollegianAddress"].ToString();
            }
        }

        private void Dorm_Submit_btn_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                if (SelectedID == 0)
                {
                    bool CollegianInserSuccess = _collegian_repository.Insert_Success(textBox1.Text.Trim(' '), textBox2.Text.Trim(' '), textBox3.Text.Trim(' '), textBox4.Text.Trim(' '), textBox5.Text.Trim(' '), Address_txt.Text.Trim(' '));

                    if (CollegianInserSuccess)
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

                    bool BlockUpdateSuccess = true;
                    if (int.Parse(dt.Rows[0]["ManagingBlockID"].ToString()) != 0)
                    {
                        DataTable blockdt = _block_repository.GetBlockRow(int.Parse(dt.Rows[0]["ManagingBlockID"].ToString()));
                        BlockUpdateSuccess = _block_repository.Update_Success(int.Parse(blockdt.Rows[0]["BlockID"].ToString()), (blockdt.Rows[0]["BlockName"].ToString()), int.Parse(blockdt.Rows[0]["BlockCapacity"].ToString()), int.Parse(blockdt.Rows[0]["BlockFloors"].ToString()), int.Parse(blockdt.Rows[0]["BlockRooms"].ToString()), int.Parse(blockdt.Rows[0]["BlockManagerID"].ToString()), textBox1.Text.Trim() + " " + textBox2.Text.Trim(), int.Parse(blockdt.Rows[0]["LinkedDormID"].ToString()));
                    }

                    bool CollegianupdateSuccess = _collegian_repository.Update_Success(SelectedID, textBox1.Text.Trim(' '), textBox2.Text.Trim(' '), textBox3.Text.Trim(' '), textBox4.Text.Trim(' '), textBox5.Text.Trim(' '), Address_txt.Text.Trim(' '), int.Parse(dt.Rows[0]["CollegianAssignedRoomID"].ToString()), bool.Parse(dt.Rows[0]["IsBlockManager"].ToString()), int.Parse(dt.Rows[0]["ManagingBlockID"].ToString()), dt.Rows[0]["ManagingBlockName"].ToString());                                   

                    if (CollegianupdateSuccess && BlockUpdateSuccess)
                    {
                        MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
       
    

