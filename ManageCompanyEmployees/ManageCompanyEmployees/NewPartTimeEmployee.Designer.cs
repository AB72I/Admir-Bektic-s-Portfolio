namespace ManageCompanyEmployees
{
    partial class frmNewEmployee
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblProjects = new System.Windows.Forms.Label();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rdoFullTime = new System.Windows.Forms.RadioButton();
            this.rdoPartTime = new System.Windows.Forms.RadioButton();
            this.grbFPTime = new System.Windows.Forms.GroupBox();
            this.grbFPTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(36, 134);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(57, 20);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "Salary:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(99, 134);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(261, 26);
            this.txtSalary.TabIndex = 3;
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Location = new System.Drawing.Point(23, 196);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(70, 20);
            this.lblProjects.TabIndex = 4;
            this.lblProjects.Text = "Projects:";
            // 
            // lstProjects
            // 
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 20;
            this.lstProjects.Location = new System.Drawing.Point(99, 196);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(261, 144);
            this.lstProjects.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(277, 364);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 55);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rdoFullTime
            // 
            this.rdoFullTime.AutoSize = true;
            this.rdoFullTime.Location = new System.Drawing.Point(15, 18);
            this.rdoFullTime.Name = "rdoFullTime";
            this.rdoFullTime.Size = new System.Drawing.Size(97, 24);
            this.rdoFullTime.TabIndex = 7;
            this.rdoFullTime.TabStop = true;
            this.rdoFullTime.Text = "Full Time";
            this.rdoFullTime.UseVisualStyleBackColor = true;
            // 
            // rdoPartTime
            // 
            this.rdoPartTime.AutoSize = true;
            this.rdoPartTime.Location = new System.Drawing.Point(143, 18);
            this.rdoPartTime.Name = "rdoPartTime";
            this.rdoPartTime.Size = new System.Drawing.Size(101, 24);
            this.rdoPartTime.TabIndex = 8;
            this.rdoPartTime.TabStop = true;
            this.rdoPartTime.Text = "Part Time";
            this.rdoPartTime.UseVisualStyleBackColor = true;
  //          this.rdoPartTime.CheckedChanged += new System.EventHandler(this.rdoPartTime_CheckedChanged);
            // 
            // grbFPTime
            // 
            this.grbFPTime.Controls.Add(this.rdoFullTime);
            this.grbFPTime.Controls.Add(this.rdoPartTime);
            this.grbFPTime.Location = new System.Drawing.Point(99, 59);
            this.grbFPTime.Name = "grbFPTime";
            this.grbFPTime.Size = new System.Drawing.Size(261, 54);
            this.grbFPTime.TabIndex = 9;
            this.grbFPTime.TabStop = false;
            // 
            // frmNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 431);
            this.Controls.Add(this.grbFPTime);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.lblProjects);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "frmNewEmployee";
            this.Text = "New Employee";
            this.Load += new System.EventHandler(this.frmNewEmployee_Load);
            this.grbFPTime.ResumeLayout(false);
            this.grbFPTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rdoFullTime;
        private System.Windows.Forms.RadioButton rdoPartTime;
        private System.Windows.Forms.GroupBox grbFPTime;
    }
}