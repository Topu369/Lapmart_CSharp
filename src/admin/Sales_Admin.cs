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
    public partial class Sales_Admin : Form
    {

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }

        private DataTable year { get; set;  }
        private List<string> yearList = new List<string>();
        private SqlDataReader sdr { get; set; }
        IndividualSales form;


        private void loadDetailedSale( DataTable dt)
        {
            form = new IndividualSales(dt);
            form.Show();

        }


        public Sales_Admin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            createYearList();

        }

        private void PopulateGridView(string sql = "select * from [dbo].[SellsInfo]")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.gridview_Sales.AutoGenerateColumns = false;
            this.gridview_Sales.DataSource = this.Ds.Tables[0];
            this.gridview_Sales.Refresh();
        }

        private void createYearList(string sql = "select Year ,count(saleID) from dbo.SellsInfo group by YEAR order by Year desc;")
        {
            SqlCommand cmd = new SqlCommand(sql, Da.Sqlcon);
            using (sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    yearList.Add(sdr["Year"].ToString());
                }
            }

            cmb_year.DataSource = yearList;
            cmb_year.SelectedIndex = 0;
        }


       

        private void gridview_Sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (form != null)
            {
                this.form.Dispose();
            }
            
            string saleID = gridview_Sales.CurrentRow.Cells["SaleID"].Value.ToString();
            string sql = "select sd.SaleDetailID,sd.ProductID, p.ProductName, sd.Quantity, sd.UnitPrice, sd.Subtotal  " +
                "from dbo.SaleDetails sd " +
                "Inner Join dbo.Products p " +
                "on sd.ProductID=p.ProductID " +
                "where sd.SaleID=@saleid;";

            using (SqlCommand cmd = new SqlCommand(sql, this.Da.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@saleid", saleID);
                Dt = this.Da.ExecuteQueryTable(cmd);

                loadDetailedSale(Dt);
            }
        }

        private void cmb_orderBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = cmb_year.Text.ToString();

            string sql= "select * from [dbo].[SellsInfo] where Year="+year+";";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmb_catagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_monthly_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_yearly_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_increment_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sales_Admin_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            string ID = txtSearch.Text;
            string sql = "select * from [dbo].[SellsInfo] where UserID="+ ID +" ;";

            if ( string.IsNullOrEmpty(ID) )
            {
                PopulateGridView();
               
            }

            else
            {
                PopulateGridView(sql);
            } 





            }

        //private void txtSearch_MouseLeave(object sender, EventArgs e)
        //{
        //    txtSearch.Text = "Search by Seller ID";
        //}

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = cmb_year.Text;
            string month = cmbMonth.Text;
            string sql = "select * from [dbo].[SellsInfo] where year=" + year + " and month='" + month + "';";
            PopulateGridView(sql);




        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text== "Search by SellerID")
            {
                txtSearch.Clear();

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.cmbMonth.ResetText();
            this.cmb_year.ResetText();
        }
    }
}
