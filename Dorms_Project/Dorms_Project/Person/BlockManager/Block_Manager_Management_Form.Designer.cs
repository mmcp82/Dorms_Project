namespace Dorms_Project.Person.BlockManager
{
    partial class Block_Manager_Management_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Block_Details = new System.Windows.Forms.Button();
            this.Block_Manager_Refresh_btn = new System.Windows.Forms.Button();
            this.Delete_Block_Manager_btn = new System.Windows.Forms.Button();
            this.Edit_Block_Manager_btn = new System.Windows.Forms.Button();
            this.Add_Block_Manager_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DG_Block_Manager = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Block_Manager)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Block_Details);
            this.groupBox1.Controls.Add(this.Block_Manager_Refresh_btn);
            this.groupBox1.Controls.Add(this.Delete_Block_Manager_btn);
            this.groupBox1.Controls.Add(this.Edit_Block_Manager_btn);
            this.groupBox1.Controls.Add(this.Add_Block_Manager_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات";
            // 
            // Block_Details
            // 
            this.Block_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Block_Details.ForeColor = System.Drawing.Color.Black;
            this.Block_Details.Location = new System.Drawing.Point(348, 19);
            this.Block_Details.Name = "Block_Details";
            this.Block_Details.Size = new System.Drawing.Size(101, 27);
            this.Block_Details.TabIndex = 7;
            this.Block_Details.Text = "جزئیات بلوک";
            this.Block_Details.UseVisualStyleBackColor = true;
            this.Block_Details.Click += new System.EventHandler(this.Block_Details_Click);
            // 
            // Block_Manager_Refresh_btn
            // 
            this.Block_Manager_Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Block_Manager_Refresh_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Block_Manager_Refresh_btn.Location = new System.Drawing.Point(241, 19);
            this.Block_Manager_Refresh_btn.Name = "Block_Manager_Refresh_btn";
            this.Block_Manager_Refresh_btn.Size = new System.Drawing.Size(101, 27);
            this.Block_Manager_Refresh_btn.TabIndex = 6;
            this.Block_Manager_Refresh_btn.Text = "بروز رسانی";
            this.Block_Manager_Refresh_btn.UseVisualStyleBackColor = true;
            this.Block_Manager_Refresh_btn.Click += new System.EventHandler(this.Block_Manager_Refresh_btn_Click);
            // 
            // Delete_Block_Manager_btn
            // 
            this.Delete_Block_Manager_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Block_Manager_btn.ForeColor = System.Drawing.Color.Red;
            this.Delete_Block_Manager_btn.Location = new System.Drawing.Point(455, 19);
            this.Delete_Block_Manager_btn.Name = "Delete_Block_Manager_btn";
            this.Delete_Block_Manager_btn.Size = new System.Drawing.Size(101, 27);
            this.Delete_Block_Manager_btn.TabIndex = 8;
            this.Delete_Block_Manager_btn.Text = "حذف مسئول";
            this.Delete_Block_Manager_btn.UseVisualStyleBackColor = true;
            this.Delete_Block_Manager_btn.Click += new System.EventHandler(this.Delete_Block_Manager_btn_Click);
            // 
            // Edit_Block_Manager_btn
            // 
            this.Edit_Block_Manager_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Block_Manager_btn.ForeColor = System.Drawing.Color.Blue;
            this.Edit_Block_Manager_btn.Location = new System.Drawing.Point(562, 19);
            this.Edit_Block_Manager_btn.Name = "Edit_Block_Manager_btn";
            this.Edit_Block_Manager_btn.Size = new System.Drawing.Size(101, 27);
            this.Edit_Block_Manager_btn.TabIndex = 9;
            this.Edit_Block_Manager_btn.Text = "ویرایش مسئول";
            this.Edit_Block_Manager_btn.UseVisualStyleBackColor = true;
            this.Edit_Block_Manager_btn.Click += new System.EventHandler(this.Edit_Block_Manager_btn_Click);
            // 
            // Add_Block_Manager_btn
            // 
            this.Add_Block_Manager_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Block_Manager_btn.ForeColor = System.Drawing.Color.Green;
            this.Add_Block_Manager_btn.Location = new System.Drawing.Point(669, 19);
            this.Add_Block_Manager_btn.Name = "Add_Block_Manager_btn";
            this.Add_Block_Manager_btn.Size = new System.Drawing.Size(101, 27);
            this.Add_Block_Manager_btn.TabIndex = 10;
            this.Add_Block_Manager_btn.Text = "افزودن مسئول";
            this.Add_Block_Manager_btn.UseVisualStyleBackColor = true;
            this.Add_Block_Manager_btn.Click += new System.EventHandler(this.Add_Block_Manager_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DG_Block_Manager);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(776, 368);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست مسئول بلوک ها";
            // 
            // DG_Block_Manager
            // 
            this.DG_Block_Manager.AllowUserToAddRows = false;
            this.DG_Block_Manager.AllowUserToDeleteRows = false;
            this.DG_Block_Manager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Block_Manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Block_Manager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DG_Block_Manager.Location = new System.Drawing.Point(6, 22);
            this.DG_Block_Manager.Name = "DG_Block_Manager";
            this.DG_Block_Manager.ReadOnly = true;
            this.DG_Block_Manager.Size = new System.Drawing.Size(764, 340);
            this.DG_Block_Manager.TabIndex = 5;
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
            this.ManagingBlockName.HeaderText = "بلوک مدیریت شده";
            this.ManagingBlockName.Name = "ManagingBlockName";
            this.ManagingBlockName.ReadOnly = true;
            // 
            // CollegianAddress
            // 
            this.CollegianAddress.DataPropertyName = "CollegianAddress";
            this.CollegianAddress.HeaderText = "آدرس";
            this.CollegianAddress.Name = "CollegianAddress";
            this.CollegianAddress.ReadOnly = true;
            // 
            // Block_Manager_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Block_Manager_Management_Form";
            this.Text = "Block_Manager_Management_Form";
            this.Load += new System.EventHandler(this.Block_Manager_Management_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Block_Manager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Block_Manager_Refresh_btn;
        private System.Windows.Forms.Button Delete_Block_Manager_btn;
        private System.Windows.Forms.Button Edit_Block_Manager_btn;
        private System.Windows.Forms.Button Add_Block_Manager_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DG_Block_Manager;
        private System.Windows.Forms.Button Block_Details;
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