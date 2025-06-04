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
            DG_Dorms.AutoGenerateColumns = false;
            DG_Dorms.DataSource = _repository.GetDormTable();
        }
    }
}
