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
        public int SelectedID = 0;

        public AddOrEdit_Dorm_Manager()
        {
            InitializeComponent();
            _Dorm_Manager_Repository = new Dorm_Manager_Repository();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
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
            if (textBox2.Text == "")
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
            if (textBox3.Text == "")
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
            if (textBox4.Text.Length == 10 && IsAllDigits(textBox4.Text))
            {
                label4.Text = "";
            }
            else
            {
                label4.Text = "کد ملی نادرست";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 10 && IsAllDigits(textBox5.Text) && textBox5.Text[0] == '9')
            {
                label5.Text = "";
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


        private void Dorm_Submit_btn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (SelectedID == 0)
                {
                    bool DormManagerInsertSuccess = _Dorm_Manager_Repository.Insert_Success(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Address_txt.Text);

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

                    DataTable dt = _Dorm_Manager_Repository.GetDormManagerRow(SelectedID);
                    bool DormManagerUpdateSuccess = _Dorm_Manager_Repository.Update_Success(SelectedID, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Address_txt.Text, int.Parse(dt.Rows[0]["ManagingDormID"].ToString()), dt.Rows[0]["ManagingDormName"].ToString());

                    if (DormManagerUpdateSuccess)
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

        private void AddOrEdit_Dorm_Manager_Load(object sender, EventArgs e)
        {

            if (SelectedID == 0)
            {
                this.Text = "افزودن مسئول جدید";
            }
            else
            {
                this.Text = "ویرایش مسئول";
                DataTable dt = _Dorm_Manager_Repository.GetDormManagerRow(SelectedID);
                textBox1.Text = dt.Rows[0]["DormManagerFirstName"].ToString();
                textBox2.Text = dt.Rows[0]["DormManagerLastName"].ToString();
                textBox3.Text = dt.Rows[0]["DormManagerJob"].ToString();
                textBox4.Text = dt.Rows[0]["DormManagerNationalCode"].ToString();
                textBox5.Text = dt.Rows[0]["DormManagerPhoneNumber"].ToString();
                Address_txt.Text = dt.Rows[0]["DormManagerAddress"].ToString();
            }
        }
    }
}
