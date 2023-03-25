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
    public partial class DeleteAppointmentUI : Form
    {
        public DeleteAppointmentUI()
        {
            InitializeComponent();
        }

        private void addAdminRegisterButton_Click(object sender, EventArgs e)
        {
            //string deleteAppointment = $"Delete from appointment where APPOINTMENTSERIAL='{appointmentSerialTextBox.Text}'";
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //DbAccess.UpdateDeleteInsert(deleteAppointment);
                DbAccess.deleteappointment(Convert.ToInt32(appointmentSerialTextBox.Text));
                MessageBox.Show("User deleted successfully !!!");
            }
        }

        private void DeleteAppointmentUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            appointmentListDataGridView.DataSource = dbAccess.GetDoctorPaitentAppointment();
        }

        private void addAdminBackButton_Click(object sender, EventArgs e)
        {
            AppointmentManagement appointmentManagement = new AppointmentManagement();
            appointmentManagement.Show();
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
