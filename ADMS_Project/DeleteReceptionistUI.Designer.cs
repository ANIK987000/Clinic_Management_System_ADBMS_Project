
namespace ADMS_Project
{
    partial class DeleteReceptionistUI
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
            this.deleteReceptionistBackButton = new System.Windows.Forms.Button();
            this.receptionistDeleteFormGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteReceptionistIdLabel = new System.Windows.Forms.Label();
            this.deleteReceptionistDeleteButton = new System.Windows.Forms.Button();
            this.deleteReceptionistIdTextBox = new System.Windows.Forms.TextBox();
            this.ReceptionistListGroupBox = new System.Windows.Forms.GroupBox();
            this.ReceptionistListDataGridView = new System.Windows.Forms.DataGridView();
            this.logOutButton = new System.Windows.Forms.Button();
            this.receptionistDeleteFormGroupBox.SuspendLayout();
            this.ReceptionistListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionistListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteReceptionistBackButton
            // 
            this.deleteReceptionistBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.deleteReceptionistBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteReceptionistBackButton.Location = new System.Drawing.Point(12, 420);
            this.deleteReceptionistBackButton.Name = "deleteReceptionistBackButton";
            this.deleteReceptionistBackButton.Size = new System.Drawing.Size(89, 27);
            this.deleteReceptionistBackButton.TabIndex = 18;
            this.deleteReceptionistBackButton.Text = "Back";
            this.deleteReceptionistBackButton.UseVisualStyleBackColor = false;
            this.deleteReceptionistBackButton.Click += new System.EventHandler(this.deleteReceptionistBackButton_Click);
            // 
            // receptionistDeleteFormGroupBox
            // 
            this.receptionistDeleteFormGroupBox.Controls.Add(this.DeleteReceptionistIdLabel);
            this.receptionistDeleteFormGroupBox.Controls.Add(this.deleteReceptionistDeleteButton);
            this.receptionistDeleteFormGroupBox.Controls.Add(this.deleteReceptionistIdTextBox);
            this.receptionistDeleteFormGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receptionistDeleteFormGroupBox.Location = new System.Drawing.Point(239, 12);
            this.receptionistDeleteFormGroupBox.Name = "receptionistDeleteFormGroupBox";
            this.receptionistDeleteFormGroupBox.Size = new System.Drawing.Size(398, 121);
            this.receptionistDeleteFormGroupBox.TabIndex = 17;
            this.receptionistDeleteFormGroupBox.TabStop = false;
            this.receptionistDeleteFormGroupBox.Text = "Receptionist Delete Form";
            // 
            // DeleteReceptionistIdLabel
            // 
            this.DeleteReceptionistIdLabel.AutoSize = true;
            this.DeleteReceptionistIdLabel.Location = new System.Drawing.Point(17, 36);
            this.DeleteReceptionistIdLabel.Name = "DeleteReceptionistIdLabel";
            this.DeleteReceptionistIdLabel.Size = new System.Drawing.Size(102, 20);
            this.DeleteReceptionistIdLabel.TabIndex = 17;
            this.DeleteReceptionistIdLabel.Text = "Receptionist ID";
            // 
            // deleteReceptionistDeleteButton
            // 
            this.deleteReceptionistDeleteButton.BackColor = System.Drawing.Color.LightCyan;
            this.deleteReceptionistDeleteButton.Location = new System.Drawing.Point(189, 78);
            this.deleteReceptionistDeleteButton.Name = "deleteReceptionistDeleteButton";
            this.deleteReceptionistDeleteButton.Size = new System.Drawing.Size(91, 30);
            this.deleteReceptionistDeleteButton.TabIndex = 15;
            this.deleteReceptionistDeleteButton.Text = "Delete";
            this.deleteReceptionistDeleteButton.UseVisualStyleBackColor = false;
            this.deleteReceptionistDeleteButton.Click += new System.EventHandler(this.deleteReceptionistDeleteButton_Click);
            // 
            // deleteReceptionistIdTextBox
            // 
            this.deleteReceptionistIdTextBox.Location = new System.Drawing.Point(150, 36);
            this.deleteReceptionistIdTextBox.Name = "deleteReceptionistIdTextBox";
            this.deleteReceptionistIdTextBox.Size = new System.Drawing.Size(191, 25);
            this.deleteReceptionistIdTextBox.TabIndex = 11;
            // 
            // ReceptionistListGroupBox
            // 
            this.ReceptionistListGroupBox.Controls.Add(this.ReceptionistListDataGridView);
            this.ReceptionistListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.ReceptionistListGroupBox.Location = new System.Drawing.Point(12, 139);
            this.ReceptionistListGroupBox.Name = "ReceptionistListGroupBox";
            this.ReceptionistListGroupBox.Size = new System.Drawing.Size(792, 275);
            this.ReceptionistListGroupBox.TabIndex = 34;
            this.ReceptionistListGroupBox.TabStop = false;
            this.ReceptionistListGroupBox.Text = "Receptionist List";
            // 
            // ReceptionistListDataGridView
            // 
            this.ReceptionistListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.ReceptionistListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceptionistListDataGridView.Location = new System.Drawing.Point(33, 49);
            this.ReceptionistListDataGridView.Name = "ReceptionistListDataGridView";
            this.ReceptionistListDataGridView.RowHeadersWidth = 62;
            this.ReceptionistListDataGridView.Size = new System.Drawing.Size(743, 220);
            this.ReceptionistListDataGridView.TabIndex = 0;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(722, 420);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 35;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // DeleteReceptionistUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 468);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.ReceptionistListGroupBox);
            this.Controls.Add(this.deleteReceptionistBackButton);
            this.Controls.Add(this.receptionistDeleteFormGroupBox);
            this.Name = "DeleteReceptionistUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteReceptionistUI";
            this.Load += new System.EventHandler(this.DeleteReceptionistUI_Load);
            this.receptionistDeleteFormGroupBox.ResumeLayout(false);
            this.receptionistDeleteFormGroupBox.PerformLayout();
            this.ReceptionistListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionistListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteReceptionistBackButton;
        private System.Windows.Forms.GroupBox receptionistDeleteFormGroupBox;
        private System.Windows.Forms.Label DeleteReceptionistIdLabel;
        private System.Windows.Forms.Button deleteReceptionistDeleteButton;
        private System.Windows.Forms.TextBox deleteReceptionistIdTextBox;
        private System.Windows.Forms.GroupBox ReceptionistListGroupBox;
        private System.Windows.Forms.DataGridView ReceptionistListDataGridView;
        private System.Windows.Forms.Button logOutButton;
    }
}