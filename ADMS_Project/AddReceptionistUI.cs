using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS_Project
{
    public partial class AddReceptionistUI : Form
    {
        public AddReceptionistUI()
        {
            InitializeComponent();
        }
        public bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                return false;
            }
        }
        private void addReceptionistRegisterButton_Click(object sender, EventArgs e)
        {
            //string insertReceptionist = $"insert into  receptionist(RECEPTIONISTID,RECEPTIONISTNAME,USERNAME,PASSWORD,EMAIL,GENDER,AGE,ADMINID) values(receptionist_sequence.nextval,'{addReceptionistNameTextBox.Text}', '{addReceptionistUsernameTextBox.Text}', '{addReceptionistPasswordTextBox.Text}','{addReceptionistEmailTextBox.Text}', '{addReceptionistGenderComboBox.Text}','{addReceptionistAgeTextBox.Text}','{textBox1.Text}')";
            if (addReceptionistNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (addReceptionistUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (addReceptionistPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            //else if (addReceptionistPasswordTextBox.Text.Length != 10)
            //{
            //    MessageBox.Show("Password length should be ten");
            //}
            else if (addReceptionistConfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm Password cannot be empty");
            }
            else if (addReceptionistEmailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (IsValidEmailAddress(addReceptionistEmailTextBox.Text) != true)
            {
                MessageBox.Show("Email pattern is not correct");
            }
            else if (addReceptionistGenderComboBox.Text == "")
            {
                MessageBox.Show("Gender cannot be empty");
            }
            else if (addReceptionistAgeTextBox.Text == "")
            {
                MessageBox.Show("Age cannot be empty");
            }
            else if (!int.TryParse(addReceptionistAgeTextBox.Text.ToString(), out int value))
            {
                MessageBox.Show("Age must be an integer");
            }
            else if (Convert.ToInt32(addReceptionistAgeTextBox.Text) < 0)
            {
                MessageBox.Show("Age cannot be negative");
            }
            else
            {
                if (addReceptionistPasswordTextBox.Text != addReceptionistConfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and Confirm Password does not match");
                }
                else
                {
                    //DbAccess.UpdateDeleteInsert(insertReceptionist);
                    DbAccess.addreceptionist(addReceptionistNameTextBox.Text,addReceptionistUsernameTextBox.Text,addReceptionistConfirmPasswordTextBox.Text,addReceptionistEmailTextBox.Text,addReceptionistGenderComboBox.Text,Convert.ToInt32(addReceptionistAgeTextBox.Text),Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("User added successfully !!!");

                }
            }
        }

        private void addReceptionistBackButton_Click(object sender, EventArgs e)
        {
            ReceptionistManagement receptionistManagement = new ReceptionistManagement();
            receptionistManagement.Show();
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
