namespace Dorms_Project
{
    partial class Management_Form
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
            this.Dorm_btn = new System.Windows.Forms.Button();
            this.Block_btn = new System.Windows.Forms.Button();
            this.Person_btn = new System.Windows.Forms.Button();
            this.Item_btn = new System.Windows.Forms.Button();
            this.Report_btn = new System.Windows.Forms.Button();
            this.Welcome_Sign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dorm_btn
            // 
            this.Dorm_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Dorm_btn.Location = new System.Drawing.Point(163, 158);
            this.Dorm_btn.Name = "Dorm_btn";
            this.Dorm_btn.Size = new System.Drawing.Size(144, 51);
            this.Dorm_btn.TabIndex = 0;
            this.Dorm_btn.Text = "مدیریت خوابگاه ها";
            this.Dorm_btn.UseVisualStyleBackColor = false;
            this.Dorm_btn.Click += new System.EventHandler(this.Dorm_btn_Click);
            // 
            // Block_btn
            // 
            this.Block_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Block_btn.Location = new System.Drawing.Point(163, 215);
            this.Block_btn.Name = "Block_btn";
            this.Block_btn.Size = new System.Drawing.Size(144, 51);
            this.Block_btn.TabIndex = 1;
            this.Block_btn.Text = "مدیریت بلوک ها";
            this.Block_btn.UseVisualStyleBackColor = false;
            this.Block_btn.Click += new System.EventHandler(this.Block_btn_Click);
            // 
            // Person_btn
            // 
            this.Person_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Person_btn.Location = new System.Drawing.Point(163, 272);
            this.Person_btn.Name = "Person_btn";
            this.Person_btn.Size = new System.Drawing.Size(144, 51);
            this.Person_btn.TabIndex = 2;
            this.Person_btn.Text = "مدیریت اشخاص";
            this.Person_btn.UseVisualStyleBackColor = false;
            this.Person_btn.Click += new System.EventHandler(this.Person_btn_Click);
            // 
            // Item_btn
            // 
            this.Item_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Item_btn.Location = new System.Drawing.Point(163, 329);
            this.Item_btn.Name = "Item_btn";
            this.Item_btn.Size = new System.Drawing.Size(144, 51);
            this.Item_btn.TabIndex = 3;
            this.Item_btn.Text = "مدیریت اموال";
            this.Item_btn.UseVisualStyleBackColor = false;
            this.Item_btn.Click += new System.EventHandler(this.Item_btn_Click);
            // 
            // Report_btn
            // 
            this.Report_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Report_btn.Location = new System.Drawing.Point(163, 386);
            this.Report_btn.Name = "Report_btn";
            this.Report_btn.Size = new System.Drawing.Size(144, 51);
            this.Report_btn.TabIndex = 4;
            this.Report_btn.Text = "گزارش گیری";
            this.Report_btn.UseVisualStyleBackColor = false;
            this.Report_btn.Click += new System.EventHandler(this.Report_btn_Click);
            // 
            // Welcome_Sign
            // 
            this.Welcome_Sign.AutoSize = true;
            this.Welcome_Sign.BackColor = System.Drawing.SystemColors.Control;
            this.Welcome_Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Welcome_Sign.Location = new System.Drawing.Point(163, 81);
            this.Welcome_Sign.Name = "Welcome_Sign";
            this.Welcome_Sign.Size = new System.Drawing.Size(151, 37);
            this.Welcome_Sign.TabIndex = 5;
            this.Welcome_Sign.Text = "صفحه اصلی";
            // 
            // Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(478, 487);
            this.Controls.Add(this.Welcome_Sign);
            this.Controls.Add(this.Report_btn);
            this.Controls.Add(this.Item_btn);
            this.Controls.Add(this.Person_btn);
            this.Controls.Add(this.Block_btn);
            this.Controls.Add(this.Dorm_btn);
            this.Name = "Management_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "صفحه مدیریت";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dorm_btn;
        private System.Windows.Forms.Button Block_btn;
        private System.Windows.Forms.Button Person_btn;
        private System.Windows.Forms.Button Item_btn;
        private System.Windows.Forms.Button Report_btn;
        private System.Windows.Forms.Label Welcome_Sign;
    }
}

