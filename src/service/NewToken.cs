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
    public partial class NewToken : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }
        private string purchaseID { get; set; }
        private bool isWarrantyAvailable { get; set; }
        private DataTable customerTable { get; set; }
        public string customerName { get; set; }
        public string customerPhone { get; set; }
        public string customerID { get; set; }

        public List<string> techniciansList=new List<string>();

        public SqlDataReader sdr;

        public string technicianID;


        public NewToken(bool check = false)
        {
            InitializeComponent();
            Da = new DataAccess();
            isWarrantyAvailable = check;
            technicianList();
            tokenID();
            if (isWarrantyAvailable)
            {
                rdWarranty.Select();
            }
            else
            {
                rdService.Select();
            }
        }

        public void generateCustomerID()
        {
            try
            {
                string sql = "select CustomerID from dbo.customers where Phone='" + txtPhone.Text + "';";
                Dt = this.Da.ExecuteQueryTable(sql);
                customerID = Dt.Rows[0][0].ToString();

            }
            catch (Exception exc)
            {
                return;
            }


        }


        public void technicianList()
        {
            //techniciansList = new List<string>();
            string sql = "select Fullname from dbo.Users where role='Technician'; ";
            using (  SqlCommand cmd = new SqlCommand(sql, this.Da.Sqlcon))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        techniciansList.Add(reader["FullName"].ToString());
                    }
                    reader.Close();
                    cmbTlist.DataSource = techniciansList;
                    
                    
                }

                
            }

            

        }


        // AKA RepairID
        // A TokenLog table was created but later delete, so there are some messeup in naming
        public void tokenID()
        {
            string sql = "select RepairID from dbo.Repairs order by RepairID desc";
            Dt = this.Da.ExecuteQueryTable(sql);
            string id = Dt.Rows[0][0].ToString();
            txtToken.Text = Convert.ToString(Convert.ToInt32(id) + 1);
        }

        // Invoke only when digits are =10
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

        // Invoked when customerSearchResult is clicked
        public void showCustomerNameID()
        {
            txtCustomerName.Text = customerName;
            customerInfoContainer.Visible = false;

        }

        private void NewToken_Load(object sender, EventArgs e)
        {

        }

        private void btnNewToken_Click(object sender, EventArgs e)
        {
            generateCustomerID();
            string sql = "";
            if (rdWarranty.Checked)
            {
                sql = "Insert into dbo.Repairs (CustomerID, ProductID, RepairStatus,TechnicianID, ProblemDescription) values ( @customerID, @productID, 'Pending' ,@tid, @discription)";
            }
            else if (rdService.Checked)
            {
                sql = "Insert into dbo.Repairs (CustomerID, RepairStatus,TechnicianID, ProblemDescription) values ( @customerID, 'Pending' ,@tid, @discription)";
            }

            using (SqlCommand cmd = new SqlCommand(sql, this.Da.Sqlcon))
            {
                cmd.Parameters.AddWithValue("ProductID", txtProductID.Text);
                cmd.Parameters.AddWithValue("@customerID", customerID);
                cmd.Parameters.AddWithValue("@discription", txtDiscription.Text);
                cmd.Parameters.AddWithValue("tid", technicianID);
                int inserted = cmd.ExecuteNonQuery();
                if (inserted == 1)
                {
                    MessageBox.Show("New Token Created");
                }
                else
                {
                    MessageBox.Show("Error creating new token");
                }

                cmd.Parameters.Clear();
            }



        }

        private void clearAll()
        {
            txtProductID.Clear();
            txtCost.Clear();
            txtCustomerName.Clear();
            txtDiscription.Clear();
            txtPhone.Clear();
            txtProductName.Clear();
        }
        private void rdService_CheckedChanged(object sender, EventArgs e)
        {

            clearAll();

            txtPhone.ReadOnly = false;
            txtProductID.ReadOnly = true;
            txtProductName.ReadOnly = false;
            

        }

        private void rdWarranty_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                //MessageBox.Show(" Click on 'Check' button to Add Products with warranty");
                clearAll();

            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.TextLength != 10)
            {

                customerInfoContainer.Visible = false;
                this.customerInfoContainer.Size = new System.Drawing.Size(151, 0);
                txtCustomerName.Text = "";

            }

            else
            {


                if ((int.TryParse(txtPhone.Text, out int phone)))
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

        private void btnAddnewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer(txtPhone.Text);
            temp t = new temp();
            t.Controls.Add(ac);
            t.Show();

        }

        private void cmbTlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            technicianList();
            string sql = "Select UserID from dbo.users where fullname=@name";
            using (SqlCommand cmd = new SqlCommand(sql, this.Da.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@name", cmbTlist.Text);
                object temp = cmd.ExecuteScalar();
                technicianID = Convert.ToString(temp);
            }
        }
    }
}
