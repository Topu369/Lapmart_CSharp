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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if( (string.IsNullOrEmpty(txtbox_username.Text.Trim())) || (string.IsNullOrEmpty(txtbox_password.Text.Trim())) )
            {

                MessageBox.Show("Fill All the fields");
                return;

            }
                
            string sql = @"SELECT UserID, Username, Password, Role, FullName FROM Users 
                   WHERE Username = '" + this.txtbox_username.Text +
                   "' AND Password = '" + this.txtbox_password.Text + "';";


            
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

           
          

            //Dataset er moddhe datatable populate howar somoy database er table er field gular name niye ney???

            if (ds.Tables[0].Rows.Count == 1) // dataset er moddhe first table er view te koyta row asshe
            {


                string [] Fullname = (ds.Tables[0].Rows[0]["FullName"].ToString()).Split(' '); // Just first nmae
                string role = ds.Tables[0].Rows[0]["Role"].ToString();
                string id = ds.Tables[0].Rows[0]["UserID"].ToString();

                if (role == "Manager")
                {
                    admin_Dash adash = new admin_Dash(Fullname[0], id);
                    this.Hide();
                    adash.Show();
                }

                if (role == "Salesperson")
                {
                    Seller sdash = new Seller(Fullname[0], id);
                    this.Hide();
                    sdash.Show();
                }

                if (role == "Service Executive")
                {
                    Warranty_AND_Service w_ser= new Warranty_AND_Service(Fullname[0], id);
                    this.Hide();
                    w_ser.Show();
                }

                if (role == "Technician")
                {
                    Technician techi = new Technician(Fullname[0], id);
                    this.Hide();
                    techi.Show();
                }

                
                
            }
            else
            {
                MessageBox.Show("Login Invalid!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
