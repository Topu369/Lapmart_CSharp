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
    public partial class Warranty_AND_Service : Form
    {
        
        public Warranty_AND_Service(string name, string id)
        {
            InitializeComponent();
            load(new Check(this.ServiceMainPanel));
            welcome_Lbl.Text = "Welcome" + name;
            
        }

        public void load(UserControl uc)
        {
            if(ServiceMainPanel.Controls.Count>0) this.ServiceMainPanel.Controls.Clear();
            ServiceMainPanel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
            

        }

        private void ServiceMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            load(new Queue_Status());
        }

        private void btnNewToken_Click(object sender, EventArgs e)
        {
            load(new NewToken(false));
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            load(new Check(this.ServiceMainPanel));
        }

        private void welcome_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            this.Dispose();
            l.Show();
        }
    }
}
