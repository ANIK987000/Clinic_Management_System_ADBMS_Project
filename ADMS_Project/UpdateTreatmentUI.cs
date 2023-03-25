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
    public partial class UpdateTreatmentUI : Form
    {
        public UpdateTreatmentUI()
        {
            InitializeComponent();
        }

        private void addAdminRegisterButton_Click(object sender, EventArgs e)
        {
            //string updateAdmin = $"update treatment set PRESCRIPTIONNO='{prescriptionNoTextBox.Text}', PATIENTID='{patientIdTextBox.Text}', DOCTORID='{doctorIdTextBox.Text}',PRESCRIPTION='{prescriptionTextBox.Text}' where PRESCRIPTIONNO='{prescriptionNoTextBox.Text}'";

            if (prescriptionNoTextBox.Text == "")
            {
                MessageBox.Show("PrescriptionNo cannot be empty");
            }
           
            else if (prescriptionTextBox.Text == "")
            {
                MessageBox.Show("Prescription cannot be empty");
            }
    
            else
            {


                //DbAccess.UpdateDeleteInsert(updateAdmin);
                DbAccess.updatetreatment(Convert.ToInt32(prescriptionNoTextBox.Text),prescriptionTextBox.Text);
                MessageBox.Show("User updated successfully !!!");

            }
        }

        private void UpdateTreatmentUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            treatmentListDataGridView.DataSource = dbAccess.GetPatientTreatment();
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
