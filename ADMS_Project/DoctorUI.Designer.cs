
namespace ADMS_Project
{
    partial class DoctorUI
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
            this.doctorUIDoctorLabel = new System.Windows.Forms.Label();
            this.doctorUIGiveTreatmentButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doctorUIDoctorLabel
            // 
            this.doctorUIDoctorLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorUIDoctorLabel.Location = new System.Drawing.Point(230, 28);
            this.doctorUIDoctorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorUIDoctorLabel.Name = "doctorUIDoctorLabel";
            this.doctorUIDoctorLabel.Size = new System.Drawing.Size(156, 55);
            this.doctorUIDoctorLabel.TabIndex = 20;
            this.doctorUIDoctorLabel.Text = "Doctor";
            this.doctorUIDoctorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doctorUIGiveTreatmentButton
            // 
            this.doctorUIGiveTreatmentButton.BackColor = System.Drawing.Color.LightCyan;
            this.doctorUIGiveTreatmentButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorUIGiveTreatmentButton.Location = new System.Drawing.Point(419, 142);
            this.doctorUIGiveTreatmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.doctorUIGiveTreatmentButton.Name = "doctorUIGiveTreatmentButton";
            this.doctorUIGiveTreatmentButton.Size = new System.Drawing.Size(106, 69);
            this.doctorUIGiveTreatmentButton.TabIndex = 18;
            this.doctorUIGiveTreatmentButton.Text = "Treatment Management";
            this.doctorUIGiveTreatmentButton.UseVisualStyleBackColor = false;
            this.doctorUIGiveTreatmentButton.Click += new System.EventHandler(this.doctorUIGiveTreatmentButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(261, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 69);
            this.button2.TabIndex = 22;
            this.button2.Text = "Show Patient";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(107, 142);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 69);
            this.button3.TabIndex = 23;
            this.button3.Text = "Update Profile";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DoctorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 381);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.doctorUIDoctorLabel);
            this.Controls.Add(this.doctorUIGiveTreatmentButton);
            this.Name = "DoctorUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorUI";
            this.Load += new System.EventHandler(this.DoctorUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label doctorUIDoctorLabel;
        private System.Windows.Forms.Button doctorUIGiveTreatmentButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}