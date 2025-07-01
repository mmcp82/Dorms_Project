namespace Dorms_Project.Person
{
    partial class Person_Management_Form
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
            this.Welcome_Sign = new System.Windows.Forms.Label();
            this.Pmanager_btn = new System.Windows.Forms.Button();
            this.Bmanager_btn = new System.Windows.Forms.Button();
            this.Dmanager_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome_Sign
            // 
            this.Welcome_Sign.AutoSize = true;
            this.Welcome_Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Welcome_Sign.Location = new System.Drawing.Point(104, 58);
            this.Welcome_Sign.Name = "Welcome_Sign";
            this.Welcome_Sign.Size = new System.Drawing.Size(189, 37);
            this.Welcome_Sign.TabIndex = 11;
            this.Welcome_Sign.Text = "مدیریت اشخاص";
            // 
            // Pmanager_btn
            // 
            this.Pmanager_btn.Location = new System.Drawing.Point(125, 249);
            this.Pmanager_btn.Name = "Pmanager_btn";
            this.Pmanager_btn.Size = new System.Drawing.Size(144, 51);
            this.Pmanager_btn.TabIndex = 8;
            this.Pmanager_btn.Text = "مدیریت دانشجویان";
            this.Pmanager_btn.UseVisualStyleBackColor = true;
            this.Pmanager_btn.Click += new System.EventHandler(this.Pmanager_btn_Click);
            // 
            // Bmanager_btn
            // 
            this.Bmanager_btn.Location = new System.Drawing.Point(125, 192);
            this.Bmanager_btn.Name = "Bmanager_btn";
            this.Bmanager_btn.Size = new System.Drawing.Size(144, 51);
            this.Bmanager_btn.TabIndex = 7;
            this.Bmanager_btn.Text = "مدیریت مسئولان بلوک";
            this.Bmanager_btn.UseVisualStyleBackColor = true;
            this.Bmanager_btn.Click += new System.EventHandler(this.Bmanager_btn_Click);
            // 
            // Dmanager_btn
            // 
            this.Dmanager_btn.Location = new System.Drawing.Point(125, 135);
            this.Dmanager_btn.Name = "Dmanager_btn";
            this.Dmanager_btn.Size = new System.Drawing.Size(144, 51);
            this.Dmanager_btn.TabIndex = 6;
            this.Dmanager_btn.Text = "مدیریت مسئولان خوابگاه";
            this.Dmanager_btn.UseVisualStyleBackColor = true;
            this.Dmanager_btn.Click += new System.EventHandler(this.Dmanager_btn_Click);
            // 
            // Person_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 385);
            this.Controls.Add(this.Welcome_Sign);
            this.Controls.Add(this.Pmanager_btn);
            this.Controls.Add(this.Bmanager_btn);
            this.Controls.Add(this.Dmanager_btn);
            this.Name = "Person_Management_Form";
            this.Text = "Person_Management_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_Sign;
        private System.Windows.Forms.Button Pmanager_btn;
        private System.Windows.Forms.Button Bmanager_btn;
        private System.Windows.Forms.Button Dmanager_btn;
    }
}