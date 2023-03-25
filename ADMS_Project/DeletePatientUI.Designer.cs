
namespace ADMS_Project
{
    partial class DeletePatientUI
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
            this.deletePatientGroupBox = new System.Windows.Forms.GroupBox();
            this.deletePatientDeleteButton = new System.Windows.Forms.Button();
            this.deletePatientIdTextBox = new System.Windows.Forms.TextBox();
            this.deletePatientIdLabel = new System.Windows.Forms.Label();
            this.PatientListGroupBox = new System.Windows.Forms.GroupBox();
            this.patientListDataGridView = new System.Windows.Forms.DataGridView();
            this.addAdminBackButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.deletePatientGroupBox.SuspendLayout();
            this.PatientListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deletePatientGroupBox
            // 
            this.deletePatientGroupBox.Controls.Add(this.deletePatientDeleteButton);
            this.deletePatientGroupBox.Controls.Add(this.deletePatientIdTextBox);
            this.deletePatientGroupBox.Controls.Add(this.deletePatientIdLabel);
            this.deletePatientGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientGroupBox.Location = new System.Drawing.Point(236, 21);
            this.deletePatientGroupBox.Name = "deletePatientGroupBox";
            this.deletePatientGroupBox.Size = new System.Drawing.Size(347, 114);
            this.deletePatientGroupBox.TabIndex = 22;
            this.deletePatientGroupBox.TabStop = false;
            this.deletePatientGroupBox.Text = "Patient Delete Form";
            // 
            // deletePatientDeleteButton
            // 
            this.deletePatientDeleteButton.BackColor = System.Drawing.Color.LightCyan;
            this.deletePatientDeleteButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientDeleteButton.Location = new System.Drawing.Point(134, 61);
            this.deletePatientDeleteButton.Name = "deletePatientDeleteButton";
            this.deletePatientDeleteButton.Size = new System.Drawing.Size(88, 38);
            this.deletePatientDeleteButton.TabIndex = 21;
            this.deletePatientDeleteButton.Text = "Delete";
            this.deletePatientDeleteButton.UseVisualStyleBackColor = false;
            this.deletePatientDeleteButton.Click += new System.EventHandler(this.deletePatientDeleteButton_Click);
            // 
            // deletePatientIdTextBox
            // 
            this.deletePatientIdTextBox.Location = new System.Drawing.Point(99, 30);
            this.deletePatientIdTextBox.Name = "deletePatientIdTextBox";
            this.deletePatientIdTextBox.Size = new System.Drawing.Size(174, 25);
            this.deletePatientIdTextBox.TabIndex = 1;
            // 
            // deletePatientIdLabel
            // 
            this.deletePatientIdLabel.AutoSize = true;
            this.deletePatientIdLabel.Location = new System.Drawing.Point(19, 30);
            this.deletePatientIdLabel.Name = "deletePatientIdLabel";
            this.deletePatientIdLabel.Size = new System.Drawing.Size(63, 20);
            this.deletePatientIdLabel.TabIndex = 0;
            this.deletePatientIdLabel.Text = "PatientId";
            // 
            // PatientListGroupBox
            // 
            this.PatientListGroupBox.Controls.Add(this.patientListDataGridView);
            this.PatientListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.PatientListGroupBox.Location = new System.Drawing.Point(24, 141);
            this.PatientListGroupBox.Name = "PatientListGroupBox";
            this.PatientListGroupBox.Size = new System.Drawing.Size(764, 261);
            this.PatientListGroupBox.TabIndex = 32;
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
            this.patientListDataGridView.Size = new System.Drawing.Size(721, 217);
            this.patientListDataGridView.TabIndex = 0;
            // 
            // addAdminBackButton
            // 
            this.addAdminBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminBackButton.Location = new System.Drawing.Point(24, 408);
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
            this.logOutButton.Location = new System.Drawing.Point(706, 408);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 34;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // DeletePatientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 454);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.addAdminBackButton);
            this.Controls.Add(this.PatientListGroupBox);
            this.Controls.Add(this.deletePatientGroupBox);
            this.Name = "DeletePatientUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletePatientUI";
            this.Load += new System.EventHandler(this.DeletePatientUI_Load);
            this.deletePatientGroupBox.ResumeLayout(false);
            this.deletePatientGroupBox.PerformLayout();
            this.PatientListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox deletePatientGroupBox;
        private System.Windows.Forms.Button deletePatientDeleteButton;
        private System.Windows.Forms.TextBox deletePatientIdTextBox;
        private System.Windows.Forms.Label deletePatientIdLabel;
        private System.Windows.Forms.GroupBox PatientListGroupBox;
        private System.Windows.Forms.DataGridView patientListDataGridView;
        private System.Windows.Forms.Button addAdminBackButton;
        private System.Windows.Forms.Button logOutButton;
    }
}