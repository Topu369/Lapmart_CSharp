namespace LaptopManagement
{
    partial class IndividualSales
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
            this.dgv_IndividualRecord = new System.Windows.Forms.DataGridView();
            this.SaleDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IndividualRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_IndividualRecord
            // 
            this.dgv_IndividualRecord.AllowUserToAddRows = false;
            this.dgv_IndividualRecord.AllowUserToDeleteRows = false;
            this.dgv_IndividualRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_IndividualRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_IndividualRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IndividualRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleDetailID,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.UnitPrice,
            this.SubTotal});
            this.dgv_IndividualRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_IndividualRecord.Location = new System.Drawing.Point(0, 0);
            this.dgv_IndividualRecord.Name = "dgv_IndividualRecord";
            this.dgv_IndividualRecord.ReadOnly = true;
            this.dgv_IndividualRecord.RowHeadersVisible = false;
            this.dgv_IndividualRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_IndividualRecord.Size = new System.Drawing.Size(800, 247);
            this.dgv_IndividualRecord.TabIndex = 39;
            this.dgv_IndividualRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_IndividualRecord_CellContentClick);
            // 
            // SaleDetailID
            // 
            this.SaleDetailID.DataPropertyName = "SaleDetailID";
            this.SaleDetailID.HeaderText = "SaleDetailID";
            this.SaleDetailID.Name = "SaleDetailID";
            this.SaleDetailID.ReadOnly = true;
            this.SaleDetailID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IndividualSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 247);
            this.Controls.Add(this.dgv_IndividualRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IndividualSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order History";
            this.Load += new System.EventHandler(this.IndividualSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IndividualRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_IndividualRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}