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
    public partial class AdminManagement : Form
    {
        public AdminManagement()
        {
            InitializeComponent();
        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            //adminListDataGridView.DataSource = dbAccess.GetAllAdmins();
        }

        private void addAdminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAdminUI addAdminUI = new AddAdminUI();
            addAdminUI.Show();
            this.Hide();
        }

        private void deleteAdminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteAdminUI deleteAdminUI = new DeleteAdminUI();
            deleteAdminUI.Show();
            this.Hide();
        }

        private void updateAdminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateAdminUI updateAdminUI = new UpdateAdminUI();
            updateAdminUI.Show();
            this.Hide();
        }
    }
}
