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
    public partial class UpdatePatientUI : Form
    {
        public UpdatePatientUI()
        {
            InitializeComponent();
        }

        private void UpdatePatientUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            patientListDataGridView.DataSource = dbAccess.GetAllPatients();
        }

        private void updatePatientUpdateButton_Click(object sender, EventArgs e)
        {
            string updateAdmin = $"update patient set PATIENTNAME='{updatePatientNameTextBox.Text}', USERNAME='{updatePatientUsernameTextBox.Text}', PASSWORD='{updatePatientPasswordTextBox.Text}',GENDER='{updatePatientGenderComboBox.Text}', AGE='{updatePatientAgeTextBox.Text}',HEIGHT='{updatePatientHeightTextBox.Text}',WEIGHT='{updatePatientWeightTextBox.Text}',BLOODGROUP='{updatePatietntBloodGroupComboBox.Text}',DISEASE='{checkedListBox1.Text}' where PATIENTID='{textBox1.Text}'";

            if (updatePatientNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (updatePatientUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (updatePatientPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (updatePatientPasswordTextBox.Text.Length != 9)
            {
                MessageBox.Show("Password length should be nine");
            }

            else if (updatePatientGenderComboBox.Text == "")
            {
                MessageBox.Show("Gender cannot be empty");
            }
            else if (updatePatientAgeTextBox.Text == "")
            {
                MessageBox.Show("Age cannot be empty");
            }
            else if (!int.TryParse(updatePatientAgeTextBox.Text.ToString(), out int value))
            {
                MessageBox.Show("Age must be an integer");
            }
            else if (Convert.ToInt32(updatePatientAgeTextBox.Text) < 0)
            {
                MessageBox.Show("Age cannot be negative");
            }
            else if (updatePatientHeightTextBox.Text == "")
            {
                MessageBox.Show("Height cannot be empty");
            }
            else if (!int.TryParse(updatePatientHeightTextBox.Text.ToString(), out int value1))
            {
                MessageBox.Show("Height must be an integer");
            }
            else if (Convert.ToInt32(updatePatientHeightTextBox.Text) < 0)
            {
                MessageBox.Show("Height cannot be negative");
            }
            else if (updatePatientWeightTextBox.Text == "")
            {
                MessageBox.Show("Weight cannot be empty");
            }
            else if (!int.TryParse(updatePatientWeightTextBox.Text.ToString(), out int value2))
            {
                MessageBox.Show("Weight must be an integer");
            }
            else if (Convert.ToInt32(updatePatientWeightTextBox.Text) < 0)
            {
                MessageBox.Show("Weight cannot be negative");
            }
            else if (updatePatietntBloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Blood Group cannot be empty");
            }
            else if (checkedListBox1.Text == "")
            {
                MessageBox.Show("Current Disease cannot be empty");
            }

            else
            {


                DbAccess.UpdateDeleteInsert(updateAdmin);
                MessageBox.Show("User updated successfully !!!");

            }
        }

        private void addAdminBackButton_Click(object sender, EventArgs e)
        {
            PatientUI patientUI = new PatientUI();
            patientUI.Show();
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
