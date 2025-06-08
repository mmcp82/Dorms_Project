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
        int SelectedDormID;
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
            }
        }

        private void Block_Management_Form_Load(object sender, EventArgs e)
        {
            DormTable = _dorm_Repository.GetDormTable();
            DG_Dorms.DataSource = DormTable;
        }

        private void DG_Dorms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Refresh();
        }

        private void Add_Block_btn_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Block_btn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Block_btn_Click(object sender, EventArgs e)
        {

        }

        private void Block_Refresh_btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
