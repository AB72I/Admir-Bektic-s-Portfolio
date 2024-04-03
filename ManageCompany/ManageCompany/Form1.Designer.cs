namespace ManageCompany
{
    partial class frmManageCompany
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
            this.btnListEmployees = new System.Windows.Forms.Button();
            this.btnSortEmployees = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnLongestEmp = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chbWithIDs = new System.Windows.Forms.CheckBox();
            this.lblSearchEmp = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.btnTotalEmps = new System.Windows.Forms.Button();
            this.txtTotalNumEmps = new System.Windows.Forms.TextBox();
            this.chbWithDays = new System.Windows.Forms.CheckBox();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lstID = new System.Windows.Forms.ListBox();
            this.lstDays = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListEmployees
            // 
            this.btnListEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEmployees.Location = new System.Drawing.Point(48, 48);
            this.btnListEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListEmployees.Name = "btnListEmployees";
            this.btnListEmployees.Size = new System.Drawing.Size(86, 48);
            this.btnListEmployees.TabIndex = 0;
            this.btnListEmployees.Text = "List Employees";
            this.btnListEmployees.UseVisualStyleBackColor = true;
            this.btnListEmployees.Click += new System.EventHandler(this.btnListEmployees_Click);
            // 
            // btnSortEmployees
            // 
            this.btnSortEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortEmployees.Location = new System.Drawing.Point(48, 204);
            this.btnSortEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSortEmployees.Name = "btnSortEmployees";
            this.btnSortEmployees.Size = new System.Drawing.Size(86, 48);
            this.btnSortEmployees.TabIndex = 1;
            this.btnSortEmployees.Text = "Sort Employees";
            this.btnSortEmployees.UseVisualStyleBackColor = true;
            this.btnSortEmployees.Click += new System.EventHandler(this.btnSortEmployees_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmp.Location = new System.Drawing.Point(508, 153);
            this.btnSearchEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(100, 30);
            this.btnSearchEmp.TabIndex = 2;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(48, 145);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(86, 48);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(508, 197);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveEmployee.TabIndex = 4;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnLongestEmp
            // 
            this.btnLongestEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongestEmp.Location = new System.Drawing.Point(48, 270);
            this.btnLongestEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLongestEmp.Name = "btnLongestEmp";
            this.btnLongestEmp.Size = new System.Drawing.Size(86, 48);
            this.btnLongestEmp.TabIndex = 5;
            this.btnLongestEmp.Text = "Longest Employee";
            this.btnLongestEmp.UseVisualStyleBackColor = true;
            this.btnLongestEmp.Click += new System.EventHandler(this.btnLongestEmp_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(8, 12);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(88, 20);
            this.lblCompanyName.TabIndex = 7;
            this.lblCompanyName.Text = "Company:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(98, 12);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(512, 23);
            this.txtCompanyName.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(535, 287);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 41);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(454, 287);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 41);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chbWithIDs
            // 
            this.chbWithIDs.AutoSize = true;
            this.chbWithIDs.Location = new System.Drawing.Point(48, 103);
            this.chbWithIDs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbWithIDs.Name = "chbWithIDs";
            this.chbWithIDs.Size = new System.Drawing.Size(62, 17);
            this.chbWithIDs.TabIndex = 11;
            this.chbWithIDs.Text = "With ID";
            this.chbWithIDs.UseVisualStyleBackColor = true;
            // 
            // lblSearchEmp
            // 
            this.lblSearchEmp.AutoSize = true;
            this.lblSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmp.Location = new System.Drawing.Point(504, 101);
            this.lblSearchEmp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchEmp.Name = "lblSearchEmp";
            this.lblSearchEmp.Size = new System.Drawing.Size(111, 17);
            this.lblSearchEmp.TabIndex = 14;
            this.lblSearchEmp.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(508, 122);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(102, 20);
            this.txtEmployeeName.TabIndex = 15;
            this.txtEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTotalEmps
            // 
            this.btnTotalEmps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalEmps.Location = new System.Drawing.Point(212, 270);
            this.btnTotalEmps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTotalEmps.Name = "btnTotalEmps";
            this.btnTotalEmps.Size = new System.Drawing.Size(96, 48);
            this.btnTotalEmps.TabIndex = 16;
            this.btnTotalEmps.Text = "Total Number Employees";
            this.btnTotalEmps.UseVisualStyleBackColor = true;
            this.btnTotalEmps.Click += new System.EventHandler(this.btnTotalEmps_Click);
            // 
            // txtTotalNumEmps
            // 
            this.txtTotalNumEmps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNumEmps.Location = new System.Drawing.Point(314, 287);
            this.txtTotalNumEmps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalNumEmps.Name = "txtTotalNumEmps";
            this.txtTotalNumEmps.Size = new System.Drawing.Size(112, 23);
            this.txtTotalNumEmps.TabIndex = 17;
            this.txtTotalNumEmps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chbWithDays
            // 
            this.chbWithDays.AutoSize = true;
            this.chbWithDays.Location = new System.Drawing.Point(48, 122);
            this.chbWithDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbWithDays.Name = "chbWithDays";
            this.chbWithDays.Size = new System.Drawing.Size(75, 17);
            this.chbWithDays.TabIndex = 19;
            this.chbWithDays.Text = "With Days";
            this.chbWithDays.UseVisualStyleBackColor = true;
            // 
            // lstEmployees
            // 
            this.lstEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 16;
            this.lstEmployees.Location = new System.Drawing.Point(146, 81);
            this.lstEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(126, 180);
            this.lstEmployees.TabIndex = 20;
            this.lstEmployees.SelectedIndexChanged += new System.EventHandler(this.lstEmployees_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(178, 48);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(302, 48);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(372, 48);
            this.lblDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(45, 20);
            this.lblDays.TabIndex = 23;
            this.lblDays.Text = "Days";
            // 
            // lstID
            // 
            this.lstID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstID.FormattingEnabled = true;
            this.lstID.ItemHeight = 16;
            this.lstID.Location = new System.Drawing.Point(290, 81);
            this.lstID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstID.Name = "lstID";
            this.lstID.Size = new System.Drawing.Size(60, 180);
            this.lstID.TabIndex = 24;
            // 
            // lstDays
            // 
            this.lstDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDays.FormattingEnabled = true;
            this.lstDays.ItemHeight = 16;
            this.lstDays.Location = new System.Drawing.Point(366, 81);
            this.lstDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDays.Name = "lstDays";
            this.lstDays.Size = new System.Drawing.Size(60, 180);
            this.lstDays.TabIndex = 25;
            // 
            // frmManageCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 337);
            this.Controls.Add(this.lstDays);
            this.Controls.Add(this.lstID);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.chbWithDays);
            this.Controls.Add(this.txtTotalNumEmps);
            this.Controls.Add(this.btnTotalEmps);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblSearchEmp);
            this.Controls.Add(this.chbWithIDs);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.btnLongestEmp);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.btnSortEmployees);
            this.Controls.Add(this.btnListEmployees);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmManageCompany";
            this.Text = "Manage Company";
            this.Load += new System.EventHandler(this.frmManageCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListEmployees;
        private System.Windows.Forms.Button btnSortEmployees;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnLongestEmp;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chbWithIDs;
        private System.Windows.Forms.Label lblSearchEmp;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Button btnTotalEmps;
        private System.Windows.Forms.TextBox txtTotalNumEmps;
        private System.Windows.Forms.CheckBox chbWithDays;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.ListBox lstID;
        private System.Windows.Forms.ListBox lstDays;
    }
}

