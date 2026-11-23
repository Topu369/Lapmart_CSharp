namespace LaptopManagement
{
    partial class Report_Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxStats = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.txtbox_increment = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.txtbox_yearly = new System.Windows.Forms.TextBox();
            this.txtbox_monthly = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.gbxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStats
            // 
            this.gbxStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(152)))), ((int)(((byte)(106)))));
            this.gbxStats.Controls.Add(this.label5);
            this.gbxStats.Controls.Add(this.label3);
            this.gbxStats.Controls.Add(this.cmb_year);
            this.gbxStats.Controls.Add(this.txtbox_increment);
            this.gbxStats.Controls.Add(this.cmbMonth);
            this.gbxStats.Controls.Add(this.txtbox_yearly);
            this.gbxStats.Controls.Add(this.txtbox_monthly);
            this.gbxStats.Controls.Add(this.label7);
            this.gbxStats.Controls.Add(this.label2);
            this.gbxStats.Controls.Add(this.label1);
            this.gbxStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStats.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxStats.Location = new System.Drawing.Point(30, 26);
            this.gbxStats.Name = "gbxStats";
            this.gbxStats.Size = new System.Drawing.Size(711, 421);
            this.gbxStats.TabIndex = 16;
            this.gbxStats.TabStop = false;
            this.gbxStats.Text = "Statistics";
            this.gbxStats.Enter += new System.EventHandler(this.gbxStats_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(409, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(174, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Month";
            // 
            // cmb_year
            // 
            this.cmb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Items.AddRange(new object[] {
            "Price (High to Low)",
            "Price (Low to High)"});
            this.cmb_year.Location = new System.Drawing.Point(412, 43);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(124, 24);
            this.cmb_year.TabIndex = 17;
            this.cmb_year.SelectedIndexChanged += new System.EventHandler(this.cmb_year_SelectedIndexChanged);
            // 
            // txtbox_increment
            // 
            this.txtbox_increment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtbox_increment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_increment.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_increment.Location = new System.Drawing.Point(173, 280);
            this.txtbox_increment.Name = "txtbox_increment";
            this.txtbox_increment.ReadOnly = true;
            this.txtbox_increment.Size = new System.Drawing.Size(359, 24);
            this.txtbox_increment.TabIndex = 14;
            this.txtbox_increment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(174, 48);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(124, 24);
            this.cmbMonth.TabIndex = 19;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // txtbox_yearly
            // 
            this.txtbox_yearly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtbox_yearly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_yearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_yearly.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_yearly.Location = new System.Drawing.Point(411, 191);
            this.txtbox_yearly.Name = "txtbox_yearly";
            this.txtbox_yearly.ReadOnly = true;
            this.txtbox_yearly.Size = new System.Drawing.Size(121, 24);
            this.txtbox_yearly.TabIndex = 13;
            this.txtbox_yearly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_monthly
            // 
            this.txtbox_monthly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtbox_monthly.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_monthly.Location = new System.Drawing.Point(173, 191);
            this.txtbox_monthly.Name = "txtbox_monthly";
            this.txtbox_monthly.ReadOnly = true;
            this.txtbox_monthly.Size = new System.Drawing.Size(133, 25);
            this.txtbox_monthly.TabIndex = 12;
            this.txtbox_monthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(171, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "Yearly Increment or Decrement";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(383, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yearly Sale (BDT)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(171, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monthly Sale";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(311, 466);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(139, 23);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Report_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.gbxStats);
            this.Name = "Report_Admin";
            this.Size = new System.Drawing.Size(770, 510);
            this.Load += new System.EventHandler(this.Report_Admin_Load);
            this.gbxStats.ResumeLayout(false);
            this.gbxStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStats;
        private System.Windows.Forms.TextBox txtbox_increment;
        private System.Windows.Forms.TextBox txtbox_yearly;
        private System.Windows.Forms.TextBox txtbox_monthly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnReport;
    }
}
