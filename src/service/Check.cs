using System;
using System.CodeDom;
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
    public partial class Check : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }
        private string purchaseID { get; set; }
        private bool isWarrantyAvailable { get; set; }
        private Panel ServiceMainP { get; set; }


        public Check(Panel p)
        {
            InitializeComponent();
            Da = new DataAccess();
            btnNewToken.Enabled = false;
            ServiceMainP = p;
        }

        public void populateGrid(string s)
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(s);
                this.dgv_SaleDetails.AutoGenerateColumns = false;
                this.dgv_SaleDetails.DataSource = this.Ds.Tables[0];
                purchaseID = Ds.Tables[0].Rows[0]["SaleDetailID"].ToString();
                
            }
            catch (Exception exe)
            {
                MessageBox.Show("Purchase ID Must be in digits");
                return;
            }
            
        }

        
        public void populateBoxes()
        {
            DataTable dt = new DataTable();
            txtPurchaseID.Text = purchaseID;
            string sql = "select CustomerID, FullName from dbo.Customers where CustomerID= (select CustomerID from dbo.Sales where SaleID=(select SaleID from dbo.SaleDetails where SaleDetailID="+ purchaseID +") );";
            dt = Da.ExecuteQueryTable(sql);
            txtCustomerID.Text = dt.Rows[0]["CustomerID"].ToString();
            txtCustomerName.Text = dt.Rows[0]["FullName"].ToString();

            sql = "select sd.ProductID, p.ProductName, p.Model from SaleDetails sd inner join dbo.Products p on sd.ProductID=p.ProductID where sd.SaleDetailID="+purchaseID+";";
            dt = Da.ExecuteQueryTable(sql);
            txtProductID.Text = dt.Rows[0]["ProductID"].ToString();
            txtProductName.Text = dt.Rows[0]["ProductName"].ToString();
            txtModel.Text = dt.Rows[0]["Model"].ToString();

            sql = "select Format(SaleDate,'dd/MM/yyyy') as SaleDate from dbo.Sales where SaleID=(select SaleID from dbo.SaleDetails where SaleDetailID=" + purchaseID + ");";
            dt = Da.ExecuteQueryTable(sql);
            txtBuyDate.Text = dt.Rows[0][0].ToString();

            warrantyLeft();

        }

        public void warrantyLeft()
        {
            DateTime dt = DateTime.Now.Date;  
            DateTime buyDate = DateTime.ParseExact(txtBuyDate.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).Date;
               
            TimeSpan timeSpan = dt - buyDate;
            int time = timeSpan.Days;
            int warranty = Convert.ToInt32(dgv_SaleDetails.CurrentRow.Cells["Warranty"].Value);
            txtWarrentyLeft.Text = (warranty-time).ToString();
            
            if((warranty - time) <= 0)
            {
                isWarrantyAvailable = false;
                btnNewToken.Enabled = false;
                MessageBox.Show("Warranty expired");
            }
            else
            {
                isWarrantyAvailable = true;
                btnNewToken.Enabled = true;
            }
        }

        private void dgv_SaleDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateBoxes();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            string purchaseID = txtSearch.Text;
            bool isString = int.TryParse(purchaseID, out int purID);
            string sql = "select sd.SaleDetailID ,p.ProductName, p.Warranty, Format(s.SaleDate,'dd/MM/yyy') AS SaleDate from dbo.SaleDetails sd  inner join dbo.Products p on sd.ProductID=p.ProductID Inner join dbo.Sales s on sd.SaleID=s.SaleID where sd.SaleDetailID=" + purchaseID + ";";

            if (string.IsNullOrEmpty(txtSearch.Text) )
            {
                dgv_SaleDetails.DataSource = null;
                dgv_SaleDetails.Rows.Clear();
                dgv_SaleDetails.Refresh();
                
            }
            else if (!isString)
            {
                MessageBox.Show("Purchase ID Must be in digits");
                txtSearch.Clear();
            }

            else
            {
                populateGrid(sql);

            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtSearch.Clear();
        }

        private void Check_Load(object sender, EventArgs e)
        {

        }

        private void btnNewToken_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPurchaseID.Text))
            {
                MessageBox.Show("Select a purchased Product first");
            }
            UserControl uc = new NewToken(isWarrantyAvailable);
            NewToken n = (NewToken)uc;
            this.ServiceMainP.Controls.RemoveAt(0);
            uc.Dock = DockStyle.Fill;
            this.ServiceMainP.Controls.Add(uc);

            n.txtProductID.Text = this.txtProductID.Text;
            n.txtProductName.Text = this.txtProductName.Text;
            if (isWarrantyAvailable)
            {
                n.txtCost.Text = "0";
            }

            string sql = "select FullName, Phone from dbo.Customers " +
                "where CustomerID=" +
                "(select CustomerID from dbo.Sales " +
                "where SaleID=" +
                "(select SaleID from SaleDetails where SaleDetailID="+purchaseID+" ));  ";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            
            if (dt.Rows.Count > 0)
            {
                n.txtCustomerName.Text = dt.Rows[0][0].ToString();
                n.txtPhone.Text = dt.Rows[0][1].ToString();
                if (n.customerInfoContainer.Visible == true)
                {
                    n.customerInfoContainer.Visible = false;
                }
            }

            else
            {
                MessageBox.Show("Facing problem to fetch information");
            }
                uc.Show();
            this.Hide();
            
        }

        private void txtPurchaseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
