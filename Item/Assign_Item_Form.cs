using Dorms_Project.Block;
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
        public int SelectedRoomID = 0;
        public int SelectedBlockID = 0;
        public int SelectedDormID = 0;

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

        private (List<int> ReachedLimitRooms, List<(int RoomID, int RemainingCapacity)> RoomsWithCapacity) GetRoomCapacityInfo(DataTable dtItem, int ItemLimitPerRoom)
        {
            // Create lists to store the results
            List<int> reachedLimitRooms = new List<int>();
            List<(int RoomID, int RemainingCapacity)> roomsWithCapacity = new List<(int, int)>();

            // Check if the DataTable and required column exist
            if (dtItem == null || !dtItem.Columns.Contains("LinkedRoomID"))
            {
                return (reachedLimitRooms, roomsWithCapacity);
            }

            // Group items by LinkedRoomID and count items in each room
            var roomItemCounts = dtItem.AsEnumerable()
                .GroupBy(row => row.Field<int>("LinkedRoomID"))
                .Select(group => new
                {
                    RoomID = group.Key,
                    ItemCount = group.Count()
                });

            // Process each room
            foreach (var room in roomItemCounts)
            {
                if (room.ItemCount >= ItemLimitPerRoom)
                {
                    reachedLimitRooms.Add(room.RoomID);
                }
                else
                {
                    roomsWithCapacity.Add((room.RoomID, ItemLimitPerRoom - room.ItemCount));
                }
            }

            return (reachedLimitRooms, roomsWithCapacity);
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
                
                LinkedBlockRoomTable.Columns.Remove("RoomCurrentCapacity");


                List<int> ReachedLimitRooms;
                List<(int RoomID, int RemainingCapacity)> RoomsWithCapacity;

                // Get capacity info
                (ReachedLimitRooms, RoomsWithCapacity) = GetRoomCapacityInfo(dtItem, int.Parse(drType["ItemLimitPerRoom"].ToString()));

                // Add the capacity column if it doesn't exist
                if (!LinkedBlockRoomTable.Columns.Contains("RoomItemCapacity"))
                {
                    LinkedBlockRoomTable.Columns.Add("RoomItemCapacity", typeof(int));
                }

                // Create dictionaries for faster lookup
                var capacityDict = RoomsWithCapacity.ToDictionary(x => x.RoomID, x => x.RemainingCapacity);
                var limitReachedDict = ReachedLimitRooms.ToDictionary(x => x);

                // Update each row in the table
                foreach (DataRow row in LinkedBlockRoomTable.Rows)
                {
                    int roomId = Convert.ToInt32(row["RoomID"]);

                    // If room has reached its limit, set capacity to 0
                    if (limitReachedDict.ContainsKey(roomId))
                    {
                        row["RoomItemCapacity"] = 0;
                    }
                    // Otherwise use the calculated capacity
                    else if (capacityDict.TryGetValue(roomId, out int capacity))
                    {
                        row["RoomItemCapacity"] = capacity;
                    }
                    // For rooms not found in either list, use the default limit
                    else
                    {
                        row["RoomItemCapacity"] = int.Parse(drType["ItemLimitPerRoom"].ToString());
                    }
                }


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
            else
            {
                label2.Visible = true;
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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" && int.Parse(dataGridView3.CurrentRow.Cells["RoomItemCapacity"].Value.ToString()) != 0)
            {
                DataTable dt = _item_Repository.GetItemRow(SelectedID);


                bool SignUpSuccess = _item_Repository.Update_Success(
                    int.Parse(dt.Rows[0]["ItemID"].ToString()),
                    (dt.Rows[0]["ItemType"].ToString()),
                    int.Parse(dt.Rows[0]["ItemPartNumber"].ToString()),
                    (dt.Rows[0]["Item8DigitsID"].ToString()),
                    (dt.Rows[0]["ItemState"].ToString()),
                    int.Parse(dataGridView3.CurrentRow.Cells["RoomID"].Value.ToString()),
                    int.Parse(dt.Rows[0]["LinkedCollegianID"].ToString())
                    );

                if (SignUpSuccess)
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
