namespace LaptopManagement
{
    partial class dashboard_T
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRepairStatus = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtRepairID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QueueLog)).BeginInit();
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
            this.dgv_QueueLog.Location = new System.Drawing.Point(0, 0);
            this.dgv_QueueLog.Name = "dgv_QueueLog";
            this.dgv_QueueLog.RowHeadersVisible = false;
            this.dgv_QueueLog.Size = new System.Drawing.Size(770, 317);
            this.dgv_QueueLog.TabIndex = 1;
            this.dgv_QueueLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QueueLog_CellContentClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(38, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repair Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(38, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost";
            // 
            // cmbRepairStatus
            // 
            this.cmbRepairStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbRepairStatus.FormattingEnabled = true;
            this.cmbRepairStatus.Items.AddRange(new object[] {
            "In Progress",
            "Pending",
            "Completed",
            "Not Fixable"});
            this.cmbRepairStatus.Location = new System.Drawing.Point(151, 370);
            this.cmbRepairStatus.Name = "cmbRepairStatus";
            this.cmbRepairStatus.Size = new System.Drawing.Size(145, 28);
            this.cmbRepairStatus.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCost.Location = new System.Drawing.Point(151, 440);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(145, 26);
            this.txtCost.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDate.Location = new System.Drawing.Point(151, 404);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(145, 26);
            this.txtDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(38, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Date";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.Location = new System.Drawing.Point(331, 464);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 31);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Status";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtRepairID
            // 
            this.txtRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRepairID.Location = new System.Drawing.Point(151, 336);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.ReadOnly = true;
            this.txtRepairID.Size = new System.Drawing.Size(145, 26);
            this.txtRepairID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(38, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Repair ID";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiscription.Location = new System.Drawing.Point(322, 355);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.ReadOnly = true;
            this.txtDiscription.Size = new System.Drawing.Size(193, 67);
            this.txtDiscription.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(321, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Problem Discription";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNotes.Location = new System.Drawing.Point(557, 355);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(193, 67);
            this.txtNotes.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(556, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Notes";
            // 
            // dashboard_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRepairID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.cmbRepairStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_QueueLog);
            this.Name = "dashboard_T";
            this.Size = new System.Drawing.Size(770, 510);
            this.Load += new System.EventHandler(this.dashboard_T_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QueueLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRepairStatus;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtRepairID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label6;
    }
}
