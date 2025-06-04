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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete_Item_btn = new System.Windows.Forms.Button();
            this.Edit_Item_btn = new System.Windows.Forms.Button();
            this.Add_Item_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
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
            this.groupBox1.Controls.Add(this.Edit_Item_btn);
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
            // Edit_Item_btn
            // 
            this.Edit_Item_btn.ForeColor = System.Drawing.Color.Blue;
            this.Edit_Item_btn.Location = new System.Drawing.Point(562, 19);
            this.Edit_Item_btn.Name = "Edit_Item_btn";
            this.Edit_Item_btn.Size = new System.Drawing.Size(101, 27);
            this.Edit_Item_btn.TabIndex = 1;
            this.Edit_Item_btn.Text = "ویرایش وسیله";
            this.Edit_Item_btn.UseVisualStyleBackColor = true;
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
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete_Item_btn;
        private System.Windows.Forms.Button Edit_Item_btn;
        private System.Windows.Forms.Button Add_Item_btn;
    }
}