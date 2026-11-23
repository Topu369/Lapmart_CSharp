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
    public partial class Queue_Status : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }


        public Queue_Status()
        {
            InitializeComponent();
            Da = new DataAccess();
            populateGridView();
        }

        private void populateGridView(string s= "select * from dbo.Repairs")
        {
            Dt = Da.ExecuteQueryTable(s);
            dgv_QueueLog.AutoGenerateColumns = false;
            dgv_QueueLog.DataSource = Dt;
        }

        private void Queue_Status_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search By RepairID")
            {
                txtSearch.Clear();
            }
            else
            {
                string sql = "select * from dbo.Repairs where RepairID=" + txtSearch.Text + ";";
                populateGridView(sql);
            }
        }
    }
}
