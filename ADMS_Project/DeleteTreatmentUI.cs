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
    public partial class DeleteTreatmentUI : Form
    {
        public DeleteTreatmentUI()
        {
            InitializeComponent();
        }

        private void addAdminRegisterButton_Click(object sender, EventArgs e)
        {
            //string deleteTreatment = $"Delete from treatment where PRESCRIPTIONNO='{prescriptionNoTextBox.Text}'";
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //DbAccess.UpdateDeleteInsert(deleteTreatment);
                DbAccess.deletetreatment(Convert.ToInt32(prescriptionNoTextBox.Text));
                MessageBox.Show("Deleted successfully !!!");
            }
        }

        private void DeleteTreatmentUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            treatmentListDataGridView.DataSource = dbAccess.GetPatientTreatment(); ;
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
