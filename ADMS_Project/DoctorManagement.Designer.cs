
namespace ADMS_Project
{
    partial class DoctorManagement
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
            this.backButton = new System.Windows.Forms.Button();
            this.deleteDoctorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addDoctorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DoctorListGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorListDataGridView = new System.Windows.Forms.DataGridView();
            this.logOutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DoctorListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCyan;
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(60, 400);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 39);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteDoctorLinkLabel
            // 
            this.deleteDoctorLinkLabel.AutoSize = true;
            this.deleteDoctorLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDoctorLinkLabel.ForeColor = System.Drawing.Color.Purple;
            this.deleteDoctorLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.deleteDoctorLinkLabel.Location = new System.Drawing.Point(409, 29);
            this.deleteDoctorLinkLabel.Name = "deleteDoctorLinkLabel";
            this.deleteDoctorLinkLabel.Size = new System.Drawing.Size(91, 20);
            this.deleteDoctorLinkLabel.TabIndex = 26;
            this.deleteDoctorLinkLabel.TabStop = true;
            this.deleteDoctorLinkLabel.Text = "Delete Doctor";
            this.deleteDoctorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteDoctorLinkLabel_LinkClicked);
            // 
            // addDoctorLinkLabel
            // 
            this.addDoctorLinkLabel.AutoSize = true;
            this.addDoctorLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.addDoctorLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDoctorLinkLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.addDoctorLinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.addDoctorLinkLabel.Location = new System.Drawing.Point(274, 29);
            this.addDoctorLinkLabel.Name = "addDoctorLinkLabel";
            this.addDoctorLinkLabel.Size = new System.Drawing.Size(78, 20);
            this.addDoctorLinkLabel.TabIndex = 25;
            this.addDoctorLinkLabel.TabStop = true;
            this.addDoctorLinkLabel.Text = "Add Doctor";
            this.addDoctorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addDoctorLinkLabel_LinkClicked);
            // 
            // DoctorListGroupBox
            // 
            this.DoctorListGroupBox.Controls.Add(this.doctorListDataGridView);
            this.DoctorListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.DoctorListGroupBox.Location = new System.Drawing.Point(60, 72);
            this.DoctorListGroupBox.Name = "DoctorListGroupBox";
            this.DoctorListGroupBox.Size = new System.Drawing.Size(635, 271);
            this.DoctorListGroupBox.TabIndex = 24;
            this.DoctorListGroupBox.TabStop = false;
            this.DoctorListGroupBox.Text = "Doctor List";
            // 
            // doctorListDataGridView
            // 
            this.doctorListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.doctorListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorListDataGridView.Location = new System.Drawing.Point(39, 45);
            this.doctorListDataGridView.Name = "doctorListDataGridView";
            this.doctorListDataGridView.RowHeadersWidth = 62;
            this.doctorListDataGridView.Size = new System.Drawing.Size(555, 197);
            this.doctorListDataGridView.TabIndex = 0;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(613, 402);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 28;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(248, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "Enable Trigger";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(413, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "Disable Trigger";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoctorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteDoctorLinkLabel);
            this.Controls.Add(this.addDoctorLinkLabel);
            this.Controls.Add(this.DoctorListGroupBox);
            this.Name = "DoctorManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorManagement";
            this.Load += new System.EventHandler(this.DoctorManagement_Load);
            this.DoctorListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.LinkLabel deleteDoctorLinkLabel;
        private System.Windows.Forms.LinkLabel addDoctorLinkLabel;
        private System.Windows.Forms.GroupBox DoctorListGroupBox;
        private System.Windows.Forms.DataGridView doctorListDataGridView;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}