namespace LaptopManagement
{
    partial class inventory_Admin
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
            this.grid_Inventory = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtlbl_search = new System.Windows.Forms.Label();
            this.txtbox_prodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_brand = new System.Windows.Forms.TextBox();
            this.txtbox_price = new System.Windows.Forms.TextBox();
            this.txtbox_model = new System.Windows.Forms.TextBox();
            this.txtbox_stock = new System.Windows.Forms.TextBox();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txtlbl_ID = new System.Windows.Forms.Label();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.btn_dlt = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtbox_specs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_warranty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Inventory
            // 
            this.grid_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Brand,
            this.Model,
            this.QuantityInStock,
            this.UnitPrice,
            this.Specifications,
            this.Warranty});
            this.grid_Inventory.Location = new System.Drawing.Point(12, 48);
            this.grid_Inventory.Name = "grid_Inventory";
            this.grid_Inventory.RowHeadersVisible = false;
            this.grid_Inventory.Size = new System.Drawing.Size(443, 450);
            this.grid_Inventory.TabIndex = 0;
            this.grid_Inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grid_Inventory.DoubleClick += new System.EventHandler(this.grid_Inventory_DoubleClick);
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
            this.ProductName.Width = 130;
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
            // Specifications
            // 
            this.Specifications.DataPropertyName = "Specifications";
            this.Specifications.HeaderText = "Specifications";
            this.Specifications.Name = "Specifications";
            this.Specifications.ReadOnly = true;
            this.Specifications.Visible = false;
            // 
            // Warranty
            // 
            this.Warranty.DataPropertyName = "Warranty";
            this.Warranty.HeaderText = "Warranty";
            this.Warranty.Name = "Warranty";
            this.Warranty.ReadOnly = true;
            this.Warranty.Visible = false;
            // 
            // txtlbl_search
            // 
            this.txtlbl_search.AutoSize = true;
            this.txtlbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_search.Location = new System.Drawing.Point(12, 17);
            this.txtlbl_search.Name = "txtlbl_search";
            this.txtlbl_search.Size = new System.Drawing.Size(55, 18);
            this.txtlbl_search.TabIndex = 1;
            this.txtlbl_search.Text = "Search";
            // 
            // txtbox_prodName
            // 
            this.txtbox_prodName.BackColor = System.Drawing.Color.White;
            this.txtbox_prodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_prodName.Location = new System.Drawing.Point(583, 57);
            this.txtbox_prodName.Name = "txtbox_prodName";
            this.txtbox_prodName.Size = new System.Drawing.Size(164, 24);
            this.txtbox_prodName.TabIndex = 2;
            this.txtbox_prodName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock";
            // 
            // txtbox_brand
            // 
            this.txtbox_brand.BackColor = System.Drawing.Color.White;
            this.txtbox_brand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_brand.Location = new System.Drawing.Point(583, 95);
            this.txtbox_brand.Name = "txtbox_brand";
            this.txtbox_brand.Size = new System.Drawing.Size(164, 24);
            this.txtbox_brand.TabIndex = 9;
            this.txtbox_brand.TextChanged += new System.EventHandler(this.txtbox_brand_TextChanged);
            // 
            // txtbox_price
            // 
            this.txtbox_price.BackColor = System.Drawing.Color.White;
            this.txtbox_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_price.Location = new System.Drawing.Point(583, 179);
            this.txtbox_price.Name = "txtbox_price";
            this.txtbox_price.Size = new System.Drawing.Size(164, 24);
            this.txtbox_price.TabIndex = 11;
            this.txtbox_price.TextChanged += new System.EventHandler(this.txtbox_price_TextChanged);
            // 
            // txtbox_model
            // 
            this.txtbox_model.BackColor = System.Drawing.Color.White;
            this.txtbox_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_model.Location = new System.Drawing.Point(583, 141);
            this.txtbox_model.Name = "txtbox_model";
            this.txtbox_model.Size = new System.Drawing.Size(164, 24);
            this.txtbox_model.TabIndex = 10;
            this.txtbox_model.TextChanged += new System.EventHandler(this.txtbox_model_TextChanged);
            // 
            // txtbox_stock
            // 
            this.txtbox_stock.BackColor = System.Drawing.Color.White;
            this.txtbox_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_stock.Location = new System.Drawing.Point(583, 220);
            this.txtbox_stock.Name = "txtbox_stock";
            this.txtbox_stock.Size = new System.Drawing.Size(164, 24);
            this.txtbox_stock.TabIndex = 12;
            this.txtbox_stock.TextChanged += new System.EventHandler(this.txtbox_stock_TextChanged);
            // 
            // txtbox_search
            // 
            this.txtbox_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtbox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_search.Font = new System.Drawing.Font("Ubuntu Mono Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_search.Location = new System.Drawing.Point(73, 15);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(382, 24);
            this.txtbox_search.TabIndex = 13;
            this.txtbox_search.TextChanged += new System.EventHandler(this.txtbox_search_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.Location = new System.Drawing.Point(478, 395);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(269, 37);
            this.btn_clearAll.TabIndex = 17;
            this.btn_clearAll.Text = "Clear All";
            this.btn_clearAll.UseVisualStyleBackColor = true;
            this.btn_clearAll.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(478, 456);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 37);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txtlbl_ID
            // 
            this.txtlbl_ID.AutoSize = true;
            this.txtlbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_ID.Location = new System.Drawing.Point(475, 19);
            this.txtlbl_ID.Name = "txtlbl_ID";
            this.txtlbl_ID.Size = new System.Drawing.Size(78, 18);
            this.txtlbl_ID.TabIndex = 21;
            this.txtlbl_ID.Text = "Product ID";
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.BackColor = System.Drawing.Color.White;
            this.txtbox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_ID.Location = new System.Drawing.Point(583, 19);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.ReadOnly = true;
            this.txtbox_ID.Size = new System.Drawing.Size(164, 24);
            this.txtbox_ID.TabIndex = 20;
            this.txtbox_ID.TextChanged += new System.EventHandler(this.txtbox_ID_TextChanged);
            // 
            // btn_dlt
            // 
            this.btn_dlt.Location = new System.Drawing.Point(672, 456);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(75, 37);
            this.btn_dlt.TabIndex = 22;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = true;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(577, 456);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 37);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Save and Update";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtbox_specs
            // 
            this.txtbox_specs.BackColor = System.Drawing.Color.White;
            this.txtbox_specs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_specs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_specs.Location = new System.Drawing.Point(583, 257);
            this.txtbox_specs.Multiline = true;
            this.txtbox_specs.Name = "txtbox_specs";
            this.txtbox_specs.Size = new System.Drawing.Size(164, 88);
            this.txtbox_specs.TabIndex = 25;
            this.txtbox_specs.TextChanged += new System.EventHandler(this.txtbox_specs_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Specification";
            // 
            // txtbox_warranty
            // 
            this.txtbox_warranty.BackColor = System.Drawing.Color.White;
            this.txtbox_warranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_warranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_warranty.Location = new System.Drawing.Point(583, 351);
            this.txtbox_warranty.Name = "txtbox_warranty";
            this.txtbox_warranty.Size = new System.Drawing.Size(164, 24);
            this.txtbox_warranty.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Warranty(Days)";
            // 
            // inventory_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 510);
            this.Controls.Add(this.txtbox_warranty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_specs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.txtlbl_ID);
            this.Controls.Add(this.txtbox_ID);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_clearAll);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.txtbox_stock);
            this.Controls.Add(this.txtbox_price);
            this.Controls.Add(this.txtbox_model);
            this.Controls.Add(this.txtbox_brand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_prodName);
            this.Controls.Add(this.txtlbl_search);
            this.Controls.Add(this.grid_Inventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventory_Admin";
            this.Text = "inventoryF";
            this.Load += new System.EventHandler(this.inventoryF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Inventory;
        private System.Windows.Forms.Label txtlbl_search;
        private System.Windows.Forms.TextBox txtbox_prodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_brand;
        private System.Windows.Forms.TextBox txtbox_price;
        private System.Windows.Forms.TextBox txtbox_model;
        private System.Windows.Forms.TextBox txtbox_stock;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label txtlbl_ID;
        private System.Windows.Forms.TextBox txtbox_ID;
        private System.Windows.Forms.Button btn_dlt;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txtbox_specs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_warranty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warranty;
    }
}