namespace flights
{
    partial class frmPassengerList
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
            this.lstPassengerList = new System.Windows.Forms.ListBox();
            this.lblFlight = new System.Windows.Forms.Label();
            this.txtFlight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstPassengerList
            // 
            this.lstPassengerList.FormattingEnabled = true;
            this.lstPassengerList.Location = new System.Drawing.Point(222, 71);
            this.lstPassengerList.Name = "lstPassengerList";
            this.lstPassengerList.Size = new System.Drawing.Size(232, 199);
            this.lstPassengerList.TabIndex = 0;
            this.lstPassengerList.SelectedIndexChanged += new System.EventHandler(this.lstFlighList_SelectedIndexChanged);
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFlight.Location = new System.Drawing.Point(152, 22);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(48, 20);
            this.lblFlight.TabIndex = 1;
            this.lblFlight.Text = "Flight";
            // 
            // txtFlight
            // 
            this.txtFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFlight.Location = new System.Drawing.Point(222, 22);
            this.txtFlight.Name = "txtFlight";
            this.txtFlight.Size = new System.Drawing.Size(232, 26);
            this.txtFlight.TabIndex = 2;
            this.txtFlight.TextChanged += new System.EventHandler(this.txtFlight_TextChanged);
            // 
            // frmPassengerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFlight);
            this.Controls.Add(this.lblFlight);
            this.Controls.Add(this.lstPassengerList);
            this.Name = "frmPassengerList";
            this.Text = "PassengerList";
            this.Load += new System.EventHandler(this.frmPassengerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPassengerList;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.TextBox txtFlight;
    }
}