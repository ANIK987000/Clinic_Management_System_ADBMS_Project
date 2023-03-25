
namespace ADMS_Project
{
    partial class DeleteAdminUI
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
            this.adminDeleteFormGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteAdminIdLabel = new System.Windows.Forms.Label();
            this.deleteAdminDeleteButton = new System.Windows.Forms.Button();
            this.deleteAdminIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteAdminBackButton = new System.Windows.Forms.Button();
            this.adminListGroupBox = new System.Windows.Forms.GroupBox();
            this.adminListDataGridView = new System.Windows.Forms.DataGridView();
            this.logOutButton = new System.Windows.Forms.Button();
            this.adminDeleteFormGroupBox.SuspendLayout();
            this.adminListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminDeleteFormGroupBox
            // 
            this.adminDeleteFormGroupBox.Controls.Add(this.DeleteAdminIdLabel);
            this.adminDeleteFormGroupBox.Controls.Add(this.deleteAdminDeleteButton);
            this.adminDeleteFormGroupBox.Controls.Add(this.deleteAdminIdTextBox);
            this.adminDeleteFormGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDeleteFormGroupBox.Location = new System.Drawing.Point(233, 12);
            this.adminDeleteFormGroupBox.Name = "adminDeleteFormGroupBox";
            this.adminDeleteFormGroupBox.Size = new System.Drawing.Size(342, 144);
            this.adminDeleteFormGroupBox.TabIndex = 2;
            this.adminDeleteFormGroupBox.TabStop = false;
            this.adminDeleteFormGroupBox.Text = "Admin Delete Form";
            // 
            // DeleteAdminIdLabel
            // 
            this.DeleteAdminIdLabel.AutoSize = true;
            this.DeleteAdminIdLabel.Location = new System.Drawing.Point(19, 41);
            this.DeleteAdminIdLabel.Name = "DeleteAdminIdLabel";
            this.DeleteAdminIdLabel.Size = new System.Drawing.Size(65, 20);
            this.DeleteAdminIdLabel.TabIndex = 17;
            this.DeleteAdminIdLabel.Text = "Admin ID";
            // 
            // deleteAdminDeleteButton
            // 
            this.deleteAdminDeleteButton.BackColor = System.Drawing.Color.LightCyan;
            this.deleteAdminDeleteButton.Location = new System.Drawing.Point(146, 82);
            this.deleteAdminDeleteButton.Name = "deleteAdminDeleteButton";
            this.deleteAdminDeleteButton.Size = new System.Drawing.Size(91, 41);
            this.deleteAdminDeleteButton.TabIndex = 15;
            this.deleteAdminDeleteButton.Text = "Delete";
            this.deleteAdminDeleteButton.UseVisualStyleBackColor = false;
            this.deleteAdminDeleteButton.Click += new System.EventHandler(this.deleteAdminDeleteButton_Click);
            // 
            // deleteAdminIdTextBox
            // 
            this.deleteAdminIdTextBox.Location = new System.Drawing.Point(103, 41);
            this.deleteAdminIdTextBox.Name = "deleteAdminIdTextBox";
            this.deleteAdminIdTextBox.Size = new System.Drawing.Size(180, 25);
            this.deleteAdminIdTextBox.TabIndex = 11;
            // 
            // deleteAdminBackButton
            // 
            this.deleteAdminBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.deleteAdminBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdminBackButton.Location = new System.Drawing.Point(12, 417);
            this.deleteAdminBackButton.Name = "deleteAdminBackButton";
            this.deleteAdminBackButton.Size = new System.Drawing.Size(89, 30);
            this.deleteAdminBackButton.TabIndex = 17;
            this.deleteAdminBackButton.Text = "Back";
            this.deleteAdminBackButton.UseVisualStyleBackColor = false;
            this.deleteAdminBackButton.Click += new System.EventHandler(this.deleteAdminBackButton_Click);
            // 
            // adminListGroupBox
            // 
            this.adminListGroupBox.Controls.Add(this.adminListDataGridView);
            this.adminListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.adminListGroupBox.Location = new System.Drawing.Point(12, 162);
            this.adminListGroupBox.Name = "adminListGroupBox";
            this.adminListGroupBox.Size = new System.Drawing.Size(794, 249);
            this.adminListGroupBox.TabIndex = 22;
            this.adminListGroupBox.TabStop = false;
            this.adminListGroupBox.Text = "Admin List";
            // 
            // adminListDataGridView
            // 
            this.adminListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.adminListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminListDataGridView.Location = new System.Drawing.Point(20, 24);
            this.adminListDataGridView.Name = "adminListDataGridView";
            this.adminListDataGridView.RowHeadersWidth = 62;
            this.adminListDataGridView.Size = new System.Drawing.Size(744, 207);
            this.adminListDataGridView.TabIndex = 0;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(724, 418);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 26;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // DeleteAdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 464);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.adminListGroupBox);
            this.Controls.Add(this.deleteAdminBackButton);
            this.Controls.Add(this.adminDeleteFormGroupBox);
            this.Name = "DeleteAdminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteAdminUI";
            this.Load += new System.EventHandler(this.DeleteAdminUI_Load);
            this.adminDeleteFormGroupBox.ResumeLayout(false);
            this.adminDeleteFormGroupBox.PerformLayout();
            this.adminListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox adminDeleteFormGroupBox;
        private System.Windows.Forms.Label DeleteAdminIdLabel;
        private System.Windows.Forms.Button deleteAdminDeleteButton;
        private System.Windows.Forms.TextBox deleteAdminIdTextBox;
        private System.Windows.Forms.Button deleteAdminBackButton;
        private System.Windows.Forms.GroupBox adminListGroupBox;
        private System.Windows.Forms.DataGridView adminListDataGridView;
        private System.Windows.Forms.Button logOutButton;
    }
}