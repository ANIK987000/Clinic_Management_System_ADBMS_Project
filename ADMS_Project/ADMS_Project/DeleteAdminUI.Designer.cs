
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
            this.DeleteAdminNameLabel = new System.Windows.Forms.Label();
            this.deleteAdminNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteAdminBackButton = new System.Windows.Forms.Button();
            this.adminDeleteFormGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminDeleteFormGroupBox
            // 
            this.adminDeleteFormGroupBox.Controls.Add(this.DeleteAdminIdLabel);
            this.adminDeleteFormGroupBox.Controls.Add(this.deleteAdminDeleteButton);
            this.adminDeleteFormGroupBox.Controls.Add(this.deleteAdminIdTextBox);
            this.adminDeleteFormGroupBox.Controls.Add(this.DeleteAdminNameLabel);
            this.adminDeleteFormGroupBox.Controls.Add(this.deleteAdminNameTextBox);
            this.adminDeleteFormGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDeleteFormGroupBox.Location = new System.Drawing.Point(115, 29);
            this.adminDeleteFormGroupBox.Name = "adminDeleteFormGroupBox";
            this.adminDeleteFormGroupBox.Size = new System.Drawing.Size(342, 315);
            this.adminDeleteFormGroupBox.TabIndex = 2;
            this.adminDeleteFormGroupBox.TabStop = false;
            this.adminDeleteFormGroupBox.Text = "Admin Delete Form";
            // 
            // DeleteAdminIdLabel
            // 
            this.DeleteAdminIdLabel.AutoSize = true;
            this.DeleteAdminIdLabel.Location = new System.Drawing.Point(41, 91);
            this.DeleteAdminIdLabel.Name = "DeleteAdminIdLabel";
            this.DeleteAdminIdLabel.Size = new System.Drawing.Size(65, 20);
            this.DeleteAdminIdLabel.TabIndex = 17;
            this.DeleteAdminIdLabel.Text = "Admin ID";
            // 
            // deleteAdminDeleteButton
            // 
            this.deleteAdminDeleteButton.BackColor = System.Drawing.Color.LightCyan;
            this.deleteAdminDeleteButton.Location = new System.Drawing.Point(182, 137);
            this.deleteAdminDeleteButton.Name = "deleteAdminDeleteButton";
            this.deleteAdminDeleteButton.Size = new System.Drawing.Size(91, 41);
            this.deleteAdminDeleteButton.TabIndex = 15;
            this.deleteAdminDeleteButton.Text = "Delete";
            this.deleteAdminDeleteButton.UseVisualStyleBackColor = false;
            // 
            // deleteAdminIdTextBox
            // 
            this.deleteAdminIdTextBox.Location = new System.Drawing.Point(139, 91);
            this.deleteAdminIdTextBox.Name = "deleteAdminIdTextBox";
            this.deleteAdminIdTextBox.Size = new System.Drawing.Size(180, 25);
            this.deleteAdminIdTextBox.TabIndex = 11;
            // 
            // DeleteAdminNameLabel
            // 
            this.DeleteAdminNameLabel.AutoSize = true;
            this.DeleteAdminNameLabel.Location = new System.Drawing.Point(20, 51);
            this.DeleteAdminNameLabel.Name = "DeleteAdminNameLabel";
            this.DeleteAdminNameLabel.Size = new System.Drawing.Size(86, 20);
            this.DeleteAdminNameLabel.TabIndex = 2;
            this.DeleteAdminNameLabel.Text = "Admin Name";
            // 
            // deleteAdminNameTextBox
            // 
            this.deleteAdminNameTextBox.Location = new System.Drawing.Point(139, 51);
            this.deleteAdminNameTextBox.Name = "deleteAdminNameTextBox";
            this.deleteAdminNameTextBox.Size = new System.Drawing.Size(180, 25);
            this.deleteAdminNameTextBox.TabIndex = 1;
            // 
            // deleteAdminBackButton
            // 
            this.deleteAdminBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.deleteAdminBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdminBackButton.Location = new System.Drawing.Point(115, 367);
            this.deleteAdminBackButton.Name = "deleteAdminBackButton";
            this.deleteAdminBackButton.Size = new System.Drawing.Size(89, 38);
            this.deleteAdminBackButton.TabIndex = 17;
            this.deleteAdminBackButton.Text = "Back";
            this.deleteAdminBackButton.UseVisualStyleBackColor = false;
            // 
            // DeleteAdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.deleteAdminBackButton);
            this.Controls.Add(this.adminDeleteFormGroupBox);
            this.Name = "DeleteAdminUI";
            this.Text = "DeleteAdminUI";
            this.adminDeleteFormGroupBox.ResumeLayout(false);
            this.adminDeleteFormGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox adminDeleteFormGroupBox;
        private System.Windows.Forms.Label DeleteAdminIdLabel;
        private System.Windows.Forms.Button deleteAdminDeleteButton;
        private System.Windows.Forms.TextBox deleteAdminIdTextBox;
        private System.Windows.Forms.Label DeleteAdminNameLabel;
        private System.Windows.Forms.TextBox deleteAdminNameTextBox;
        private System.Windows.Forms.Button deleteAdminBackButton;
    }
}