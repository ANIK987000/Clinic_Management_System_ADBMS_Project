using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Net.Mail;

namespace ADMS_Project
{
    public partial class Registration : Form
    {
        
        public Registration()
        {
            InitializeComponent();
        }

       public void label4_Click(object sender, EventArgs e)
        {

        }

     public void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

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
        private void addAdminRegisterButton_Click(object sender, EventArgs e)
        {
            string insertReg = "insert into  admin(ADMINID,ADMINNAME,USERNAME,EMAIL ,PASSWORD,GENDER,AGE) values(admin_sequence.nextval,'{addAdminNameTextBox.Text}', '{addAdminUsernameTextBox.Text}', '{addAdminEmailTextBox.Text}','{addAdminPasswordTextBox.Text}', '{addAdminGenderComboBox.Text}','{addAdminAgeTextBox.Text}')";

            if (addAdminNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (addAdminUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (addAdminPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            //else if (addAdminPasswordTextBox.Text.Length != 7)
            //{
            //    MessageBox.Show("Password length should be seven");
            //}
            else if (addAdminConfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm Password cannot be empty");
            }
            else if (addAdminEmailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (IsValidEmailAddress(addAdminEmailTextBox.Text) != true)
            {
                MessageBox.Show("Email pattern is not correct");
            }

            else if (addAdminGenderComboBox.Text == "")
            {
                MessageBox.Show("Gender cannot be empty");
            }
            else if (addAdminAgeTextBox.Text == "")
            {
                MessageBox.Show("Age cannot be empty");
            }
            else if (!int.TryParse(addAdminAgeTextBox.Text.ToString(), out int value))
            {
                MessageBox.Show("Age must be an integer");
            }

            else if (Convert.ToInt32(addAdminAgeTextBox.Text) < 0)
            {
                MessageBox.Show("Age cannot be negative");
            }

            else
            {
                if (addAdminPasswordTextBox.Text != addAdminConfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and Confirm Password does not match");
                }
                else
                {
                    DbAccess.UpdateDeleteInsert(insertReg);
                    MessageBox.Show("User added successfully !!!");
                }
            }


            //DbAccess.UpdateDeleteInsert(insertReg);
            //MessageBox.Show("User added successfully !!!");
            DbAccess.Connection.Close();

        }
    }
}
