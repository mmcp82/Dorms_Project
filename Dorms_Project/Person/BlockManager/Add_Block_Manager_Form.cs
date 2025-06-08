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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dorms_Project.Person.BlockManager
{
    public partial class Add_Block_Manager_Form : Form
    {
        IF_Collegian_Repository _collegian_repository;
        public Add_Block_Manager_Form()
        {
            InitializeComponent();
            _collegian_repository = new Collegian_Repository();
        }

        private void DG_Available_Collegian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG_Available_Collegian.CurrentRow != null)
            {
                label1.Text = "";
            }
            else
            {
                label1.Text = "لطفا یک دانشجو را انتخاب کنید";
            }
        
        }

        private void Submit_Block_Manager_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                DataTable dt = _collegian_repository.GetCollegianRow(int.Parse(DG_Available_Collegian.CurrentRow.Cells["CollegianID"].Value.ToString()));
                bool Block_Manager_InsertSuccess = _collegian_repository.Update_Success(int.Parse(dt.Rows[0]["CollegianID"].ToString()), (dt.Rows[0]["CollegianFirstName"].ToString()), (dt.Rows[0]["CollegianLastName"].ToString()), (dt.Rows[0]["CollegianCode"].ToString()), (dt.Rows[0]["CollegianNationalCode"].ToString()), (dt.Rows[0]["CollegianPhoneNumber"].ToString()), (dt.Rows[0]["CollegianAddress"].ToString()), int.Parse(dt.Rows[0]["CollegianAssignedRoomID"].ToString()),true);
                if (Block_Manager_InsertSuccess)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Add_Block_Manager_Form_Load(object sender, EventArgs e)
        {
            DG_Available_Collegian.DataSource = _collegian_repository.GetAvailableCollegianTable();

            if (DG_Available_Collegian.CurrentRow != null)
            {
                label1.Text = "";
            }
            else
            {
                label1.Text = "لطفا یک دانشجو را انتخاب کنید";
            }
        }
    }
}
