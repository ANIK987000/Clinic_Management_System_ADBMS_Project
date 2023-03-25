
namespace ADMS_Project
{
    partial class PatientUI
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
            this.patientUIPatientLabel = new System.Windows.Forms.Label();
            this.patientUIBookAppointmentButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientUIPatientLabel
            // 
            this.patientUIPatientLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientUIPatientLabel.Location = new System.Drawing.Point(204, 37);
            this.patientUIPatientLabel.Name = "patientUIPatientLabel";
            this.patientUIPatientLabel.Size = new System.Drawing.Size(153, 64);
            this.patientUIPatientLabel.TabIndex = 31;
            this.patientUIPatientLabel.Text = "Patient";
            this.patientUIPatientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patientUIBookAppointmentButton
            // 
            this.patientUIBookAppointmentButton.BackColor = System.Drawing.Color.LightCyan;
            this.patientUIBookAppointmentButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientUIBookAppointmentButton.Location = new System.Drawing.Point(140, 142);
            this.patientUIBookAppointmentButton.Name = "patientUIBookAppointmentButton";
            this.patientUIBookAppointmentButton.Size = new System.Drawing.Size(100, 61);
            this.patientUIBookAppointmentButton.TabIndex = 28;
            this.patientUIBookAppointmentButton.Text = "Update Profile";
            this.patientUIBookAppointmentButton.UseVisualStyleBackColor = false;
            this.patientUIBookAppointmentButton.Click += new System.EventHandler(this.patientUIBookAppointmentButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(313, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 61);
            this.button1.TabIndex = 33;
            this.button1.Text = "See Doctors List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientUIPatientLabel);
            this.Controls.Add(this.patientUIBookAppointmentButton);
            this.Name = "PatientUI";
            this.Text = "PatientUI";
            this.Load += new System.EventHandler(this.PatientUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label patientUIPatientLabel;
        private System.Windows.Forms.Button patientUIBookAppointmentButton;
        private System.Windows.Forms.Button button1;
    }
}