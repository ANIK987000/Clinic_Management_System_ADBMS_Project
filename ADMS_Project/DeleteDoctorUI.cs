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
    public partial class DeleteDoctorUI : Form
    {
        public DeleteDoctorUI()
        {
            InitializeComponent();
        }

        private void DoctorDeleteButton_Click(object sender, EventArgs e)
        {
            //string deleteDoctor = $"Delete from doctor where DOCTORID='{deleteDoctorIdTextBox.Text}'";
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //DbAccess.UpdateDeleteInsert(deleteDoctor);
                DbAccess.deletedoctor(Convert.ToInt32(deleteDoctorIdTextBox.Text));
                MessageBox.Show("User deleted successfully !!!");
            }
        }

        private void DeleteDoctorUI_Load(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            doctorListDataGridView.DataSource = dbAccess.GetAllDoctors1();
        }

        private void deleteDoctorBackButton_Click(object sender, EventArgs e)
        {
            DoctorManagement doctorManagement = new DoctorManagement();
            doctorManagement.Show();
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
