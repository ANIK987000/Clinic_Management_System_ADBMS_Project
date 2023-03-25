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
    public partial class UpdateReceptionistUI : Form
    {
        public UpdateReceptionistUI()
        {
            InitializeComponent();
        }

        private void UpdateReceptionistUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            receptionistListDataGridView.DataSource = dbAccess.GetAllReceptionists();
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
        private void updateReceptionistUpdateButton_Click(object sender, EventArgs e)
        {
            string updateReceptionist = $"update receptionist set RECEPTIONISTNAME='{updateReceptionistNameTextBox.Text}', USERNAME='{updateReceptionistUsernameTextBox.Text}', PASSWORD='{updateReceptionistPasswordTextBox.Text}',EMAIL='{updateReceptionistEmailTextBox.Text}', GENDER='{updateReceptionistGenderComboBox.Text}',AGE='{updateReceptionistAgeTextBox.Text}' where RECEPTIONISTID='{updateReceptionistIdTextBox.Text}'";

            if (updateReceptionistNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (updateReceptionistUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (updateReceptionistPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
           
            else if (updateReceptionistEmailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (IsValidEmailAddress(updateReceptionistEmailTextBox.Text) != true)
            {
                MessageBox.Show("Email pattern is not correct");
            }

            else if (updateReceptionistGenderComboBox.Text == "")
            {
                MessageBox.Show("Gender cannot be empty");
            }
            else if (updateReceptionistAgeTextBox.Text == "")
            {
                MessageBox.Show("Age cannot be empty");
            }
            else if (!int.TryParse(updateReceptionistAgeTextBox.Text.ToString(), out int value))
            {
                MessageBox.Show("Age must be an integer");
            }

            else if (Convert.ToInt32(updateReceptionistAgeTextBox.Text) < 0)
            {
                MessageBox.Show("Age cannot be negative");
            }

            else
            {


                DbAccess.UpdateDeleteInsert(updateReceptionist);
                MessageBox.Show("User updated successfully !!!");

            }
        }

        private void updateReceptionistBackButton_Click(object sender, EventArgs e)
        {
            //ReceptionistUI dash = new ReceptionistUI();
            //dash.ShowDialog();
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
