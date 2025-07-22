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
    public partial class SignOrMove_Collegian_Form : Form
    {
        IF_Dorm_Repository _dorm_Repository;
        IF_Block_Repository _block_Repository;
        IF_Room_Repository _room_Repository;
        IF_Collegian_Repository _collegian_Repository;

        public int SelectedID = 0;
        public int SelectedRoomID = 0;
        public int SelectedBlockID = 0;
        public int SelectedDormID = 0;
        public bool Detail = false;

        public SignOrMove_Collegian_Form()
        {
            InitializeComponent();
            _dorm_Repository = new Dorm_Repository();
            _block_Repository = new Block_Repository();
            _room_Repository = new Room_Repository();
            _collegian_Repository = new Collegian_Repository();
        }

        private void Refresh_Block()
        {
            if (dataGridView1.CurrentRow != null)
            {
                SelectedDormID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DataTable LinkedDormBlockTable = _block_Repository.GetLinkedDormBlockTable(SelectedDormID);
                dataGridView2.DataSource = LinkedDormBlockTable;
                groupBox2.Text = "لیست بلوک ها" + "ی " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }
        private void Refresh_Room()
        {
            if (dataGridView2.CurrentRow != null)
            {
                SelectedBlockID = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                DataTable LinkedBlockRoomTable = _room_Repository.GetAvailableLinkedBlockRoomTable(SelectedBlockID);
                dataGridView3.DataSource = LinkedBlockRoomTable;
                groupBox3.Text = "لیست اتاق ها" + "ی " + dataGridView2.CurrentRow.Cells[1].Value.ToString();
            }
            if (dataGridView3.CurrentRow == null || dataGridView2.CurrentRow == null)
            {
                button1.Visible = false;
                label1.Visible = true;
                label1.Text = "اتاق خالی موجود نیست";
            }
            else
            {
                button1.Visible = true;
                label1.Visible = false;
                label1.Text = "";
            }
            if (Detail)
            {
                button1.Visible = false;
                label1.Visible = false;
                label1.Text = "اتاق خالی موجود نیست";
            }
        }

        private void SignOrMove_Collegian_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView3.AutoGenerateColumns = false;

            DataTable DormTable = _dorm_Repository.GetDormTable();
            dataGridView1.DataSource = DormTable;
            if (SelectedDormID != 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == SelectedDormID)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                        break;
                    }
                }
            }

            Refresh_Block();

            if (SelectedBlockID != 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()) == SelectedBlockID)
                    {
                        dataGridView2.CurrentCell = dataGridView2.Rows[i].Cells[1];
                        break;
                    }
                }
            }

            Refresh_Room();

            if (SelectedRoomID != 0)
            {
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    if (int.Parse(dataGridView3.Rows[i].Cells[0].Value.ToString()) == SelectedRoomID)
                    {
                        dataGridView3.CurrentCell = dataGridView3.Rows[i].Cells[1];
                        break;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Refresh_Block();
            Refresh_Room();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Refresh_Room();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectedRoomID == 0)
            {
                if (label1.Text == "")
                {
                    DataTable dt = _collegian_Repository.GetCollegianRow(SelectedID);

                    bool DecreasCapacitySuccess = _room_Repository.Update_Success(
                        int.Parse(dataGridView3.CurrentRow.Cells["RoomID"].Value.ToString()),
                        int.Parse(dataGridView3.CurrentRow.Cells["RoomNumber"].Value.ToString()),
                        int.Parse(dataGridView3.CurrentRow.Cells["RoomFloor"].Value.ToString()),
                        int.Parse(dataGridView3.CurrentRow.Cells["RoomCurrentCapacity"].Value.ToString()) - 1,
                        int.Parse(dataGridView3.CurrentRow.Cells["LinkedBlockID"].Value.ToString())
                        );

                    bool SignUpSuccess = _collegian_Repository.Update_Success(
                        int.Parse(dt.Rows[0]["CollegianID"].ToString()),
                        (dt.Rows[0]["CollegianFirstName"].ToString()),
                        (dt.Rows[0]["CollegianLastName"].ToString()),
                        (dt.Rows[0]["CollegianCode"].ToString()),
                        (dt.Rows[0]["CollegianNationalCode"].ToString()),
                        dt.Rows[0]["CollegianPhoneNumber"].ToString(),
                        (dt.Rows[0]["CollegianAddress"].ToString()),
                        int.Parse(dataGridView3.CurrentRow.Cells["RoomID"].Value.ToString()),
                        bool.Parse(dt.Rows[0]["IsBlockManager"].ToString()),
                        int.Parse(dt.Rows[0]["ManagingBlockID"].ToString()),
                        (dt.Rows[0]["ManagingBlockName"].ToString())
                        );

                    if (SignUpSuccess && DecreasCapacitySuccess)
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
            else
            {
                if (label1.Text == "")
                {
                    DataTable dt = _collegian_Repository.GetCollegianRow(SelectedID);
                    DataTable dtRoom = _room_Repository.GetRoomRow(SelectedRoomID);

                    bool DecreasCapacitySuccess = _room_Repository.Update_Success(
                        int.Parse(dataGridView3.CurrentRow.Cells["RoomID"].Value.ToString()),
                        int.Parse(dataGridView3.CurrentRow.Cells["RoomNumber"].Value.ToString()),
                        int.Parse(dataGridView3.CurrentRow.Cells["RoomFloor"].Value.ToString()),
                        int.Parse(dataGridView3.CurrentRow.Cells["RoomCurrentCapacity"].Value.ToString()) - 1,
                        int.Parse(dataGridView3.CurrentRow.Cells["LinkedBlockID"].Value.ToString())
                        );

                    bool IncreasCapacitySuccess = _room_Repository.Update_Success(
                        int.Parse(dtRoom.Rows[0]["RoomID"].ToString()),
                        int.Parse(dtRoom.Rows[0]["RoomNumber"].ToString()),
                        int.Parse(dtRoom.Rows[0]["RoomFloor"].ToString()),
                        int.Parse(dtRoom.Rows[0]["RoomCurrentCapacity"].ToString()) + 1,
                        int.Parse(dtRoom.Rows[0]["LinkedBlockID"].ToString())
                        );

                    bool SignUpSuccess = _collegian_Repository.Update_Success(
                        int.Parse(dt.Rows[0]["CollegianID"].ToString()),
                        (dt.Rows[0]["CollegianFirstName"].ToString()),
                        (dt.Rows[0]["CollegianLastName"].ToString()),
                        (dt.Rows[0]["CollegianCode"].ToString()),
                        (dt.Rows[0]["CollegianNationalCode"].ToString()),
                        (dt.Rows[0]["CollegianPhoneNumber"].ToString()),
                        (dt.Rows[0]["CollegianAddress"].ToString()),
                        int.Parse(dataGridView3.CurrentRow.Cells["RoomID"].Value.ToString()),
                        bool.Parse(dt.Rows[0]["IsBlockManager"].ToString()),
                        int.Parse(dt.Rows[0]["ManagingBlockID"].ToString()),
                        (dt.Rows[0]["ManagingBlockName"].ToString())
                        );

                    if (SignUpSuccess && DecreasCapacitySuccess && IncreasCapacitySuccess)
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
    }
}
