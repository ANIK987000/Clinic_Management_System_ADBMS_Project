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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            dynamic reader;
            if (loginPasswordTextBox.Text == "" && loginUsernameTextBox.Text == "")
            {
                MessageBox.Show("Provide Username and Password");
            }
            else if (loginUsernameTextBox.Text == "")
            {
                MessageBox.Show("Provide Username ");
            }
            else if (loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Provide Password");
            }
            else if(cuser.Text=="User")
            {
                MessageBox.Show("Select User");
            }
            else 
            {

                if (cuser.Text == "Admin")
                {
                    reader = DbAccess.GetData($"SELECT * FROM admin WHERE Username='{loginUsernameTextBox.Text}' and password='{loginPasswordTextBox.Text}'");

                    if (reader.HasRows == true)
                    {
                        MessageBox.Show("Login Successful !!! ");
                        AdminUI dash = new AdminUI();
                        dash.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Sorry, login failed !!!");
                    }
                }
                else if (cuser.Text == "Receptionist")
                {
                    reader = DbAccess.GetData($"SELECT * FROM receptionist WHERE Username='{loginUsernameTextBox.Text}' and password='{loginPasswordTextBox.Text}'");

                    if (reader.HasRows == true)
                    {
                        //Session.Id = Int32.Parse(loginUsernameTextBox.Text);
                        MessageBox.Show("Login Successful !!! ");
                        ReceptionistUI dash = new ReceptionistUI();
                        dash.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Sorry, login failed !!!");
                    }
                }
                else if (cuser.Text == "Doctor")
                {
                    reader = DbAccess.GetData($"SELECT * FROM doctor WHERE Username='{loginUsernameTextBox.Text}' and password='{loginPasswordTextBox.Text}'");

                    if (reader.HasRows == true)
                    {
                        //Session.Id = Int32.Parse(loginUsernameTextBox.Text);
                        MessageBox.Show("Login Successful !!! ");
                        DoctorUI dash = new DoctorUI();
                        dash.Show();
                        this.Hide();
                        //dash.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Sorry, login failed !!!");
                    }
                }
                else if (cuser.Text == "Patient")
                {
                    reader = DbAccess.GetData($"SELECT * FROM patient WHERE Username='{loginUsernameTextBox.Text}' and password='{loginPasswordTextBox.Text}'");

                    if (reader.HasRows == true)
                    {
                        MessageBox.Show("Login Successful !!! ");
                        PatientUI dash = new PatientUI();
                        dash.Show();
                        this.Hide();
                        //dash.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Sorry, login failed !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
            //else
            //{
            //    MessageBox.Show("Select User");
            //}
            /**/
        }
    }
}
