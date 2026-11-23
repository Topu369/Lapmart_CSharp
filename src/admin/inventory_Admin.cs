using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopManagement
{
    public partial class inventory_Admin : Form
    {

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }

        //private void LoadData()
        //{
        //    // Query your Products table
        //    string sql = "SELECT * FROM Products";

        //    // Get DataTable from DataAccess
        //    DataTable dt = this.Da.ExecuteQueryTable(sql);

        //    // Bind it to the DataGridView
        //    grid_Inventory.AutoGenerateColumns = false; // since we are using custom columns
        //    grid_Inventory.DataSource = dt;
        //}

        public inventory_Admin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateProductID();

        }


        // clear all the text boxes.
        private void ClearAll()
        {
            this.txtbox_ID.Clear();
            this.txtbox_ID.ReadOnly = true;
            this.txtbox_prodName.Clear();
            this.txtbox_brand.Clear();
            this.txtbox_model.Clear();
            this.txtbox_price.Clear();
            this.txtbox_stock.Clear();
            this.txtbox_specs.Clear();
            this.txtbox_warranty.Clear();
            GenerateProductID();
        }


        // new product ID when the Inventory form loads or clearing all the fields.
        private void GenerateProductID()
        {
            this.Sql = "select * from Products order by ProductID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            int n = Convert.ToInt32(Dt.Rows[0]["ProductID"]);
            string newID = (++n).ToString(/*"d4"*/);
            this.txtbox_ID.Text = newID;
        }


        private void PopulateGridView(string sql = "select * from Products;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.grid_Inventory.AutoGenerateColumns = false;
            this.grid_Inventory.DataSource = this.Ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inventoryF_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string productId = this.txtbox_ID.Text?.Trim();
                string productName = this.txtbox_prodName.Text?.Trim();
                string brand = this.txtbox_brand.Text?.Trim();
                string model = this.txtbox_model.Text?.Trim();
                string stockText = this.txtbox_stock.Text?.Trim();
                string priceText = this.txtbox_price.Text?.Trim();
                string specs = this.txtbox_specs.Text?.Trim();
                string warrantyr = this.txtbox_warranty.Text?.Trim();

                if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(brand) ||
                    string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(stockText) || string.IsNullOrWhiteSpace(specs) || string.IsNullOrWhiteSpace(warrantyr)||
                    string.IsNullOrWhiteSpace(priceText))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (!int.TryParse(stockText, out int quantityInStock))
                {
                    if (quantityInStock < 0)
                    {
                        MessageBox.Show("Quantity In Stock must be a valid integer.");
                        return;
                    }
                   
                }

                if (!decimal.TryParse(priceText, out decimal unitPrice))
                {
                    if (unitPrice < 0)
                    {
                        MessageBox.Show("Unit Price must be a valid number.");
                        return;
                    }
                    
                }

                bool hasProductId = !string.IsNullOrWhiteSpace(productId);
                string insertSql = "INSERT INTO Products (ProductName, Brand, Model, QuantityInStock, UnitPrice, Specifications, Warranty) VALUES ( @ProductName, @Brand, @Model, @QuantityInStock, @UnitPrice, @Specifications, @Warranty);";
                  

            
                using (SqlCommand cmd = new SqlCommand(insertSql, this.Da.Sqlcon))
                {
                   if (hasProductId)
              
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Brand", brand);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@Specifications", specs);
                    cmd.Parameters.AddWithValue("@Warranty", warrantyr);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Product added successfully.");
                        PopulateGridView();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("No rows were inserted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_brand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtbox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            try
            {
                string productId = this.txtbox_ID.Text?.Trim();
                // check if a product is selected or not.
                if (string.IsNullOrWhiteSpace(productId) && this.grid_Inventory.CurrentRow != null)
                {
                    productId = this.grid_Inventory.CurrentRow.Cells["ProductID"].Value?.ToString()?.Trim();
                }

                if (string.IsNullOrWhiteSpace(productId))
                {
                    MessageBox.Show("Please select a product to delete.");
                    return;
                }

                var confirm = MessageBox.Show($"Delete product {productId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @ProductID;", this.Da.Sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Product deleted.");
                        PopulateGridView();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("No matching product found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string productId = this.txtbox_ID.Text?.Trim();
                if (string.IsNullOrWhiteSpace(productId))
                {
                    MessageBox.Show("ProductID is required to update.");
                    return;
                }

                string productName = this.txtbox_prodName.Text?.Trim();
                string brand = this.txtbox_brand.Text?.Trim();
                string model = this.txtbox_model.Text?.Trim();
                string stockText = this.txtbox_stock.Text?.Trim();
                string priceText = this.txtbox_price.Text?.Trim();
                string specs = this.txtbox_specs.Text?.Trim();
                string warrantyr = this.txtbox_warranty.Text?.Trim();


                if (string.IsNullOrWhiteSpace(specs)||string.IsNullOrWhiteSpace(warrantyr)||string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model) ||string.IsNullOrWhiteSpace(stockText) ||string.IsNullOrWhiteSpace(priceText))
                {
                    MessageBox.Show("Fill all the fields.");
                    return;
                }

                if (!int.TryParse(stockText, out int quantityInStock))
                {
                    MessageBox.Show("Quantity In Stock must be a valid integer.");
                    return;
                }

                if (!decimal.TryParse(priceText, out decimal unitPrice))
                {
                    MessageBox.Show("Unit Price must be a valid number.");
                    return;
                }

                // @xyz means it is a place holder for 
                string update = "UPDATE Products SET Specifications= @Specifications, Warranty= @Warranty, ProductName = @ProductName, Brand = @Brand, Model = @Model, QuantityInStock = @QuantityInStock, UnitPrice = @UnitPrice WHERE ProductID = @ProductID;";

                using (SqlCommand cmd = new SqlCommand(update, this.Da.Sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Brand", brand);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@Specifications", specs);
                    cmd.Parameters.AddWithValue("@Warranty", warrantyr);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Product updated successfully.");
                        PopulateGridView();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("No matching product found to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void grid_Inventory_DoubleClick(object sender, EventArgs e)
        {
            if (grid_Inventory.CurrentRow != null)
            {
                try
                {
                    this.txtbox_ID.ReadOnly = true;
                    this.txtbox_ID.Text = grid_Inventory.CurrentRow.Cells["ProductID"].Value?.ToString();
                    this.txtbox_prodName.Text = grid_Inventory.CurrentRow.Cells["ProductName"].Value?.ToString();
                    this.txtbox_brand.Text = grid_Inventory.CurrentRow.Cells["Brand"].Value?.ToString();
                    this.txtbox_model.Text = grid_Inventory.CurrentRow.Cells["Model"].Value?.ToString();
                    this.txtbox_stock.Text = grid_Inventory.CurrentRow.Cells["QuantityInStock"].Value?.ToString();
                    this.txtbox_price.Text = grid_Inventory.CurrentRow.Cells["UnitPrice"].Value?.ToString();
                    this.txtbox_specs.Text = grid_Inventory.CurrentRow.Cells["Specifications"].Value?.ToString();
                    this.txtbox_warranty.Text = grid_Inventory.CurrentRow.Cells["Warranty"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student details: " + ex.Message);
                }
            }
        }

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Products where ProductName like '" + this.txtbox_search.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void txtbox_specs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
