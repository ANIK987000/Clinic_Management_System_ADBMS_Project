
namespace ADMS_Project
{
    partial class DeleteTreatmentUI
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
            this.addAdminNameLabel = new System.Windows.Forms.Label();
            this.prescriptionNoTextBox = new System.Windows.Forms.TextBox();
            this.updatePatientListGroupBox = new System.Windows.Forms.GroupBox();
            this.treatmentListDataGridView = new System.Windows.Forms.DataGridView();
            this.logOutButton = new System.Windows.Forms.Button();
            this.adminRegistrationFormGroupBox.SuspendLayout();
            this.updatePatientListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addAdminBackButton
            // 
            this.addAdminBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminBackButton.Location = new System.Drawing.Point(12, 404);
            this.addAdminBackButton.Name = "addAdminBackButton";
            this.addAdminBackButton.Size = new System.Drawing.Size(82, 34);
            this.addAdminBackButton.TabIndex = 20;
            this.addAdminBackButton.Text = "Back";
            this.addAdminBackButton.UseVisualStyleBackColor = false;
            this.addAdminBackButton.Click += new System.EventHandler(this.addAdminBackButton_Click);
            // 
            // adminRegistrationFormGroupBox
            // 
            this.adminRegistrationFormGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.adminRegistrationFormGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminRegisterButton);
            this.adminRegistrationFormGroupBox.Controls.Add(this.addAdminNameLabel);
            this.adminRegistrationFormGroupBox.Controls.Add(this.prescriptionNoTextBox);
            this.adminRegistrationFormGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRegistrationFormGroupBox.Location = new System.Drawing.Point(294, 12);
            this.adminRegistrationFormGroupBox.Name = "adminRegistrationFormGroupBox";
            this.adminRegistrationFormGroupBox.Size = new System.Drawing.Size(290, 109);
            this.adminRegistrationFormGroupBox.TabIndex = 19;
            this.adminRegistrationFormGroupBox.TabStop = false;
            this.adminRegistrationFormGroupBox.Text = "Delete Treatment Form";
            // 
            // addAdminRegisterButton
            // 
            this.addAdminRegisterButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminRegisterButton.Location = new System.Drawing.Point(158, 67);
            this.addAdminRegisterButton.Name = "addAdminRegisterButton";
            this.addAdminRegisterButton.Size = new System.Drawing.Size(81, 29);
            this.addAdminRegisterButton.TabIndex = 15;
            this.addAdminRegisterButton.Text = "Delete";
            this.addAdminRegisterButton.UseVisualStyleBackColor = false;
            this.addAdminRegisterButton.Click += new System.EventHandler(this.addAdminRegisterButton_Click);
            // 
            // addAdminNameLabel
            // 
            this.addAdminNameLabel.AutoSize = true;
            this.addAdminNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.addAdminNameLabel.Location = new System.Drawing.Point(11, 36);
            this.addAdminNameLabel.Name = "addAdminNameLabel";
            this.addAdminNameLabel.Size = new System.Drawing.Size(101, 20);
            this.addAdminNameLabel.TabIndex = 2;
            this.addAdminNameLabel.Text = "PrescriptionNo";
            // 
            // prescriptionNoTextBox
            // 
            this.prescriptionNoTextBox.Location = new System.Drawing.Point(140, 36);
            this.prescriptionNoTextBox.Name = "prescriptionNoTextBox";
            this.prescriptionNoTextBox.Size = new System.Drawing.Size(114, 25);
            this.prescriptionNoTextBox.TabIndex = 1;
            // 
            // updatePatientListGroupBox
            // 
            this.updatePatientListGroupBox.Controls.Add(this.treatmentListDataGridView);
            this.updatePatientListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientListGroupBox.Location = new System.Drawing.Point(12, 127);
            this.updatePatientListGroupBox.Name = "updatePatientListGroupBox";
            this.updatePatientListGroupBox.Size = new System.Drawing.Size(833, 271);
            this.updatePatientListGroupBox.TabIndex = 21;
            this.updatePatientListGroupBox.TabStop = false;
            this.updatePatientListGroupBox.Text = "Treatment List";
            // 
            // treatmentListDataGridView
            // 
            this.treatmentListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.treatmentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentListDataGridView.Location = new System.Drawing.Point(6, 35);
            this.treatmentListDataGridView.Name = "treatmentListDataGridView";
            this.treatmentListDataGridView.RowHeadersWidth = 62;
            this.treatmentListDataGridView.Size = new System.Drawing.Size(807, 215);
            this.treatmentListDataGridView.TabIndex = 0;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(763, 404);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 26;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // DeleteTreatmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.updatePatientListGroupBox);
            this.Controls.Add(this.addAdminBackButton);
            this.Controls.Add(this.adminRegistrationFormGroupBox);
            this.Name = "DeleteTreatmentUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteTreatmentUI";
            this.Load += new System.EventHandler(this.DeleteTreatmentUI_Load);
            this.adminRegistrationFormGroupBox.ResumeLayout(false);
            this.adminRegistrationFormGroupBox.PerformLayout();
            this.updatePatientListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treatmentListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addAdminBackButton;
        private System.Windows.Forms.GroupBox adminRegistrationFormGroupBox;
        private System.Windows.Forms.Button addAdminRegisterButton;
        private System.Windows.Forms.Label addAdminNameLabel;
        private System.Windows.Forms.TextBox prescriptionNoTextBox;
        private System.Windows.Forms.GroupBox updatePatientListGroupBox;
        private System.Windows.Forms.DataGridView treatmentListDataGridView;
        private System.Windows.Forms.Button logOutButton;
    }
}