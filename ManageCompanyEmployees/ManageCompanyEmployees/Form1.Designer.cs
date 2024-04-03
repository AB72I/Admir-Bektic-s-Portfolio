namespace ManageCompanyEmployees
{
    partial class Form1
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.pnlFPTime = new System.Windows.Forms.Panel();
            this.rdoPartTime = new System.Windows.Forms.RadioButton();
            this.rdoFullTime = new System.Windows.Forms.RadioButton();
            this.btnListEmployees = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lsbEmpInfo = new System.Windows.Forms.ListBox();
            this.lblEmployeeInformation = new System.Windows.Forms.Label();
            this.btnUpdateEmps = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlFPTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(65, 44);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(192, 29);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(256, 44);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(493, 35);
            this.txtCompanyName.TabIndex = 1;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlFPTime
            // 
            this.pnlFPTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFPTime.Controls.Add(this.rdoPartTime);
            this.pnlFPTime.Controls.Add(this.rdoFullTime);
            this.pnlFPTime.Controls.Add(this.btnListEmployees);
            this.pnlFPTime.Location = new System.Drawing.Point(26, 250);
            this.pnlFPTime.Name = "pnlFPTime";
            this.pnlFPTime.Size = new System.Drawing.Size(198, 172);
            this.pnlFPTime.TabIndex = 2;
            // 
            // rdoPartTime
            // 
            this.rdoPartTime.AutoSize = true;
            this.rdoPartTime.Location = new System.Drawing.Point(41, 127);
            this.rdoPartTime.Name = "rdoPartTime";
            this.rdoPartTime.Size = new System.Drawing.Size(101, 24);
            this.rdoPartTime.TabIndex = 6;
            this.rdoPartTime.TabStop = true;
            this.rdoPartTime.Text = "Part Time";
            this.rdoPartTime.UseVisualStyleBackColor = true;
            // 
            // rdoFullTime
            // 
            this.rdoFullTime.AutoSize = true;
            this.rdoFullTime.Location = new System.Drawing.Point(41, 97);
            this.rdoFullTime.Name = "rdoFullTime";
            this.rdoFullTime.Size = new System.Drawing.Size(97, 24);
            this.rdoFullTime.TabIndex = 5;
            this.rdoFullTime.TabStop = true;
            this.rdoFullTime.Text = "Full Time";
            this.rdoFullTime.UseVisualStyleBackColor = true;
            // 
            // btnListEmployees
            // 
            this.btnListEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEmployees.Location = new System.Drawing.Point(34, 16);
            this.btnListEmployees.Name = "btnListEmployees";
            this.btnListEmployees.Size = new System.Drawing.Size(133, 75);
            this.btnListEmployees.TabIndex = 4;
            this.btnListEmployees.Text = "List Employees";
            this.btnListEmployees.UseVisualStyleBackColor = true;
            this.btnListEmployees.Click += new System.EventHandler(this.btnListEmployees_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(60, 135);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(133, 75);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lsbEmpInfo
            // 
            this.lsbEmpInfo.FormattingEnabled = true;
            this.lsbEmpInfo.ItemHeight = 20;
            this.lsbEmpInfo.Location = new System.Drawing.Point(256, 135);
            this.lsbEmpInfo.Name = "lsbEmpInfo";
            this.lsbEmpInfo.Size = new System.Drawing.Size(504, 224);
            this.lsbEmpInfo.TabIndex = 3;
            // 
            // lblEmployeeInformation
            // 
            this.lblEmployeeInformation.AutoSize = true;
            this.lblEmployeeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInformation.Location = new System.Drawing.Point(391, 103);
            this.lblEmployeeInformation.Name = "lblEmployeeInformation";
            this.lblEmployeeInformation.Size = new System.Drawing.Size(247, 29);
            this.lblEmployeeInformation.TabIndex = 4;
            this.lblEmployeeInformation.Text = "Employee Information";
            // 
            // btnUpdateEmps
            // 
            this.btnUpdateEmps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdateEmps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmps.Location = new System.Drawing.Point(256, 378);
            this.btnUpdateEmps.Name = "btnUpdateEmps";
            this.btnUpdateEmps.Size = new System.Drawing.Size(344, 44);
            this.btnUpdateEmps.TabIndex = 5;
            this.btnUpdateEmps.Text = "FT Employee Management";
            this.btnUpdateEmps.UseVisualStyleBackColor = false;
            this.btnUpdateEmps.Click += new System.EventHandler(this.btnUpdateEmps_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(665, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateEmps);
            this.Controls.Add(this.lblEmployeeInformation);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lsbEmpInfo);
            this.Controls.Add(this.pnlFPTime);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "Form1";
            this.Text = "Company Employees";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFPTime.ResumeLayout(false);
            this.pnlFPTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Panel pnlFPTime;
        private System.Windows.Forms.RadioButton rdoPartTime;
        private System.Windows.Forms.RadioButton rdoFullTime;
        private System.Windows.Forms.Button btnListEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ListBox lsbEmpInfo;
        private System.Windows.Forms.Label lblEmployeeInformation;
        private System.Windows.Forms.Button btnUpdateEmps;
        private System.Windows.Forms.Button btnExit;
    }
}

