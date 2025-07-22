namespace Dorms_Project.Item
{
    partial class Item_Management_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item8DigitsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkedRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkedCollegianID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.change_state_btn = new System.Windows.Forms.Button();
            this.add_type_btn = new System.Windows.Forms.Button();
            this.Delete_Item_btn = new System.Windows.Forms.Button();
            this.Add_Item_btn = new System.Windows.Forms.Button();
            this.Assign_Item_toRoom_btn = new System.Windows.Forms.Button();
            this.Assign_Item_toCollegian_btn = new System.Windows.Forms.Button();
            this.Take_Back_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(776, 368);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست وسیله ها";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemType,
            this.ItemPartNumber,
            this.Item8DigitsID,
            this.ItemState,
            this.LinkedRoomID,
            this.LinkedCollegianID});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Size = new System.Drawing.Size(764, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // ItemType
            // 
            this.ItemType.DataPropertyName = "ItemType";
            this.ItemType.HeaderText = "نوع";
            this.ItemType.Name = "ItemType";
            this.ItemType.ReadOnly = true;
            // 
            // ItemPartNumber
            // 
            this.ItemPartNumber.DataPropertyName = "ItemPartNumber";
            this.ItemPartNumber.HeaderText = "پارت نامبر";
            this.ItemPartNumber.Name = "ItemPartNumber";
            this.ItemPartNumber.ReadOnly = true;
            // 
            // Item8DigitsID
            // 
            this.Item8DigitsID.DataPropertyName = "Item8DigitsID";
            this.Item8DigitsID.HeaderText = "شماره اموال";
            this.Item8DigitsID.Name = "Item8DigitsID";
            this.Item8DigitsID.ReadOnly = true;
            // 
            // ItemState
            // 
            this.ItemState.DataPropertyName = "ItemState";
            this.ItemState.HeaderText = "وضعیت";
            this.ItemState.Name = "ItemState";
            this.ItemState.ReadOnly = true;
            // 
            // LinkedRoomID
            // 
            this.LinkedRoomID.DataPropertyName = "LinkedRoomID";
            this.LinkedRoomID.HeaderText = "LinkedRoomID";
            this.LinkedRoomID.Name = "LinkedRoomID";
            this.LinkedRoomID.ReadOnly = true;
            this.LinkedRoomID.Visible = false;
            // 
            // LinkedCollegianID
            // 
            this.LinkedCollegianID.DataPropertyName = "LinkedCollegianID";
            this.LinkedCollegianID.HeaderText = "LinkedCollegianID";
            this.LinkedCollegianID.Name = "LinkedCollegianID";
            this.LinkedCollegianID.ReadOnly = true;
            this.LinkedCollegianID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Take_Back_btn);
            this.groupBox1.Controls.Add(this.Assign_Item_toCollegian_btn);
            this.groupBox1.Controls.Add(this.change_state_btn);
            this.groupBox1.Controls.Add(this.add_type_btn);
            this.groupBox1.Controls.Add(this.Delete_Item_btn);
            this.groupBox1.Controls.Add(this.Add_Item_btn);
            this.groupBox1.Controls.Add(this.Assign_Item_toRoom_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات";
            // 
            // change_state_btn
            // 
            this.change_state_btn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.change_state_btn.Location = new System.Drawing.Point(241, 19);
            this.change_state_btn.Name = "change_state_btn";
            this.change_state_btn.Size = new System.Drawing.Size(101, 27);
            this.change_state_btn.TabIndex = 4;
            this.change_state_btn.Text = "تغییر وضعیت";
            this.change_state_btn.UseVisualStyleBackColor = true;
            this.change_state_btn.Click += new System.EventHandler(this.change_state_btn_Click);
            // 
            // add_type_btn
            // 
            this.add_type_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.add_type_btn.Location = new System.Drawing.Point(669, 19);
            this.add_type_btn.Name = "add_type_btn";
            this.add_type_btn.Size = new System.Drawing.Size(101, 27);
            this.add_type_btn.TabIndex = 3;
            this.add_type_btn.Text = "افزودن نوع";
            this.add_type_btn.UseVisualStyleBackColor = true;
            this.add_type_btn.Click += new System.EventHandler(this.add_type_btn_Click);
            // 
            // Delete_Item_btn
            // 
            this.Delete_Item_btn.ForeColor = System.Drawing.Color.Red;
            this.Delete_Item_btn.Location = new System.Drawing.Point(348, 19);
            this.Delete_Item_btn.Name = "Delete_Item_btn";
            this.Delete_Item_btn.Size = new System.Drawing.Size(101, 27);
            this.Delete_Item_btn.TabIndex = 2;
            this.Delete_Item_btn.Text = "حذف وسیله";
            this.Delete_Item_btn.UseVisualStyleBackColor = true;
            // 
            // Add_Item_btn
            // 
            this.Add_Item_btn.ForeColor = System.Drawing.Color.Green;
            this.Add_Item_btn.Location = new System.Drawing.Point(562, 19);
            this.Add_Item_btn.Name = "Add_Item_btn";
            this.Add_Item_btn.Size = new System.Drawing.Size(101, 27);
            this.Add_Item_btn.TabIndex = 0;
            this.Add_Item_btn.Text = "افزودن وسیله";
            this.Add_Item_btn.UseVisualStyleBackColor = true;
            this.Add_Item_btn.Click += new System.EventHandler(this.Add_Item_btn_Click);
            // 
            // Assign_Item_toRoom_btn
            // 
            this.Assign_Item_toRoom_btn.ForeColor = System.Drawing.Color.Blue;
            this.Assign_Item_toRoom_btn.Location = new System.Drawing.Point(455, 19);
            this.Assign_Item_toRoom_btn.Name = "Assign_Item_toRoom_btn";
            this.Assign_Item_toRoom_btn.Size = new System.Drawing.Size(101, 27);
            this.Assign_Item_toRoom_btn.TabIndex = 1;
            this.Assign_Item_toRoom_btn.Text = "اختصاص وسیله";
            this.Assign_Item_toRoom_btn.UseVisualStyleBackColor = true;
            this.Assign_Item_toRoom_btn.Click += new System.EventHandler(this.Assign_Item_toRoom_btn_Click);
            // 
            // Assign_Item_toCollegian_btn
            // 
            this.Assign_Item_toCollegian_btn.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Assign_Item_toCollegian_btn.Location = new System.Drawing.Point(134, 19);
            this.Assign_Item_toCollegian_btn.Name = "Assign_Item_toCollegian_btn";
            this.Assign_Item_toCollegian_btn.Size = new System.Drawing.Size(101, 27);
            this.Assign_Item_toCollegian_btn.TabIndex = 5;
            this.Assign_Item_toCollegian_btn.Text = "اختصاص دانشجو";
            this.Assign_Item_toCollegian_btn.UseVisualStyleBackColor = true;
            this.Assign_Item_toCollegian_btn.Click += new System.EventHandler(this.Assign_Item_toCollegian_btn_Click);
            // 
            // Take_Back_btn
            // 
            this.Take_Back_btn.ForeColor = System.Drawing.Color.Goldenrod;
            this.Take_Back_btn.Location = new System.Drawing.Point(27, 19);
            this.Take_Back_btn.Name = "Take_Back_btn";
            this.Take_Back_btn.Size = new System.Drawing.Size(101, 27);
            this.Take_Back_btn.TabIndex = 6;
            this.Take_Back_btn.Text = "پس گیری از";
            this.Take_Back_btn.UseVisualStyleBackColor = true;
            this.Take_Back_btn.Click += new System.EventHandler(this.Take_Back_btn_Click);
            // 
            // Item_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Item_Management_Form";
            this.Text = "Item_Management_Form";
            this.Load += new System.EventHandler(this.Item_Management_Form_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete_Item_btn;
        private System.Windows.Forms.Button Assign_Item_toRoom_btn;
        private System.Windows.Forms.Button Add_Item_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item8DigitsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemState;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkedRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkedCollegianID;
        private System.Windows.Forms.Button add_type_btn;
        private System.Windows.Forms.Button change_state_btn;
        private System.Windows.Forms.Button Take_Back_btn;
        private System.Windows.Forms.Button Assign_Item_toCollegian_btn;
    }
}