namespace Sports
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
            this.lblSport = new System.Windows.Forms.Label();
            this.txtSport = new System.Windows.Forms.TextBox();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHighest = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSport.Location = new System.Drawing.Point(63, 45);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(48, 20);
            this.lblSport.TabIndex = 0;
            this.lblSport.Text = "Sport";
            // 
            // txtSport
            // 
            this.txtSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSport.Location = new System.Drawing.Point(173, 45);
            this.txtSport.Name = "txtSport";
            this.txtSport.Size = new System.Drawing.Size(100, 26);
            this.txtSport.TabIndex = 1;
            // 
            // txtPlayer
            // 
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPlayer.Location = new System.Drawing.Point(173, 97);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(100, 26);
            this.txtPlayer.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(339, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 53);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add a sport";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(443, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 53);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete a sport";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHighest
            // 
            this.btnHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHighest.Location = new System.Drawing.Point(67, 171);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(81, 39);
            this.btnHighest.TabIndex = 7;
            this.btnHighest.Text = "Highest";
            this.btnHighest.UseVisualStyleBackColor = true;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnList.Location = new System.Drawing.Point(339, 97);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(81, 39);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlayers.Location = new System.Drawing.Point(67, 91);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(81, 39);
            this.btnPlayers.TabIndex = 9;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.txtSport);
            this.Controls.Add(this.lblSport);
            this.Name = "Form1";
            this.Text = "Sports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.TextBox txtSport;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnPlayers;
    }
}

