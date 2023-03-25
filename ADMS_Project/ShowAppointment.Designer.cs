
namespace ADMS_Project
{
    partial class ShowAppointment
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
            this.doctorPatientAppointmentListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addAdminBackButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPatientAppointmentListDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorPatientAppointmentListDataGridView
            // 
            this.doctorPatientAppointmentListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.doctorPatientAppointmentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorPatientAppointmentListDataGridView.Location = new System.Drawing.Point(30, 41);
            this.doctorPatientAppointmentListDataGridView.Name = "doctorPatientAppointmentListDataGridView";
            this.doctorPatientAppointmentListDataGridView.RowHeadersWidth = 62;
            this.doctorPatientAppointmentListDataGridView.Size = new System.Drawing.Size(874, 306);
            this.doctorPatientAppointmentListDataGridView.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doctorPatientAppointmentListDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 375);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Appointment";
            // 
            // addAdminBackButton
            // 
            this.addAdminBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.addAdminBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminBackButton.Location = new System.Drawing.Point(31, 404);
            this.addAdminBackButton.Name = "addAdminBackButton";
            this.addAdminBackButton.Size = new System.Drawing.Size(82, 34);
            this.addAdminBackButton.TabIndex = 21;
            this.addAdminBackButton.Text = "Back";
            this.addAdminBackButton.UseVisualStyleBackColor = false;
            this.addAdminBackButton.Click += new System.EventHandler(this.addAdminBackButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(899, 404);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 26;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // ShowAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.addAdminBackButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAppointment";
            this.Load += new System.EventHandler(this.ShowAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorPatientAppointmentListDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorPatientAppointmentListDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addAdminBackButton;
        private System.Windows.Forms.Button logOutButton;
    }
}