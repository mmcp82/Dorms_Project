namespace Dorms_Project.Block
{
    partial class AddOrEdit_Block
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
            this.Block_Submit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DG_blockManager = new System.Windows.Forms.DataGridView();
            this.CollegianID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegianFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegianLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegianCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegianNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegianPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegianAssignedRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBlockManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagingBlockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagingBlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegianAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block_Capacity_num = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Block_Name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_blockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block_Capacity_num)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Block_Submit_btn
            // 
            this.Block_Submit_btn.ForeColor = System.Drawing.Color.Green;
            this.Block_Submit_btn.Location = new System.Drawing.Point(151, 346);
            this.Block_Submit_btn.Name = "Block_Submit_btn";
            this.Block_Submit_btn.Size = new System.Drawing.Size(234, 23);
            this.Block_Submit_btn.TabIndex = 4;
            this.Block_Submit_btn.Text = "ثبت";
            this.Block_Submit_btn.UseVisualStyleBackColor = true;
            this.Block_Submit_btn.Click += new System.EventHandler(this.Block_Submit_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(330, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // DG_blockManager
            // 
            this.DG_blockManager.AllowUserToAddRows = false;
            this.DG_blockManager.AllowUserToDeleteRows = false;
            this.DG_blockManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_blockManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_blockManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollegianID,
            this.CollegianFirstName,
            this.CollegianLastName,
            this.CollegianCode,
            this.CollegianNationalCode,
            this.CollegianPhoneNumber,
            this.CollegianAssignedRoomID,
            this.IsBlockManager,
            this.ManagingBlockID,
            this.ManagingBlockName,
            this.CollegianAddress});
            this.DG_blockManager.Location = new System.Drawing.Point(6, 19);
            this.DG_blockManager.Name = "DG_blockManager";
            this.DG_blockManager.ReadOnly = true;
            this.DG_blockManager.Size = new System.Drawing.Size(488, 215);
            this.DG_blockManager.TabIndex = 3;
            // 
            // CollegianID
            // 
            this.CollegianID.DataPropertyName = "CollegianID";
            this.CollegianID.HeaderText = "CollegianID";
            this.CollegianID.Name = "CollegianID";
            this.CollegianID.ReadOnly = true;
            this.CollegianID.Visible = false;
            // 
            // CollegianFirstName
            // 
            this.CollegianFirstName.DataPropertyName = "CollegianFirstName";
            this.CollegianFirstName.HeaderText = "نام";
            this.CollegianFirstName.Name = "CollegianFirstName";
            this.CollegianFirstName.ReadOnly = true;
            // 
            // CollegianLastName
            // 
            this.CollegianLastName.DataPropertyName = "CollegianLastName";
            this.CollegianLastName.HeaderText = "نام خانوادگی";
            this.CollegianLastName.Name = "CollegianLastName";
            this.CollegianLastName.ReadOnly = true;
            // 
            // CollegianCode
            // 
            this.CollegianCode.DataPropertyName = "CollegianCode";
            this.CollegianCode.HeaderText = "شماره دانشجویی";
            this.CollegianCode.Name = "CollegianCode";
            this.CollegianCode.ReadOnly = true;
            // 
            // CollegianNationalCode
            // 
            this.CollegianNationalCode.DataPropertyName = "CollegianNationalCode";
            this.CollegianNationalCode.HeaderText = "کد ملی";
            this.CollegianNationalCode.Name = "CollegianNationalCode";
            this.CollegianNationalCode.ReadOnly = true;
            // 
            // CollegianPhoneNumber
            // 
            this.CollegianPhoneNumber.DataPropertyName = "CollegianPhoneNumber";
            this.CollegianPhoneNumber.HeaderText = "شماره تلفن";
            this.CollegianPhoneNumber.Name = "CollegianPhoneNumber";
            this.CollegianPhoneNumber.ReadOnly = true;
            // 
            // CollegianAssignedRoomID
            // 
            this.CollegianAssignedRoomID.DataPropertyName = "CollegianAssignedRoomID";
            this.CollegianAssignedRoomID.HeaderText = "CollegianAssignedRoomID";
            this.CollegianAssignedRoomID.Name = "CollegianAssignedRoomID";
            this.CollegianAssignedRoomID.ReadOnly = true;
            this.CollegianAssignedRoomID.Visible = false;
            // 
            // IsBlockManager
            // 
            this.IsBlockManager.DataPropertyName = "IsBlockManager";
            this.IsBlockManager.HeaderText = "IsBlockManager";
            this.IsBlockManager.Name = "IsBlockManager";
            this.IsBlockManager.ReadOnly = true;
            this.IsBlockManager.Visible = false;
            // 
            // ManagingBlockID
            // 
            this.ManagingBlockID.DataPropertyName = "ManagingBlockID";
            this.ManagingBlockID.HeaderText = "ManagingBlockID";
            this.ManagingBlockID.Name = "ManagingBlockID";
            this.ManagingBlockID.ReadOnly = true;
            this.ManagingBlockID.Visible = false;
            // 
            // ManagingBlockName
            // 
            this.ManagingBlockName.DataPropertyName = "ManagingBlockName";
            this.ManagingBlockName.HeaderText = "ManagingBlockName";
            this.ManagingBlockName.Name = "ManagingBlockName";
            this.ManagingBlockName.ReadOnly = true;
            this.ManagingBlockName.Visible = false;
            // 
            // CollegianAddress
            // 
            this.CollegianAddress.DataPropertyName = "CollegianAddress";
            this.CollegianAddress.HeaderText = "آدرس";
            this.CollegianAddress.Name = "CollegianAddress";
            this.CollegianAddress.ReadOnly = true;
            // 
            // Block_Capacity_num
            // 
            this.Block_Capacity_num.Increment = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Block_Capacity_num.Location = new System.Drawing.Point(6, 19);
            this.Block_Capacity_num.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
            this.Block_Capacity_num.Name = "Block_Capacity_num";
            this.Block_Capacity_num.Size = new System.Drawing.Size(222, 20);
            this.Block_Capacity_num.TabIndex = 2;
            this.Block_Capacity_num.ValueChanged += new System.EventHandler(this.Block_Capacity_num_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(62, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ظرفیت نمی تواند صفر یا کمتر باشد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Block_Capacity_num);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 63);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ظرفیت بلوک";
            // 
            // Block_Name_txt
            // 
            this.Block_Name_txt.Location = new System.Drawing.Point(6, 19);
            this.Block_Name_txt.Name = "Block_Name_txt";
            this.Block_Name_txt.Size = new System.Drawing.Size(222, 20);
            this.Block_Name_txt.TabIndex = 1;
            this.Block_Name_txt.TextChanged += new System.EventHandler(this.Block_Name_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(109, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام نمی تواند خالی باشد";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.DG_blockManager);
            this.groupBox4.Location = new System.Drawing.Point(12, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 259);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "مسئول بلوک";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Block_Name_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(281, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 63);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نام بلوک";
            // 
            // AddOrEdit_Block
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 381);
            this.Controls.Add(this.Block_Submit_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddOrEdit_Block";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "AddOrEdit_Block";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddOrEdit_Block_FormClosing);
            this.Load += new System.EventHandler(this.AddOrEdit_Block_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_blockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block_Capacity_num)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Block_Submit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DG_blockManager;
        private System.Windows.Forms.NumericUpDown Block_Capacity_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Block_Name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegianID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegianFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegianLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegianCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegianNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegianPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegianAssignedRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBlockManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagingBlockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagingBlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegianAddress;
    }
}