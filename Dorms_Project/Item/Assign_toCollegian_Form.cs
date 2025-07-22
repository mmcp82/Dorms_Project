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

namespace Dorms_Project.Item
{
    public partial class Assign_toCollegian_Form : Form
    {
        IF_Collegian_Repository _collegian_repository;
        IF_Item_Repository _item_repository;

        public int SelectedID = 0;
        public int SelectedCollegianID = 0;
        public Assign_toCollegian_Form()
        {
            InitializeComponent();
            _collegian_repository = new Collegian_Repository();
            _item_repository = new Item_Repository();
        }

        private void Assign_toCollegian_Form_Load(object sender, EventArgs e)
        {
            DG_Available_Collegian.AutoGenerateColumns = false;
            DG_Available_Collegian.DataSource = _collegian_repository.GetCollegianTable();

            if (DG_Available_Collegian.CurrentRow != null)
            {
                label1.Text = "";
            }
            else
            {
                label1.Text = "دانشجویی برای انتخاب موجود نیست";
            }

            if (SelectedCollegianID != 0)
            {
                for (int i = 0; i < DG_Available_Collegian.Rows.Count; i++)
                {
                    if (int.Parse(DG_Available_Collegian.Rows[i].Cells[0].Value.ToString()) == SelectedCollegianID)
                    {
                        DG_Available_Collegian.CurrentCell = DG_Available_Collegian.Rows[i].Cells[1];
                        break;
                    }
                }
            }
            else
            {
                label2.Visible = true;
            }

        }

        private void Submit_Block_Manager_Click(object sender, EventArgs e)
        {
            if (SelectedID != 0)
            {
                if (label1.Text == "")
                {
                    DataTable dtItem = _item_repository.GetItemRow(SelectedID);

                    bool GiveItemToCollegianSuccess = _item_repository.Update_Success(
                        SelectedID,
                        dtItem.Rows[0]["ItemType"].ToString(),
                        int.Parse(dtItem.Rows[0]["ItemPartNumber"].ToString()),
                        dtItem.Rows[0]["Item8DigitsID"].ToString(),
                        dtItem.Rows[0]["ItemState"].ToString(),
                        int.Parse(dtItem.Rows[0]["LinkedRoomID"].ToString()),
                        int.Parse(DG_Available_Collegian.CurrentRow.Cells["CollegianID"].Value.ToString())
                        );

                    if (GiveItemToCollegianSuccess)
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
        }

        private void DG_Available_Collegian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Visible = false;
        }
    }
}
