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
    public partial class UpdateAdminUI : Form
    {
        public UpdateAdminUI()
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
        private void updateAdminUpdateButton_Click(object sender, EventArgs e)
        {
            string updateAdmin = $"update admin set adminname='{updateAdminNameTextBox.Text}', USERNAME='{updateAdminUsernameTextBox.Text}', EMAIL='{updateAdminEmailTextBox.Text}',PASSWORD='{updateAdminPasswordTextBox.Text}', GENDER='{updateAdminGenderComboBox.Text}',AGE='{updateAdminAgeTextBox.Text}' where ADMINID='{updateIdTextBox.Text}'";

            if (updateAdminNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (updateAdminUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (updateAdminPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            //else if (addAdminPasswordTextBox.Text.Length != 7)
            //{
            //    MessageBox.Show("Password length should be seven");
            //}
            
            else if (updateAdminEmailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (IsValidEmailAddress(updateAdminEmailTextBox.Text) != true)
            {
                MessageBox.Show("Email pattern is not correct");
            }

            else if (updateAdminGenderComboBox.Text == "")
            {
                MessageBox.Show("Gender cannot be empty");
            }
            else if (updateAdminAgeTextBox.Text == "")
            {
                MessageBox.Show("Age cannot be empty");
            }
            else if (!int.TryParse(updateAdminAgeTextBox.Text.ToString(), out int value))
            {
                MessageBox.Show("Age must be an integer");
            }

            else if (Convert.ToInt32(updateAdminAgeTextBox.Text) < 0)
            {
                MessageBox.Show("Age cannot be negative");
            }

            else
            {
               
              
                    DbAccess.UpdateDeleteInsert(updateAdmin);
                    MessageBox.Show("User updated successfully !!!");
                
            }

        
    }

        private void UpdateAdminUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            adminListDataGridView.DataSource = dbAccess.GetAllAdmins();
        }

        private void updateAdminBackButton_Click(object sender, EventArgs e)
        {
            AdminManagement adminManagement = new AdminManagement();
            adminManagement.Show();
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
