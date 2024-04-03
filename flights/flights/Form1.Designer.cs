namespace flights
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
            this.lstFlights = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpFlight = new System.Windows.Forms.GroupBox();
            this.rdoInternational = new System.Windows.Forms.RadioButton();
            this.rdoDomestic = new System.Windows.Forms.RadioButton();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.txtPassenger = new System.Windows.Forms.TextBox();
            this.lblPassenger = new System.Windows.Forms.Label();
            this.btnPassenger = new System.Windows.Forms.Button();
            this.btnPassengers = new System.Windows.Forms.Button();
            this.grpFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFlights
            // 
            this.lstFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstFlights.FormattingEnabled = true;
            this.lstFlights.ItemHeight = 20;
            this.lstFlights.Location = new System.Drawing.Point(251, 137);
            this.lstFlights.Name = "lstFlights";
            this.lstFlights.Size = new System.Drawing.Size(325, 224);
            this.lstFlights.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(82, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Airline Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(251, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(325, 26);
            this.txtName.TabIndex = 2;
            // 
            // grpFlight
            // 
            this.grpFlight.Controls.Add(this.rdoInternational);
            this.grpFlight.Controls.Add(this.rdoDomestic);
            this.grpFlight.Location = new System.Drawing.Point(72, 238);
            this.grpFlight.Name = "grpFlight";
            this.grpFlight.Size = new System.Drawing.Size(108, 73);
            this.grpFlight.TabIndex = 4;
            this.grpFlight.TabStop = false;
            this.grpFlight.Text = "type of flight";
            // 
            // rdoInternational
            // 
            this.rdoInternational.AutoSize = true;
            this.rdoInternational.Location = new System.Drawing.Point(6, 43);
            this.rdoInternational.Name = "rdoInternational";
            this.rdoInternational.Size = new System.Drawing.Size(83, 17);
            this.rdoInternational.TabIndex = 1;
            this.rdoInternational.TabStop = true;
            this.rdoInternational.Text = "International";
            this.rdoInternational.UseVisualStyleBackColor = true;
            this.rdoInternational.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoDomestic
            // 
            this.rdoDomestic.AutoSize = true;
            this.rdoDomestic.Location = new System.Drawing.Point(7, 20);
            this.rdoDomestic.Name = "rdoDomestic";
            this.rdoDomestic.Size = new System.Drawing.Size(69, 17);
            this.rdoDomestic.TabIndex = 0;
            this.rdoDomestic.TabStop = true;
            this.rdoDomestic.Text = "Domestic";
            this.rdoDomestic.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEmployees.Location = new System.Drawing.Point(72, 137);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(108, 59);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "List Flights";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // txtPassenger
            // 
            this.txtPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassenger.Location = new System.Drawing.Point(251, 83);
            this.txtPassenger.Name = "txtPassenger";
            this.txtPassenger.Size = new System.Drawing.Size(325, 26);
            this.txtPassenger.TabIndex = 6;
            // 
            // lblPassenger
            // 
            this.lblPassenger.AutoSize = true;
            this.lblPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassenger.Location = new System.Drawing.Point(82, 86);
            this.lblPassenger.Name = "lblPassenger";
            this.lblPassenger.Size = new System.Drawing.Size(89, 20);
            this.lblPassenger.TabIndex = 7;
            this.lblPassenger.Text = "Your Name";
            // 
            // btnPassenger
            // 
            this.btnPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPassenger.Location = new System.Drawing.Point(614, 67);
            this.btnPassenger.Name = "btnPassenger";
            this.btnPassenger.Size = new System.Drawing.Size(93, 51);
            this.btnPassenger.TabIndex = 8;
            this.btnPassenger.Text = "Add Passenger";
            this.btnPassenger.UseVisualStyleBackColor = true;
            this.btnPassenger.Click += new System.EventHandler(this.btnPassenger_Click);
            // 
            // btnPassengers
            // 
            this.btnPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPassengers.Location = new System.Drawing.Point(614, 145);
            this.btnPassengers.Name = "btnPassengers";
            this.btnPassengers.Size = new System.Drawing.Size(105, 51);
            this.btnPassengers.TabIndex = 9;
            this.btnPassengers.Text = "List Passengers";
            this.btnPassengers.UseVisualStyleBackColor = true;
            this.btnPassengers.Click += new System.EventHandler(this.btnPassengers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPassengers);
            this.Controls.Add(this.btnPassenger);
            this.Controls.Add(this.lblPassenger);
            this.Controls.Add(this.txtPassenger);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.grpFlight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstFlights);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFlight.ResumeLayout(false);
            this.grpFlight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFlights;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpFlight;
        private System.Windows.Forms.RadioButton rdoInternational;
        private System.Windows.Forms.RadioButton rdoDomestic;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.TextBox txtPassenger;
        private System.Windows.Forms.Label lblPassenger;
        private System.Windows.Forms.Button btnPassenger;
        private System.Windows.Forms.Button btnPassengers;
    }
}

