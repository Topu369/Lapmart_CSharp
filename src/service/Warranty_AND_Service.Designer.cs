namespace LaptopManagement
{
    partial class Warranty_AND_Service
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcome_Lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btnNewToken = new System.Windows.Forms.Button();
            this.ServiceMainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.welcome_Lbl);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 77);
            this.panel1.TabIndex = 3;
            // 
            // welcome_Lbl
            // 
            this.welcome_Lbl.AutoSize = true;
            this.welcome_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(251)))), ((int)(((byte)(137)))));
            this.welcome_Lbl.Location = new System.Drawing.Point(736, 26);
            this.welcome_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome_Lbl.Name = "welcome_Lbl";
            this.welcome_Lbl.Size = new System.Drawing.Size(201, 25);
            this.welcome_Lbl.TabIndex = 0;
            this.welcome_Lbl.Text = "Welcome, Service";
            this.welcome_Lbl.Click += new System.EventHandler(this.welcome_Lbl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnStatus);
            this.panel2.Controls.Add(this.btnCheck);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btnNewToken);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 510);
            this.panel2.TabIndex = 4;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Ubuntu Mono", 11.25F);
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(32, 156);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(119, 40);
            this.btnStatus.TabIndex = 8;
            this.btnStatus.Text = "Queue Status";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Ubuntu Mono", 11.25F);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(32, 29);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(119, 40);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Ubuntu Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(51, 442);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(68, 40);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btnNewToken
            // 
            this.btnNewToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.btnNewToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewToken.Font = new System.Drawing.Font("Ubuntu Mono", 11.25F);
            this.btnNewToken.ForeColor = System.Drawing.Color.White;
            this.btnNewToken.Location = new System.Drawing.Point(32, 92);
            this.btnNewToken.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewToken.Name = "btnNewToken";
            this.btnNewToken.Size = new System.Drawing.Size(119, 40);
            this.btnNewToken.TabIndex = 0;
            this.btnNewToken.Text = "New Token";
            this.btnNewToken.UseVisualStyleBackColor = false;
            this.btnNewToken.Click += new System.EventHandler(this.btnNewToken_Click);
            // 
            // ServiceMainPanel
            // 
            this.ServiceMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.ServiceMainPanel.Location = new System.Drawing.Point(203, 91);
            this.ServiceMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceMainPanel.Name = "ServiceMainPanel";
            this.ServiceMainPanel.Size = new System.Drawing.Size(770, 510);
            this.ServiceMainPanel.TabIndex = 5;
            this.ServiceMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ServiceMainPanel_Paint);
            // 
            // Warranty_AND_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ServiceMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Warranty_AND_Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warranty & Service";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcome_Lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btnNewToken;
        public  System.Windows.Forms.Panel ServiceMainPanel;
    }
}