
namespace ADMS_Project
{
    partial class ShowPatientUI
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
            this.showpatientTreatmentListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateDoctorBackButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showpatientTreatmentListDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showpatientTreatmentListDataGridView
            // 
            this.showpatientTreatmentListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.showpatientTreatmentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showpatientTreatmentListDataGridView.Location = new System.Drawing.Point(38, 43);
            this.showpatientTreatmentListDataGridView.Name = "showpatientTreatmentListDataGridView";
            this.showpatientTreatmentListDataGridView.RowHeadersWidth = 62;
            this.showpatientTreatmentListDataGridView.Size = new System.Drawing.Size(856, 300);
            this.showpatientTreatmentListDataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showpatientTreatmentListDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 378);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show  Patient With Treatment";
            // 
            // updateDoctorBackButton
            // 
            this.updateDoctorBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.updateDoctorBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDoctorBackButton.Location = new System.Drawing.Point(44, 406);
            this.updateDoctorBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateDoctorBackButton.Name = "updateDoctorBackButton";
            this.updateDoctorBackButton.Size = new System.Drawing.Size(98, 33);
            this.updateDoctorBackButton.TabIndex = 36;
            this.updateDoctorBackButton.Text = "Back";
            this.updateDoctorBackButton.UseVisualStyleBackColor = false;
            this.updateDoctorBackButton.Click += new System.EventHandler(this.updateDoctorBackButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(894, 406);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 37;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // ShowPatientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.updateDoctorBackButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowPatientUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPatientUI";
            this.Load += new System.EventHandler(this.ShowPatientUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showpatientTreatmentListDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showpatientTreatmentListDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateDoctorBackButton;
        private System.Windows.Forms.Button logOutButton;
    }
}