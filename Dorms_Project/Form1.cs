using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorms_Project
{
    public partial class Management_Form : Form
    {
        public Management_Form()
        {
            InitializeComponent();
        }

        private void Dorm_btn_Click(object sender, EventArgs e)
        {
            Dorm_Management_Form dorm_Management_Form = new Dorm_Management_Form();
            dorm_Management_Form.ShowDialog();
        }

        private void Block_btn_Click(object sender, EventArgs e)
        {
            Block_Management_Form block_Management_Form = new Block_Management_Form();
            block_Management_Form.ShowDialog();
        }

        private void Person_btn_Click(object sender, EventArgs e)
        {
            Person_Management_Form person_Management_Form = new Person_Management_Form();
            person_Management_Form.ShowDialog();
        }

        private void Item_btn_Click(object sender, EventArgs e)
        {
            Item_Management_Form item_Management_Form = new Item_Management_Form();
            item_Management_Form.ShowDialog();
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            Report_Form report_Form = new Report_Form();
            report_Form.ShowDialog();
        }

    }
}
