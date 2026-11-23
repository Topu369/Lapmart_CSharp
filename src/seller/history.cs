using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopManagement
{
    public partial class history : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }
        private string sellerID { get; set; }
        
        private string sql { get; set; }

        public history(string sid)
        {
            InitializeComponent();
            this.sellerID = sid;
            this.Da = new DataAccess();
            sql = @"select s.SaleID, p.ProductID, p.ProductName, sd.Quantity, p.UnitPrice, sd.Subtotal as SubTotal, s.SaleDate " +
                "from dbo.SellsInfo s " +
                "inner join SaleDetails sd on sd.SaleID=s.SaleID " +
                "inner join dbo.Products p on sd.ProductID=p.ProductID " +
                "where s.UserID=" + sellerID + ";";
            populateGrid(sql);
        }
        private void populateGrid(string s ) 
        {
            dgv_history.AutoGenerateColumns = false;
            dgv_history.DataSource = Da.ExecuteQueryTable(s);

        }

        private void dgv_history_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
