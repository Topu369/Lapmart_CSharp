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
    public partial class dashboard_T : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }
        private string technicianID { get; set; }
        private string repairID { get; set; }

        public dashboard_T(string id)
        {
            InitializeComponent();
            Da = new DataAccess();
            technicianID = id;
            Sql = "select * from dbo.Repairs where TechnicianID=" + technicianID + ";";
            populateGridView(Sql);
            today();
        }

        private void dashboard_T_Load(object sender, EventArgs e)
        {

        }
        private void populateGridView(string s)
        {
            Dt = Da.ExecuteQueryTable(s);
            dgv_QueueLog.AutoGenerateColumns = false;
            dgv_QueueLog.DataSource = Dt;
        }

        private void populateBoxes()
        {

        }

        private void today()
        {
            DateTime time = DateTime.Now;
            txtDate.Text = Convert.ToString(time);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string s;
            if(cmbRepairStatus.Text == "Completed")
            {
                s = "Update dbo.Repairs SET ProblemDescription=@discription, RepairStatus=@status, Cost=@cost, CompletedAt=@completedAt where RepairID=@repairID ";
            }

            else
            {
                s = "Update dbo.Repairs SET RepairStatus=@status, Cost=@cost where RepairID=@repairID ";
            }

            using (SqlCommand cmd = new SqlCommand (s, this.Da.Sqlcon))
            {
                cmd.Parameters.AddWithValue("repairID", repairID);
                cmd.Parameters.AddWithValue("@status", cmbRepairStatus.Text);
                cmd.Parameters.AddWithValue("@cost", txtCost.Text);
                cmd.Parameters.AddWithValue("@completedAt", txtDate.Text);
                cmd.Parameters.AddWithValue("@discription", txtDiscription.ToString()+"#"+txtNotes.Text);

                int inserted = cmd.ExecuteNonQuery();

                if (inserted > 0)
                {
                    MessageBox.Show("Updated Successfully ");
                    populateGridView(Sql);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void dgv_QueueLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            repairID= dgv_QueueLog.CurrentRow.Cells["RepairID"].Value.ToString();
            txtRepairID.Text = dgv_QueueLog.CurrentRow.Cells["RepairID"].Value.ToString();
            cmbRepairStatus.Text = dgv_QueueLog.CurrentRow.Cells["RepairStatus"].Value.ToString();
            txtCost.Text = dgv_QueueLog.CurrentRow.Cells["Cost"].Value.ToString();
            string[] discription = dgv_QueueLog.CurrentRow.Cells["ProblemDescription"].Value.ToString().Split('#');
            txtDiscription.Text = discription[0];
            txtNotes.Text = discription[1]?? "";
        }
    }
}
