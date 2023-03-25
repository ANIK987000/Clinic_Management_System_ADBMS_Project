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
    public partial class UpdateDoctorUI : Form
    {
        public UpdateDoctorUI()
        {
            InitializeComponent();
        }

        private void UpdateDoctorUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            doctorListDataGridView.DataSource = dbAccess.GetAllDoctors();
        }

        private void updateDoctorUpdateButton_Click(object sender, EventArgs e)
        {
            string updateDoctor = $"update doctor set DOCTORNAME='{updateDoctorNameTextBox.Text}', USERNAME='{updateDoctorUsernameTextBox.Text}', PASSWORD='{updateDoctorPasswordTextBox.Text}',DEPARTMENT='{updateDoctorDepartmentComboBox.Text}', CHAMBERNO='{updateDoctorChamberNoComboBox.Text}',VISITINGDAYS='{updateDoctorVisitingDaysComboBox.Text}',VISITINGHOURS='{updateDoctorVisitingHoursComboBox.Text}',APPOINTMENTFEE='{updateDoctorAppointmentFeeComboBox.Text}' where DOCTORID='{updateDoctorIdTextBox.Text}'";

            if (updateDoctorNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (updateDoctorUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (updateDoctorPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
         
            else if (updateDoctorDepartmentComboBox.Text == "")
            {
                MessageBox.Show("Department cannot be empty");
            }
         
            else if (updateDoctorChamberNoComboBox.Text == "")
            {
                MessageBox.Show("ChamberNo cannot be empty");
            }
            else if (updateDoctorVisitingDaysComboBox.Text == "")
            {
                MessageBox.Show("Visiting Days cannot be empty");
            }

            else if (updateDoctorVisitingHoursComboBox.Text == "")
            {
                MessageBox.Show("Visiting Hours cannot be empty");
            }
            else if (updateDoctorAppointmentFeeComboBox.Text == "")
            {
                MessageBox.Show("Appointment Fee cannot be empty");
            }

            else
            {


                DbAccess.UpdateDeleteInsert(updateDoctor);
                MessageBox.Show("User updated successfully !!!");

            }
        }

        private void updateDoctorBackButton_Click(object sender, EventArgs e)
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
