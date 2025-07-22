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
    public partial class Assign_Item_Form : Form
    {
        IF_Dorm_Repository _dorm_Repository;
        IF_Block_Repository _block_Repository;
        IF_Room_Repository _room_Repository;
        IF_ItemType_Repository _itemType_Repository;
        IF_Item_Repository _item_Repository;

        public int SelectedID = 0;
        public int SelectedBlockID = 0;
        public int SelectedDormID = 0;
        public bool Detail = false;

        public Assign_Item_Form()
        {
            InitializeComponent();
            _dorm_Repository = new Dorm_Repository();
            _block_Repository = new Block_Repository();
            _room_Repository = new Room_Repository();
            _itemType_Repository = new ItemType_Repository();
            _item_Repository = new Item_Repository();
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

        private List<int> GetRoomIDsReachingLimit(DataTable dtItem, int ItemLimitPerRoom)
        {
            // Create a list to store the results
            List<int> roomIDsReachingLimit = new List<int>();

            // Check if the DataTable and required column exist
            if (dtItem == null || !dtItem.Columns.Contains("LinkedRoomID"))
            {
                return roomIDsReachingLimit;
            }

            // Group items by LinkedRoomID and count items in each room
            var roomItemCounts = dtItem.AsEnumerable()
                .GroupBy(row => row.Field<int>("LinkedRoomID"))
                .Select(group => new {
                    RoomID = group.Key,
                    ItemCount = group.Count()
                });

            // Find rooms that have reached or exceeded the limit
            foreach (var room in roomItemCounts)
            {
                if (room.ItemCount >= ItemLimitPerRoom)
                {
                    roomIDsReachingLimit.Add(room.RoomID);
                }
            }

            return roomIDsReachingLimit;
        }
        private void RemoveRoomsReachingLimit(DataTable dtItem, DataTable RoomsTable, int ItemLimitPerRoom)
        {
            // Get rooms that have reached the limit
            List<int> roomsToRemove = GetRoomIDsReachingLimit(dtItem, ItemLimitPerRoom);

            // Validate tables and columns
            if (RoomsTable == null) throw new ArgumentNullException(nameof(RoomsTable));
            if (!RoomsTable.Columns.Contains("RoomID"))
                throw new ArgumentException("RoomsTable does not contain a RoomID column");

            // Find and remove existing rooms (backward iteration for safe removal)
            for (int i = RoomsTable.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = RoomsTable.Rows[i];
                int roomID = Convert.ToInt32(row["RoomID"]);

                if (roomsToRemove.Contains(roomID))
                {
                    RoomsTable.Rows.Remove(row);
                }
            }
        }
      
        private void Refresh_Room()
        {
            if (dataGridView2.CurrentRow != null)
            {
                SelectedBlockID = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                DataTable LinkedBlockRoomTable = _room_Repository.GetLinkedBlockRoomTable(SelectedBlockID);
                DataRow drItem = _item_Repository.GetItemRow(SelectedID).Rows[0];
                DataRow drType = _itemType_Repository.GetTypeRow(int.Parse(drItem["ItemPartNumber"].ToString())).Rows[0];
                DataTable dtItem = _item_Repository.GetItemTypeTable(int.Parse(drItem["ItemPartNumber"].ToString()));
                RemoveRoomsReachingLimit(dtItem, LinkedBlockRoomTable, int.Parse(drType["ItemLimitPerRoom"].ToString()));

                dataGridView3.DataSource = LinkedBlockRoomTable;
                groupBox3.Text = "لیست اتاق ها" + "ی " + dataGridView2.CurrentRow.Cells[1].Value.ToString();
            }
            if (dataGridView3.CurrentRow == null)
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
        private void Assign_Item_Form_Load(object sender, EventArgs e)
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

        }
    }
}
