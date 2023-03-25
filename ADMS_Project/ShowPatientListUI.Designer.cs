
namespace ADMS_Project
{
    partial class ShowPatientListUI
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
            this.PatientListGroupBox = new System.Windows.Forms.GroupBox();
            this.patientListDataGridView = new System.Windows.Forms.DataGridView();
            this.addAdminBackButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.PatientListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientListGroupBox
            // 
            this.PatientListGroupBox.Controls.Add(this.patientListDataGridView);
            this.PatientListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.PatientListGroupBox.Location = new System.Drawing.Point(47, 37);
            this.PatientListGroupBox.Name = "PatientListGroupBox";
            this.PatientListGroupBox.Size = new System.Drawing.Size(703, 324);
            this.PatientListGroupBox.TabIndex = 32;
            this.PatientListGroupBox.TabStop = false;
            this.PatientListGroupBox.Text = "Patient List";
            // 
            // patientListDataGridView
            // 
            this.patientListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.patientListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientListDataGridView.Location = new System.Drawing.Point(26, 40);
            this.patientListDataGridView.Name = "patientListDataGridView";
            this.patientListDataGridView.RowHeadersWidth = 62;
            this.patientListDataGridView.Size = new System.Drawing.Size(645, 246);
            this.patientListDataGridView.TabIndex = 0;
            // 
            // addAdminBackButton
            // 
            this.addAdminBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminBackButton.Location = new System.Drawing.Point(47, 387);
            this.addAdminBackButton.Name = "addAdminBackButton";
            this.addAdminBackButton.Size = new System.Drawing.Size(82, 34);
            this.addAdminBackButton.TabIndex = 33;
            this.addAdminBackButton.Text = "Back";
            this.addAdminBackButton.UseVisualStyleBackColor = false;
            this.addAdminBackButton.Click += new System.EventHandler(this.addAdminBackButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(668, 387);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 34;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // ShowPatientListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.addAdminBackButton);
            this.Controls.Add(this.PatientListGroupBox);
            this.Name = "ShowPatientListUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPatientListUI";
            this.Load += new System.EventHandler(this.ShowPatientListUI_Load);
            this.PatientListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PatientListGroupBox;
        private System.Windows.Forms.DataGridView patientListDataGridView;
        private System.Windows.Forms.Button addAdminBackButton;
        private System.Windows.Forms.Button logOutButton;
    }
}