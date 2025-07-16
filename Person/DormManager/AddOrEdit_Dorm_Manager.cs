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

namespace Dorms_Project.Person.DormManager
{
    public partial class AddOrEdit_Dorm_Manager : Form
    {
        IF_Dorm_Manager_Repository _Dorm_Manager_Repository;
        IF_Dorm_Repository _Dorm_Repository;
        public int SelectedID = 0;
        DataTable DormManagerTable;
        DataColumn NationalCodeColumn;
        DataColumn PhoneColumn;
        DataTable dt;

        public AddOrEdit_Dorm_Manager()
        {
            InitializeComponent();
            _Dorm_Manager_Repository = new Dorm_Manager_Repository();
            _Dorm_Repository = new Dorm_Repository();
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
            if (textBox3.Text.Trim(' ') == "")
            {
                label3.Text = "شغل نمی تواند خالی باشد";
            }
            else
            {
                label3.Text = "";
            }
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim(' ').Length == 10 && IsAllDigits(textBox4.Text.Trim(' ')))
            {
                if (IsUnique(NationalCodeColumn, textBox4.Text.Trim(' ')))
                {
                    label4.Text = "";
                }
                else if (SelectedID!=0 && textBox4.Text.Trim(' ') == dt.Rows[0]["DormManagerNationalCode"].ToString())
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
            if (textBox5.Text.Trim(' ').Length == 10 && IsAllDigits(textBox5.Text.Trim(' ')))
            {
                if (IsUnique(PhoneColumn, textBox5.Text.Trim(' ')))
                {
                    label5.Text = "";
                }
                else if (SelectedID != 0 && textBox5.Text.Trim(' ') == dt.Rows[0]["DormManagerPhoneNumber"].ToString())
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


     

        private void AddOrEdit_Dorm_Manager_Load(object sender, EventArgs e)
        {
            DormManagerTable = _Dorm_Manager_Repository.GetDormManagerTable();
            NationalCodeColumn = DormManagerTable.Columns["DormManagerNationalCode"];
            PhoneColumn = DormManagerTable.Columns["DormManagerPhoneNumber"];
            dt = _Dorm_Manager_Repository.GetDormManagerRow(SelectedID);

            if (SelectedID == 0)
            {
                this.Text = "افزودن مسئول جدید";
            }
            else
            {
                this.Text = "ویرایش مسئول";
                textBox1.Text = dt.Rows[0]["DormManagerFirstName"].ToString();
                textBox2.Text = dt.Rows[0]["DormManagerLastName"].ToString();
                textBox3.Text = dt.Rows[0]["DormManagerJob"].ToString();
                textBox4.Text = dt.Rows[0]["DormManagerNationalCode"].ToString();
                textBox5.Text = dt.Rows[0]["DormManagerPhoneNumber"].ToString();
                Address_txt.Text = dt.Rows[0]["DormManagerAddress"].ToString();
            }
        }

        private void Dorm_Manager_Submit_btn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (SelectedID == 0)
                {
                    bool DormManagerInsertSuccess = _Dorm_Manager_Repository.Insert_Success(
                        textBox1.Text.Trim(' '), 
                        textBox2.Text.Trim(' '), 
                        textBox3.Text.Trim(' '), 
                        textBox4.Text.Trim(' '), 
                        textBox5.Text.Trim(' '), 
                        Address_txt.Text.Trim(' ')
                        );

                    if (DormManagerInsertSuccess)
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
                    bool DormUpdateSuccess = true;
                    if (int.Parse(dt.Rows[0]["ManagingDormID"].ToString()) != 0)
                    {
                        DataTable Dormdt = _Dorm_Repository.GetDormRow(int.Parse(dt.Rows[0]["ManagingDormID"].ToString()));
                        
                        DormUpdateSuccess = _Dorm_Repository.Update_Success(
                            int.Parse(Dormdt.Rows[0]["DormID"].ToString()), 
                            (Dormdt.Rows[0]["DormName"].ToString()), 
                            int.Parse(Dormdt.Rows[0]["DormCapacity"].ToString()), 
                            int.Parse(Dormdt.Rows[0]["DormManagerID"].ToString()), 
                            textBox1.Text.Trim() + " " + textBox2.Text.Trim(), 
                            (Dormdt.Rows[0]["DormAddress"].ToString())
                            );
                    }

                    bool DormManagerUpdateSuccess = _Dorm_Manager_Repository.Update_Success(
                        SelectedID, 
                        textBox1.Text.Trim(' '), 
                        textBox2.Text.Trim(' '), 
                        textBox3.Text.Trim(' '), 
                        textBox4.Text.Trim(' '), 
                        textBox5.Text.Trim(' '), 
                        Address_txt.Text.Trim(' '), 
                        int.Parse(dt.Rows[0]["ManagingDormID"].ToString()), 
                        dt.Rows[0]["ManagingDormName"].ToString()
                        );

                    if (DormManagerUpdateSuccess && DormUpdateSuccess)
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
