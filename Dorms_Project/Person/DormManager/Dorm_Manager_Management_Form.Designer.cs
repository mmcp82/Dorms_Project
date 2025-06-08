namespace Dorms_Project.Person.DormManager
{
    partial class Dorm_Manager_Management_Form
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
            this.Dorm_Manager_Refresh_btn = new System.Windows.Forms.Button();
            this.Delete_Dorm_Manager_btn = new System.Windows.Forms.Button();
            this.Edit_Dorm_Manager_btn = new System.Windows.Forms.Button();
            this.Add_Dorm_Manager_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DG_dormManager = new System.Windows.Forms.DataGridView();
            this.DormManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagingDormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagingDormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dorm_Details = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_dormManager)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dorm_Details);
            this.groupBox1.Controls.Add(this.Dorm_Manager_Refresh_btn);
            this.groupBox1.Controls.Add(this.Delete_Dorm_Manager_btn);
            this.groupBox1.Controls.Add(this.Edit_Dorm_Manager_btn);
            this.groupBox1.Controls.Add(this.Add_Dorm_Manager_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات";
            // 
            // Dorm_Manager_Refresh_btn
            // 
            this.Dorm_Manager_Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dorm_Manager_Refresh_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Dorm_Manager_Refresh_btn.Location = new System.Drawing.Point(241, 19);
            this.Dorm_Manager_Refresh_btn.Name = "Dorm_Manager_Refresh_btn";
            this.Dorm_Manager_Refresh_btn.Size = new System.Drawing.Size(101, 27);
            this.Dorm_Manager_Refresh_btn.TabIndex = 3;
            this.Dorm_Manager_Refresh_btn.Text = "بروز رسانی";
            this.Dorm_Manager_Refresh_btn.UseVisualStyleBackColor = true;
            this.Dorm_Manager_Refresh_btn.Click += new System.EventHandler(this.Dorm_Manager_Refresh_btn_Click);
            // 
            // Delete_Dorm_Manager_btn
            // 
            this.Delete_Dorm_Manager_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Dorm_Manager_btn.ForeColor = System.Drawing.Color.Red;
            this.Delete_Dorm_Manager_btn.Location = new System.Drawing.Point(455, 19);
            this.Delete_Dorm_Manager_btn.Name = "Delete_Dorm_Manager_btn";
            this.Delete_Dorm_Manager_btn.Size = new System.Drawing.Size(101, 27);
            this.Delete_Dorm_Manager_btn.TabIndex = 2;
            this.Delete_Dorm_Manager_btn.Text = "حذف مسئول";
            this.Delete_Dorm_Manager_btn.UseVisualStyleBackColor = true;
            this.Delete_Dorm_Manager_btn.Click += new System.EventHandler(this.Delete_Dorm_Manager_btn_Click);
            // 
            // Edit_Dorm_Manager_btn
            // 
            this.Edit_Dorm_Manager_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Dorm_Manager_btn.ForeColor = System.Drawing.Color.Blue;
            this.Edit_Dorm_Manager_btn.Location = new System.Drawing.Point(562, 19);
            this.Edit_Dorm_Manager_btn.Name = "Edit_Dorm_Manager_btn";
            this.Edit_Dorm_Manager_btn.Size = new System.Drawing.Size(101, 27);
            this.Edit_Dorm_Manager_btn.TabIndex = 1;
            this.Edit_Dorm_Manager_btn.Text = "ویرایش مسئول";
            this.Edit_Dorm_Manager_btn.UseVisualStyleBackColor = true;
            this.Edit_Dorm_Manager_btn.Click += new System.EventHandler(this.Edit_Dorm_Manager_btn_Click);
            // 
            // Add_Dorm_Manager_btn
            // 
            this.Add_Dorm_Manager_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Dorm_Manager_btn.ForeColor = System.Drawing.Color.Green;
            this.Add_Dorm_Manager_btn.Location = new System.Drawing.Point(669, 19);
            this.Add_Dorm_Manager_btn.Name = "Add_Dorm_Manager_btn";
            this.Add_Dorm_Manager_btn.Size = new System.Drawing.Size(101, 27);
            this.Add_Dorm_Manager_btn.TabIndex = 0;
            this.Add_Dorm_Manager_btn.Text = "افزودن مسئول";
            this.Add_Dorm_Manager_btn.UseVisualStyleBackColor = true;
            this.Add_Dorm_Manager_btn.Click += new System.EventHandler(this.Add_Dorm_Manager_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DG_dormManager);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(776, 368);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست مسئول خوابگاه ها";
            // 
            // DG_dormManager
            // 
            this.DG_dormManager.AllowUserToAddRows = false;
            this.DG_dormManager.AllowUserToDeleteRows = false;
            this.DG_dormManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_dormManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_dormManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DormManagerID,
            this.DormManagerFirstName,
            this.DormManagerLastName,
            this.DormManagerJob,
            this.DormManagerNationalCode,
            this.DormManagerPhoneNumber,
            this.ManagingDormID,
            this.ManagingDormName,
            this.DormManagerAddress});
            this.DG_dormManager.Location = new System.Drawing.Point(6, 22);
            this.DG_dormManager.Name = "DG_dormManager";
            this.DG_dormManager.ReadOnly = true;
            this.DG_dormManager.Size = new System.Drawing.Size(764, 340);
            this.DG_dormManager.TabIndex = 8;
            // 
            // DormManagerID
            // 
            this.DormManagerID.DataPropertyName = "DormManagerID";
            this.DormManagerID.HeaderText = "DormManagerID";
            this.DormManagerID.Name = "DormManagerID";
            this.DormManagerID.ReadOnly = true;
            this.DormManagerID.Visible = false;
            // 
            // DormManagerFirstName
            // 
            this.DormManagerFirstName.DataPropertyName = "DormManagerFirstName";
            this.DormManagerFirstName.HeaderText = "نام";
            this.DormManagerFirstName.Name = "DormManagerFirstName";
            this.DormManagerFirstName.ReadOnly = true;
            // 
            // DormManagerLastName
            // 
            this.DormManagerLastName.DataPropertyName = "DormManagerLastName";
            this.DormManagerLastName.HeaderText = "نام خانوادگی";
            this.DormManagerLastName.Name = "DormManagerLastName";
            this.DormManagerLastName.ReadOnly = true;
            // 
            // DormManagerJob
            // 
            this.DormManagerJob.DataPropertyName = "DormManagerJob";
            this.DormManagerJob.HeaderText = "شغل";
            this.DormManagerJob.Name = "DormManagerJob";
            this.DormManagerJob.ReadOnly = true;
            // 
            // DormManagerNationalCode
            // 
            this.DormManagerNationalCode.DataPropertyName = "DormManagerNationalCode";
            this.DormManagerNationalCode.HeaderText = "کد ملی";
            this.DormManagerNationalCode.Name = "DormManagerNationalCode";
            this.DormManagerNationalCode.ReadOnly = true;
            // 
            // DormManagerPhoneNumber
            // 
            this.DormManagerPhoneNumber.DataPropertyName = "DormManagerPhoneNumber";
            this.DormManagerPhoneNumber.HeaderText = "شماره تلفن";
            this.DormManagerPhoneNumber.Name = "DormManagerPhoneNumber";
            this.DormManagerPhoneNumber.ReadOnly = true;
            // 
            // ManagingDormID
            // 
            this.ManagingDormID.DataPropertyName = "ManagingDormID";
            this.ManagingDormID.HeaderText = "ManagingDormID";
            this.ManagingDormID.Name = "ManagingDormID";
            this.ManagingDormID.ReadOnly = true;
            this.ManagingDormID.Visible = false;
            // 
            // ManagingDormName
            // 
            this.ManagingDormName.DataPropertyName = "ManagingDormName";
            this.ManagingDormName.HeaderText = "خوابگاه مدیریت شده";
            this.ManagingDormName.Name = "ManagingDormName";
            this.ManagingDormName.ReadOnly = true;
            // 
            // DormManagerAddress
            // 
            this.DormManagerAddress.DataPropertyName = "DormManagerAddress";
            this.DormManagerAddress.HeaderText = "آدرس";
            this.DormManagerAddress.Name = "DormManagerAddress";
            this.DormManagerAddress.ReadOnly = true;
            // 
            // Dorm_Details
            // 
            this.Dorm_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dorm_Details.ForeColor = System.Drawing.Color.Black;
            this.Dorm_Details.Location = new System.Drawing.Point(348, 19);
            this.Dorm_Details.Name = "Dorm_Details";
            this.Dorm_Details.Size = new System.Drawing.Size(101, 27);
            this.Dorm_Details.TabIndex = 5;
            this.Dorm_Details.Text = "جزئیات خوابگاه";
            this.Dorm_Details.UseVisualStyleBackColor = true;
            // 
            // Dorm_Manager_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Dorm_Manager_Management_Form";
            this.Text = "Dorm_Manager_Management_Form";
            this.Load += new System.EventHandler(this.Dorm_Manager_Management_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_dormManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Dorm_Manager_Refresh_btn;
        private System.Windows.Forms.Button Delete_Dorm_Manager_btn;
        private System.Windows.Forms.Button Edit_Dorm_Manager_btn;
        private System.Windows.Forms.Button Add_Dorm_Manager_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DG_dormManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagingDormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagingDormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerAddress;
        private System.Windows.Forms.Button Dorm_Details;
    }
}