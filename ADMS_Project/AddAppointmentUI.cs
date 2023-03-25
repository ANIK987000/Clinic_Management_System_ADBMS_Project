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
    public partial class AddAppointmentUI : Form
    {
        public AddAppointmentUI()
        {
            InitializeComponent();
        }

        private void addAdminRegisterButton_Click(object sender, EventArgs e)
        {
            //string insertAppointment = $"insert into  appointment(APPOINTMENTSERIAL,DOCTORID,PATIENTID,APPOINTMENTDATE ,RECEPTIONISTID) values(appointment_sequence.nextval,'{doctorIdTextBox.Text}', '{patientIdTextBox.Text}', '{appointmentDateTextBox.Text}','{Session.Id}')";

            if (doctorIdTextBox.Text == "")
            {
                MessageBox.Show("Doctor ID cannot be empty");
            }
            else if (patientIdTextBox.Text == "")
            {
                MessageBox.Show("Patient ID cannot be empty");
            }
            else if (appointmentDateTextBox.Text == "")
            {
                MessageBox.Show("Appointment Date cannot be empty");
            }
            
            

            else
             {
                // DbAccess.UpdateDeleteInsert(insertAppointment);
                DbAccess.addappointment(Convert.ToInt32(doctorIdTextBox.Text),Convert.ToInt32(patientIdTextBox.Text),appointmentDateTextBox.Text,Convert.ToInt32(receptionistIdTextBox.Text));
                    MessageBox.Show("Appointment added successfully !!!");
             }
         }

        private void AddAppointmentUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            doctorListDataGridView.DataSource = dbAccess.GetAllDoctors();
            patientListDataGridView.DataSource = dbAccess.GetAllPatients();
        }

        private void addAdminBackButton_Click(object sender, EventArgs e)
        {
            AppointmentManagement appointmentManagement = new AppointmentManagement();
            appointmentManagement.Show();
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

