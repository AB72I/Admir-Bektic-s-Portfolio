namespace ManageCompanyEmployees
{
    partial class frmManagedEmployees
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
            this.lblManaged = new System.Windows.Forms.Label();
            this.lstManaged = new System.Windows.Forms.ListBox();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnUpdatesCompleted = new System.Windows.Forms.Button();
            this.lstAllPTEmps = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblManaged
            // 
            this.lblManaged.AutoSize = true;
            this.lblManaged.Location = new System.Drawing.Point(98, 107);
            this.lblManaged.Name = "lblManaged";
            this.lblManaged.Size = new System.Drawing.Size(76, 20);
            this.lblManaged.TabIndex = 2;
            this.lblManaged.Text = "Managed";
            // 
            // lstManaged
            // 
            this.lstManaged.FormattingEnabled = true;
            this.lstManaged.ItemHeight = 20;
            this.lstManaged.Location = new System.Drawing.Point(64, 130);
            this.lstManaged.Name = "lstManaged";
            this.lstManaged.Size = new System.Drawing.Size(151, 204);
            this.lstManaged.TabIndex = 3;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(474, 242);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(120, 60);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnUpdatesCompleted
            // 
            this.btnUpdatesCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdatesCompleted.Location = new System.Drawing.Point(183, 360);
            this.btnUpdatesCompleted.Name = "btnUpdatesCompleted";
            this.btnUpdatesCompleted.Size = new System.Drawing.Size(157, 58);
            this.btnUpdatesCompleted.TabIndex = 5;
            this.btnUpdatesCompleted.Text = "Updates Completed";
            this.btnUpdatesCompleted.UseVisualStyleBackColor = false;
            this.btnUpdatesCompleted.Click += new System.EventHandler(this.btnUpdatesCompleted_Click);
            // 
            // lstAllPTEmps
            // 
            this.lstAllPTEmps.FormattingEnabled = true;
            this.lstAllPTEmps.ItemHeight = 20;
            this.lstAllPTEmps.Location = new System.Drawing.Point(271, 132);
            this.lstAllPTEmps.Name = "lstAllPTEmps";
            this.lstAllPTEmps.Size = new System.Drawing.Size(151, 204);
            this.lstAllPTEmps.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Full List";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(474, 152);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 60);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // frmManagedEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 442);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAllPTEmps);
            this.Controls.Add(this.btnUpdatesCompleted);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.lstManaged);
            this.Controls.Add(this.lblManaged);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "frmManagedEmployees";
            this.Text = "Managed Employees";
            this.Load += new System.EventHandler(this.frmManagedEmployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblManaged;
        private System.Windows.Forms.ListBox lstManaged;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnUpdatesCompleted;
        private System.Windows.Forms.ListBox lstAllPTEmps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}