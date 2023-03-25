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
    public partial class UpdateAppointmentUI : Form
    {
        public UpdateAppointmentUI()
        {
            InitializeComponent();
        }

        private void addAdminRegisterButton_Click(object sender, EventArgs e)
        {
            //string updateAppointment = $"update appointment set DOCTORID='{doctorIdTextBox.Text}', PATIENTID='{patientIdTextBox.Text}', APPOINTMENTDATE='{appointmentDateTextBox.Text}',RECEPTIONISTID='{receptionistIdTextBox.Text}' where APPOINTMENTSERIAL='{appointmentSerialTextBox.Text}'";

            if (appointmentSerialTextBox.Text == "")
            {
                MessageBox.Show("Appointment Serial cannot be empty");
            }
        
            //else if (addAdminPasswordTextBox.Text.Length != 7)
            //{
            //    MessageBox.Show("Password length should be seven");
            //}

            else if (appointmentDateTextBox.Text == "")
            {
                MessageBox.Show("Appointment Date cannot be empty");
            }
      
            else
            {


                //DbAccess.UpdateDeleteInsert(updateAppointment);
                DbAccess.updateappointment(Convert.ToInt32(appointmentSerialTextBox.Text),appointmentDateTextBox.Text);
                MessageBox.Show("User updated successfully !!!");

            }
        }

        private void UpdateAppointmentUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            appointmentListDataGridView.DataSource = dbAccess.GetDoctorPaitentAppointment();
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
