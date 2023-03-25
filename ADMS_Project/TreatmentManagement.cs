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
    public partial class TreatmentManagement : Form
    {
        public TreatmentManagement()
        {
            InitializeComponent();
        }

        private void addPatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTreatmentUI addTreatmentUI = new AddTreatmentUI();
            addTreatmentUI.Show();
            this.Hide();
        }

        private void deletePatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteTreatmentUI deleteTreatmentUI = new DeleteTreatmentUI();
            deleteTreatmentUI.Show();
            this.Hide();
        }

        private void updatePatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateTreatmentUI updateTreatmentUI = new UpdateTreatmentUI();
            updateTreatmentUI.Show();
            this.Hide();
        }

        private void TreatmentManagement_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            treatmentListDataGridView.DataSource = dbAccess.ShowTreatment();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DoctorUI doctorUI = new DoctorUI();
            doctorUI.Show();
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
