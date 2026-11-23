namespace LaptopManagement
{
    partial class productSearchResult
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
            this.dgv_ProductSearchResult = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAdd2Cart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ProductSearchResult
            // 
            this.dgv_ProductSearchResult.AllowUserToResizeColumns = false;
            this.dgv_ProductSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ProductSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Brand,
            this.Model,
            this.Specifications,
            this.QuantityInStock,
            this.UnitPrice,
            this.Warranty});
            this.dgv_ProductSearchResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_ProductSearchResult.Location = new System.Drawing.Point(0, 0);
            this.dgv_ProductSearchResult.Name = "dgv_ProductSearchResult";
            this.dgv_ProductSearchResult.RowHeadersVisible = false;
            this.dgv_ProductSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductSearchResult.Size = new System.Drawing.Size(693, 197);
            this.dgv_ProductSearchResult.TabIndex = 0;
            this.dgv_ProductSearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductSearchResult_CellContentClick_1);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 290;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Visible = false;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Specifications
            // 
            this.Specifications.DataPropertyName = "Specifications";
            this.Specifications.HeaderText = "Specifications";
            this.Specifications.Name = "Specifications";
            this.Specifications.ReadOnly = true;
            this.Specifications.Visible = false;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "Stock";
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.ReadOnly = true;
            this.QuantityInStock.Width = 98;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Warranty
            // 
            this.Warranty.DataPropertyName = "Warranty";
            this.Warranty.HeaderText = "Warranty";
            this.Warranty.Name = "Warranty";
            this.Warranty.ReadOnly = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnAdd2Cart
            // 
            this.btnAdd2Cart.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd2Cart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd2Cart.Location = new System.Drawing.Point(0, 174);
            this.btnAdd2Cart.Name = "btnAdd2Cart";
            this.btnAdd2Cart.Size = new System.Drawing.Size(693, 23);
            this.btnAdd2Cart.TabIndex = 1;
            this.btnAdd2Cart.Text = "Add to Cart";
            this.btnAdd2Cart.UseVisualStyleBackColor = false;
            this.btnAdd2Cart.Click += new System.EventHandler(this.btnAdd2Cart_Click);
            // 
            // productSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd2Cart);
            this.Controls.Add(this.dgv_ProductSearchResult);
            this.Name = "productSearchResult";
            this.Size = new System.Drawing.Size(693, 197);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_ProductSearchResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAdd2Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warranty;
    }
}
