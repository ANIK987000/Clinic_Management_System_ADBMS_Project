
namespace ADMS_Project
{
    partial class TreatmentManagement
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
            this.updatePatientLinkLabel = new System.Windows.Forms.LinkLabel();
            this.deletePatientLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addPatientLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PatientListGroupBox = new System.Windows.Forms.GroupBox();
            this.treatmentListDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.PatientListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updatePatientLinkLabel
            // 
            this.updatePatientLinkLabel.AutoSize = true;
            this.updatePatientLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.updatePatientLinkLabel.Location = new System.Drawing.Point(447, 39);
            this.updatePatientLinkLabel.Name = "updatePatientLinkLabel";
            this.updatePatientLinkLabel.Size = new System.Drawing.Size(116, 20);
            this.updatePatientLinkLabel.TabIndex = 34;
            this.updatePatientLinkLabel.TabStop = true;
            this.updatePatientLinkLabel.Text = "Update Treatment";
            this.updatePatientLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updatePatientLinkLabel_LinkClicked);
            // 
            // deletePatientLinkLabel
            // 
            this.deletePatientLinkLabel.AutoSize = true;
            this.deletePatientLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.deletePatientLinkLabel.Location = new System.Drawing.Point(291, 39);
            this.deletePatientLinkLabel.Name = "deletePatientLinkLabel";
            this.deletePatientLinkLabel.Size = new System.Drawing.Size(111, 20);
            this.deletePatientLinkLabel.TabIndex = 33;
            this.deletePatientLinkLabel.TabStop = true;
            this.deletePatientLinkLabel.Text = "Delete Treatment";
            this.deletePatientLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deletePatientLinkLabel_LinkClicked);
            // 
            // addPatientLinkLabel
            // 
            this.addPatientLinkLabel.AutoSize = true;
            this.addPatientLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.addPatientLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientLinkLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addPatientLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.addPatientLinkLabel.Location = new System.Drawing.Point(143, 39);
            this.addPatientLinkLabel.Name = "addPatientLinkLabel";
            this.addPatientLinkLabel.Size = new System.Drawing.Size(98, 20);
            this.addPatientLinkLabel.TabIndex = 32;
            this.addPatientLinkLabel.TabStop = true;
            this.addPatientLinkLabel.Text = "Add Treatment";
            this.addPatientLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addPatientLinkLabel_LinkClicked);
            // 
            // PatientListGroupBox
            // 
            this.PatientListGroupBox.Controls.Add(this.treatmentListDataGridView);
            this.PatientListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.PatientListGroupBox.Location = new System.Drawing.Point(50, 94);
            this.PatientListGroupBox.Name = "PatientListGroupBox";
            this.PatientListGroupBox.Size = new System.Drawing.Size(640, 290);
            this.PatientListGroupBox.TabIndex = 31;
            this.PatientListGroupBox.TabStop = false;
            this.PatientListGroupBox.Text = "Treatment List";
            // 
            // treatmentListDataGridView
            // 
            this.treatmentListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.treatmentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentListDataGridView.Location = new System.Drawing.Point(26, 40);
            this.treatmentListDataGridView.Name = "treatmentListDataGridView";
            this.treatmentListDataGridView.RowHeadersWidth = 62;
            this.treatmentListDataGridView.Size = new System.Drawing.Size(578, 220);
            this.treatmentListDataGridView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCyan;
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(50, 404);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 37);
            this.backButton.TabIndex = 33;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(608, 404);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 38;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // TreatmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updatePatientLinkLabel);
            this.Controls.Add(this.deletePatientLinkLabel);
            this.Controls.Add(this.addPatientLinkLabel);
            this.Controls.Add(this.PatientListGroupBox);
            this.Name = "TreatmentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreatmentManagement";
            this.Load += new System.EventHandler(this.TreatmentManagement_Load);
            this.PatientListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treatmentListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel updatePatientLinkLabel;
        private System.Windows.Forms.LinkLabel deletePatientLinkLabel;
        private System.Windows.Forms.LinkLabel addPatientLinkLabel;
        private System.Windows.Forms.GroupBox PatientListGroupBox;
        private System.Windows.Forms.DataGridView treatmentListDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button logOutButton;
    }
}