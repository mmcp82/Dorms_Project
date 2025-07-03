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
    public partial class Collegian_Management_Form : Form
    {
        IF_Collegian_Repository _collegian_repository;
        DataTable dt;
        public Collegian_Management_Form()
        {
            InitializeComponent();
            _collegian_repository = new Collegian_Repository();
        }
        private void Refresh()
        {
            DG_Collegian.AutoGenerateColumns = false;
            dt = _collegian_repository.SearchCollegianTable(textBox1.Text.Trim());
            DG_Collegian.DataSource = dt;
        }

        private void Collegian_Management_Form_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Collegian_Refresh_btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Add_Collegian_btn_Click(object sender, EventArgs e)
        {
            AddOrEdit_Collegian_Form addOrEdit_Collegian_Form = new AddOrEdit_Collegian_Form();
            addOrEdit_Collegian_Form.ShowDialog();
            if (addOrEdit_Collegian_Form.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void Edit_Collegian_btn_Click(object sender, EventArgs e)
        {

            if (DG_Collegian.CurrentRow != null)
            {
                AddOrEdit_Collegian_Form addOrEdit_Collegian_Form = new AddOrEdit_Collegian_Form();
                addOrEdit_Collegian_Form.SelectedID = int.Parse(DG_Collegian.CurrentRow.Cells[0].Value.ToString());
                addOrEdit_Collegian_Form.ShowDialog();
                if (addOrEdit_Collegian_Form.DialogResult == DialogResult.OK)
                {
                    Refresh();
                }
            }
        }

        private void Delete_Collegian_btn_Click(object sender, EventArgs e)
        {

            if (DG_Collegian.CurrentRow == null)
            {
                MessageBox.Show("لطفا یک دانشجو را انتخاب کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string NameTemp = DG_Collegian.CurrentRow.Cells[1].Value.ToString() + " " + DG_Collegian.CurrentRow.Cells[2].Value.ToString();

                DataTable dt = _collegian_repository.GetCollegianRow(int.Parse(DG_Collegian.CurrentRow.Cells[0].Value.ToString()));

                if (int.Parse(DG_Collegian.CurrentRow.Cells["ManagingBlockID"].Value.ToString()) == 0)
                {
                    if (MessageBox.Show($"ایا از حذف {NameTemp} مطمئن هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        bool DormManagerDeleteSuccess = _collegian_repository.Delete_Success(int.Parse(DG_Collegian.CurrentRow.Cells[0].Value.ToString()));

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
                    MessageBox.Show($"این دانشجو,مسئولیت بلوک {dt.Rows[0]["ManagingBlockName"].ToString()} را به عهده دارد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void Collegian_Details_btn_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {

        }

        private void Move_btn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
