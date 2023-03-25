
namespace ADMS_Project
{
    partial class AdminUI
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
            this.ReceptionistManageButton = new System.Windows.Forms.Button();
            this.adminUIDoctorManagementButton = new System.Windows.Forms.Button();
            this.adminUIAdminManagementButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReceptionistManageButton
            // 
            this.ReceptionistManageButton.BackColor = System.Drawing.Color.LightCyan;
            this.ReceptionistManageButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistManageButton.Location = new System.Drawing.Point(220, 251);
            this.ReceptionistManageButton.Name = "ReceptionistManageButton";
            this.ReceptionistManageButton.Size = new System.Drawing.Size(102, 51);
            this.ReceptionistManageButton.TabIndex = 40;
            this.ReceptionistManageButton.Text = "Receptionist Management";
            this.ReceptionistManageButton.UseVisualStyleBackColor = false;
            // 
            // adminUIDoctorManagementButton
            // 
            this.adminUIDoctorManagementButton.BackColor = System.Drawing.Color.LightCyan;
            this.adminUIDoctorManagementButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUIDoctorManagementButton.Location = new System.Drawing.Point(220, 193);
            this.adminUIDoctorManagementButton.Name = "adminUIDoctorManagementButton";
            this.adminUIDoctorManagementButton.Size = new System.Drawing.Size(102, 48);
            this.adminUIDoctorManagementButton.TabIndex = 39;
            this.adminUIDoctorManagementButton.Text = "Doctor Management";
            this.adminUIDoctorManagementButton.UseVisualStyleBackColor = false;
            // 
            // adminUIAdminManagementButton
            // 
            this.adminUIAdminManagementButton.BackColor = System.Drawing.Color.LightCyan;
            this.adminUIAdminManagementButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUIAdminManagementButton.Location = new System.Drawing.Point(220, 133);
            this.adminUIAdminManagementButton.Name = "adminUIAdminManagementButton";
            this.adminUIAdminManagementButton.Size = new System.Drawing.Size(102, 50);
            this.adminUIAdminManagementButton.TabIndex = 38;
            this.adminUIAdminManagementButton.Text = "Admin Management";
            this.adminUIAdminManagementButton.UseVisualStyleBackColor = false;
            this.adminUIAdminManagementButton.Click += new System.EventHandler(this.adminUIAdminManagementButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 63);
            this.label3.TabIndex = 37;
            this.label3.Text = "Admin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 376);
            this.Controls.Add(this.ReceptionistManageButton);
            this.Controls.Add(this.adminUIDoctorManagementButton);
            this.Controls.Add(this.adminUIAdminManagementButton);
            this.Controls.Add(this.label3);
            this.Name = "AdminUI";
            this.Text = "AdminUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReceptionistManageButton;
        private System.Windows.Forms.Button adminUIDoctorManagementButton;
        private System.Windows.Forms.Button adminUIAdminManagementButton;
        private System.Windows.Forms.Label label3;
    }
}