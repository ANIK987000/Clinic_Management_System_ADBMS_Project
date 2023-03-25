
namespace ADMS_Project
{
    partial class PatientManagement
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
            this.deletePatientLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addPatientLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PatientListGroupBox = new System.Windows.Forms.GroupBox();
            this.patientListDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PatientListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deletePatientLinkLabel
            // 
            this.deletePatientLinkLabel.AutoSize = true;
            this.deletePatientLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.deletePatientLinkLabel.Location = new System.Drawing.Point(392, 33);
            this.deletePatientLinkLabel.Name = "deletePatientLinkLabel";
            this.deletePatientLinkLabel.Size = new System.Drawing.Size(92, 20);
            this.deletePatientLinkLabel.TabIndex = 33;
            this.deletePatientLinkLabel.TabStop = true;
            this.deletePatientLinkLabel.Text = "Delete Patient";
            this.deletePatientLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deletePatientLinkLabel_LinkClicked);
            // 
            // addPatientLinkLabel
            // 
            this.addPatientLinkLabel.AutoSize = true;
            this.addPatientLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.addPatientLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientLinkLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addPatientLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.addPatientLinkLabel.Location = new System.Drawing.Point(240, 33);
            this.addPatientLinkLabel.Name = "addPatientLinkLabel";
            this.addPatientLinkLabel.Size = new System.Drawing.Size(79, 20);
            this.addPatientLinkLabel.TabIndex = 32;
            this.addPatientLinkLabel.TabStop = true;
            this.addPatientLinkLabel.Text = "Add Patient";
            this.addPatientLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addPatientLinkLabel_LinkClicked);
            // 
            // PatientListGroupBox
            // 
            this.PatientListGroupBox.Controls.Add(this.patientListDataGridView);
            this.PatientListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.PatientListGroupBox.Location = new System.Drawing.Point(64, 68);
            this.PatientListGroupBox.Name = "PatientListGroupBox";
            this.PatientListGroupBox.Size = new System.Drawing.Size(618, 279);
            this.PatientListGroupBox.TabIndex = 31;
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
            this.patientListDataGridView.Size = new System.Drawing.Size(562, 209);
            this.patientListDataGridView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCyan;
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(64, 416);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 37);
            this.backButton.TabIndex = 34;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(600, 416);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 38;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(228, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 39;
            this.button1.Text = "Enable Trigger";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(396, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 40;
            this.button2.Text = "Disable Trigger";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PatientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 464);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deletePatientLinkLabel);
            this.Controls.Add(this.addPatientLinkLabel);
            this.Controls.Add(this.PatientListGroupBox);
            this.Name = "PatientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientManagement";
            this.Load += new System.EventHandler(this.PatientManagement_Load);
            this.PatientListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel deletePatientLinkLabel;
        private System.Windows.Forms.LinkLabel addPatientLinkLabel;
        private System.Windows.Forms.GroupBox PatientListGroupBox;
        private System.Windows.Forms.DataGridView patientListDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}