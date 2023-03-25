using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS_Project
{
    public partial class DoctorManagement : Form
    {
        public DoctorManagement()
        {
            InitializeComponent();
        }

        private void addDoctorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddDoctorUI addDoctorUI = new AddDoctorUI();
            addDoctorUI.Show();
            this.Hide();
        }

        private void deleteDoctorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteDoctorUI deleteDoctorUI = new DeleteDoctorUI();
            deleteDoctorUI.Show();
            this.Hide();
        }

        private void DoctorManagement_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            doctorListDataGridView.DataSource = dbAccess.GetAllDoctors1();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminUI adminUI = new AdminUI();
            adminUI.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbAccess.UpdateDeleteInsert("alter trigger doctor_opt enable");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbAccess.UpdateDeleteInsert("alter trigger doctor_opt disable");
        }
    }
}
