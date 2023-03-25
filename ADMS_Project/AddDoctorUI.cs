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
    public partial class AddDoctorUI : Form
    {
        public AddDoctorUI()
        {
            InitializeComponent();
        }

        private void addDoctorRegistrationButton_Click(object sender, EventArgs e)
        {
            //string insertDoctor = $"insert into  doctor(DOCTORID,DOCTORNAME,USERNAME,PASSWORD,DEPARTMENT,CHAMBERNO,VISITINGDAYS,VISITINGHOURS,APPOINTMENTFEE,ADMINID) values(doctor_sequence.nextval,'{addDoctorNameTextBox.Text}', '{addDoctorUsernameTextBox.Text}', '{addDoctorPasswordTextBox.Text}','{addDoctorDepartmentComboBox.Text}', '{addDoctorChamberNoComboBox.Text}','{addDoctorVisitingDaysComboBox.Text}','{addDoctorVisitingHoursComboBox.Text}','{addDoctorAppointmentFeeComboBox.Text}','{textBox1.Text}')";
            if (addDoctorNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (addDoctorUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (addDoctorPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            //else if (addDoctorPasswordTextBox.Text.Length != 8)
            //{
            //    MessageBox.Show("Password length should be eight");
            //}
            else if (addDoctorConfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm Password cannot be empty");
            }
            else if (addDoctorDepartmentComboBox.Text == "")
            {
                MessageBox.Show("Department cannot be empty");
            }
            else if (addDoctorChamberNoComboBox.Text == "")
            {
                MessageBox.Show("Chamber No cannot be empty");
            }
            else if (addDoctorVisitingDaysComboBox.Text == "")
            {
                MessageBox.Show("Visiting Days cannot be empty");
            }
            else if (addDoctorVisitingHoursComboBox.Text == "")
            {
                MessageBox.Show("Visiting Hours cannot be empty");
            }
            else if (addDoctorAppointmentFeeComboBox.Text == "")
            {
                MessageBox.Show("Appointment Fee cannot be empty");
            }
            else
            {
                if (addDoctorPasswordTextBox.Text != addDoctorConfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and Confirm Password does not match");
                }
                else
                {
                    //DbAccess.UpdateDeleteInsert(insertDoctor);
                    DbAccess.adddoctor(addDoctorNameTextBox.Text,addDoctorUsernameTextBox.Text,addDoctorPasswordTextBox.Text,addDoctorDepartmentComboBox.Text,addDoctorChamberNoComboBox.Text,addDoctorVisitingDaysComboBox.Text,addDoctorVisitingHoursComboBox.Text,Convert.ToInt32(addDoctorAppointmentFeeComboBox.Text),Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("User added successfully !!!");
                }
            }

        }

        private void addDoctorBackButton_Click(object sender, EventArgs e)
        {
            DoctorManagement doctorManagement = new DoctorManagement();
            doctorManagement.Show();
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
