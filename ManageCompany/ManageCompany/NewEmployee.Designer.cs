namespace ManageCompany
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
            this.lblDateJoined = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDateJoined = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(147, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblDateJoined
            // 
            this.lblDateJoined.AutoSize = true;
            this.lblDateJoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateJoined.Location = new System.Drawing.Point(147, 185);
            this.lblDateJoined.Name = "lblDateJoined";
            this.lblDateJoined.Size = new System.Drawing.Size(187, 74);
            this.lblDateJoined.TabIndex = 1;
            this.lblDateJoined.Text = "Date Joined\r\nCompany:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(343, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 44);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateJoined
            // 
            this.txtDateJoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateJoined.Location = new System.Drawing.Point(343, 204);
            this.txtDateJoined.Name = "txtDateJoined";
            this.txtDateJoined.Size = new System.Drawing.Size(298, 44);
            this.txtDateJoined.TabIndex = 3;
            this.txtDateJoined.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(343, 321);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(298, 90);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtDateJoined);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDateJoined);
            this.Controls.Add(this.lblName);
            this.Name = "frmNewEmployee";
            this.Text = "New Employee";
            this.Load += new System.EventHandler(this.frmNewEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateJoined;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDateJoined;
        private System.Windows.Forms.Button btnEnter;
    }
}