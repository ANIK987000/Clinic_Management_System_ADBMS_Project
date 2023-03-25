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
    public partial class DoctorUI : Form
    {
        public DoctorUI()
        {
            InitializeComponent();
        }

        private void doctorUIAppointmentListButton_Click(object sender, EventArgs e)
        {
            AddTreatmentUI addTreatmentUI = new AddTreatmentUI();
            addTreatmentUI.Show();
            this.Hide();
        }

        private void doctorUIGiveTreatmentButton_Click(object sender, EventArgs e)
        {
            TreatmentManagement treatmentManagement = new TreatmentManagement();
            treatmentManagement.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTreatmentUI updateTreatmentUI = new UpdateTreatmentUI();
            updateTreatmentUI.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPatientUI showPatientUI = new ShowPatientUI();
            showPatientUI.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDoctorUI updateDoctorUI = new UpdateDoctorUI();
            updateDoctorUI.Show();
            this.Hide();
        }

        private void DoctorUI_Load(object sender, EventArgs e)
        {

        }
    }
}
