﻿using System;
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
            adminListDataGridView.DataSource = dbAccess.GetAllAdmins();
        }
    }
}
