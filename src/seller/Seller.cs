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
    public partial class Seller : Form
    {
        public string SellerID { get; set; }
        public string SellerName { get; set; }
        private DataAccess Da { get; set; }
        public Seller(string s, string id)
        {
            InitializeComponent();
            this.welcome_Lbl.Text = "Welcome, " + s; 
            Da = new DataAccess();
            this.SellerID = id;
            this.SellerName = s;
            
            loadform(new SaleProduct(SellerID));

        }

        public void loadform(UserControl uc)
        {
            SellerMainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            SellerMainPanel.Controls.Add(uc);
            uc.Show();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            loadform(new SaleProduct(SellerID));
        }

        private void btnCW_Click(object sender, EventArgs e)
        {
            //loadform(new ClaimWarrenty());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SellerMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void welcome_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            this.Dispose();
            lg.Show();

        }

        private void welcome_Lbl_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //loadform(new AddCustomer());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            loadform(new history(this.SellerID));
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            loadform(new Inventory());
        }
    }
}
