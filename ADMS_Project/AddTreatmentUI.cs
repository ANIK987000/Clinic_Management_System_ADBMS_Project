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
    public partial class AddTreatmentUI : Form
    {
        public AddTreatmentUI()
        {
            InitializeComponent();
        }

        private void addAdminRegisterButton_Click(object sender, EventArgs e)
        {
            //string insertTreatment = $"insert into  treatment(PRESCRIPTIONNO,PATIENTID,DOCTORID,PRESCRIPTION) values(treatment_sequence.nextval,'{patientIdTextBox.Text}', '{doctorIdTextBox.Text}', '{prescriptionTextBox.Text}')";

            
            if (patientIdTextBox.Text == "")
            {
                MessageBox.Show("Patient Id cannot be empty");
            }
            else if (doctorIdTextBox.Text == "")
            {
                MessageBox.Show("Doctor Id cannot be empty");
            }
            else if (prescriptionTextBox.Text=="")
            {
                MessageBox.Show("Prescription cannot be empty");
            }
            else
            {

                //DbAccess.UpdateDeleteInsert(insertTreatment);
                DbAccess.addtreatment(Convert.ToInt32(patientIdTextBox.Text),prescriptionTextBox.Text,Convert.ToInt32(doctorIdTextBox.Text));
                    MessageBox.Show("Added successfully !!!");
                
            }
        }

        private void AddTreatmentUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            patientListDataGridView.DataSource = dbAccess.GetAllPatients();
        }

        private void patientListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addAdminBackButton_Click(object sender, EventArgs e)
        {
            TreatmentManagement treatmentManagement = new TreatmentManagement();
            treatmentManagement.Show();
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
