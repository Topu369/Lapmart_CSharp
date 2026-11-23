using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopManagement
{
    public partial class AddCustomer : UserControl
    {

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }
        public AddCustomer(string phone)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.txtbox_CustomerPhone.Text = phone;
            PopulateGridView();

           
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void ClearAll()
        {
            this.txtbox_CustomerName.Clear();
            this.txtbox_CustomerName.Clear();
            this.txtbox_CustomerPhone.Clear();
            this.txtbox_CustomerAddress.Clear();
            this.txtbox_CustomerEmail.Clear();
            this.txtbox_search.Clear();
        }

        

        private void PopulateGridView(string sql = "select * from Customers;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.grid_Customer.AutoGenerateColumns = false;
            this.grid_Customer.DataSource = this.Ds.Tables[0];
        }

        private void txtbox_CustomerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_CustomerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_CustomerPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlbl_username_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_address_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_empName_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_CustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlbl_phn_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {
          
            if(this.txtbox_search.Text=="") 
            {
                this.PopulateGridView();
            }

            this.Sql = "select * from Customers where Phone = '" + this.txtbox_search.Text + "';";
            this.PopulateGridView(this.Sql);
        }

        private void grid_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbox_search_Enter(object sender, EventArgs e)
        {
            this.Sql = "select * from Customers where Phone = '" + this.txtbox_search.Text + "';";
            this.PopulateGridView(this.Sql);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if we're in edit mode (ID field should be read-only and not empty)
                if ( ! string.IsNullOrWhiteSpace(this.txtbox_CustomerPhone.Text) && !string.IsNullOrWhiteSpace(this.txtbox_CustomerName.Text))
                {
                    // Update existing user
                    
                    string customerName = this.txtbox_CustomerName.Text?.Trim();
                    string customerPhone = this.txtbox_CustomerPhone.Text?.Trim();
                    string customerAddress = this.txtbox_CustomerAddress.Text?.Trim();
                    string customerEmail = this.txtbox_CustomerEmail.Text?.Trim();
                    string customerID = grid_Customer.CurrentRow.Cells["CustomerID"].Value?.ToString();



                    // Validate required fields
                    if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerPhone) ||
                        string.IsNullOrWhiteSpace(customerAddress) )
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }

                   
                   

                  // Update user
                    string updateSql = "UPDATE Customers SET FullName = @FullName, Phone = @Phone, Address = @Address, Email= @Email WHERE CustomerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(updateSql, this.Da.Sqlcon))
                    {
                        
                        cmd.Parameters.AddWithValue("@FullName", customerName);
                        cmd.Parameters.AddWithValue("@Phone", customerPhone);
                        cmd.Parameters.AddWithValue("@Address", customerAddress);
                        cmd.Parameters.AddWithValue("@Email", customerEmail);
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Customer updated successfully.");
                            PopulateGridView();
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("No customer information was updated.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please double-click on a row to edit a customer first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the DataGridView
                if (grid_Customer.CurrentRow == null)
                {
                    MessageBox.Show("Please select a row to delete.");
                    return;
                }

                // Get the UserID from the selected row
                string customerID = grid_Customer.CurrentRow.Cells["CustomerID"].Value?.ToString();
                string customerName = grid_Customer.CurrentRow.Cells["FullName"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(customerID))
                {
                    MessageBox.Show("Invalid user selected.");
                    return;
                }

                // Show confirmation dialog
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete user '{customerName}' (ID: {customerName})?\n\nThis action cannot be undone.", "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the user from database
                    string deleteSql = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, this.Da.Sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("User deleted successfully.");
                            PopulateGridView(); // Refresh the grid
                            ClearAll(); // Clear the form fields
                        }
                        else
                        {
                            MessageBox.Show("No user was deleted. The user may have already been removed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if we're in edit mode (ID field should be read-only and not empty)
                if (!string.IsNullOrWhiteSpace(this.txtbox_CustomerPhone.Text) && !string.IsNullOrWhiteSpace(this.txtbox_CustomerName.Text))
                {
                    // Update existing user

                    string customerName = this.txtbox_CustomerName.Text?.Trim();
                    string customerPhone = this.txtbox_CustomerPhone.Text?.Trim();
                    string customerAddress = this.txtbox_CustomerAddress.Text?.Trim();
                    string customerEmail = this.txtbox_CustomerEmail.Text?.Trim();



                    // Validate required fields
                    if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerPhone) )
                    {
                        MessageBox.Show("Please fill in required fields.");
                        return;
                    }


                    // Check if customer already exists (excluding current user)
                    string checkUserSql = "SELECT COUNT(*) FROM Customers WHERE Phone = @Phone ";
                    using (SqlCommand checkCmd = new SqlCommand(checkUserSql, this.Da.Sqlcon))
                    {
                        checkCmd.Parameters.AddWithValue("@Phone", customerPhone);
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.");
                            return;
                        }
                    }

                    string insertSql = "INSERT INTO Customers (FullName, Phone, Address, Email) VALUES (@FullName, @Phone, @Address, @Email)";

                    using (SqlCommand cmd = new SqlCommand(insertSql, this.Da.Sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@FullName", customerName);
                        cmd.Parameters.AddWithValue("@Phone", customerPhone);
                        cmd.Parameters.AddWithValue("@Address", customerAddress);
                        cmd.Parameters.AddWithValue("@Email", customerEmail);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Employee added successfully.");
                            PopulateGridView();
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void grid_Customer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_Customer_DoubleClick(object sender, EventArgs e)
        {
            if (grid_Customer.CurrentRow != null)
            {
                try
                {
                   
                    this.txtbox_CustomerPhone.Text = grid_Customer.CurrentRow.Cells["Phone"].Value?.ToString();
                    this.txtbox_CustomerName.Text = grid_Customer.CurrentRow.Cells["FullName"].Value?.ToString();
                    this.txtbox_CustomerAddress.Text = grid_Customer.CurrentRow.Cells["Address"].Value?.ToString();
                    this.txtbox_CustomerEmail.Text = grid_Customer.CurrentRow.Cells["Email"].Value?.ToString();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student details: " + ex.Message);
                }
            }
        }
    }
}
