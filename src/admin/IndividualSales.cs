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
    public partial class IndividualSales : Form
    {
        public IndividualSales(DataTable dt)
        {
            InitializeComponent();
            dgv_IndividualRecord.DataSource = dt;
        }

        private void IndividualSales_Load(object sender, EventArgs e)
        {

        }

        private void dgv_IndividualRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
