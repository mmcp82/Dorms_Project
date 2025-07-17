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
    public partial class Item_Management_Form : Form
    {
        IF_Item_Repository _Item_Repository;
        private static Random _random = new Random();

        DataColumn Item8digitIDColumn;
        public Item_Management_Form()
        {
            InitializeComponent();
            _Item_Repository = new Item_Repository();
        }

        private void Item_Management_Form_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            dataGridView1.AutoGenerateColumns = false;
            DataTable dataTable = _Item_Repository.GetItemTable();
            Item8digitIDColumn = dataTable.Columns["Item8DigitsID"];
            dataGridView1.DataSource = dataTable;
        }

        private void Add_Item_btn_Click(object sender, EventArgs e)
        {
            // Example usage:
            var options = new List<string> { "تخت", "کمد", "میز", "صندلی", "یخچال" };

            var (result, selectedValue) = ComboMessageBox.Show(
                "لطفا یک گزینه را انتخاب کنید",
                "انتخاب",
                options
                );

            if (result == DialogResult.OK)
            {
                MessageBox.Show($"شما گزینه {selectedValue} را انتخاب کردید");


                string partNumber;

                switch (selectedValue)
                {
                    case "تخت":
                        partNumber = "001";
                        break;
                    case "کمد":
                        partNumber = "002";
                        break;
                    case "میز":
                        partNumber = "003";
                        break;
                    case "صندلی":
                        partNumber = "004";
                        break;
                    case "یخچال":
                        partNumber = "005";
                        break;
                    default:
                        partNumber = "000";
                        break;
                }
                if (partNumber != "000")
                {
                    bool InsertItemSuccess = _Item_Repository.Insert_Success(selectedValue, partNumber, Generate8DigitId(), "سالم");
                    if (InsertItemSuccess)
                    {
                        Refresh();
                    }
                }

            }
        }

        public string Generate8DigitId()
        {
            string newID;
            do
            {
                newID = _random.Next(10000000, 99999999).ToString();
            } while (!IsUnique(Item8digitIDColumn, newID));
            return newID;
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
