
namespace ADMS_Project
{
    partial class DeleteDoctorUI
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
            this.deleteDoctorBackButton = new System.Windows.Forms.Button();
            this.doctorDeleteFormGroupBox = new System.Windows.Forms.GroupBox();
            this.DoctorDeleteButton = new System.Windows.Forms.Button();
            this.deleteDoctorIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteDoctorIdLebel = new System.Windows.Forms.Label();
            this.DoctorListGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorListDataGridView = new System.Windows.Forms.DataGridView();
            this.logOutButton = new System.Windows.Forms.Button();
            this.doctorDeleteFormGroupBox.SuspendLayout();
            this.DoctorListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteDoctorBackButton
            // 
            this.deleteDoctorBackButton.BackColor = System.Drawing.Color.LightCyan;
            this.deleteDoctorBackButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDoctorBackButton.Location = new System.Drawing.Point(11, 419);
            this.deleteDoctorBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteDoctorBackButton.Name = "deleteDoctorBackButton";
            this.deleteDoctorBackButton.Size = new System.Drawing.Size(79, 29);
            this.deleteDoctorBackButton.TabIndex = 20;
            this.deleteDoctorBackButton.Text = "Back";
            this.deleteDoctorBackButton.UseVisualStyleBackColor = false;
            this.deleteDoctorBackButton.Click += new System.EventHandler(this.deleteDoctorBackButton_Click);
            // 
            // doctorDeleteFormGroupBox
            // 
            this.doctorDeleteFormGroupBox.Controls.Add(this.DoctorDeleteButton);
            this.doctorDeleteFormGroupBox.Controls.Add(this.deleteDoctorIdTextBox);
            this.doctorDeleteFormGroupBox.Controls.Add(this.deleteDoctorIdLebel);
            this.doctorDeleteFormGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorDeleteFormGroupBox.Location = new System.Drawing.Point(238, 11);
            this.doctorDeleteFormGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.doctorDeleteFormGroupBox.Name = "doctorDeleteFormGroupBox";
            this.doctorDeleteFormGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.doctorDeleteFormGroupBox.Size = new System.Drawing.Size(342, 121);
            this.doctorDeleteFormGroupBox.TabIndex = 19;
            this.doctorDeleteFormGroupBox.TabStop = false;
            this.doctorDeleteFormGroupBox.Text = "Doctor Delete Form";
            // 
            // DoctorDeleteButton
            // 
            this.DoctorDeleteButton.BackColor = System.Drawing.Color.LightCyan;
            this.DoctorDeleteButton.Location = new System.Drawing.Point(148, 75);
            this.DoctorDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DoctorDeleteButton.Name = "DoctorDeleteButton";
            this.DoctorDeleteButton.Size = new System.Drawing.Size(85, 30);
            this.DoctorDeleteButton.TabIndex = 17;
            this.DoctorDeleteButton.Text = "Delete";
            this.DoctorDeleteButton.UseVisualStyleBackColor = false;
            this.DoctorDeleteButton.Click += new System.EventHandler(this.DoctorDeleteButton_Click);
            // 
            // deleteDoctorIdTextBox
            // 
            this.deleteDoctorIdTextBox.Location = new System.Drawing.Point(108, 37);
            this.deleteDoctorIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.deleteDoctorIdTextBox.Name = "deleteDoctorIdTextBox";
            this.deleteDoctorIdTextBox.Size = new System.Drawing.Size(179, 25);
            this.deleteDoctorIdTextBox.TabIndex = 14;
            // 
            // deleteDoctorIdLebel
            // 
            this.deleteDoctorIdLebel.AutoSize = true;
            this.deleteDoctorIdLebel.Location = new System.Drawing.Point(23, 37);
            this.deleteDoctorIdLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deleteDoctorIdLebel.Name = "deleteDoctorIdLebel";
            this.deleteDoctorIdLebel.Size = new System.Drawing.Size(65, 20);
            this.deleteDoctorIdLebel.TabIndex = 13;
            this.deleteDoctorIdLebel.Text = "Doctor Id";
            this.deleteDoctorIdLebel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DoctorListGroupBox
            // 
            this.DoctorListGroupBox.Controls.Add(this.doctorListDataGridView);
            this.DoctorListGroupBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.DoctorListGroupBox.Location = new System.Drawing.Point(11, 137);
            this.DoctorListGroupBox.Name = "DoctorListGroupBox";
            this.DoctorListGroupBox.Size = new System.Drawing.Size(759, 277);
            this.DoctorListGroupBox.TabIndex = 25;
            this.DoctorListGroupBox.TabStop = false;
            this.DoctorListGroupBox.Text = "Doctor List";
            // 
            // doctorListDataGridView
            // 
            this.doctorListDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.doctorListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorListDataGridView.Location = new System.Drawing.Point(17, 49);
            this.doctorListDataGridView.Name = "doctorListDataGridView";
            this.doctorListDataGridView.RowHeadersWidth = 62;
            this.doctorListDataGridView.Size = new System.Drawing.Size(722, 211);
            this.doctorListDataGridView.TabIndex = 0;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.logOutButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(688, 419);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 34);
            this.logOutButton.TabIndex = 26;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // DeleteDoctorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 462);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.DoctorListGroupBox);
            this.Controls.Add(this.deleteDoctorBackButton);
            this.Controls.Add(this.doctorDeleteFormGroupBox);
            this.Name = "DeleteDoctorUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteDoctorUI";
            this.Load += new System.EventHandler(this.DeleteDoctorUI_Load);
            this.doctorDeleteFormGroupBox.ResumeLayout(false);
            this.doctorDeleteFormGroupBox.PerformLayout();
            this.DoctorListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteDoctorBackButton;
        private System.Windows.Forms.GroupBox doctorDeleteFormGroupBox;
        private System.Windows.Forms.Button DoctorDeleteButton;
        private System.Windows.Forms.TextBox deleteDoctorIdTextBox;
        private System.Windows.Forms.Label deleteDoctorIdLebel;
        private System.Windows.Forms.GroupBox DoctorListGroupBox;
        private System.Windows.Forms.DataGridView doctorListDataGridView;
        private System.Windows.Forms.Button logOutButton;
    }
}