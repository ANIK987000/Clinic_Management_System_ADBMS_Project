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
    public partial class AppointmentManagement : Form
    {
        public AppointmentManagement()
        {
            InitializeComponent();
        }

        private void addPatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAppointmentUI addAppointmentUI = new AddAppointmentUI();
            addAppointmentUI.Show();
            this.Hide();
        }

        private void deletePatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteAppointmentUI deleteAppointmentUI = new DeleteAppointmentUI();
            deleteAppointmentUI.Show();
            this.Hide();
        }

        private void updatePatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateAppointmentUI updateAppointmentUI = new UpdateAppointmentUI();
            updateAppointmentUI.Show();
            this.Hide();
        }

        private void AppointmentManagement_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            appointmentListDataGridView.DataSource = dbAccess.ShowAppointment();
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
    }
}
