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
    public partial class customerSearchResult : UserControl
    {
        public SaleProduct sp { get; set; }
        public NewToken nt { get; set; }
        public DataSet Ds { get; set; }
        public DataTable Dt { get; set; }
        public UserControl UC { get; set; }

      
        public customerSearchResult(UserControl uc)
        {
            UC = uc;
            InitializeComponent();
            if(uc is SaleProduct)
            {
                sp = (SaleProduct)uc;
            }

            else if(uc is NewToken)
            {
                nt = (NewToken)uc;
            }
            
        }

        public void spObjectReceiver(UserControl uc)
        {

        }
        private void customerSearchResult_Load(object sender, EventArgs e)
        {

        }

        public void showDetails(DataTable dt)
        {
            
        }

        private void customerSearchResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(UC is SaleProduct)
            {
                sp.showCustomerName();
            }

            else if (UC is NewToken)
            {
                nt.showCustomerNameID();
            }

            
        }
    }
}
