using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LaptopManagement
{
    public partial class productSearchResult : UserControl
    {
        
        public DataRow dtrow { get; set; }
        public DataTable Dt { get; set; }
        public DataTable dgvToDataTable { get; set; }
        public SaleProduct sp { get; set; }
        public productSearchResult()
        {
            InitializeComponent();
        }
        
        public void populateGridview(DataTable dt, UserControl uc)
        {
            dgv_ProductSearchResult.AutoGenerateColumns = false;
            dgv_ProductSearchResult.DataSource = dt;
            Dt = dt;
            sp = (SaleProduct)uc;
        }




        

        private void dgv_ProductSearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_ProductSearchResult_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnAdd2Cart_Click(object sender, EventArgs e)
        {
            sp.addToCart();
            sp.initialBoxContents();
        }

        private void dgv_ProductSearchResult_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
