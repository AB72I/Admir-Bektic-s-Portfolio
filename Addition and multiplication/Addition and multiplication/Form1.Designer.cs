namespace Addition_and_multiplication
{
    partial class frmAddMultiply
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
            this.lblValueA = new System.Windows.Forms.Label();
            this.lblValueB = new System.Windows.Forms.Label();
            this.lblValueC = new System.Windows.Forms.Label();
            this.btnResult1 = new System.Windows.Forms.Button();
            this.btnResult2 = new System.Windows.Forms.Button();
            this.txtValueA = new System.Windows.Forms.TextBox();
            this.txtValueB = new System.Windows.Forms.TextBox();
            this.txtValueC = new System.Windows.Forms.TextBox();
            this.txtAddMultiply = new System.Windows.Forms.TextBox();
            this.txtMultiplyAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValueA
            // 
            this.lblValueA.AutoSize = true;
            this.lblValueA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValueA.Location = new System.Drawing.Point(40, 50);
            this.lblValueA.Name = "lblValueA";
            this.lblValueA.Size = new System.Drawing.Size(65, 20);
            this.lblValueA.TabIndex = 0;
            this.lblValueA.Text = "Value A";
            this.lblValueA.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValueB
            // 
            this.lblValueB.AutoSize = true;
            this.lblValueB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValueB.Location = new System.Drawing.Point(322, 50);
            this.lblValueB.Name = "lblValueB";
            this.lblValueB.Size = new System.Drawing.Size(65, 20);
            this.lblValueB.TabIndex = 1;
            this.lblValueB.Text = "Value B";
            this.lblValueB.Click += new System.EventHandler(this.lblValueB_Click);
            // 
            // lblValueC
            // 
            this.lblValueC.AutoSize = true;
            this.lblValueC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValueC.Location = new System.Drawing.Point(562, 50);
            this.lblValueC.Name = "lblValueC";
            this.lblValueC.Size = new System.Drawing.Size(65, 20);
            this.lblValueC.TabIndex = 2;
            this.lblValueC.Text = "Value C";
            // 
            // btnResult1
            // 
            this.btnResult1.BackColor = System.Drawing.Color.Yellow;
            this.btnResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnResult1.Location = new System.Drawing.Point(182, 160);
            this.btnResult1.Name = "btnResult1";
            this.btnResult1.Size = new System.Drawing.Size(132, 46);
            this.btnResult1.TabIndex = 3;
            this.btnResult1.Text = "A + (B * C)";
            this.btnResult1.UseVisualStyleBackColor = false;
            this.btnResult1.Click += new System.EventHandler(this.btnResult1_Click);
            // 
            // btnResult2
            // 
            this.btnResult2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnResult2.Location = new System.Drawing.Point(182, 235);
            this.btnResult2.Name = "btnResult2";
            this.btnResult2.Size = new System.Drawing.Size(132, 48);
            this.btnResult2.TabIndex = 4;
            this.btnResult2.Text = "(A + B) * C";
            this.btnResult2.UseVisualStyleBackColor = false;
            this.btnResult2.Click += new System.EventHandler(this.btnResult2_Click);
            // 
            // txtValueA
            // 
            this.txtValueA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValueA.Location = new System.Drawing.Point(144, 50);
            this.txtValueA.Name = "txtValueA";
            this.txtValueA.Size = new System.Drawing.Size(97, 26);
            this.txtValueA.TabIndex = 5;
            // 
            // txtValueB
            // 
            this.txtValueB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValueB.Location = new System.Drawing.Point(419, 44);
            this.txtValueB.Name = "txtValueB";
            this.txtValueB.Size = new System.Drawing.Size(97, 26);
            this.txtValueB.TabIndex = 6;
            // 
            // txtValueC
            // 
            this.txtValueC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValueC.Location = new System.Drawing.Point(673, 47);
            this.txtValueC.Name = "txtValueC";
            this.txtValueC.Size = new System.Drawing.Size(97, 26);
            this.txtValueC.TabIndex = 7;
            // 
            // txtAddMultiply
            // 
            this.txtAddMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtAddMultiply.Location = new System.Drawing.Point(397, 168);
            this.txtAddMultiply.Name = "txtAddMultiply";
            this.txtAddMultiply.Size = new System.Drawing.Size(100, 32);
            this.txtAddMultiply.TabIndex = 8;
            // 
            // txtMultiplyAdd
            // 
            this.txtMultiplyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtMultiplyAdd.Location = new System.Drawing.Point(397, 244);
            this.txtMultiplyAdd.Name = "txtMultiplyAdd";
            this.txtMultiplyAdd.Size = new System.Drawing.Size(100, 32);
            this.txtMultiplyAdd.TabIndex = 9;
            // 
            // frmAddMultiply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.txtMultiplyAdd);
            this.Controls.Add(this.txtAddMultiply);
            this.Controls.Add(this.txtValueC);
            this.Controls.Add(this.txtValueB);
            this.Controls.Add(this.txtValueA);
            this.Controls.Add(this.btnResult2);
            this.Controls.Add(this.btnResult1);
            this.Controls.Add(this.lblValueC);
            this.Controls.Add(this.lblValueB);
            this.Controls.Add(this.lblValueA);
            this.Name = "frmAddMultiply";
            this.Text = "Addition and Multiplication";
            this.Load += new System.EventHandler(this.frmAddMultiply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValueA;
        private System.Windows.Forms.Label lblValueB;
        private System.Windows.Forms.Label lblValueC;
        private System.Windows.Forms.Button btnResult1;
        private System.Windows.Forms.Button btnResult2;
        private System.Windows.Forms.TextBox txtValueA;
        private System.Windows.Forms.TextBox txtValueB;
        private System.Windows.Forms.TextBox txtValueC;
        private System.Windows.Forms.TextBox txtAddMultiply;
        private System.Windows.Forms.TextBox txtMultiplyAdd;
    }
}

