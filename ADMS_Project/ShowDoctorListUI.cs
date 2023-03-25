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
    public partial class ShowDoctorListUI : Form
    {
        public ShowDoctorListUI()
        {
            InitializeComponent();
        }

        private void ShowDoctorListUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            doctorListDataGridView.DataSource = dbAccess.GetAllDoctors1();
        }

        private void addAdminBackButton_Click(object sender, EventArgs e)
        {
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
