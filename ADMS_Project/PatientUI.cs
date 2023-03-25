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
    public partial class PatientUI : Form
    {
        public PatientUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeeDoctorsList seeDoctorsList = new SeeDoctorsList();
            seeDoctorsList.Show();
            this.Hide();
        }

        private void patientUIBookAppointmentButton_Click(object sender, EventArgs e)
        {
            UpdatePatientUI updatePatientUI = new UpdatePatientUI();
            updatePatientUI.Show();
            this.Hide();
        }

        private void PatientUI_Load(object sender, EventArgs e)
        {

        }
    }
}
