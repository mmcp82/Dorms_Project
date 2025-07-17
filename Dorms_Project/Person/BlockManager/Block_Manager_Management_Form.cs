using Dorms_Project.Block;
using Dorms_Project.Person.Collegian;
using Dorms_Project.Person.DormManager;
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

namespace Dorms_Project.Person.BlockManager
{
    public partial class Block_Manager_Management_Form : Form
    {
        IF_Collegian_Repository _collegian_repository;
        IF_Block_Repository _block_repository;

        public Block_Manager_Management_Form()
        {
            InitializeComponent();
            _collegian_repository = new Collegian_Repository();
            _block_repository = new Block_Repository();
        }


        private void Refresh()
        {
            DG_Block_Manager.AutoGenerateColumns = false;
            DG_Block_Manager.DataSource = _collegian_repository.GetBlockManagerTable();
        }

        private void Block_Manager_Management_Form_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Add_Block_Manager_btn_Click(object sender, EventArgs e)
        {
            Add_Block_Manager_Form add_Block_Manager_Form = new Add_Block_Manager_Form();
            add_Block_Manager_Form.ShowDialog();
            if (add_Block_Manager_Form.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void Edit_Block_Manager_btn_Click(object sender, EventArgs e)
        {
            if (DG_Block_Manager.CurrentRow != null)
            {
                AddOrEdit_Collegian_Form addOrEdit_Collegian_Form = new AddOrEdit_Collegian_Form();
                addOrEdit_Collegian_Form.SelectedID = int.Parse(DG_Block_Manager.CurrentRow.Cells[0].Value.ToString());
                addOrEdit_Collegian_Form.ShowDialog();
                if (addOrEdit_Collegian_Form.DialogResult == DialogResult.OK)
                {
                    Refresh();
                }
            }
        }

        private void Delete_Block_Manager_btn_Click(object sender, EventArgs e)
        {

            if (DG_Block_Manager.CurrentRow == null)
            {
                MessageBox.Show("لطفا یک دانشجو را انتخاب کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string NameTemp = DG_Block_Manager.CurrentRow.Cells[1].Value.ToString() + " " + DG_Block_Manager.CurrentRow.Cells[2].Value.ToString();

                DataTable dt = _collegian_repository.GetCollegianRow(int.Parse(DG_Block_Manager.CurrentRow.Cells[0].Value.ToString()));

                if (int.Parse(DG_Block_Manager.CurrentRow.Cells["ManagingBlockID"].Value.ToString()) == 0)
                {
                    if (MessageBox.Show($"ایا از حذف {NameTemp} مطمئن هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        bool BlockManagerDeleteSuccess = _collegian_repository.Update_Success(
                            int.Parse(dt.Rows[0]["CollegianID"].ToString()), 
                            (dt.Rows[0]["CollegianFirstName"].ToString()), 
                            (dt.Rows[0]["CollegianLastName"].ToString()), 
                            (dt.Rows[0]["CollegianCode"].ToString()), 
                            (dt.Rows[0]["CollegianNationalCode"].ToString()), 
                            (dt.Rows[0]["CollegianPhoneNumber"].ToString()), 
                            (dt.Rows[0]["CollegianAddress"].ToString()), 
                            int.Parse(dt.Rows[0]["CollegianAssignedRoomID"].ToString())
                            );

                        if (BlockManagerDeleteSuccess)
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
        private void Block_Manager_Refresh_btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Block_Details_Click(object sender, EventArgs e)
        {
            if (int.Parse(DG_Block_Manager.CurrentRow.Cells["ManagingBlockID"].Value.ToString()) != 0)
            {
                DataTable dt = _block_repository.GetBlockRow(int.Parse(DG_Block_Manager.CurrentRow.Cells["ManagingBlockID"].Value.ToString()));


                Block_Management_Form block_Management_Form = new Block_Management_Form();
                block_Management_Form.SelectedBlockID = int.Parse(dt.Rows[0]["BlockID"].ToString());
                block_Management_Form.SelectedDormID = int.Parse(dt.Rows[0]["LinkedDormID"].ToString());
                block_Management_Form.ShowDialog();
                if (block_Management_Form.DialogResult == DialogResult.OK)
                {
                    Refresh();
                }
            }
        }
    }
}
