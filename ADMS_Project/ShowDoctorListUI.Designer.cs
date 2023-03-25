
namespace ADMS_Project
{
    partial class ShowDoctorListUI
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
            this.DoctorListGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorListDataGridView = new System.Windows.Forms.DataGridView();
            this.addAdminBackButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.DoctorListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorListGroupBox
            // 
            this.DoctorListGroupBox.Controls.Add(this.doctorListDataGridView);
            this.DoctorListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.DoctorListGroupBox.Location = new System.Drawing.Point(42, 36);
            this.DoctorListGroupBox.Name = "DoctorListGroupBox";
            this.DoctorListGroupBox.Size = new System.Drawing.Size(699, 341);
            this.DoctorListGroupBox.TabIndex = 25;
            this.DoctorListGroupBox.TabStop = false;
            this.DoctorListGroupBox.Text = "Doctor List";
            // 
            // doctorListDataGridView
            // 
            this.doctorListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.doctorListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorListDataGridView.Location = new System.Drawing.Point(32, 44);
            this.doctorListDataGridView.Name = "doctorListDataGridView";
            this.doctorListDataGridView.RowHeadersWidth = 62;
            this.doctorListDataGridView.Size = new System.Drawing.Size(637, 265);
            this.doctorListDataGridView.TabIndex = 0;
            // 
            // addAdminBackButton
            // 
            this.addAdminBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminBackButton.Location = new System.Drawing.Point(42, 394);
            this.addAdminBackButton.Name = "addAdminBackButton";
            this.addAdminBackButton.Size = new System.Drawing.Size(82, 34);
            this.addAdminBackButton.TabIndex = 26;
            this.addAdminBackButton.Text = "Back";
            this.addAdminBackButton.UseVisualStyleBackColor = false;
            this.addAdminBackButton.Click += new System.EventHandler(this.addAdminBackButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(659, 394);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 27;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // ShowDoctorListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.addAdminBackButton);
            this.Controls.Add(this.DoctorListGroupBox);
            this.Name = "ShowDoctorListUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowDoctorListUI";
            this.Load += new System.EventHandler(this.ShowDoctorListUI_Load);
            this.DoctorListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DoctorListGroupBox;
        private System.Windows.Forms.DataGridView doctorListDataGridView;
        private System.Windows.Forms.Button addAdminBackButton;
        private System.Windows.Forms.Button logOutButton;
    }
}