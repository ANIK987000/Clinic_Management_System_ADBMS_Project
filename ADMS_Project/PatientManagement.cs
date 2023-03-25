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
    public partial class PatientManagement : Form
    {
        public PatientManagement()
        {
            InitializeComponent();
        }

        private void addPatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddPatientUI addPatientUI = new AddPatientUI();
            addPatientUI.Show();
            this.Hide();
        }

        private void deletePatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeletePatientUI deletePatientUI = new DeletePatientUI();
            deletePatientUI.Show();
            this.Hide();
        }

        private void updatePatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePatientUI updatePatientUI = new UpdatePatientUI();
            updatePatientUI.Show();
            this.Hide();
        }

        private void PatientManagement_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            patientListDataGridView.DataSource = dbAccess.GetAllPatients1();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ReceptionistUI receptionistUI = new ReceptionistUI();
            receptionistUI.Show();
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
            DbAccess.UpdateDeleteInsert("alter trigger patient_opt enable");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbAccess.UpdateDeleteInsert("alter trigger patient_opt disable");
        }
    }
}
