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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace LaptopManagement
{
    public partial class employee_Admin : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }

        public employee_Admin()
        {

            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateUserID();
        }

        private void ClearAll()
        {
            this.txtbox_empID.Clear();
            this.txtbox_empID.ReadOnly = true;
            this.txtbox_empName.Clear();
            this.txtbox_empPhone.Clear();
            this.txtbox_empAddress.Clear();
            this.txtbox_empUser.Clear();
            this.txtbox_empPass.Clear();
            GenerateUserID();
        }

        private void GenerateUserID()
        {
            this.Sql = "select * from Users order by UserID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            int n = Convert.ToInt32(Dt.Rows[0]["UserID"]);
            string newID = (++n).ToString();
            this.txtbox_empID.Text = newID;
        }

        private void PopulateGridView(string sql = "select * from Users;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.grid_User.AutoGenerateColumns = false;
            this.grid_User.DataSource = this.Ds.Tables[0];
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            ClearAll();

        }

        private int isUserExist(string Username)
        {


            string checkUniqueUser = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            using (SqlCommand checkCmd = new SqlCommand(checkUniqueUser, this.Da.Sqlcon))
            {
                checkCmd.Parameters.AddWithValue("@Username", Username);
                int userCount = (int)checkCmd.ExecuteScalar();
                return userCount;
            }

        }

        private bool isValidPhoneNumber(string empphone, out long? Phone)
        {
            if(long.TryParse(empphone, out long PhoneNumber))
            {
                if (empphone.Length > 11)
                {
                    MessageBox.Show("Invalid Phone Number");
                    Phone = PhoneNumber;
                    return false;
                }
                else
                {
                    Phone = PhoneNumber;
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Invalid Phone Number");
                Phone = null;
                return true;
            }
               
        }


        private void txtbox_empID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empUser_TextChanged(object sender, EventArgs e)
        {

        }







        // Insert new record to Database from gridview--------------------------------------------------------------------


        //Active
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {

                // ******************************************Checks if everything is okey****************************************

                string empID = this.txtbox_empID.Text?.Trim();
                string empName = this.txtbox_empName.Text?.Trim();
                string empPhone = this.txtbox_empPhone.Text?.Trim();
                string empAddress = this.txtbox_empAddress.Text?.Trim();
                string empUserName = this.txtbox_empUser.Text?.Trim();
                string empPassword = this.txtbox_empPass.Text?.Trim();
                string empRole = this.cmbox_role.Text?.Trim();


                // check if textbox IsNullOrWhiteSpace
                if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(empPhone) || string.IsNullOrWhiteSpace(empRole) ||
                    string.IsNullOrWhiteSpace(empAddress) || string.IsNullOrWhiteSpace(empUserName) ||
                    string.IsNullOrWhiteSpace(empPassword))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Validate phone number format (should be numeric)

                isValidPhoneNumber(empPhone,out long? phoneNumber);

                if (phoneNumber == null) return;
                
                
                // Check if username already exists

                if (isUserExist(empUserName) > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    return;
                }


                // ***************************************************************************************************************



                // Insert new user
                // This qerry is called parametarized querry.

                /*
                 * SqlCommand's obj is compiled with the actual value in the parameters of sqlquerry string, so that the SqlCommand obj can be 
                 * used to invoke methods and execute querry in the db end.
                 * Look -> SqlCommand takes both querry and Sqlcon, so SqlCommand obj knows about the database where the action need to perform.
                 */




                string insertSql = "INSERT INTO Users (FullName, Phone, Address, Username, Password, Role) VALUES (@FullName, @Phone, @Address, @Username, @Password, @Role)";

                using (SqlCommand cmd = new SqlCommand(insertSql, this.Da.Sqlcon))
                {
                    cmd.Parameters.AddWithValue("@FullName", empName);
                    cmd.Parameters.AddWithValue("@Phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@Address", empAddress);
                    cmd.Parameters.AddWithValue("@Username", empUserName);
                    cmd.Parameters.AddWithValue("@Password", empPassword);
                    cmd.Parameters.AddWithValue("@Role", empRole);

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
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        //Active
        private void btn_dlt_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the DataGridView
                if (grid_User.CurrentRow == null)
                {
                    MessageBox.Show("Please select a row to delete.");
                    return;
                }

                // Get the UserID from the selected row
                string userID = grid_User.CurrentRow.Cells["UserID"].Value?.ToString();
                string userName = grid_User.CurrentRow.Cells["FullName"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(userID))
                {
                    MessageBox.Show("Invalid user selected.");
                    return;
                }

                // Show confirmation dialog
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete user '{userName}' (ID: {userID})?\n\nThis action cannot be undone.", "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the user from database
                    string deleteSql = "DELETE FROM Users WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, this.Da.Sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);

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

        //Active
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                //******************************* Checking ******************************************************
                // Check if we're in edit mode (ID field should be read-only and not empty)
                if (this.txtbox_empID.ReadOnly && !string.IsNullOrWhiteSpace(this.txtbox_empID.Text))
                {
                    // Update existing user
                    string userID = this.txtbox_empID.Text.Trim();
                    string empName = this.txtbox_empName.Text?.Trim();
                    string empPhone = this.txtbox_empPhone.Text?.Trim();
                    string empAddress = this.txtbox_empAddress.Text?.Trim();
                    string empUserName = this.txtbox_empUser.Text?.Trim();
                    string empRole = this.cmbox_role.Text?.Trim();

                    // Validate required fields
                    if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(empPhone) || string.IsNullOrWhiteSpace(empRole) ||
                        string.IsNullOrWhiteSpace(empAddress) || string.IsNullOrWhiteSpace(empUserName) )
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }

                    // Validate phone number format
                    isValidPhoneNumber(empPhone, out long? phoneNumber);

                    if (phoneNumber == null) return;

                    // Check if username already exists (excluding current user)
                    if (isUserExist(empUserName)>0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                    }

                    //*********************************************************************************************


                    // Update user
                    string updateSql = "UPDATE Users SET FullName = @FullName, Phone = @Phone, Address = @Address, Username = @Username, Role=@Role WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(updateSql, this.Da.Sqlcon))
                    {
                        
                        cmd.Parameters.AddWithValue("@FullName", empName);
                        cmd.Parameters.AddWithValue("@Phone", phoneNumber);
                        cmd.Parameters.AddWithValue("@Address", empAddress);
                        cmd.Parameters.AddWithValue("@Username", empUserName);
                        cmd.Parameters.AddWithValue("@Role", empRole);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("User updated successfully.");
                            PopulateGridView();
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("No user was updated. Try Again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please double-click on a row to edit a user first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        
        private void cmbox_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grid_User_DoubleClick(object sender, EventArgs e)
        {
            if (grid_User.CurrentRow != null)
            {
                try
                {
                    this.txtbox_empName.ReadOnly = true;
                    this.txtbox_empID.ReadOnly = true;
                    this.txtbox_empPass.ReadOnly = true;
                    this.txtbox_empID.Text = grid_User.CurrentRow.Cells["UserID"].Value?.ToString();
                    this.txtbox_empName.Text = grid_User.CurrentRow.Cells["FullName"].Value?.ToString();
                    this.txtbox_empPhone.Text = grid_User.CurrentRow.Cells["Phone"].Value?.ToString();
                    this.txtbox_empAddress.Text = grid_User.CurrentRow.Cells["Address"].Value?.ToString();
                    this.txtbox_empUser.Text = grid_User.CurrentRow.Cells["Username"].Value?.ToString();
                    this.txtbox_empPass.Text = "**********";
                    this.cmbox_role.Text = grid_User.CurrentRow.Cells["Role"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Employee details: " + ex.Message);
                }
            }
        }

        private void txtbox_test_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee_F_Load(object sender, EventArgs e)
        {

        }

        private void txtlbl_username_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_empName_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_phn_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_ID_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_role_Click(object sender, EventArgs e)
        {

        }

        private void txtlbl_address_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Users where FullName like '" + this.txtbox_search.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void grid_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
