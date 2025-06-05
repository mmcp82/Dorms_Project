using Dorms_Project.Person.DormManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorms_Project.Person
{
    public partial class Person_Management_Form : Form
    {
        public Person_Management_Form()
        {
            InitializeComponent();
        }

        private void Dmanager_btn_Click(object sender, EventArgs e)
        {
            Dorm_Manager_Management_Form dorm_Manager_Management_Form = new Dorm_Manager_Management_Form();
            dorm_Manager_Management_Form.ShowDialog();
        }
    }
}
