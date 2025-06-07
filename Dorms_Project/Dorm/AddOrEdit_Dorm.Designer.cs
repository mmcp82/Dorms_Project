namespace Dorms_Project.Dorm
{
    partial class AddOrEdit_Dorm
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
            this.Dorm_Name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dorm_Capacity_num = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Dorm_Address_txt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DG_dormManager = new System.Windows.Forms.DataGridView();
            this.DormManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagingDormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dorm_Submit_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dorm_Capacity_num)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_dormManager)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dorm_Name_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(101, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نام خوابگاه";
            // 
            // Dorm_Name_txt
            // 
            this.Dorm_Name_txt.Location = new System.Drawing.Point(6, 19);
            this.Dorm_Name_txt.Name = "Dorm_Name_txt";
            this.Dorm_Name_txt.Size = new System.Drawing.Size(222, 20);
            this.Dorm_Name_txt.TabIndex = 7;
            this.Dorm_Name_txt.TextChanged += new System.EventHandler(this.Dorm_Name_txt_TextChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dorm_Capacity_num);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(101, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ظرفیت خوابگاه";
            // 
            // Dorm_Capacity_num
            // 
            this.Dorm_Capacity_num.Increment = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Dorm_Capacity_num.Location = new System.Drawing.Point(6, 19);
            this.Dorm_Capacity_num.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
            this.Dorm_Capacity_num.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Dorm_Capacity_num.Name = "Dorm_Capacity_num";
            this.Dorm_Capacity_num.Size = new System.Drawing.Size(222, 20);
            this.Dorm_Capacity_num.TabIndex = 7;
            this.Dorm_Capacity_num.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Dorm_Capacity_num.ValueChanged += new System.EventHandler(this.Dorm_Capacity_num_ValueChanged);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Dorm_Address_txt);
            this.groupBox5.Location = new System.Drawing.Point(101, 373);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 63);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "آدرس خوابگاه";
            // 
            // Dorm_Address_txt
            // 
            this.Dorm_Address_txt.Location = new System.Drawing.Point(6, 19);
            this.Dorm_Address_txt.Name = "Dorm_Address_txt";
            this.Dorm_Address_txt.Size = new System.Drawing.Size(222, 20);
            this.Dorm_Address_txt.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.DG_dormManager);
            this.groupBox4.Location = new System.Drawing.Point(12, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 217);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "مسئول خوابگاه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(254, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
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
            this.DormManagerAddress,
            this.ManagingDormID});
            this.DG_dormManager.Location = new System.Drawing.Point(6, 19);
            this.DG_dormManager.Name = "DG_dormManager";
            this.DG_dormManager.ReadOnly = true;
            this.DG_dormManager.Size = new System.Drawing.Size(389, 172);
            this.DG_dormManager.TabIndex = 7;
            this.DG_dormManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_dormManager_CellContentClick);
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
            // DormManagerAddress
            // 
            this.DormManagerAddress.DataPropertyName = "DormManagerAddress";
            this.DormManagerAddress.HeaderText = "آدرس";
            this.DormManagerAddress.Name = "DormManagerAddress";
            this.DormManagerAddress.ReadOnly = true;
            // 
            // ManagingDormID
            // 
            this.ManagingDormID.DataPropertyName = "ManagingDormID";
            this.ManagingDormID.HeaderText = "ManagingDormID";
            this.ManagingDormID.Name = "ManagingDormID";
            this.ManagingDormID.ReadOnly = true;
            this.ManagingDormID.Visible = false;
            // 
            // Dorm_Submit_btn
            // 
            this.Dorm_Submit_btn.ForeColor = System.Drawing.Color.Green;
            this.Dorm_Submit_btn.Location = new System.Drawing.Point(101, 446);
            this.Dorm_Submit_btn.Name = "Dorm_Submit_btn";
            this.Dorm_Submit_btn.Size = new System.Drawing.Size(234, 23);
            this.Dorm_Submit_btn.TabIndex = 9;
            this.Dorm_Submit_btn.Text = "ثبت";
            this.Dorm_Submit_btn.UseVisualStyleBackColor = true;
            this.Dorm_Submit_btn.Click += new System.EventHandler(this.Dorm_Submit_btn_Click);
            // 
            // AddOrEdit_Dorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 481);
            this.Controls.Add(this.Dorm_Submit_btn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddOrEdit_Dorm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "AddOrEdit_Dorm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddOrEdit_Dorm_FormClosing);
            this.Load += new System.EventHandler(this.AddOrEdit_Dorm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dorm_Capacity_num)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_dormManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Dorm_Name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Dorm_Address_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown Dorm_Capacity_num;
        private System.Windows.Forms.DataGridView DG_dormManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Dorm_Submit_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagingDormID;
    }
}