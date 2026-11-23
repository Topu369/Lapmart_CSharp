namespace LaptopManagement
{
    partial class Inventory
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
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.txtlbl_search = new System.Windows.Forms.Label();
            this.grid_Inventory = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_search
            // 
            this.txtbox_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtbox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_search.Font = new System.Drawing.Font("Ubuntu Mono Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_search.Location = new System.Drawing.Point(225, 14);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(382, 24);
            this.txtbox_search.TabIndex = 16;
            this.txtbox_search.TextChanged += new System.EventHandler(this.txtbox_search_TextChanged);
            // 
            // txtlbl_search
            // 
            this.txtlbl_search.AutoSize = true;
            this.txtlbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_search.Location = new System.Drawing.Point(164, 16);
            this.txtlbl_search.Name = "txtlbl_search";
            this.txtlbl_search.Size = new System.Drawing.Size(55, 18);
            this.txtlbl_search.TabIndex = 15;
            this.txtlbl_search.Text = "Search";
            // 
            // grid_Inventory
            // 
            this.grid_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Brand,
            this.Model,
            this.Specifications,
            this.QuantityInStock,
            this.UnitPrice,
            this.Warranty});
            this.grid_Inventory.Location = new System.Drawing.Point(15, 47);
            this.grid_Inventory.Name = "grid_Inventory";
            this.grid_Inventory.RowHeadersVisible = false;
            this.grid_Inventory.Size = new System.Drawing.Size(739, 450);
            this.grid_Inventory.TabIndex = 14;
            this.grid_Inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Inventory_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 40;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.Width = 70;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.Width = 110;
            // 
            // Specifications
            // 
            this.Specifications.DataPropertyName = "Specifications";
            this.Specifications.HeaderText = "Specifications";
            this.Specifications.Name = "Specifications";
            this.Specifications.ReadOnly = true;
            this.Specifications.Width = 175;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "Stock";
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.Width = 40;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "PPU";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 50;
            // 
            // Warranty
            // 
            this.Warranty.DataPropertyName = "Warranty";
            this.Warranty.HeaderText = "Warranty";
            this.Warranty.Name = "Warranty";
            this.Warranty.ReadOnly = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.txtlbl_search);
            this.Controls.Add(this.grid_Inventory);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(770, 510);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.Label txtlbl_search;
        private System.Windows.Forms.DataGridView grid_Inventory;
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
