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
    public partial class ReceptionistManagement : Form
    {
        public ReceptionistManagement()
        {
            InitializeComponent();
        }

        private void addReceptionsitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddReceptionistUI addReceptionistUI = new AddReceptionistUI();
            addReceptionistUI.Show();
            this.Hide();
        }

        private void deleteReceptionistLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteReceptionistUI deleteReceptionistUI = new DeleteReceptionistUI();
            deleteReceptionistUI.Show();
            this.Hide();
        }

        private void ReceptionistManagement_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            ReceptionistListDataGridView.DataSource = dbAccess.GetAllReceptionists1();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminUI adminUI = new AdminUI();
            adminUI.Show();
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
