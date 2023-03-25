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
    public partial class SeeDoctorsList : Form
    {
        public SeeDoctorsList()
        {
            InitializeComponent();
        }

        private void SeeDoctorsList_Load(object sender, EventArgs e)
        {
            //var reader = DbAccess.GetData($"SELECT * FROM doctor");

            //if(reader.HasRows==true)
            //{
            //    MessageBox.Show("Loading all details");
            //    dataGridView1.DataSource = reader;
            //}
           DbAccess dbAccess = new DbAccess();
            doctorListDataGridView.DataSource = dbAccess.GetAllDoctors1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addAdminBackButton_Click(object sender, EventArgs e)
        {
            PatientUI patientUI = new PatientUI();
            patientUI.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
