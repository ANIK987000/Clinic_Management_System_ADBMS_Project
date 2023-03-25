
namespace ADMS_Project
{
    partial class ReceptionistManagement
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
            this.deleteReceptionistLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addReceptionsitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ReceptionistListGroupBox = new System.Windows.Forms.GroupBox();
            this.ReceptionistListDataGridView = new System.Windows.Forms.DataGridView();
            this.ReceptionistListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionistListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(603, 404);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 37;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCyan;
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(85, 399);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 37);
            this.backButton.TabIndex = 32;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteReceptionistLinkLabel
            // 
            this.deleteReceptionistLinkLabel.AutoSize = true;
            this.deleteReceptionistLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteReceptionistLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.deleteReceptionistLinkLabel.Location = new System.Drawing.Point(456, 43);
            this.deleteReceptionistLinkLabel.Name = "deleteReceptionistLinkLabel";
            this.deleteReceptionistLinkLabel.Size = new System.Drawing.Size(127, 20);
            this.deleteReceptionistLinkLabel.TabIndex = 35;
            this.deleteReceptionistLinkLabel.TabStop = true;
            this.deleteReceptionistLinkLabel.Text = "Delete Receptionist";
            this.deleteReceptionistLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteReceptionistLinkLabel_LinkClicked);
            // 
            // addReceptionsitLinkLabel
            // 
            this.addReceptionsitLinkLabel.AutoSize = true;
            this.addReceptionsitLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReceptionsitLinkLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addReceptionsitLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.addReceptionsitLinkLabel.Location = new System.Drawing.Point(260, 43);
            this.addReceptionsitLinkLabel.Name = "addReceptionsitLinkLabel";
            this.addReceptionsitLinkLabel.Size = new System.Drawing.Size(114, 20);
            this.addReceptionsitLinkLabel.TabIndex = 34;
            this.addReceptionsitLinkLabel.TabStop = true;
            this.addReceptionsitLinkLabel.Text = "Add Receptionist";
            this.addReceptionsitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addReceptionsitLinkLabel_LinkClicked);
            // 
            // ReceptionistListGroupBox
            // 
            this.ReceptionistListGroupBox.Controls.Add(this.ReceptionistListDataGridView);
            this.ReceptionistListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.ReceptionistListGroupBox.Location = new System.Drawing.Point(85, 89);
            this.ReceptionistListGroupBox.Name = "ReceptionistListGroupBox";
            this.ReceptionistListGroupBox.Size = new System.Drawing.Size(600, 291);
            this.ReceptionistListGroupBox.TabIndex = 33;
            this.ReceptionistListGroupBox.TabStop = false;
            this.ReceptionistListGroupBox.Text = "Receptionist List";
            // 
            // ReceptionistListDataGridView
            // 
            this.ReceptionistListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.ReceptionistListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceptionistListDataGridView.Location = new System.Drawing.Point(30, 39);
            this.ReceptionistListDataGridView.Name = "ReceptionistListDataGridView";
            this.ReceptionistListDataGridView.RowHeadersWidth = 62;
            this.ReceptionistListDataGridView.Size = new System.Drawing.Size(538, 214);
            this.ReceptionistListDataGridView.TabIndex = 0;
            // 
            // ReceptionistManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteReceptionistLinkLabel);
            this.Controls.Add(this.addReceptionsitLinkLabel);
            this.Controls.Add(this.ReceptionistListGroupBox);
            this.Name = "ReceptionistManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.ReceptionistManagement_Load);
            this.ReceptionistListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionistListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.LinkLabel deleteReceptionistLinkLabel;
        private System.Windows.Forms.LinkLabel addReceptionsitLinkLabel;
        private System.Windows.Forms.GroupBox ReceptionistListGroupBox;
        private System.Windows.Forms.DataGridView ReceptionistListDataGridView;
    }
}