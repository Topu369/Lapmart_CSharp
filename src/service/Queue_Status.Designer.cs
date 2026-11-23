namespace LaptopManagement
{
    partial class Queue_Status
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
            this.dgv_QueueLog = new System.Windows.Forms.DataGridView();
            this.RepairID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechnicianID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QueueLog)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_QueueLog
            // 
            this.dgv_QueueLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QueueLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RepairID,
            this.CustomerID,
            this.TechnicianID,
            this.ProductID,
            this.ProblemDescription,
            this.RepairStatus,
            this.Cost,
            this.CreatedAt,
            this.CompletedAt});
            this.dgv_QueueLog.Location = new System.Drawing.Point(0, 68);
            this.dgv_QueueLog.Name = "dgv_QueueLog";
            this.dgv_QueueLog.RowHeadersVisible = false;
            this.dgv_QueueLog.Size = new System.Drawing.Size(770, 442);
            this.dgv_QueueLog.TabIndex = 0;
            // 
            // RepairID
            // 
            this.RepairID.DataPropertyName = "RepairID";
            this.RepairID.HeaderText = "RepairID";
            this.RepairID.Name = "RepairID";
            this.RepairID.ReadOnly = true;
            this.RepairID.Width = 60;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 70;
            // 
            // TechnicianID
            // 
            this.TechnicianID.DataPropertyName = "TechnicianID";
            this.TechnicianID.HeaderText = "TechnicianID";
            this.TechnicianID.Name = "TechnicianID";
            this.TechnicianID.ReadOnly = true;
            this.TechnicianID.Width = 80;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 60;
            // 
            // ProblemDescription
            // 
            this.ProblemDescription.DataPropertyName = "ProblemDescription";
            this.ProblemDescription.HeaderText = "ProblemDescription";
            this.ProblemDescription.Name = "ProblemDescription";
            this.ProblemDescription.ReadOnly = true;
            this.ProblemDescription.Width = 165;
            // 
            // RepairStatus
            // 
            this.RepairStatus.DataPropertyName = "RepairStatus";
            this.RepairStatus.HeaderText = "RepairStatus";
            this.RepairStatus.Name = "RepairStatus";
            this.RepairStatus.ReadOnly = true;
            this.RepairStatus.Width = 80;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 50;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "CreatedAt";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // CompletedAt
            // 
            this.CompletedAt.DataPropertyName = "CompletedAt";
            this.CompletedAt.HeaderText = "CompletedAt";
            this.CompletedAt.Name = "CompletedAt";
            this.CompletedAt.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(39, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 30);
            this.panel1.TabIndex = 26;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(8, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(651, 16);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.Text = "Search By RepairID";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LaptopManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(664, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Queue_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_QueueLog);
            this.Name = "Queue_Status";
            this.Size = new System.Drawing.Size(770, 510);
            this.Load += new System.EventHandler(this.Queue_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QueueLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QueueLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnicianID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletedAt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
