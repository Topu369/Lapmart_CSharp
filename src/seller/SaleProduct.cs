using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LaptopManagement
{
    public partial class SaleProduct : UserControl
    {

        private DataAccess Da { get; set; }
        private string Sql { get; set; }

        private DataTable productTable { get; set; }
        public DataTable cartTable { get; set; }
        private DataTable customerTable { get; set; }

        public string SalerID { get; set; }
        public string customerName { get; set; }
        public string customerPhone { get; set; }
        public bool customerSelected { get; set; }
        public productSearchResult psr { get; set; }


        // Update in Sale, SaleDetails, Products table.
        private int SaleID { get; set; }
        private int SaleDetailID { get; set; }
        //private int Quantity { get; set; }
        private int CustomerID { get; set; }

        private int updatedSuccessfully = 0;
        private List<string> addedItem;

        public SaleProduct(string s)
        {

            InitializeComponent();
            this.customerInfoContainer.Visible = false;
            this.productResultContainer.Visible = false;
            this.Da = new DataAccess();
            this.SalerID = s;
            this.interactionContainer.Enabled = false;

            cartTable = new DataTable();
            psr = new productSearchResult();

            foreach (DataGridViewColumn col in psr.dgv_ProductSearchResult.Columns)
            {
                cartTable.Columns.Add(col.Name);

            }
            cartTable.Columns.Add("Quantity");
            cartTable.Columns.Add("Subtotal");

            addedItem = new List<string>();

            PopulateGridView();
        }


        private bool checkAvaiableQuantity()
        {
            int quantity = Convert.ToInt32(nudQuantity.Value);
            int stock = Convert.ToInt32(cartTable.Rows[dgv_Cart.CurrentRow.Index]["QuantityInStock"]);
            if (quantity > stock) { return false; }
            else
            {
                return true;
            }


        }
        private void setCustomerID()
        {
            string sql = "select [CustomerID] from [LapMart].[dbo].[Customers] where Phone=@phone";
            using (SqlCommand cmd = new SqlCommand(sql, Da.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@phone", customerPhone);
                CustomerID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            interactionContainer.Enabled = true;
        }
        private bool searchCustomer(string phoneNum)
        {


            string sql = "Select * from dbo.Customers where Phone=@phone";

            using (SqlCommand cmd = new SqlCommand(sql, Da.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@phone", phoneNum);
                customerTable = Da.ExecuteQueryTable(cmd);

            }


            if (customerTable.Rows.Count > 0)
            {
                customerName = customerTable.Rows[0]["FullName"].ToString();
                customerPhone = customerTable.Rows[0]["Phone"].ToString();
                return true;
            }

            else
            {
                return false;
            }
        }
        public void showCustomerName()
        {

            this.customerInfoContainer.Visible = false;
            lblCustomerName.Text = customerName;
            setCustomerID();
        }


        public void addToCart()
        {

            // filter kortese
            if (addedItem.Count !=0 )
            {
                foreach (string test in addedItem)
                {
                    if (psr.dgv_ProductSearchResult.CurrentRow.Cells["ProductID"].Value.ToString() == test)
                    {
                        MessageBox.Show("Already added to the Cart");
                        return;
                    }
                }
            }


            string pid;
            foreach (DataGridViewRow row in psr.dgv_ProductSearchResult.SelectedRows)
            {
                DataRow dRow = cartTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;

                }
                dRow["Quantity"] = 1;
                dRow["Subtotal"] = row.Cells["UnitPrice"].Value;

                pid = dRow["ProductID"].ToString();
                

                cartTable.Rows.Add(dRow);

                addedItem.Add(pid);


            }





        }
        private void PopulateGridView()
        {

            this.dgv_Cart.AutoGenerateColumns = false;
            this.dgv_Cart.DataSource = this.cartTable;
        }

        private void ClearAll()
        {
            this.cartTable.Clear();

            this.txtProductID.Clear();
            this.txtSearch.Clear();
            this.txtUnitPrice.Clear();
            this.txtProductName.Clear();
            this.nudQuantity.Text = "0";
            this.txtSearch.Clear();
            this.txtTotal.Clear();
            this.txtModel.Clear();
            this.txtSpecs.Clear();



        }
        private void GenerateSaleID()
        {
            this.Sql = "select * from [LapMart].[dbo].[Sales] order by SaleID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            if (Dt.Rows.Count > 0)
            {
                SaleID = Convert.ToInt32(Dt.Rows[0]["SaleID"]);
            }

        }

        private void CountTotalPrice()
        {
            int count;
            double total = 0;
            count = this.dgv_Cart.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                double quantity = Convert.ToDouble(this.dgv_Cart.Rows[i].Cells["Quantity"].Value?.ToString());
                double unitprice = Convert.ToDouble(this.dgv_Cart.Rows[i].Cells["UnitPrice"].Value?.ToString());
                total += quantity * unitprice;
            }
            this.txtTotal.Text = total.ToString();
        }
        private double CountSubTotal(int quantity, double unitprice)
        {

            return quantity * unitprice;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void modifySaleDetailsTable()
        {
            GenerateSaleID();
            foreach (DataRow dr in cartTable.Rows)
            {
                string productID = dr["ProductID"].ToString();
                string quantity = dr["Quantity"].ToString();
                string unitprice = dr["UnitPrice"].ToString();

                string sql = "Insert Into [LapMart].[dbo].[SaleDetails] (SaleID, ProductID, Quantity, UnitPrice) VALUES (@saleID, @productID, @quantity, @unitprice)";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, this.Da.Sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@saleID", SaleID);
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@unitprice", unitprice);

                        int insert = cmd.ExecuteNonQuery();
                        if (insert > 0)
                        {
                            updatedSuccessfully = 3;
                        }
                        else
                        {
                            updatedSuccessfully = 0;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                    {
                        MessageBox.Show($"Error #{error.Number}: {error.Message}");
                    }
                }




            }

        }

        private void modifySaleTable()
        {
            string sql = "INSERT INTO [LapMart].[dbo].[Sales] (UserID, CustomerID, TotalAmount) VALUES (@SellerID, @CustomerID, @TotalAmount )";
            using (SqlCommand cmd = new SqlCommand(sql, this.Da.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@SellerID", SalerID);
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@TotalAmount", txtTotal.Text);

                try 
                {
                    int? insert = cmd.ExecuteNonQuery();

                    if (insert > 0 && insert != null)
                    {
                        updatedSuccessfully = 2;
                    }
                    else
                    {
                        updatedSuccessfully = 0;
                    }

                }
                catch(Exception exc)
                {
                    MessageBox.Show("Cart is empty");
                }
                
            }

        }

        private void updateProductTable()
        {
            int test = cartTable.Rows.Count;
            int text1 = test;

            for (int i = 0; i < cartTable.Rows.Count; i++)
            {

                string prodID = Convert.ToString(cartTable.Rows[0]["ProductID"]);


                DataRow[] dr = productTable.Select("ProductID=" + prodID);
                int quantity = Convert.ToInt32(dr[0]["QuantityInStock"]) - Convert.ToInt32(cartTable.Rows[0]["Quantity"]);


                string sql = "Update Products SET QuantityInStock=@quantity WHERE ProductID=@prodID";
                using (SqlCommand cmd = new SqlCommand(sql, Da.Sqlcon))
                {

                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@prodID", prodID);

                    int updated = cmd.ExecuteNonQuery();

                    if (updated > 0)
                    {
                        updatedSuccessfully = 1;
                    }
                    else
                    {
                        updatedSuccessfully = 0;
                    }


                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            updateProductTable();
            modifySaleTable();
            modifySaleDetailsTable();


            if (updatedSuccessfully == 3)
            {
                MessageBox.Show(" Purchase Confirmed ");
                cartTable.Clear();
            }
            else
            {
                MessageBox.Show("There is an error", "Error");
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            this.Sql = "select * from dbo.Products where ProductName like '" + this.txtSearch.Text + "%';";
            productTable = Da.ExecuteQueryTable(Sql);
            psr.populateGridview(productTable, this);

            productResultContainer.Controls.Clear();
            productResultContainer.Controls.Add(psr);
            psr.Dock = DockStyle.Fill;
            this.productResultContainer.Visible = true;
            this.productResultContainer.Size = new System.Drawing.Size(693, 250);

            this.dgv_Cart.DataSource = this.cartTable;


            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                this.productResultContainer.Visible = false;
            }


        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaleProduct_Load(object sender, EventArgs e)
        {

        }
        private void dgvProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productResultContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            int count=0;
            count++;
            if (txtPhone.TextLength != 10)
            {

                customerInfoContainer.Visible = false;
                this.customerInfoContainer.Size = new System.Drawing.Size(151, 0);
                lblCustomerName.Text = "_ _ _";
                customerName = "";
                interactionContainer.Enabled = false;
            }

            else
            {

                
                if ((long.TryParse(txtPhone.Text, out long phone)))
                {
                    bool available = searchCustomer(phone.ToString());

                    if (available)
                    {
                        customerInfoContainer.Visible = true;
                        this.customerInfoContainer.Size = new System.Drawing.Size(151, 94);

                        customerSearchResult csr = new customerSearchResult(this);
                        csr.lblCustomerName.Text = customerName;
                        csr.lblPhone.Text = customerPhone;
                        customerInfoContainer.Controls.Clear();
                        csr.Dock = DockStyle.Fill;
                        customerInfoContainer.Controls.Add(csr);
                    }

                    else
                    {
                        customerInfoContainer.Visible = true;
                        this.customerInfoContainer.Size = new System.Drawing.Size(151, 94);
                        customerInfoContainer.Controls.Clear();
                        pnl_CustomerNotAvailable.Dock = DockStyle.Fill;
                        customerInfoContainer.Controls.Add(pnl_CustomerNotAvailable);


                    }
                }

                else
                {
                    customerInfoContainer.Visible = false;

                }

            }

        }

        public void initialBoxContents()
        {
            int lastIndex = cartTable.Rows.Count - 1;
            txtProductID.Text = cartTable.Rows[lastIndex]["ProductID"].ToString();
            txtProductName.Text = cartTable.Rows[lastIndex]["ProductName"].ToString();
            txtModel.Text = cartTable.Rows[lastIndex]["Model"].ToString();
            txtSpecs.Text = cartTable.Rows[lastIndex]["Specifications"].ToString();
            txtUnitPrice.Text = cartTable.Rows[lastIndex]["UnitPrice"].ToString();
            nudQuantity.Value = Convert.ToDecimal(cartTable.Rows[lastIndex]["Quantity"]);
        }

        private void dgv_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtProductID.Text = dgv_Cart.CurrentRow.Cells["ProductID"].Value.ToString();
                txtProductName.Text = dgv_Cart.CurrentRow.Cells["ProductName"].Value.ToString();
                txtModel.Text = dgv_Cart.CurrentRow.Cells["Model"].Value.ToString();
                txtSpecs.Text = dgv_Cart.CurrentRow.Cells["Specifications"].Value.ToString();
                txtUnitPrice.Text = dgv_Cart.CurrentRow.Cells["UnitPrice"].Value.ToString();
                nudQuantity.Value = Convert.ToDecimal(dgv_Cart.CurrentRow.Cells["Quantity"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add a product first");
                return;
            }

        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {

            if (nudQuantity.Value >= 1)
            {

                if (checkAvaiableQuantity())
                {
                    if (dgv_Cart.CurrentRow != null)
                    {

                        cartTable.Rows[dgv_Cart.CurrentRow.Index]["Quantity"] = nudQuantity.Value;
                        //dgv_Cart.CurrentRow.Cells["Quantity"].Value = nudQuantity.Value;

                        int quantity = Convert.ToInt32(cartTable.Rows[dgv_Cart.CurrentRow.Index]["Quantity"]);
                        double unitprice = Convert.ToDouble(cartTable.Rows[dgv_Cart.CurrentRow.Index]["UnitPrice"]);
                        CountTotalPrice();
                        cartTable.Rows[dgv_Cart.CurrentRow.Index]["Subtotal"] = CountSubTotal(quantity, unitprice);
                        dgv_Cart.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Not enough quantity in stock");
                    nudQuantity.Value = Convert.ToDecimal(cartTable.Rows[dgv_Cart.CurrentRow.Index]["QuantityInStock"]);
                    return;
                }

            }

            else
            {
                if (cartTable.Rows.Count == 0 || dgv_Cart.Rows.Count == 0)
                {
                    nudQuantity.Value = 0;
                    return;
                }

                else
                {
                    MessageBox.Show("At least one unit is required");
                    nudQuantity.Value = 1;
                }

            }

        }

        private void SaleProduct_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (dgv_Cart.RowCount == 0)
            {
                MessageBox.Show("Noting to Remove. Select Item first");
                return;
            }
            cartTable.Rows[dgv_Cart.CurrentRow.Index].Delete();
            dgv_Cart.Refresh();

            if (dgv_Cart.Rows.Count == 1)
            {
                ClearAll();
            }
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void interactionContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            temp t = new temp();
            AddCustomer ac = new AddCustomer(txtPhone.Text);
            t.Controls.Add(ac);
            ac.Dock = DockStyle.Fill;
            t.Show();
        }
    }
}
