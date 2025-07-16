using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorms_Project.Item
{
    public partial class ComboMessageBox : Form
    {
        public ComboMessageBox()
        {
            InitializeComponent();
        }

        // Public static method to show the dialog
        public static (DialogResult Result, string SelectedValue) Show(
            string message,
            string caption,
            IEnumerable<string> options,
            string defaultOption = null,
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel)
        {
            using (var form = new ComboMessageBox())
            {
                form.Text = caption;
                form.lblMessage.Text = message;

                // Populate the ComboBox
                form.cmbOptions.Items.AddRange(options.ToArray());

                // Set default selection if provided
                if (!string.IsNullOrEmpty(defaultOption) && form.cmbOptions.Items.Contains(defaultOption))
                {
                    form.cmbOptions.SelectedItem = defaultOption;
                }
                else if (form.cmbOptions.Items.Count > 0)
                {
                    form.cmbOptions.SelectedIndex = 0;
                }

                // Configure buttons
                switch (buttons)
                {
                    case MessageBoxButtons.OK:
                        form.btnOK.Visible = true;
                        form.btnCancel.Visible = false;
                        form.btnOK.DialogResult = DialogResult.OK;
                        form.AcceptButton = form.btnOK;
                        break;
                    case MessageBoxButtons.OKCancel:
                        form.btnOK.Visible = true;
                        form.btnCancel.Visible = true;
                        form.btnOK.DialogResult = DialogResult.OK;
                        form.btnCancel.DialogResult = DialogResult.Cancel;
                        form.CancelButton = form.btnCancel;
                        break;
                        // Add other button combinations as needed
                }

                var result = form.ShowDialog();
                return (result, result == DialogResult.OK ? form.cmbOptions.SelectedItem?.ToString() : null);
            }
        }

        // Optional: Handle form loading to set proper size
        private void ComboMessageBox_Load(object sender, EventArgs e)
        {
            // Auto-size the form to fit content
            this.Height = lblMessage.Height + cmbOptions.Height + btnOK.Height + 100;
        }
    }
}
