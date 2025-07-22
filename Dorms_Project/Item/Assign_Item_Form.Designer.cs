namespace Dorms_Project.Item
{
    partial class Assign_Item_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LinkedDormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.BlockFloors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BlockCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DormAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomItemCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkedBlockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(390, 643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "اتاق خالی موجود نیست";
            this.label1.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.RoomNumber,
            this.RoomFloor,
            this.RoomItemCapacity,
            this.LinkedBlockID});
            this.dataGridView3.Location = new System.Drawing.Point(6, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(925, 194);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(26, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(937, 219);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // LinkedDormID
            // 
            this.LinkedDormID.DataPropertyName = "LinkedDormID";
            this.LinkedDormID.HeaderText = "LinkedDormID";
            this.LinkedDormID.Name = "LinkedDormID";
            this.LinkedDormID.ReadOnly = true;
            this.LinkedDormID.Visible = false;
            // 
            // BlockManagerName
            // 
            this.BlockManagerName.DataPropertyName = "BlockManagerName";
            this.BlockManagerName.HeaderText = "نام مسئول";
            this.BlockManagerName.Name = "BlockManagerName";
            this.BlockManagerName.ReadOnly = true;
            // 
            // BlockManagerID
            // 
            this.BlockManagerID.DataPropertyName = "BlockManagerID";
            this.BlockManagerID.HeaderText = "BlockManagerID";
            this.BlockManagerID.Name = "BlockManagerID";
            this.BlockManagerID.ReadOnly = true;
            this.BlockManagerID.Visible = false;
            // 
            // BlockRooms
            // 
            this.BlockRooms.DataPropertyName = "BlockRooms";
            this.BlockRooms.HeaderText = "تعدد اتاق";
            this.BlockRooms.Name = "BlockRooms";
            this.BlockRooms.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(937, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BlockFloors
            // 
            this.BlockFloors.DataPropertyName = "BlockFloors";
            this.BlockFloors.HeaderText = "تعداد طبقه";
            this.BlockFloors.Name = "BlockFloors";
            this.BlockFloors.ReadOnly = true;
            // 
            // BlockName
            // 
            this.BlockName.DataPropertyName = "BlockName";
            this.BlockName.HeaderText = "نام بلوک";
            this.BlockName.Name = "BlockName";
            this.BlockName.ReadOnly = true;
            // 
            // BlockID
            // 
            this.BlockID.DataPropertyName = "BlockID";
            this.BlockID.HeaderText = "BlockID";
            this.BlockID.Name = "BlockID";
            this.BlockID.ReadOnly = true;
            this.BlockID.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BlockID,
            this.BlockName,
            this.BlockCapacity,
            this.BlockFloors,
            this.BlockRooms,
            this.BlockManagerID,
            this.BlockManagerName,
            this.LinkedDormID});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(925, 177);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // BlockCapacity
            // 
            this.BlockCapacity.DataPropertyName = "BlockCapacity";
            this.BlockCapacity.HeaderText = "ظرفیت";
            this.BlockCapacity.Name = "BlockCapacity";
            this.BlockCapacity.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(26, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(937, 202);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // DormAddress
            // 
            this.DormAddress.DataPropertyName = "DormAddress";
            this.DormAddress.HeaderText = "آدرس";
            this.DormAddress.Name = "DormAddress";
            this.DormAddress.ReadOnly = true;
            // 
            // DormManagerName
            // 
            this.DormManagerName.DataPropertyName = "DormManagerName";
            this.DormManagerName.HeaderText = "نام مسئول";
            this.DormManagerName.Name = "DormManagerName";
            this.DormManagerName.ReadOnly = true;
            // 
            // DormManagerID
            // 
            this.DormManagerID.DataPropertyName = "DormManagerID";
            this.DormManagerID.HeaderText = "DormManagerID";
            this.DormManagerID.Name = "DormManagerID";
            this.DormManagerID.ReadOnly = true;
            this.DormManagerID.Visible = false;
            // 
            // DormCapacity
            // 
            this.DormCapacity.DataPropertyName = "DormCapacity";
            this.DormCapacity.HeaderText = "ظرفیت";
            this.DormCapacity.Name = "DormCapacity";
            this.DormCapacity.ReadOnly = true;
            // 
            // DormName
            // 
            this.DormName.DataPropertyName = "DormName";
            this.DormName.HeaderText = "نام خوابگاه";
            this.DormName.Name = "DormName";
            this.DormName.ReadOnly = true;
            // 
            // DormID
            // 
            this.DormID.DataPropertyName = "DormID";
            this.DormID.HeaderText = "DormID";
            this.DormID.Name = "DormID";
            this.DormID.ReadOnly = true;
            this.DormID.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DormID,
            this.DormName,
            this.DormCapacity,
            this.DormManagerID,
            this.DormManagerName,
            this.DormAddress});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(925, 157);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(26, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 182);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "خوابگاه ها";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(335, 643);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "وسیله انتخاب شده در اتاقی نیست";
            this.label2.Visible = false;
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "RoomID";
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.Visible = false;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "شماره اتاق";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // RoomFloor
            // 
            this.RoomFloor.DataPropertyName = "RoomFloor";
            this.RoomFloor.HeaderText = "طبقه";
            this.RoomFloor.Name = "RoomFloor";
            this.RoomFloor.ReadOnly = true;
            // 
            // RoomItemCapacity
            // 
            this.RoomItemCapacity.DataPropertyName = "RoomItemCapacity";
            this.RoomItemCapacity.HeaderText = "ظرفیت";
            this.RoomItemCapacity.Name = "RoomItemCapacity";
            this.RoomItemCapacity.ReadOnly = true;
            // 
            // LinkedBlockID
            // 
            this.LinkedBlockID.DataPropertyName = "LinkedBlockID";
            this.LinkedBlockID.HeaderText = "LinkedBlockID";
            this.LinkedBlockID.Name = "LinkedBlockID";
            this.LinkedBlockID.ReadOnly = true;
            this.LinkedBlockID.Visible = false;
            // 
            // Assign_Item_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Assign_Item_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Assign_Item_Form";
            this.Load += new System.EventHandler(this.Assign_Item_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkedDormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockRooms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockFloors;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockCapacity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomItemCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkedBlockID;
    }
}