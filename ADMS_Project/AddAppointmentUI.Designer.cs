
namespace ADMS_Project
{
    partial class AddAppointmentUI
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
            this.receptionistIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.appointmentDateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addAdminRegisterButton = new System.Windows.Forms.Button();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.doctorIdTextBox = new System.Windows.Forms.TextBox();
            this.addAdminPasswordLabel = new System.Windows.Forms.Label();
            this.addAdminUsernameLabel = new System.Windows.Forms.Label();
            this.DoctorListGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorListDataGridView = new System.Windows.Forms.DataGridView();
            this.PatientListGroupBox = new System.Windows.Forms.GroupBox();
            this.patientListDataGridView = new System.Windows.Forms.DataGridView();
            this.addAdminBackButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.adminRegistrationFormGroupBox.SuspendLayout();
            this.DoctorListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorListDataGridView)).BeginInit();
            this.PatientListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminRegistrationFormGroupBox
            // 
            this.adminRegistrationFormGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.adminRegistrationFormGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminRegistrationFormGroupBox.Controls.Add(this.receptionistIdTextBox);
            this.adminRegistrationFormGroupBox.Controls.Add(this.label2);
            this.adminRegistrationFormGroupBox.Controls.Add(this.appointmentDateTextBox);
            this.adminRegistrationFormGroupBox.Controls.Add(this.label1);
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminRegisterButton);
            this.adminRegistrationFormGroupBox.Controls.Add(this.patientIdTextBox);
            this.adminRegistrationFormGroupBox.Controls.Add(this.doctorIdTextBox);
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminPasswordLabel);
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminUsernameLabel);
            this.adminRegistrationFormGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRegistrationFormGroupBox.Location = new System.Drawing.Point(12, 12);
            this.adminRegistrationFormGroupBox.Name = "adminRegistrationFormGroupBox";
            this.adminRegistrationFormGroupBox.Size = new System.Drawing.Size(307, 212);
            this.adminRegistrationFormGroupBox.TabIndex = 18;
            this.adminRegistrationFormGroupBox.TabStop = false;
            this.adminRegistrationFormGroupBox.Text = "Add Appointment Form";
            // 
            // receptionistIdTextBox
            // 
            this.receptionistIdTextBox.Location = new System.Drawing.Point(137, 131);
            this.receptionistIdTextBox.Name = "receptionistIdTextBox";
            this.receptionistIdTextBox.Size = new System.Drawing.Size(151, 25);
            this.receptionistIdTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "ReceptionistId";
            // 
            // appointmentDateTextBox
            // 
            this.appointmentDateTextBox.Location = new System.Drawing.Point(137, 96);
            this.appointmentDateTextBox.Name = "appointmentDateTextBox";
            this.appointmentDateTextBox.Size = new System.Drawing.Size(151, 25);
            this.appointmentDateTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "AppointmentDate";
            // 
            // addAdminRegisterButton
            // 
            this.addAdminRegisterButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminRegisterButton.Location = new System.Drawing.Point(169, 172);
            this.addAdminRegisterButton.Name = "addAdminRegisterButton";
            this.addAdminRegisterButton.Size = new System.Drawing.Size(81, 30);
            this.addAdminRegisterButton.TabIndex = 15;
            this.addAdminRegisterButton.Text = "Add";
            this.addAdminRegisterButton.UseVisualStyleBackColor = false;
            this.addAdminRegisterButton.Click += new System.EventHandler(this.addAdminRegisterButton_Click);
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Location = new System.Drawing.Point(137, 64);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(151, 25);
            this.patientIdTextBox.TabIndex = 11;
            // 
            // doctorIdTextBox
            // 
            this.doctorIdTextBox.Location = new System.Drawing.Point(137, 30);
            this.doctorIdTextBox.Name = "doctorIdTextBox";
            this.doctorIdTextBox.Size = new System.Drawing.Size(151, 25);
            this.doctorIdTextBox.TabIndex = 10;
            // 
            // addAdminPasswordLabel
            // 
            this.addAdminPasswordLabel.AutoSize = true;
            this.addAdminPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.addAdminPasswordLabel.Location = new System.Drawing.Point(58, 30);
            this.addAdminPasswordLabel.Name = "addAdminPasswordLabel";
            this.addAdminPasswordLabel.Size = new System.Drawing.Size(62, 20);
            this.addAdminPasswordLabel.TabIndex = 4;
            this.addAdminPasswordLabel.Text = "DoctorId";
            // 
            // addAdminUsernameLabel
            // 
            this.addAdminUsernameLabel.AutoSize = true;
            this.addAdminUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.addAdminUsernameLabel.Location = new System.Drawing.Point(58, 64);
            this.addAdminUsernameLabel.Name = "addAdminUsernameLabel";
            this.addAdminUsernameLabel.Size = new System.Drawing.Size(63, 20);
            this.addAdminUsernameLabel.TabIndex = 3;
            this.addAdminUsernameLabel.Text = "PatientId";
            // 
            // DoctorListGroupBox
            // 
            this.DoctorListGroupBox.Controls.Add(this.doctorListDataGridView);
            this.DoctorListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.DoctorListGroupBox.Location = new System.Drawing.Point(12, 230);
            this.DoctorListGroupBox.Name = "DoctorListGroupBox";
            this.DoctorListGroupBox.Size = new System.Drawing.Size(879, 277);
            this.DoctorListGroupBox.TabIndex = 26;
            this.DoctorListGroupBox.TabStop = false;
            this.DoctorListGroupBox.Text = "Doctor List";
            // 
            // doctorListDataGridView
            // 
            this.doctorListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.doctorListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorListDataGridView.Location = new System.Drawing.Point(26, 43);
            this.doctorListDataGridView.Name = "doctorListDataGridView";
            this.doctorListDataGridView.RowHeadersWidth = 62;
            this.doctorListDataGridView.Size = new System.Drawing.Size(845, 211);
            this.doctorListDataGridView.TabIndex = 0;
            // 
            // PatientListGroupBox
            // 
            this.PatientListGroupBox.Controls.Add(this.patientListDataGridView);
            this.PatientListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.PatientListGroupBox.Location = new System.Drawing.Point(328, 12);
            this.PatientListGroupBox.Name = "PatientListGroupBox";
            this.PatientListGroupBox.Size = new System.Drawing.Size(563, 216);
            this.PatientListGroupBox.TabIndex = 33;
            this.PatientListGroupBox.TabStop = false;
            this.PatientListGroupBox.Text = "Patient List";
            // 
            // patientListDataGridView
            // 
            this.patientListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.patientListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientListDataGridView.Location = new System.Drawing.Point(23, 24);
            this.patientListDataGridView.Name = "patientListDataGridView";
            this.patientListDataGridView.RowHeadersWidth = 62;
            this.patientListDataGridView.Size = new System.Drawing.Size(510, 178);
            this.patientListDataGridView.TabIndex = 0;
            // 
            // addAdminBackButton
            // 
            this.addAdminBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminBackButton.Location = new System.Drawing.Point(12, 513);
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
            this.logOutButton.Location = new System.Drawing.Point(809, 519);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 35;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // AddAppointmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 565);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.addAdminBackButton);
            this.Controls.Add(this.PatientListGroupBox);
            this.Controls.Add(this.DoctorListGroupBox);
            this.Controls.Add(this.adminRegistrationFormGroupBox);
            this.Name = "AddAppointmentUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAppointmentUI";
            this.Load += new System.EventHandler(this.AddAppointmentUI_Load);
            this.adminRegistrationFormGroupBox.ResumeLayout(false);
            this.adminRegistrationFormGroupBox.PerformLayout();
            this.DoctorListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorListDataGridView)).EndInit();
            this.PatientListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox adminRegistrationFormGroupBox;
        private System.Windows.Forms.Button addAdminRegisterButton;
        private System.Windows.Forms.TextBox patientIdTextBox;
        private System.Windows.Forms.TextBox doctorIdTextBox;
        private System.Windows.Forms.Label addAdminPasswordLabel;
        private System.Windows.Forms.Label addAdminUsernameLabel;
        private System.Windows.Forms.TextBox appointmentDateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DoctorListGroupBox;
        private System.Windows.Forms.DataGridView doctorListDataGridView;
        private System.Windows.Forms.GroupBox PatientListGroupBox;
        private System.Windows.Forms.DataGridView patientListDataGridView;
        private System.Windows.Forms.TextBox receptionistIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAdminBackButton;
        private System.Windows.Forms.Button logOutButton;
    }
}