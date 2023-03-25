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
    public partial class ReceptionistUI : Form
    {
        public ReceptionistUI()
        {
            InitializeComponent();
        }

        private void registerPatientButton_Click(object sender, EventArgs e)
        {
            PatientManagement patientManagement = new PatientManagement();
            patientManagement.Show();
            this.Hide();
        }

        private void logIngPatientButton_Click(object sender, EventArgs e)
        {
            AppointmentManagement appointmentManagement = new AppointmentManagement();
            appointmentManagement.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateReceptionistUI updateReceptionistUI = new UpdateReceptionistUI();
            updateReceptionistUI.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowAppointment showAppointment = new ShowAppointment();
            showAppointment.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowDoctorListUI showDoctorListUI = new ShowDoctorListUI();
            showDoctorListUI.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowPatientListUI showPatientListUI = new ShowPatientListUI();
            showPatientListUI.Show();
            this.Hide();
        }

        
    }
}
