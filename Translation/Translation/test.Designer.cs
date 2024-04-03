namespace Translation
{
    partial class frmTest
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
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAmerican = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNames
            // 
            this.lstNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 20;
            this.lstNames.Location = new System.Drawing.Point(47, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(136, 124);
            this.lstNames.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStart.Location = new System.Drawing.Point(247, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 46);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Test";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtAmerican
            // 
            this.txtAmerican.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAmerican.Location = new System.Drawing.Point(367, 47);
            this.txtAmerican.Name = "txtAmerican";
            this.txtAmerican.Size = new System.Drawing.Size(190, 26);
            this.txtAmerican.TabIndex = 2;
            this.txtAmerican.TextChanged += new System.EventHandler(this.txtAmerican_TextChanged);
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEnglish.Location = new System.Drawing.Point(367, 110);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(190, 26);
            this.txtEnglish.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(247, 160);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 34);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(583, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtAmerican);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstNames);
            this.Name = "frmTest";
            this.Text = "test";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAmerican;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
    }
}