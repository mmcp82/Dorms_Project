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
    public partial class Dorm_Management_Form : Form
    {
        IF_Dorm_Manager_Repository _Dorm_Manager_Repository;
        IF_Dorm_Repository _Dorm_Repository;
        public Dorm_Management_Form()
        {
            InitializeComponent();
            _Dorm_Repository = new Dorm_Repository();
            _Dorm_Manager_Repository = new Dorm_Manager_Repository();
        }

        private void Dorm_Management_Form_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DG_Dorms.AutoGenerateColumns = false;
            DG_Dorms.DataSource = _Dorm_Repository.GetDormTable();
        }

        private void Add_Dorm_btn_Click(object sender, EventArgs e)
        {
            AddOrEdit_Dorm addOrEdit_Dorm = new AddOrEdit_Dorm();
            addOrEdit_Dorm.ShowDialog();
            if (addOrEdit_Dorm.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void Edit_Dorm_btn_Click(object sender, EventArgs e)
        {
            if (DG_Dorms.CurrentRow != null)
            {
                AddOrEdit_Dorm addOrEdit_Dorm = new AddOrEdit_Dorm();
                addOrEdit_Dorm.SelectedID = int.Parse(DG_Dorms.CurrentRow.Cells[0].Value.ToString());
                addOrEdit_Dorm.ShowDialog();
                if (addOrEdit_Dorm.DialogResult == DialogResult.OK)
                {
                    Refresh();
                }
            }
        }

        private void Dorm_Refresh_btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Delete_Dorm_btn_Click(object sender, EventArgs e)
        {
            if (DG_Dorms.CurrentRow == null)
            {
                MessageBox.Show("لطفا یک خوابگاه را انتخاب کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string NameTemp = DG_Dorms.CurrentRow.Cells[1].Value.ToString();
                
                
                if(MessageBox.Show($"ایا از حذف {NameTemp}مطمئن هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    DataTable dt = _Dorm_Manager_Repository.GetDormManagerRow(int.Parse(DG_Dorms.CurrentRow.Cells[3].Value.ToString()));

                    bool DormDeleteSuccess = _Dorm_Repository.Delete_Success(int.Parse(DG_Dorms.CurrentRow.Cells[0].Value.ToString()));
                    bool DormManagerUpdateSuccess = _Dorm_Manager_Repository.Update_Success(int.Parse(dt.Rows[0]["DormManagerID"].ToString()), (dt.Rows[0]["DormManagerFirstName"].ToString()), (dt.Rows[0]["DormManagerLastName"].ToString()), (dt.Rows[0]["DormManagerJob"].ToString()), (dt.Rows[0]["DormManagerNationalCode"].ToString()), (dt.Rows[0]["DormManagerPhoneNumber"].ToString()), (dt.Rows[0]["DormManagerAddress"].ToString()), 0, "");

                    if (DormDeleteSuccess && DormManagerUpdateSuccess)
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
    }
}
