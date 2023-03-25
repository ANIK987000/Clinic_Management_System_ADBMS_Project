
namespace ADMS_Project
{
    partial class AdminManagement
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
            this.logOutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.updateAdminLinkLabel = new System.Windows.Forms.LinkLabel();
            this.deleteAdminLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addAdminLinkLabel = new System.Windows.Forms.LinkLabel();
            this.adminListGroupBox = new System.Windows.Forms.GroupBox();
            this.adminListDataGridView = new System.Windows.Forms.DataGridView();
            this.adminListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(557, 366);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 25;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCyan;
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(22, 366);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 40);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateAdminLinkLabel
            // 
            this.updateAdminLinkLabel.AutoSize = true;
            this.updateAdminLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAdminLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.updateAdminLinkLabel.Location = new System.Drawing.Point(440, 13);
            this.updateAdminLinkLabel.Name = "updateAdminLinkLabel";
            this.updateAdminLinkLabel.Size = new System.Drawing.Size(95, 20);
            this.updateAdminLinkLabel.TabIndex = 24;
            this.updateAdminLinkLabel.TabStop = true;
            this.updateAdminLinkLabel.Text = "Update Admin";
            this.updateAdminLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateAdminLinkLabel_LinkClicked);
            // 
            // deleteAdminLinkLabel
            // 
            this.deleteAdminLinkLabel.AutoSize = true;
            this.deleteAdminLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdminLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.deleteAdminLinkLabel.Location = new System.Drawing.Point(270, 13);
            this.deleteAdminLinkLabel.Name = "deleteAdminLinkLabel";
            this.deleteAdminLinkLabel.Size = new System.Drawing.Size(90, 20);
            this.deleteAdminLinkLabel.TabIndex = 23;
            this.deleteAdminLinkLabel.TabStop = true;
            this.deleteAdminLinkLabel.Text = "Delete Admin";
            this.deleteAdminLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteAdminLinkLabel_LinkClicked);
            // 
            // addAdminLinkLabel
            // 
            this.addAdminLinkLabel.AutoSize = true;
            this.addAdminLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.addAdminLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminLinkLabel.ForeColor = System.Drawing.Color.Purple;
            this.addAdminLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.addAdminLinkLabel.Location = new System.Drawing.Point(119, 13);
            this.addAdminLinkLabel.Name = "addAdminLinkLabel";
            this.addAdminLinkLabel.Size = new System.Drawing.Size(77, 20);
            this.addAdminLinkLabel.TabIndex = 22;
            this.addAdminLinkLabel.TabStop = true;
            this.addAdminLinkLabel.Text = "Add Admin";
            this.addAdminLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addAdminLinkLabel_LinkClicked);
            // 
            // adminListGroupBox
            // 
            this.adminListGroupBox.Controls.Add(this.adminListDataGridView);
            this.adminListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.adminListGroupBox.Location = new System.Drawing.Point(22, 68);
            this.adminListGroupBox.Name = "adminListGroupBox";
            this.adminListGroupBox.Size = new System.Drawing.Size(617, 278);
            this.adminListGroupBox.TabIndex = 21;
            this.adminListGroupBox.TabStop = false;
            this.adminListGroupBox.Text = "Admin List";
            // 
            // adminListDataGridView
            // 
            this.adminListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.adminListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminListDataGridView.Location = new System.Drawing.Point(20, 49);
            this.adminListDataGridView.Name = "adminListDataGridView";
            this.adminListDataGridView.RowHeadersWidth = 62;
            this.adminListDataGridView.Size = new System.Drawing.Size(575, 197);
            this.adminListDataGridView.TabIndex = 0;
            // 
            // AdminManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 417);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateAdminLinkLabel);
            this.Controls.Add(this.deleteAdminLinkLabel);
            this.Controls.Add(this.addAdminLinkLabel);
            this.Controls.Add(this.adminListGroupBox);
            this.Name = "AdminManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManagement";
            this.Load += new System.EventHandler(this.AdminManagement_Load);
            this.adminListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.LinkLabel updateAdminLinkLabel;
        private System.Windows.Forms.LinkLabel deleteAdminLinkLabel;
        private System.Windows.Forms.LinkLabel addAdminLinkLabel;
        private System.Windows.Forms.GroupBox adminListGroupBox;
        private System.Windows.Forms.DataGridView adminListDataGridView;
    }
}