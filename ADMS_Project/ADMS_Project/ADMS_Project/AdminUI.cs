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
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        private void adminUIAdminManagementButton_Click(object sender, EventArgs e)
        {
            AdminManagement adminManagement = new AdminManagement();
            adminManagement.Show();
            this.Hide();
        }
    }
}
