using Dorms_Project.Repository;
using Dorms_Project.Services;
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
        IF_ItemType_Repository _ItemType_Repository;
        public ComboMessageBox()
        {
            InitializeComponent();
            _ItemType_Repository = new ItemType_Repository();
        }

        // Public static method to show the dialog
        public static (DialogResult Result, string SelectedValue) Show(
            string message,
            string caption,
            IEnumerable<string> options,
            bool AddType,
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
                if (AddType)
                {
                    form.textBox1.Visible = true;
                    form.numericUpDown1.Visible = true;
                    form.cmbOptions.Visible = false;
                }
                else
                {
                    form.textBox1.Visible = false;
                    form.numericUpDown1.Visible = false;
                    form.cmbOptions.Visible = true;
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
            this.Height = lblMessage.Height + cmbOptions.Height + textBox1.Height + btnOK.Height + 100;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable TypeTable = _ItemType_Repository.GetTypesTable();
            DataColumn TypeColumn = TypeTable.Columns["ItemType"];
            if (textBox1.Text.Trim(' ') != "")
            {
                if (IsUnique(TypeColumn, textBox1.Text.Trim(' ')))
                {
                    bool TypeInsertSuccess = _ItemType_Repository.Insert_Seuccess(textBox1.Text.Trim(' '), (int)(numericUpDown1.Value));
                }
                else
                {
                    int typeID = FindID(TypeTable, textBox1.Text.Trim(' '));
                    bool TypeUpdateSuccess = _ItemType_Repository.Update_Success(typeID, textBox1.Text.Trim(' '), (int)numericUpDown1.Value);
                }
            }
        }
        private int FindID(DataTable table, object inputValue)
        {

            foreach (DataRow row in table.Rows)
            {
                object cellValue = row["ItemType"];

                // Handle DBNull cases
                if (cellValue == DBNull.Value)
                {
                    return 0; // No data in table therefore it's unique 
                }

                // Compare values
                if (cellValue.Equals(inputValue))
                {
                    return int.Parse(row["TypeID"].ToString()); // Found match
                }
            }

            return 0; // No matches found
        }
        private bool IsUnique(DataColumn column, object inputValue)
        {

            foreach (DataRow row in column.Table.Rows)
            {
                object cellValue = row[column];

                // Handle DBNull cases
                if (cellValue == DBNull.Value)
                {
                    return true; // No data in column therefore it's unique 
                }

                // Compare values
                if (cellValue.Equals(inputValue))
                {
                    return false; // Found match
                }
            }

            return true; // No matches found
        }
    }
}
