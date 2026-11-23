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
    public partial class Technician : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }
        private string technicianID { get; set; }
        private string technicianName { get; set; }

        public Technician(string name, string id)
        {
            InitializeComponent();
            technicianID = id;
            technicianName = name;
            welcome_Lbl.Text = "Welcome " + technicianName;
            loadform(new dashboard_T(technicianID));
        }

        public void loadform(UserControl uc)
        {
            SellerMainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            SellerMainPanel.Controls.Add(uc);
            uc.Show();
        }

        private void SellerMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewToken_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            this.Dispose();
            l.Show();
        }

        private void Technician_Load(object sender, EventArgs e)
        {

        }

        private void welcome_Lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
