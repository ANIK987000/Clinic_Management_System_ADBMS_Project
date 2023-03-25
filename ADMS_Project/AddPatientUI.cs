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
    public partial class AddPatientUI : Form
    {
        public AddPatientUI()
        {
            InitializeComponent();
        }

        private void addPatientRegisterButton_Click(object sender, EventArgs e)
        {
            //string insertPatient = $"insert into  patient(PATIENTID,PATIENTNAME,USERNAME,PASSWORD,GENDER,AGE,HEIGHT,WEIGHT,BLOODGROUP,DISEASE) values(patient_sequence.nextval,'{addPatientNameTextBox.Text}', '{addPatientUserNameTextBox.Text}', '{addPatientPasswordTextBox.Text}','{addPatientGenderComboBox.Text}', '{addPatientAgeTextBox.Text}','{addPatientHeightTextBox.Text}','{addPatientWeightTextBox.Text}','{bloodGroupComboBox.Text}','{checkedListBox1.Text}')";
            //string insertPatient = $"begin addpatient(patient_sequence.nextval,'{addPatientNameTextBox.Text}', '{addPatientUserNameTextBox.Text}', '{addPatientPasswordTextBox.Text}','{addPatientGenderComboBox.Text}', '{addPatientAgeTextBox.Text}','{addPatientHeightTextBox.Text}','{addPatientWeightTextBox.Text}','{bloodGroupComboBox.Text}','{checkedListBox1.Text}');end;";
            if (addPatientNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (addPatientUserNameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (addPatientPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            //else if (addPatientPasswordTextBox.Text.Length != 9)
            //{
            //    MessageBox.Show("Password length should be nine");
            //}
            else if (addPatientConfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm Password cannot be empty");
            }
            else if (addPatientGenderComboBox.Text == "")
            {
                MessageBox.Show("Gender cannot be empty");
            }
            else if (addPatientAgeTextBox.Text == "")
            {
                MessageBox.Show("Age cannot be empty");
            }
            else if (!int.TryParse(addPatientAgeTextBox.Text.ToString(), out int value))
            {
                MessageBox.Show("Age must be an integer");
            }
            else if (Convert.ToInt32(addPatientAgeTextBox.Text) < 0)
            {
                MessageBox.Show("Age cannot be negative");
            }
            else if (addPatientHeightTextBox.Text == "")
            {
                MessageBox.Show("Height cannot be empty");
            }
            else if (!int.TryParse(addPatientHeightTextBox.Text.ToString(), out int value1))
            {
                MessageBox.Show("Height must be an integer");
            }

            else if (Convert.ToInt32(addPatientHeightTextBox.Text) < 0)
            {
                MessageBox.Show("Height cannot be negative");
            }
            else if (addPatientWeightTextBox.Text == "")
            {
                MessageBox.Show("Weight cannot be empty");
            }
            else if (!int.TryParse(addPatientWeightTextBox.Text.ToString(), out int value2))
            {
                MessageBox.Show("Weight must be an integer");
            }
            else if (Convert.ToInt32(addPatientWeightTextBox.Text) < 0)
            {
                MessageBox.Show("Weight cannot be negative");
            }
            else if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Blood Group cannot be empty");
            }
            else if (checkedListBox1.Text == "")
            {
                MessageBox.Show("Current Disease cannot be empty");
            }
            else
            {
                if (addPatientPasswordTextBox.Text != addPatientConfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and Confirm Password does not match");
                }
                else
                {
                    //DbAccess.addpatient();
                    DbAccess.addpatient(addPatientNameTextBox.Text, addPatientUserNameTextBox.Text, addPatientPasswordTextBox.Text, addPatientGenderComboBox.Text, Int32.Parse(addPatientAgeTextBox.Text), Int32.Parse(addPatientHeightTextBox.Text), Int32.Parse(addPatientWeightTextBox.Text), bloodGroupComboBox.Text, checkedListBox1.Text);

                    MessageBox.Show("User added successfully !!!");
                }
            }
        }

        private void addAdminBackButton_Click(object sender, EventArgs e)
        {
            PatientManagement patientManagement = new PatientManagement();
            patientManagement.Show();
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
