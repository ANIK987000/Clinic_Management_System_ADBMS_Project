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
    public partial class DeletePatientUI : Form
    {
        public DeletePatientUI()
        {
            InitializeComponent();
        }

        private void deletePatientDeleteButton_Click(object sender, EventArgs e)
        {
            //string deletePatient = $"Delete from patient where PATIENTID='{deletePatientIdTextBox.Text}'";
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //DbAccess.UpdateDeleteInsert(deletePatient);
                DbAccess.deletepatient(Convert.ToInt32(deletePatientIdTextBox.Text));
                MessageBox.Show("User deleted successfully !!!");
            }
        }

        private void DeletePatientUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            patientListDataGridView.DataSource = dbAccess.GetAllPatients1();
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
