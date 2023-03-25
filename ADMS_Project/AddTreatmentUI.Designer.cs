
namespace ADMS_Project
{
    partial class AddTreatmentUI
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
            this.addAdminBackButton = new System.Windows.Forms.Button();
            this.adminRegistrationFormGroupBox = new System.Windows.Forms.GroupBox();
            this.addAdminRegisterButton = new System.Windows.Forms.Button();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.doctorIdTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addAdminConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.addAdminPasswordLabel = new System.Windows.Forms.Label();
            this.addAdminUsernameLabel = new System.Windows.Forms.Label();
            this.updatePatientListGroupBox = new System.Windows.Forms.GroupBox();
            this.patientListDataGridView = new System.Windows.Forms.DataGridView();
            this.logOutButton = new System.Windows.Forms.Button();
            this.adminRegistrationFormGroupBox.SuspendLayout();
            this.updatePatientListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addAdminBackButton
            // 
            this.addAdminBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminBackButton.Location = new System.Drawing.Point(24, 404);
            this.addAdminBackButton.Name = "addAdminBackButton";
            this.addAdminBackButton.Size = new System.Drawing.Size(82, 34);
            this.addAdminBackButton.TabIndex = 18;
            this.addAdminBackButton.Text = "Back";
            this.addAdminBackButton.UseVisualStyleBackColor = false;
            this.addAdminBackButton.Click += new System.EventHandler(this.addAdminBackButton_Click);
            // 
            // adminRegistrationFormGroupBox
            // 
            this.adminRegistrationFormGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.adminRegistrationFormGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminRegisterButton);
            this.adminRegistrationFormGroupBox.Controls.Add(this.patientIdTextBox);
            this.adminRegistrationFormGroupBox.Controls.Add(this.doctorIdTextBox);
            this.adminRegistrationFormGroupBox.Controls.Add(this.prescriptionTextBox);
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminConfirmPasswordLabel);
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminPasswordLabel);
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminUsernameLabel);
            this.adminRegistrationFormGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRegistrationFormGroupBox.Location = new System.Drawing.Point(24, 23);
            this.adminRegistrationFormGroupBox.Name = "adminRegistrationFormGroupBox";
            this.adminRegistrationFormGroupBox.Size = new System.Drawing.Size(310, 345);
            this.adminRegistrationFormGroupBox.TabIndex = 17;
            this.adminRegistrationFormGroupBox.TabStop = false;
            this.adminRegistrationFormGroupBox.Text = "Add Treatment Form";
            // 
            // addAdminRegisterButton
            // 
            this.addAdminRegisterButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminRegisterButton.Location = new System.Drawing.Point(154, 253);
            this.addAdminRegisterButton.Name = "addAdminRegisterButton";
            this.addAdminRegisterButton.Size = new System.Drawing.Size(81, 37);
            this.addAdminRegisterButton.TabIndex = 15;
            this.addAdminRegisterButton.Text = "Register";
            this.addAdminRegisterButton.UseVisualStyleBackColor = false;
            this.addAdminRegisterButton.Click += new System.EventHandler(this.addAdminRegisterButton_Click);
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Location = new System.Drawing.Point(117, 62);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(151, 25);
            this.patientIdTextBox.TabIndex = 11;
            // 
            // doctorIdTextBox
            // 
            this.doctorIdTextBox.Location = new System.Drawing.Point(117, 117);
            this.doctorIdTextBox.Name = "doctorIdTextBox";
            this.doctorIdTextBox.Size = new System.Drawing.Size(151, 25);
            this.doctorIdTextBox.TabIndex = 10;
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.Location = new System.Drawing.Point(117, 164);
            this.prescriptionTextBox.Multiline = true;
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.Size = new System.Drawing.Size(151, 68);
            this.prescriptionTextBox.TabIndex = 9;
            // 
            // addAdminConfirmPasswordLabel
            // 
            this.addAdminConfirmPasswordLabel.AutoSize = true;
            this.addAdminConfirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.addAdminConfirmPasswordLabel.Location = new System.Drawing.Point(8, 184);
            this.addAdminConfirmPasswordLabel.Name = "addAdminConfirmPasswordLabel";
            this.addAdminConfirmPasswordLabel.Size = new System.Drawing.Size(84, 20);
            this.addAdminConfirmPasswordLabel.TabIndex = 5;
            this.addAdminConfirmPasswordLabel.Text = "Prescription";
            // 
            // addAdminPasswordLabel
            // 
            this.addAdminPasswordLabel.AutoSize = true;
            this.addAdminPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.addAdminPasswordLabel.Location = new System.Drawing.Point(30, 117);
            this.addAdminPasswordLabel.Name = "addAdminPasswordLabel";
            this.addAdminPasswordLabel.Size = new System.Drawing.Size(62, 20);
            this.addAdminPasswordLabel.TabIndex = 4;
            this.addAdminPasswordLabel.Text = "DoctorId";
            // 
            // addAdminUsernameLabel
            // 
            this.addAdminUsernameLabel.AutoSize = true;
            this.addAdminUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.addAdminUsernameLabel.Location = new System.Drawing.Point(29, 62);
            this.addAdminUsernameLabel.Name = "addAdminUsernameLabel";
            this.addAdminUsernameLabel.Size = new System.Drawing.Size(63, 20);
            this.addAdminUsernameLabel.TabIndex = 3;
            this.addAdminUsernameLabel.Text = "PatientId";
            // 
            // updatePatientListGroupBox
            // 
            this.updatePatientListGroupBox.Controls.Add(this.patientListDataGridView);
            this.updatePatientListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientListGroupBox.Location = new System.Drawing.Point(352, 23);
            this.updatePatientListGroupBox.Name = "updatePatientListGroupBox";
            this.updatePatientListGroupBox.Size = new System.Drawing.Size(612, 345);
            this.updatePatientListGroupBox.TabIndex = 19;
            this.updatePatientListGroupBox.TabStop = false;
            this.updatePatientListGroupBox.Text = "Patient List";
            // 
            // patientListDataGridView
            // 
            this.patientListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.patientListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientListDataGridView.Location = new System.Drawing.Point(13, 36);
            this.patientListDataGridView.Name = "patientListDataGridView";
            this.patientListDataGridView.RowHeadersWidth = 62;
            this.patientListDataGridView.Size = new System.Drawing.Size(582, 287);
            this.patientListDataGridView.TabIndex = 0;
            this.patientListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientListDataGridView_CellContentClick);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(882, 404);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 26;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // AddTreatmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.updatePatientListGroupBox);
            this.Controls.Add(this.addAdminBackButton);
            this.Controls.Add(this.adminRegistrationFormGroupBox);
            this.Name = "AddTreatmentUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTreatmentUI";
            this.Load += new System.EventHandler(this.AddTreatmentUI_Load);
            this.adminRegistrationFormGroupBox.ResumeLayout(false);
            this.adminRegistrationFormGroupBox.PerformLayout();
            this.updatePatientListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addAdminBackButton;
        private System.Windows.Forms.GroupBox adminRegistrationFormGroupBox;
        private System.Windows.Forms.Button addAdminRegisterButton;
        private System.Windows.Forms.TextBox patientIdTextBox;
        private System.Windows.Forms.TextBox doctorIdTextBox;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.Label addAdminConfirmPasswordLabel;
        private System.Windows.Forms.Label addAdminPasswordLabel;
        private System.Windows.Forms.Label addAdminUsernameLabel;
        private System.Windows.Forms.GroupBox updatePatientListGroupBox;
        private System.Windows.Forms.DataGridView patientListDataGridView;
        private System.Windows.Forms.Button logOutButton;
    }
}