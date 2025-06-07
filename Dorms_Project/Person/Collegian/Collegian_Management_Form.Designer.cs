namespace Dorms_Project.Person.Collegian
{
    partial class Collegian_Management_Form
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Collegian_Details_btn = new System.Windows.Forms.Button();
            this.Move_btn = new System.Windows.Forms.Button();
            this.SignUp_btn = new System.Windows.Forms.Button();
            this.Collegian_Refresh_btn = new System.Windows.Forms.Button();
            this.Delete_Collegian_btn = new System.Windows.Forms.Button();
            this.Edit_Collegian_btn = new System.Windows.Forms.Button();
            this.Add_Collegian_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DG_Collegian = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.DG_Collegian)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Collegian_Details_btn);
            this.groupBox1.Controls.Add(this.Move_btn);
            this.groupBox1.Controls.Add(this.SignUp_btn);
            this.groupBox1.Controls.Add(this.Collegian_Refresh_btn);
            this.groupBox1.Controls.Add(this.Delete_Collegian_btn);
            this.groupBox1.Controls.Add(this.Edit_Collegian_btn);
            this.groupBox1.Controls.Add(this.Add_Collegian_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Collegian_Details_btn
            // 
            this.Collegian_Details_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Collegian_Details_btn.ForeColor = System.Drawing.Color.Blue;
            this.Collegian_Details_btn.Location = new System.Drawing.Point(154, 19);
            this.Collegian_Details_btn.Name = "Collegian_Details_btn";
            this.Collegian_Details_btn.Size = new System.Drawing.Size(151, 27);
            this.Collegian_Details_btn.TabIndex = 5;
            this.Collegian_Details_btn.Text = "اطلاعات دانشجو";
            this.Collegian_Details_btn.UseVisualStyleBackColor = true;
            this.Collegian_Details_btn.Click += new System.EventHandler(this.Collegian_Details_btn_Click);
            // 
            // Move_btn
            // 
            this.Move_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Move_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Move_btn.Location = new System.Drawing.Point(468, 52);
            this.Move_btn.Name = "Move_btn";
            this.Move_btn.Size = new System.Drawing.Size(151, 27);
            this.Move_btn.TabIndex = 7;
            this.Move_btn.Text = "جابه جایی دانشجو";
            this.Move_btn.UseVisualStyleBackColor = true;
            this.Move_btn.Click += new System.EventHandler(this.Move_btn_Click);
            // 
            // SignUp_btn
            // 
            this.SignUp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_btn.ForeColor = System.Drawing.Color.Green;
            this.SignUp_btn.Location = new System.Drawing.Point(625, 52);
            this.SignUp_btn.Name = "SignUp_btn";
            this.SignUp_btn.Size = new System.Drawing.Size(145, 27);
            this.SignUp_btn.TabIndex = 4;
            this.SignUp_btn.Text = "ثبت نام دانشجو";
            this.SignUp_btn.UseVisualStyleBackColor = true;
            this.SignUp_btn.Click += new System.EventHandler(this.SignUp_btn_Click);
            // 
            // Collegian_Refresh_btn
            // 
            this.Collegian_Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Collegian_Refresh_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Collegian_Refresh_btn.Location = new System.Drawing.Point(6, 19);
            this.Collegian_Refresh_btn.Name = "Collegian_Refresh_btn";
            this.Collegian_Refresh_btn.Size = new System.Drawing.Size(142, 27);
            this.Collegian_Refresh_btn.TabIndex = 3;
            this.Collegian_Refresh_btn.Text = "بروز رسانی";
            this.Collegian_Refresh_btn.UseVisualStyleBackColor = true;
            this.Collegian_Refresh_btn.Click += new System.EventHandler(this.Collegian_Refresh_btn_Click);
            // 
            // Delete_Collegian_btn
            // 
            this.Delete_Collegian_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Collegian_btn.ForeColor = System.Drawing.Color.Red;
            this.Delete_Collegian_btn.Location = new System.Drawing.Point(311, 19);
            this.Delete_Collegian_btn.Name = "Delete_Collegian_btn";
            this.Delete_Collegian_btn.Size = new System.Drawing.Size(151, 27);
            this.Delete_Collegian_btn.TabIndex = 2;
            this.Delete_Collegian_btn.Text = "حذف دانشجو";
            this.Delete_Collegian_btn.UseVisualStyleBackColor = true;
            this.Delete_Collegian_btn.Click += new System.EventHandler(this.Delete_Collegian_btn_Click);
            // 
            // Edit_Collegian_btn
            // 
            this.Edit_Collegian_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Collegian_btn.ForeColor = System.Drawing.Color.Blue;
            this.Edit_Collegian_btn.Location = new System.Drawing.Point(468, 19);
            this.Edit_Collegian_btn.Name = "Edit_Collegian_btn";
            this.Edit_Collegian_btn.Size = new System.Drawing.Size(151, 27);
            this.Edit_Collegian_btn.TabIndex = 1;
            this.Edit_Collegian_btn.Text = "ویرایش دانشجو";
            this.Edit_Collegian_btn.UseVisualStyleBackColor = true;
            this.Edit_Collegian_btn.Click += new System.EventHandler(this.Edit_Collegian_btn_Click);
            // 
            // Add_Collegian_btn
            // 
            this.Add_Collegian_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Collegian_btn.ForeColor = System.Drawing.Color.Green;
            this.Add_Collegian_btn.Location = new System.Drawing.Point(625, 19);
            this.Add_Collegian_btn.Name = "Add_Collegian_btn";
            this.Add_Collegian_btn.Size = new System.Drawing.Size(145, 27);
            this.Add_Collegian_btn.TabIndex = 0;
            this.Add_Collegian_btn.Text = "افزودن دانشجو";
            this.Add_Collegian_btn.UseVisualStyleBackColor = true;
            this.Add_Collegian_btn.Click += new System.EventHandler(this.Add_Collegian_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DG_Collegian);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(776, 330);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست خوابگاه ها";
            // 
            // DG_Collegian
            // 
            this.DG_Collegian.AllowUserToAddRows = false;
            this.DG_Collegian.AllowUserToDeleteRows = false;
            this.DG_Collegian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Collegian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Collegian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DG_Collegian.Location = new System.Drawing.Point(6, 22);
            this.DG_Collegian.Name = "DG_Collegian";
            this.DG_Collegian.ReadOnly = true;
            this.DG_Collegian.Size = new System.Drawing.Size(764, 302);
            this.DG_Collegian.TabIndex = 8;
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
            // Collegian_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Collegian_Management_Form";
            this.Text = "Collegian_Management_Form";
            this.Load += new System.EventHandler(this.Collegian_Management_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Collegian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Collegian_Refresh_btn;
        private System.Windows.Forms.Button Delete_Collegian_btn;
        private System.Windows.Forms.Button Edit_Collegian_btn;
        private System.Windows.Forms.Button Add_Collegian_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DG_Collegian;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Move_btn;
        private System.Windows.Forms.Button Collegian_Details_btn;
        private System.Windows.Forms.Button SignUp_btn;
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