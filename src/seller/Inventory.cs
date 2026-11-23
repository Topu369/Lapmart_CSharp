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
    public partial class Inventory : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }
        public Inventory()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Products;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.grid_Inventory.AutoGenerateColumns = false;
            this.grid_Inventory.DataSource = this.Ds.Tables[0];
        }
        private void grid_Inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Products where ProductName like '" + this.txtbox_search.Text + "%';";
            this.PopulateGridView(this.Sql);
        }
    }
}
