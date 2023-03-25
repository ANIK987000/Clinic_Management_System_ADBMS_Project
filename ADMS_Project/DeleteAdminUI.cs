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
    public partial class DeleteAdminUI : Form
    {
        public DeleteAdminUI()
        {
            InitializeComponent();
        }

        private void deleteAdminDeleteButton_Click(object sender, EventArgs e)
        {
            string deleteAdmin = $"Delete from admin where ADMINID='{deleteAdminIdTextBox.Text}'";
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

               DbAccess.UpdateDeleteInsert(deleteAdmin);
               MessageBox.Show("User deleted successfully !!!");
            }
        }

        private void DeleteAdminUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            adminListDataGridView.DataSource = dbAccess.GetAllAdmins1();
        }

        private void deleteAdminBackButton_Click(object sender, EventArgs e)
        {
            AdminManagement adminManagement = new AdminManagement();
            adminManagement.Show();
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
