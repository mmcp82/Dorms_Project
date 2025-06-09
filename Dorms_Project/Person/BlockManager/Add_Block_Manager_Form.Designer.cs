namespace Dorms_Project.Person.BlockManager
{
    partial class Add_Block_Manager_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.DG_Available_Collegian = new System.Windows.Forms.DataGridView();
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
            this.Submit_Block_Manager = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Available_Collegian)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DG_Available_Collegian);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(776, 357);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست دانشجو ها";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(596, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "دانشجویی برای انتخاب موجود نیست";
            // 
            // DG_Available_Collegian
            // 
            this.DG_Available_Collegian.AllowUserToAddRows = false;
            this.DG_Available_Collegian.AllowUserToDeleteRows = false;
            this.DG_Available_Collegian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Available_Collegian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Available_Collegian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DG_Available_Collegian.Location = new System.Drawing.Point(6, 22);
            this.DG_Available_Collegian.Name = "DG_Available_Collegian";
            this.DG_Available_Collegian.ReadOnly = true;
            this.DG_Available_Collegian.Size = new System.Drawing.Size(764, 302);
            this.DG_Available_Collegian.TabIndex = 8;
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
            // Submit_Block_Manager
            // 
            this.Submit_Block_Manager.ForeColor = System.Drawing.Color.Green;
            this.Submit_Block_Manager.Location = new System.Drawing.Point(347, 388);
            this.Submit_Block_Manager.Name = "Submit_Block_Manager";
            this.Submit_Block_Manager.Size = new System.Drawing.Size(127, 28);
            this.Submit_Block_Manager.TabIndex = 7;
            this.Submit_Block_Manager.Text = "ثبت";
            this.Submit_Block_Manager.UseVisualStyleBackColor = true;
            this.Submit_Block_Manager.Click += new System.EventHandler(this.Submit_Block_Manager_Click);
            // 
            // Add_Block_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.Submit_Block_Manager);
            this.Controls.Add(this.groupBox2);
            this.Name = "Add_Block_Manager_Form";
            this.Text = "Add_Block_Manager_Form";
            this.Load += new System.EventHandler(this.Add_Block_Manager_Form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Available_Collegian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DG_Available_Collegian;
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
        private System.Windows.Forms.Button Submit_Block_Manager;
        private System.Windows.Forms.Label label1;
    }
}