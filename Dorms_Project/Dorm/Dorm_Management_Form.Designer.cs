namespace Dorms_Project.Dorm
{
    partial class Dorm_Management_Form
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
            this.Dorm_Refresh_btn = new System.Windows.Forms.Button();
            this.Delete_Dorm_btn = new System.Windows.Forms.Button();
            this.Edit_Dorm_btn = new System.Windows.Forms.Button();
            this.Add_Dorm_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DG_Dorms = new System.Windows.Forms.DataGridView();
            this.DormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Dorms)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dorm_Refresh_btn);
            this.groupBox1.Controls.Add(this.Delete_Dorm_btn);
            this.groupBox1.Controls.Add(this.Edit_Dorm_btn);
            this.groupBox1.Controls.Add(this.Add_Dorm_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات";
            // 
            // Dorm_Refresh_btn
            // 
            this.Dorm_Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dorm_Refresh_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Dorm_Refresh_btn.Location = new System.Drawing.Point(348, 19);
            this.Dorm_Refresh_btn.Name = "Dorm_Refresh_btn";
            this.Dorm_Refresh_btn.Size = new System.Drawing.Size(101, 27);
            this.Dorm_Refresh_btn.TabIndex = 7;
            this.Dorm_Refresh_btn.Text = "بروز رسانی";
            this.Dorm_Refresh_btn.UseVisualStyleBackColor = true;
            this.Dorm_Refresh_btn.Click += new System.EventHandler(this.Dorm_Refresh_btn_Click);
            // 
            // Delete_Dorm_btn
            // 
            this.Delete_Dorm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Dorm_btn.ForeColor = System.Drawing.Color.Red;
            this.Delete_Dorm_btn.Location = new System.Drawing.Point(455, 19);
            this.Delete_Dorm_btn.Name = "Delete_Dorm_btn";
            this.Delete_Dorm_btn.Size = new System.Drawing.Size(101, 27);
            this.Delete_Dorm_btn.TabIndex = 8;
            this.Delete_Dorm_btn.Text = "حذف خوابگاه";
            this.Delete_Dorm_btn.UseVisualStyleBackColor = true;
            this.Delete_Dorm_btn.Click += new System.EventHandler(this.Delete_Dorm_btn_Click);
            // 
            // Edit_Dorm_btn
            // 
            this.Edit_Dorm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Dorm_btn.ForeColor = System.Drawing.Color.Blue;
            this.Edit_Dorm_btn.Location = new System.Drawing.Point(562, 19);
            this.Edit_Dorm_btn.Name = "Edit_Dorm_btn";
            this.Edit_Dorm_btn.Size = new System.Drawing.Size(101, 27);
            this.Edit_Dorm_btn.TabIndex = 9;
            this.Edit_Dorm_btn.Text = "ویرایش خوابگاه";
            this.Edit_Dorm_btn.UseVisualStyleBackColor = true;
            this.Edit_Dorm_btn.Click += new System.EventHandler(this.Edit_Dorm_btn_Click);
            // 
            // Add_Dorm_btn
            // 
            this.Add_Dorm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Dorm_btn.ForeColor = System.Drawing.Color.Green;
            this.Add_Dorm_btn.Location = new System.Drawing.Point(669, 19);
            this.Add_Dorm_btn.Name = "Add_Dorm_btn";
            this.Add_Dorm_btn.Size = new System.Drawing.Size(101, 27);
            this.Add_Dorm_btn.TabIndex = 10;
            this.Add_Dorm_btn.Text = "افزودن خوابگاه";
            this.Add_Dorm_btn.UseVisualStyleBackColor = true;
            this.Add_Dorm_btn.Click += new System.EventHandler(this.Add_Dorm_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DG_Dorms);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(776, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست خوابگاه ها";
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
            this.DG_Dorms.Location = new System.Drawing.Point(6, 22);
            this.DG_Dorms.Name = "DG_Dorms";
            this.DG_Dorms.ReadOnly = true;
            this.DG_Dorms.Size = new System.Drawing.Size(764, 340);
            this.DG_Dorms.TabIndex = 6;
            // 
            // DormID
            // 
            this.DormID.DataPropertyName = "DormID";
            this.DormID.FillWeight = 25.99545F;
            this.DormID.HeaderText = "DormID";
            this.DormID.Name = "DormID";
            this.DormID.ReadOnly = true;
            this.DormID.Visible = false;
            // 
            // DormName
            // 
            this.DormName.DataPropertyName = "DormName";
            this.DormName.FillWeight = 88.73082F;
            this.DormName.HeaderText = "نام خوابگاه";
            this.DormName.Name = "DormName";
            this.DormName.ReadOnly = true;
            // 
            // DormCapacity
            // 
            this.DormCapacity.DataPropertyName = "DormCapacity";
            this.DormCapacity.FillWeight = 38.07107F;
            this.DormCapacity.HeaderText = "ظرفیت";
            this.DormCapacity.Name = "DormCapacity";
            this.DormCapacity.ReadOnly = true;
            // 
            // DormManagerID
            // 
            this.DormManagerID.DataPropertyName = "DormManagerID";
            this.DormManagerID.FillWeight = 84.1068F;
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
            this.DormAddress.FillWeight = 263.0959F;
            this.DormAddress.HeaderText = "آدرس خوابگاه";
            this.DormAddress.Name = "DormAddress";
            this.DormAddress.ReadOnly = true;
            // 
            // Dorm_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dorm_Management_Form";
            this.Text = "Dorm_Management_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dorm_Management_Form_FormClosing);
            this.Load += new System.EventHandler(this.Dorm_Management_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Dorms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_Dorm_btn;
        private System.Windows.Forms.Button Delete_Dorm_btn;
        private System.Windows.Forms.Button Edit_Dorm_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DG_Dorms;
        private System.Windows.Forms.Button Dorm_Refresh_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormAddress;
    }
}