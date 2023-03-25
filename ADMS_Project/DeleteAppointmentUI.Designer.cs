
namespace ADMS_Project
{
    partial class DeleteAppointmentUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminRegistrationFormGroupBox = new System.Windows.Forms.GroupBox();
            this.addAdminRegisterButton = new System.Windows.Forms.Button();
            this.appointmentSerialTextBox = new System.Windows.Forms.TextBox();
            this.addAdminPasswordLabel = new System.Windows.Forms.Label();
            this.PatientListGroupBox = new System.Windows.Forms.GroupBox();
            this.appointmentListDataGridView = new System.Windows.Forms.DataGridView();
            this.addAdminBackButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.adminRegistrationFormGroupBox.SuspendLayout();
            this.PatientListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminRegistrationFormGroupBox
            // 
            this.adminRegistrationFormGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.adminRegistrationFormGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminRegisterButton);
            this.adminRegistrationFormGroupBox.Controls.Add(this.appointmentSerialTextBox);
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminPasswordLabel);
            this.adminRegistrationFormGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRegistrationFormGroupBox.Location = new System.Drawing.Point(282, 12);
            this.adminRegistrationFormGroupBox.Name = "adminRegistrationFormGroupBox";
            this.adminRegistrationFormGroupBox.Size = new System.Drawing.Size(323, 142);
            this.adminRegistrationFormGroupBox.TabIndex = 19;
            this.adminRegistrationFormGroupBox.TabStop = false;
            this.adminRegistrationFormGroupBox.Text = "Add Appointment Form";
            // 
            // addAdminRegisterButton
            // 
            this.addAdminRegisterButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminRegisterButton.Location = new System.Drawing.Point(160, 89);
            this.addAdminRegisterButton.Name = "addAdminRegisterButton";
            this.addAdminRegisterButton.Size = new System.Drawing.Size(81, 37);
            this.addAdminRegisterButton.TabIndex = 15;
            this.addAdminRegisterButton.Text = "Delete";
            this.addAdminRegisterButton.UseVisualStyleBackColor = false;
            this.addAdminRegisterButton.Click += new System.EventHandler(this.addAdminRegisterButton_Click);
            // 
            // appointmentSerialTextBox
            // 
            this.appointmentSerialTextBox.Location = new System.Drawing.Point(131, 45);
            this.appointmentSerialTextBox.Name = "appointmentSerialTextBox";
            this.appointmentSerialTextBox.Size = new System.Drawing.Size(151, 25);
            this.appointmentSerialTextBox.TabIndex = 10;
            // 
            // addAdminPasswordLabel
            // 
            this.addAdminPasswordLabel.AutoSize = true;
            this.addAdminPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.addAdminPasswordLabel.Location = new System.Drawing.Point(6, 45);
            this.addAdminPasswordLabel.Name = "addAdminPasswordLabel";
            this.addAdminPasswordLabel.Size = new System.Drawing.Size(119, 20);
            this.addAdminPasswordLabel.TabIndex = 4;
            this.addAdminPasswordLabel.Text = "AppointmenSerial";
            // 
            // PatientListGroupBox
            // 
            this.PatientListGroupBox.Controls.Add(this.appointmentListDataGridView);
            this.PatientListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.PatientListGroupBox.Location = new System.Drawing.Point(12, 160);
            this.PatientListGroupBox.Name = "PatientListGroupBox";
            this.PatientListGroupBox.Size = new System.Drawing.Size(952, 261);
            this.PatientListGroupBox.TabIndex = 33;
            this.PatientListGroupBox.TabStop = false;
            this.PatientListGroupBox.Text = "Appointment List";
            // 
            // appointmentListDataGridView
            // 
            this.appointmentListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.appointmentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentListDataGridView.Location = new System.Drawing.Point(23, 24);
            this.appointmentListDataGridView.Name = "appointmentListDataGridView";
            this.appointmentListDataGridView.RowHeadersWidth = 62;
            this.appointmentListDataGridView.Size = new System.Drawing.Size(912, 217);
            this.appointmentListDataGridView.TabIndex = 0;
            // 
            // addAdminBackButton
            // 
            this.addAdminBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminBackButton.Location = new System.Drawing.Point(12, 437);
            this.addAdminBackButton.Name = "addAdminBackButton";
            this.addAdminBackButton.Size = new System.Drawing.Size(82, 34);
            this.addAdminBackButton.TabIndex = 34;
            this.addAdminBackButton.Text = "Back";
            this.addAdminBackButton.UseVisualStyleBackColor = false;
            this.addAdminBackButton.Click += new System.EventHandler(this.addAdminBackButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(882, 436);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 35);
            this.logOutButton.TabIndex = 35;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // DeleteAppointmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 483);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.addAdminBackButton);
            this.Controls.Add(this.PatientListGroupBox);
            this.Controls.Add(this.adminRegistrationFormGroupBox);
            this.Name = "DeleteAppointmentUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteAppointmentUI";
            this.Load += new System.EventHandler(this.DeleteAppointmentUI_Load);
            this.adminRegistrationFormGroupBox.ResumeLayout(false);
            this.adminRegistrationFormGroupBox.PerformLayout();
            this.PatientListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox adminRegistrationFormGroupBox;
        private System.Windows.Forms.Button addAdminRegisterButton;
        private System.Windows.Forms.TextBox appointmentSerialTextBox;
        private System.Windows.Forms.Label addAdminPasswordLabel;
        private System.Windows.Forms.GroupBox PatientListGroupBox;
        private System.Windows.Forms.DataGridView appointmentListDataGridView;
        private System.Windows.Forms.Button addAdminBackButton;
        private System.Windows.Forms.Button logOutButton;
    }
}