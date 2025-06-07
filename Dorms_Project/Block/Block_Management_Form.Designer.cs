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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete_Block_btn = new System.Windows.Forms.Button();
            this.Edit_Block_btn = new System.Windows.Forms.Button();
            this.Add_Block_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Block_Refresh_btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(776, 268);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست بلوک ها";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Block_Refresh_btn);
            this.groupBox1.Controls.Add(this.dataGridView1);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(657, 126);
            this.dataGridView1.TabIndex = 3;
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
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(764, 240);
            this.dataGridView2.TabIndex = 0;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete_Block_btn;
        private System.Windows.Forms.Button Edit_Block_btn;
        private System.Windows.Forms.Button Add_Block_btn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Block_Refresh_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}