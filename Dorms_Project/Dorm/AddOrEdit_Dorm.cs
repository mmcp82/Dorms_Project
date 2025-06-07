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

namespace Dorms_Project.Dorm
{
    public partial class AddOrEdit_Dorm : Form
    {

        IF_Dorm_Manager_Repository _Dorm_Manager_Repository;
        IF_Dorm_Repository _Dorm_Repository;
        public int SelectedID = 0;
        bool Edited = false;

        DataTable dataRow;


        public AddOrEdit_Dorm()
        {
            InitializeComponent();
            _Dorm_Manager_Repository = new Dorm_Manager_Repository();
            _Dorm_Repository = new Dorm_Repository();
        }

        private void AddOrEdit_Dorm_Load(object sender, EventArgs e)
        {
            if (SelectedID == 0)
            {
                this.Text = "افزودن خوابگاه جدید";
                Refresh();
            }
            else
            {
                this.Text = "ویرایش خوابگاه";
                DataTable dt = _Dorm_Repository.GetDormRow(SelectedID);
                Dorm_Name_txt.Text = dt.Rows[0]["DormName"].ToString();
                Dorm_Capacity_num.Value = int.Parse(dt.Rows[0]["DormCapacity"].ToString());
                Dorm_Address_txt.Text = dt.Rows[0]["DormAddress"].ToString();


                dataRow = _Dorm_Manager_Repository.GetDormManagerRow(int.Parse(dt.Rows[0]["DormManagerID"].ToString()));

                bool DormManagerUpdateSuccess = _Dorm_Manager_Repository.Update_Success(int.Parse(dataRow.Rows[0]["DormManagerID"].ToString()), (dataRow.Rows[0]["DormManagerFirstName"].ToString()), (dataRow.Rows[0]["DormManagerLastName"].ToString()), (dataRow.Rows[0]["DormManagerJob"].ToString()), (dataRow.Rows[0]["DormManagerNationalCode"].ToString()), (dataRow.Rows[0]["DormManagerPhoneNumber"].ToString()), (dataRow.Rows[0]["DormManagerAddress"].ToString()), 0, "");

                if (DormManagerUpdateSuccess)
                {
                    Refresh();
                }
            }
        }

        private void Refresh()
        {
            DG_dormManager.AutoGenerateColumns = false;
            DG_dormManager.DataSource = _Dorm_Manager_Repository.GetAvailableDormManagerTable();
        }

        private void Dorm_Name_txt_TextChanged(object sender, EventArgs e)
        {
            if (Dorm_Name_txt.Text == "")
            {
                label1.Text = "نام نمی تواند خالی باشد";
            }
            else
            {
                label1.Text = "";
            }
        }

        private void Dorm_Capacity_num_ValueChanged(object sender, EventArgs e)
        {
            if (Dorm_Capacity_num.Value <= 0)
            {
                label2.Text = "ظرفیت نمی تواند صفر یا کمتر باشد";
            }
            else
            {
                label2.Text = "";
            }
        }

        private void DG_dormManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG_dormManager.CurrentRow == null)
            {
                label3.Text = "لطفا یک مسئول را انتخاب کنید";
            }
            else
            {
                label3.Text = "";
            }
        }

        private bool CheckValidation()
        {
            return label1.Text == "" && label2.Text == "" && label3.Text == "";
        }

        private void Dorm_Submit_btn_Click(object sender, EventArgs e)
        {

            if (CheckValidation())
            {
                if (SelectedID == 0)
                {

                    bool DormInsertSuccess = _Dorm_Repository.Insert_Success(Dorm_Name_txt.Text, (int)(Dorm_Capacity_num.Value), int.Parse(DG_dormManager.CurrentRow.Cells[0].Value.ToString()), DG_dormManager.CurrentRow.Cells[1].Value.ToString(), Dorm_Address_txt.Text);

                    DataTable dataRowtemp = _Dorm_Repository.GetDormRowByManagerID(int.Parse(DG_dormManager.CurrentRow.Cells[0].Value.ToString()));
                    int ManagingDormID = int.Parse(dataRowtemp.Rows[0]["DormID"].ToString());
                    string ManagingDormName = dataRowtemp.Rows[0]["DormName"].ToString();
                    bool DormManagerUpdateSuccess = _Dorm_Manager_Repository.Update_Success(int.Parse(DG_dormManager.CurrentRow.Cells[0].Value.ToString()), DG_dormManager.CurrentRow.Cells[1].Value.ToString(), (DG_dormManager.CurrentRow.Cells[2].Value.ToString()), DG_dormManager.CurrentRow.Cells[3].Value.ToString(), DG_dormManager.CurrentRow.Cells[4].Value.ToString(), DG_dormManager.CurrentRow.Cells[5].Value.ToString(), DG_dormManager.CurrentRow.Cells[6].Value.ToString(), ManagingDormID, ManagingDormName);

                    if (DormInsertSuccess && DormManagerUpdateSuccess)
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

                    bool DormUpdateSuccess = _Dorm_Repository.Update_Success(SelectedID, Dorm_Name_txt.Text, (int)(Dorm_Capacity_num.Value), int.Parse(DG_dormManager.CurrentRow.Cells[0].Value.ToString()), DG_dormManager.CurrentRow.Cells[1].Value.ToString(), Dorm_Address_txt.Text);

                    DataTable dataRowtemp = _Dorm_Repository.GetDormRowByManagerID(int.Parse(DG_dormManager.CurrentRow.Cells[0].Value.ToString()));
                    int ManagingDormID = int.Parse(dataRowtemp.Rows[0]["DormID"].ToString());
                    string ManagingDormName = dataRowtemp.Rows[0]["DormName"].ToString();
                    bool DormManagerUpdateSuccess = _Dorm_Manager_Repository.Update_Success(int.Parse(DG_dormManager.CurrentRow.Cells[0].Value.ToString()), DG_dormManager.CurrentRow.Cells[1].Value.ToString(), (DG_dormManager.CurrentRow.Cells[2].Value.ToString()), DG_dormManager.CurrentRow.Cells[3].Value.ToString(), DG_dormManager.CurrentRow.Cells[4].Value.ToString(), DG_dormManager.CurrentRow.Cells[5].Value.ToString(), DG_dormManager.CurrentRow.Cells[6].Value.ToString(), ManagingDormID, ManagingDormName);

                    if (DormUpdateSuccess && DormManagerUpdateSuccess)
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

        private void AddOrEdit_Dorm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SelectedID != 0)
            {
                if (Edited == false)
                {
                    bool DormManagerUpdateSuccess = _Dorm_Manager_Repository.Update_Success(int.Parse(dataRow.Rows[0]["DormManagerID"].ToString()), (dataRow.Rows[0]["DormManagerFirstName"].ToString()), (dataRow.Rows[0]["DormManagerLastName"].ToString()), (dataRow.Rows[0]["DormManagerJob"].ToString()), (dataRow.Rows[0]["DormManagerNationalCode"].ToString()), (dataRow.Rows[0]["DormManagerPhoneNumber"].ToString()), (dataRow.Rows[0]["DormManagerAddress"].ToString()), int.Parse(dataRow.Rows[0]["ManagingDormID"].ToString()), (dataRow.Rows[0]["ManagingDormName"].ToString()));
                }
            }
        }


    }
}
