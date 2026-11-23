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
    public partial class Report_Admin : UserControl
    {

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }

        private DataTable year { get; set; }
        private List<string> yearList = new List<string>();
        private SqlDataReader sdr { get; set; }
        private string currentYear;

        public Report_Admin()
        {
            InitializeComponent();
            Da = new DataAccess();
            createYearList();
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
            currentYear = cmb_year.Text;
        }
        private void Report_Admin_Load(object sender, EventArgs e)
        {

        }

        private void gbxStats_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string month = cmbMonth.Text;
            string year = cmb_year.Text;

            string sql = "select SUM(TotalAmount) from dbo.SellsInfo where Month='" + month + "' and year=" + year + "; ";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            txtbox_monthly.Text = dt.Rows[0][0].ToString();

            sql = "select SUM(TotalAmount) from dbo.SellsInfo where year=" + year + ";";

            dt = this.Da.ExecuteQueryTable(sql);
            txtbox_yearly.Text = dt.Rows[0][0].ToString();

            string yearbefore = (int.Parse(currentYear) - 1).ToString(); 
            sql= "select SUM(TotalAmount) from dbo.SellsInfo where year=" + currentYear + ";";
            SqlCommand cmd = new SqlCommand(sql,this.Da.Sqlcon);

            int y1 =Convert.ToInt32( cmd.ExecuteScalar() ); // current
            sql = "select SUM(TotalAmount) from dbo.SellsInfo where year=" + yearbefore + ";";
            cmd = new SqlCommand(sql, this.Da.Sqlcon);
            var result = cmd.ExecuteScalar();
            int y2 = result == DBNull.Value ? 0 : Convert.ToInt32(result); // previous

            try
            {
                double change = ((y1 - y2) / y2) * 100;

                txtbox_increment.Text = Convert.ToString(change) + "%";

            }
            catch (Exception exc)
            {
                MessageBox.Show("No Record for previous year");
                txtbox_increment.Text = "0 %";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
