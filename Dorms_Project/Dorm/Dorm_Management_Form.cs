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

namespace Dorms_Project.Dorm
{
    public partial class Dorm_Management_Form : Form
    {
        IF_Dorm_Repository _repository;

        public Dorm_Management_Form()
        {
            InitializeComponent();
            _repository = new Dorm_Repository();
        }

        private void Dorm_Management_Form_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DG_Dorms.AutoGenerateColumns = false;
            DG_Dorms.DataSource = _repository.GetDormTable();
        }

        private void Add_Dorm_btn_Click(object sender, EventArgs e)
        {
            AddOrEdit_Dorm addOrEdit_Dorm = new AddOrEdit_Dorm();
            addOrEdit_Dorm.ShowDialog();
            if (addOrEdit_Dorm.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void Edit_Dorm_btn_Click(object sender, EventArgs e)
        {
            AddOrEdit_Dorm addOrEdit_Dorm = new AddOrEdit_Dorm();
            addOrEdit_Dorm.ShowDialog();
        }

        private void Dorm_Refresh_btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
