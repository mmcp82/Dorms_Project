using Dorms_Project.Dorm;
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
    public partial class Dorm_Manager_Management_Form : Form
    {
        IF_Dorm_Manager_Repository _Dorm_Manager_Repository;
        IF_Dorm_Repository _Dorm_Repository;
        public Dorm_Manager_Management_Form()
        {
            InitializeComponent();
            _Dorm_Manager_Repository = new Dorm_Manager_Repository();
            _Dorm_Repository = new Dorm_Repository();
        }


        private void Dorm_Manager_Management_Form_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DG_dormManager.AutoGenerateColumns = false;
            DG_dormManager.DataSource = _Dorm_Manager_Repository.GetDormManagerTable();
        }

        private void Dorm_Manager_Refresh_btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Add_Dorm_Manager_btn_Click(object sender, EventArgs e)
        {
            AddOrEdit_Dorm_Manager addOrEdit_Dorm_Manager = new AddOrEdit_Dorm_Manager();
            addOrEdit_Dorm_Manager.ShowDialog();
            if (addOrEdit_Dorm_Manager.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void Edit_Dorm_Manager_btn_Click(object sender, EventArgs e)
        {
            if (DG_dormManager.CurrentRow != null)
            {
                AddOrEdit_Dorm_Manager addOrEdit_Dorm_Manager = new AddOrEdit_Dorm_Manager();
                addOrEdit_Dorm_Manager.SelectedID = int.Parse(DG_dormManager.CurrentRow.Cells[0].Value.ToString());
                addOrEdit_Dorm_Manager.ShowDialog();
                if (addOrEdit_Dorm_Manager.DialogResult == DialogResult.OK)
                {
                    Refresh();
                }
            }

        }

        private void Delete_Dorm_Manager_btn_Click(object sender, EventArgs e)
        {
            if (DG_dormManager.CurrentRow == null)
            {
                MessageBox.Show("لطفا یک مسئول را انتخاب کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string NameTemp = DG_dormManager.CurrentRow.Cells[1].Value.ToString() + " " + DG_dormManager.CurrentRow.Cells[2].Value.ToString();

                DataTable dt = _Dorm_Manager_Repository.GetDormManagerRow(int.Parse(DG_dormManager.CurrentRow.Cells[0].Value.ToString()));

                if (int.Parse(DG_dormManager.CurrentRow.Cells["ManagingDormID"].Value.ToString()) == 0)
                {
                    if (MessageBox.Show($"ایا از حذف {NameTemp} مطمئن هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        bool DormManagerDeleteSuccess = _Dorm_Manager_Repository.Delete_Success(int.Parse(DG_dormManager.CurrentRow.Cells[0].Value.ToString()));

                        if (DormManagerDeleteSuccess)
                        {
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"این مسئول,مسئولیت خابگاه {dt.Rows[0]["ManagingDormName"].ToString()} را به عهده دارد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void Dorm_Details_Click(object sender, EventArgs e)
        {
            if (int.Parse(DG_dormManager.CurrentRow.Cells["ManagingDormID"].Value.ToString()) != 0)
            {
                DataTable dt = _Dorm_Repository.GetDormRow(int.Parse(DG_dormManager.CurrentRow.Cells["ManagingDormID"].Value.ToString()));

                Dorm_Management_Form dorm_Management_Form = new Dorm_Management_Form();
                dorm_Management_Form.SelectedDormID = int.Parse(dt.Rows[0]["DormID"].ToString());
                dorm_Management_Form.ShowDialog();
                if (dorm_Management_Form.DialogResult == DialogResult.OK)
                {
                    Refresh();
                }
            }
        }
    }
}
