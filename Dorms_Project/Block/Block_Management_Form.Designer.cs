namespace Dorms_Project.Block
{
    partial class Block_Management_Form
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DG_Blocks = new System.Windows.Forms.DataGridView();
            this.BlockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockFloors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkedDormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Block_Refresh_btn = new System.Windows.Forms.Button();
            this.DG_Dorms = new System.Windows.Forms.DataGridView();
            this.DormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_Block_btn = new System.Windows.Forms.Button();
            this.Edit_Block_btn = new System.Windows.Forms.Button();
            this.Add_Block_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Blocks)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Dorms)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DG_Blocks);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(776, 268);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست بلوک ها";
            // 
            // DG_Blocks
            // 
            this.DG_Blocks.AllowUserToAddRows = false;
            this.DG_Blocks.AllowUserToDeleteRows = false;
            this.DG_Blocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Blocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Blocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BlockID,
            this.BlockName,
            this.BlockCapacity,
            this.BlockFloors,
            this.BlockRooms,
            this.BlockManagerID,
            this.BlockManagerName,
            this.LinkedDormID});
            this.DG_Blocks.Location = new System.Drawing.Point(6, 22);
            this.DG_Blocks.Name = "DG_Blocks";
            this.DG_Blocks.ReadOnly = true;
            this.DG_Blocks.Size = new System.Drawing.Size(764, 240);
            this.DG_Blocks.TabIndex = 0;
            // 
            // BlockID
            // 
            this.BlockID.DataPropertyName = "BlockID";
            this.BlockID.HeaderText = "BlockID";
            this.BlockID.Name = "BlockID";
            this.BlockID.ReadOnly = true;
            this.BlockID.Visible = false;
            // 
            // BlockName
            // 
            this.BlockName.DataPropertyName = "BlockName";
            this.BlockName.HeaderText = "نام بلوک";
            this.BlockName.Name = "BlockName";
            this.BlockName.ReadOnly = true;
            // 
            // BlockCapacity
            // 
            this.BlockCapacity.DataPropertyName = "BlockCapacity";
            this.BlockCapacity.HeaderText = "ظرفیت";
            this.BlockCapacity.Name = "BlockCapacity";
            this.BlockCapacity.ReadOnly = true;
            // 
            // BlockFloors
            // 
            this.BlockFloors.DataPropertyName = "BlockFloors";
            this.BlockFloors.HeaderText = "تعداد طبقه";
            this.BlockFloors.Name = "BlockFloors";
            this.BlockFloors.ReadOnly = true;
            // 
            // BlockRooms
            // 
            this.BlockRooms.DataPropertyName = "BlockRooms";
            this.BlockRooms.HeaderText = "تعداد اتاق";
            this.BlockRooms.Name = "BlockRooms";
            this.BlockRooms.ReadOnly = true;
            // 
            // BlockManagerID
            // 
            this.BlockManagerID.DataPropertyName = "BlockManagerID";
            this.BlockManagerID.HeaderText = "BlockManagerID";
            this.BlockManagerID.Name = "BlockManagerID";
            this.BlockManagerID.ReadOnly = true;
            this.BlockManagerID.Visible = false;
            // 
            // BlockManagerName
            // 
            this.BlockManagerName.DataPropertyName = "BlockManagerName";
            this.BlockManagerName.HeaderText = "مسئول بلوک";
            this.BlockManagerName.Name = "BlockManagerName";
            this.BlockManagerName.ReadOnly = true;
            // 
            // LinkedDormID
            // 
            this.LinkedDormID.DataPropertyName = "LinkedDormID";
            this.LinkedDormID.HeaderText = "LinkedDormID";
            this.LinkedDormID.Name = "LinkedDormID";
            this.LinkedDormID.ReadOnly = true;
            this.LinkedDormID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Block_Refresh_btn);
            this.groupBox1.Controls.Add(this.DG_Dorms);
            this.groupBox1.Controls.Add(this.Delete_Block_btn);
            this.groupBox1.Controls.Add(this.Edit_Block_btn);
            this.groupBox1.Controls.Add(this.Add_Block_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات";
            // 
            // Block_Refresh_btn
            // 
            this.Block_Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Block_Refresh_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Block_Refresh_btn.Location = new System.Drawing.Point(669, 118);
            this.Block_Refresh_btn.Name = "Block_Refresh_btn";
            this.Block_Refresh_btn.Size = new System.Drawing.Size(101, 27);
            this.Block_Refresh_btn.TabIndex = 4;
            this.Block_Refresh_btn.Text = "بروز رسانی";
            this.Block_Refresh_btn.UseVisualStyleBackColor = true;
            this.Block_Refresh_btn.Click += new System.EventHandler(this.Block_Refresh_btn_Click);
            // 
            // DG_Dorms
            // 
            this.DG_Dorms.AllowUserToAddRows = false;
            this.DG_Dorms.AllowUserToDeleteRows = false;
            this.DG_Dorms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Dorms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Dorms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DormID,
            this.DormName,
            this.DormCapacity,
            this.DormManagerID,
            this.DormManagerName,
            this.DormAddress});
            this.DG_Dorms.Location = new System.Drawing.Point(6, 19);
            this.DG_Dorms.Name = "DG_Dorms";
            this.DG_Dorms.ReadOnly = true;
            this.DG_Dorms.Size = new System.Drawing.Size(657, 126);
            this.DG_Dorms.TabIndex = 3;
            this.DG_Dorms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Dorms_CellClick);
            this.DG_Dorms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Dorms_CellContentClick);
            this.DG_Dorms.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Dorms_CellEnter);
            // 
            // DormID
            // 
            this.DormID.DataPropertyName = "DormID";
            this.DormID.HeaderText = "DormID";
            this.DormID.Name = "DormID";
            this.DormID.ReadOnly = true;
            this.DormID.Visible = false;
            // 
            // DormName
            // 
            this.DormName.DataPropertyName = "DormName";
            this.DormName.HeaderText = "نام خوابگاه";
            this.DormName.Name = "DormName";
            this.DormName.ReadOnly = true;
            // 
            // DormCapacity
            // 
            this.DormCapacity.DataPropertyName = "DormCapacity";
            this.DormCapacity.HeaderText = "ظرفیت";
            this.DormCapacity.Name = "DormCapacity";
            this.DormCapacity.ReadOnly = true;
            // 
            // DormManagerID
            // 
            this.DormManagerID.DataPropertyName = "DormManagerID";
            this.DormManagerID.HeaderText = "DormManagerID";
            this.DormManagerID.Name = "DormManagerID";
            this.DormManagerID.ReadOnly = true;
            this.DormManagerID.Visible = false;
            // 
            // DormManagerName
            // 
            this.DormManagerName.DataPropertyName = "DormManagerName";
            this.DormManagerName.HeaderText = "مسئول خوابگاه";
            this.DormManagerName.Name = "DormManagerName";
            this.DormManagerName.ReadOnly = true;
            // 
            // DormAddress
            // 
            this.DormAddress.DataPropertyName = "DormAddress";
            this.DormAddress.HeaderText = "آدرس خوابگاه";
            this.DormAddress.Name = "DormAddress";
            this.DormAddress.ReadOnly = true;
            // 
            // Delete_Block_btn
            // 
            this.Delete_Block_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Block_btn.ForeColor = System.Drawing.Color.Red;
            this.Delete_Block_btn.Location = new System.Drawing.Point(669, 85);
            this.Delete_Block_btn.Name = "Delete_Block_btn";
            this.Delete_Block_btn.Size = new System.Drawing.Size(101, 27);
            this.Delete_Block_btn.TabIndex = 2;
            this.Delete_Block_btn.Text = "حذف بلوک";
            this.Delete_Block_btn.UseVisualStyleBackColor = true;
            this.Delete_Block_btn.Click += new System.EventHandler(this.Delete_Block_btn_Click);
            // 
            // Edit_Block_btn
            // 
            this.Edit_Block_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Block_btn.ForeColor = System.Drawing.Color.Blue;
            this.Edit_Block_btn.Location = new System.Drawing.Point(669, 52);
            this.Edit_Block_btn.Name = "Edit_Block_btn";
            this.Edit_Block_btn.Size = new System.Drawing.Size(101, 27);
            this.Edit_Block_btn.TabIndex = 1;
            this.Edit_Block_btn.Text = "ویرایش بلوک";
            this.Edit_Block_btn.UseVisualStyleBackColor = true;
            this.Edit_Block_btn.Click += new System.EventHandler(this.Edit_Block_btn_Click);
            // 
            // Add_Block_btn
            // 
            this.Add_Block_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Block_btn.ForeColor = System.Drawing.Color.Green;
            this.Add_Block_btn.Location = new System.Drawing.Point(669, 19);
            this.Add_Block_btn.Name = "Add_Block_btn";
            this.Add_Block_btn.Size = new System.Drawing.Size(101, 27);
            this.Add_Block_btn.TabIndex = 0;
            this.Add_Block_btn.Text = "افزودن بلوک";
            this.Add_Block_btn.UseVisualStyleBackColor = true;
            this.Add_Block_btn.Click += new System.EventHandler(this.Add_Block_btn_Click);
            // 
            // Block_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Block_Management_Form";
            this.Text = "Block_Management_Form";
            this.Load += new System.EventHandler(this.Block_Management_Form_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Blocks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Dorms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete_Block_btn;
        private System.Windows.Forms.Button Edit_Block_btn;
        private System.Windows.Forms.Button Add_Block_btn;
        private System.Windows.Forms.DataGridView DG_Blocks;
        private System.Windows.Forms.Button Block_Refresh_btn;
        private System.Windows.Forms.DataGridView DG_Dorms;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockFloors;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkedDormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormAddress;
    }
}