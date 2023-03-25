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
    public partial class DeleteReceptionistUI : Form
    {
        public DeleteReceptionistUI()
        {
            InitializeComponent();
        }

        private void deleteReceptionistDeleteButton_Click(object sender, EventArgs e)
        {
            //string deleteReceptionist = $"Delete from receptionist where RECEPTIONISTID='{deleteReceptionistIdTextBox.Text}'";
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //DbAccess.UpdateDeleteInsert(deleteReceptionist);
                DbAccess.deletereceptionist(Convert.ToInt32(deleteReceptionistIdTextBox.Text));
                MessageBox.Show("User deleted successfully !!!");
            }
        }

        private void DeleteReceptionistUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            ReceptionistListDataGridView.DataSource = dbAccess.GetAllReceptionists1();
        }

        private void deleteReceptionistBackButton_Click(object sender, EventArgs e)
        {
            ReceptionistManagement receptionistManagement = new ReceptionistManagement();
            receptionistManagement.Show();
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
