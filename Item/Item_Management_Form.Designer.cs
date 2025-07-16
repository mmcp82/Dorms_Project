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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete_Item_btn = new System.Windows.Forms.Button();
            this.Assign_Item_toRoom_btn = new System.Windows.Forms.Button();
            this.Add_Item_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item8DigitsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkedRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkedCollegianID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete_Item_btn);
            this.groupBox1.Controls.Add(this.Assign_Item_toRoom_btn);
            this.groupBox1.Controls.Add(this.Add_Item_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات";
            // 
            // Delete_Item_btn
            // 
            this.Delete_Item_btn.ForeColor = System.Drawing.Color.Red;
            this.Delete_Item_btn.Location = new System.Drawing.Point(455, 19);
            this.Delete_Item_btn.Name = "Delete_Item_btn";
            this.Delete_Item_btn.Size = new System.Drawing.Size(101, 27);
            this.Delete_Item_btn.TabIndex = 2;
            this.Delete_Item_btn.Text = "حذف وسیله";
            this.Delete_Item_btn.UseVisualStyleBackColor = true;
            // 
            // Assign_Item_toRoom_btn
            // 
            this.Assign_Item_toRoom_btn.ForeColor = System.Drawing.Color.Blue;
            this.Assign_Item_toRoom_btn.Location = new System.Drawing.Point(562, 19);
            this.Assign_Item_toRoom_btn.Name = "Assign_Item_toRoom_btn";
            this.Assign_Item_toRoom_btn.Size = new System.Drawing.Size(101, 27);
            this.Assign_Item_toRoom_btn.TabIndex = 1;
            this.Assign_Item_toRoom_btn.Text = "اختصاص وسیله";
            this.Assign_Item_toRoom_btn.UseVisualStyleBackColor = true;
            // 
            // Add_Item_btn
            // 
            this.Add_Item_btn.ForeColor = System.Drawing.Color.Green;
            this.Add_Item_btn.Location = new System.Drawing.Point(669, 19);
            this.Add_Item_btn.Name = "Add_Item_btn";
            this.Add_Item_btn.Size = new System.Drawing.Size(101, 27);
            this.Add_Item_btn.TabIndex = 0;
            this.Add_Item_btn.Text = "افزودن وسیله";
            this.Add_Item_btn.UseVisualStyleBackColor = true;
            this.Add_Item_btn.Click += new System.EventHandler(this.Add_Item_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemType,
            this.ItemPartNumber,
            this.Item8DigitsID,
            this.ItemState,
            this.LinkedRoomID,
            this.LinkedCollegianID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}