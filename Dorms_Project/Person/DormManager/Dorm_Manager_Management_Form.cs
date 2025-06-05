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

namespace Dorms_Project.Person.DormManager
{
    public partial class Dorm_Manager_Management_Form : Form
    {
        IF_Dorm_Manager_Repository _Dorm_Manager_Repository;

        public Dorm_Manager_Management_Form()
        {
            InitializeComponent();
            _Dorm_Manager_Repository = new Dorm_Manager_Repository();
        }

        private void Dorm_Manager_Management_Form_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DG_dormManager.AutoGenerateColumns = false;
            DG_dormManager.DataSource = _Dorm_Manager_Repository.GetDormManagerTable();
        }

        private void Add_Dorm_Manager_btn_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Dorm_Manager_btn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Dorm_Manager_btn_Click(object sender, EventArgs e)
        {

        }

        private void Dorm_Manager_Refresh_btn_Click(object sender, EventArgs e)
        {

        }

        private void Managing_Dorm_Details_Click(object sender, EventArgs e)
        {

        }

    }
}
