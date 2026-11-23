using System;
using System.Data;
using System.Data.SqlClient;

namespace LaptopManagement
{
    internal class DataAccess
    {
        
        /*
         1. SqlConnection makes connection to the DB by setting protocols
         2. SqlCommand process given querry
         3. 
         */


        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Server=.\SQLEXPRESS;Database=LapMart;Trusted_Connection=True;");
            this.Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }


        // Returns a ready made dataset
        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return this.Ds;
            }
            catch (Exception exc)
            {
                return null;
            }
        }



        // Indexing table from dataset using table name........
        public DataSet ExecuteQuery(string sql, string tabName)
        {
            try
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds, tabName);
                return this.Ds;
            }
            catch (Exception exc)
            {
                return null;
            }
        }


        // For parametarized querry. SqlCommand Process the querry string with parameters, palaces value to the parameter using .Parameter.AddWithValue() method
        public DataSet ExecuteQuery(SqlCommand sqlcommand)
        {
            try
            {
                this.Sda = new SqlDataAdapter(sqlcommand);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return this.Ds;
            }
            catch (Exception exc)
            {
                return null;
            }
        }


        //Returns a single dataTable obj
        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }

        public DataTable ExecuteQueryTable(SqlCommand cmd)
        {
            
            this.Sda = new SqlDataAdapter(cmd);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }


        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }

        public int ExecuteUpdateQuery(SqlCommand cmd)
        {
        
            return cmd.ExecuteNonQuery(); 
            
        }

    }
}