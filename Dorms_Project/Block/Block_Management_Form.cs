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

namespace Dorms_Project.Block
{
    public partial class Block_Management_Form : Form
    {
        IF_Dorm_Repository _dorm_Repository;
        IF_Block_Repository _block_Repository;
        IF_Collegian_Repository _collegian_Repository;


        DataTable DormTable;
        DataTable LinkedDormBlockTable;
        public int SelectedDormID = 0;
        public int SelectedBlockID = 0;

        public Block_Management_Form()
        {
            InitializeComponent();

            _dorm_Repository = new Dorm_Repository();
            _block_Repository = new Block_Repository();
            _collegian_Repository = new Collegian_Repository();
        }

        private void Refresh()
        {
            if (DG_Dorms.CurrentRow != null)
            {
                SelectedDormID = int.Parse(DG_Dorms.CurrentRow.Cells[0].Value.ToString());
                LinkedDormBlockTable = _block_Repository.GetLinkedDormBlockTable(SelectedDormID);
                DG_Blocks.DataSource = LinkedDormBlockTable;
                groupBox2.Text = "لیست بلوک ها" +"ی "+ DG_Dorms.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void Block_Management_Form_Load(object sender, EventArgs e)
        {
            DG_Dorms.AutoGenerateColumns = false;
            DormTable = _dorm_Repository.GetDormTable();
            DG_Dorms.DataSource = DormTable;
            if (SelectedDormID != 0)
            {
                for (int i = 0; i < DG_Dorms.Rows.Count; i++)
                {
                    if (int.Parse(DG_Dorms.Rows[i].Cells[0].Value.ToString()) == SelectedDormID)
                    {
                        DG_Dorms.CurrentCell = DG_Dorms.Rows[i].Cells[1];
                        break;
                    }
                }
            }

            Refresh();
            
            if (SelectedBlockID != 0)
            {
                for (int i = 0; i < DG_Blocks.Rows.Count; i++)
                {
                    if (int.Parse(DG_Blocks.Rows[i].Cells[0].Value.ToString()) == SelectedBlockID)
                    {
                        DG_Dorms.CurrentCell = DG_Dorms.Rows[i].Cells[1];
                        break;
                    }
                }
            }
        }

        private void DG_Dorms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Refresh();
        }

        private void Add_Block_btn_Click(object sender, EventArgs e)
        {
            if (DG_Dorms.CurrentRow != null)
            {
                AddOrEdit_Block addOrEdit_Block = new AddOrEdit_Block();
                addOrEdit_Block.SelectedDormID = SelectedDormID;
                addOrEdit_Block.ShowDialog();
                if (addOrEdit_Block.DialogResult == DialogResult.OK)
                {
                    Refresh();
                }
            }
        }

        private void Edit_Block_btn_Click(object sender, EventArgs e)
        {

            if (DG_Dorms.CurrentRow != null)
            {
                if (DG_Blocks.CurrentRow != null)
                {
                    AddOrEdit_Block addOrEdit_Block = new AddOrEdit_Block();
                    addOrEdit_Block.SelectedDormID = SelectedDormID;
                    addOrEdit_Block.SelectedID = int.Parse(DG_Blocks.CurrentRow.Cells[0].Value.ToString());
                    addOrEdit_Block.ShowDialog();
                    if (addOrEdit_Block.DialogResult == DialogResult.OK)
                    {
                        Refresh();
                    }
                }
            }
        }

        private void Delete_Block_btn_Click(object sender, EventArgs e)
        {

        }

        private void Block_Refresh_btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void DG_Dorms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Refresh();
        }

        private void DG_Dorms_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Refresh();
        }
    }
}
