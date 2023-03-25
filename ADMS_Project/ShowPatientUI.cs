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
    public partial class ShowPatientUI : Form
    {
        public ShowPatientUI()
        {
            InitializeComponent();
        }

        private void ShowPatientUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            showpatientTreatmentListDataGridView.DataSource = dbAccess.GetPatientTreatment();
            
        }

        private void updateDoctorBackButton_Click(object sender, EventArgs e)
        {
            DoctorUI doctorUI = new DoctorUI();
            doctorUI.Show();
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
