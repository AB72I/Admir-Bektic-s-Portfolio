namespace Translation
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
            this.btnNext = new System.Windows.Forms.Button();
            this.txtAmerican = new System.Windows.Forms.TextBox();
            this.lstTesters = new System.Windows.Forms.ListBox();
            this.lblAmerican = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Location = new System.Drawing.Point(54, 58);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 29);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtAmerican
            // 
            this.txtAmerican.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAmerican.Location = new System.Drawing.Point(188, 58);
            this.txtAmerican.Name = "txtAmerican";
            this.txtAmerican.Size = new System.Drawing.Size(176, 26);
            this.txtAmerican.TabIndex = 2;
            // 
            // lstTesters
            // 
            this.lstTesters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstTesters.FormattingEnabled = true;
            this.lstTesters.ItemHeight = 20;
            this.lstTesters.Location = new System.Drawing.Point(188, 119);
            this.lstTesters.Name = "lstTesters";
            this.lstTesters.Size = new System.Drawing.Size(369, 184);
            this.lstTesters.TabIndex = 3;
            // 
            // lblAmerican
            // 
            this.lblAmerican.AutoSize = true;
            this.lblAmerican.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAmerican.Location = new System.Drawing.Point(184, 24);
            this.lblAmerican.Name = "lblAmerican";
            this.lblAmerican.Size = new System.Drawing.Size(76, 20);
            this.lblAmerican.TabIndex = 4;
            this.lblAmerican.Text = "American";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEnglish.Location = new System.Drawing.Point(381, 58);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(176, 26);
            this.txtEnglish.TabIndex = 5;
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEnglish.Location = new System.Drawing.Point(377, 24);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(61, 20);
            this.lblEnglish.TabIndex = 6;
            this.lblEnglish.Text = "English";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTest.Location = new System.Drawing.Point(54, 119);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(99, 60);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Take the test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(54, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 51);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.lblAmerican);
            this.Controls.Add(this.lstTesters);
            this.Controls.Add(this.txtAmerican);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtAmerican;
        private System.Windows.Forms.ListBox lstTesters;
        private System.Windows.Forms.Label lblAmerican;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnExit;
    }
}

