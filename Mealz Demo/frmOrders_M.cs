using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mealz_Demo
{
    public partial class frmOrders_M : Form
    {
        /**
        string sqlConnectionString = ""; // Replace "" with the connection string to your database.
        SqlConnection sqlConnection = new SqlConnection(""); // Replace "" with sqlConnectionString
        **/

        string ordernum;

        public frmOrders_M()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;

        public void LoadAll()
        {
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");

            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();
            comm = new SqlCommand("SELECT order_num, user_id FROM tblOrder WHERE order_done = 0", conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "tblOrder");

            dbViewBusy.DataSource = ds;
            dbViewBusy.DataMember = "tblOrder";

            ////////////////////////////////////////////////////////

            adapt = new SqlDataAdapter();
            ds = new DataSet();
            comm = new SqlCommand("SELECT order_num, user_id FROM tblOrder WHERE order_done = 1 AND order_collected = 0", conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "tblOrder");

            dbViewDone.DataSource = ds;
            dbViewDone.DataMember = "tblOrder";

            conn.Close();
        }

        /**
        private void frmOrders_M_Load(object sender, EventArgs e)
        {
            getOrders();
        }

        private void getOrders()
        {
            ordersBeingPrepared();
            ordersReady();
        }

        private void ordersBeingPrepared(string status = "not ready")
        {
            sqlConnection.Open();

            string sqlOrdersBeingPrepared = "SELECT * FROM table WHERE status=@status";
            SqlCommand ordersBeingPrepared = new SqlCommand(sqlOrdersBeingPrepared, sqlConnection);

            ordersBeingPrepared.Parameters.AddWithValue("@status", status);

            SqlDataReader dataReader = ordersBeingPrepared.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    /*
                        0 and 2 are the indexes for the orderNumber and status columns in your database.
                        
                        Now, if the order's status isn't at index 2, change the value to 3 or whatever the case may be.
                     *//**

                    string order = dataReader.GetString(0) + "\t" + dataReader.GetString(2);
                    lstBusy.Items.Add(order);
                }
            }

            dataReader.Close();

            sqlConnection.Close();
        }

        private void ordersReady(string status = "ready")
        {
            sqlConnection.Open();

            string sqlOrdersBeingPrepared = "SELECT * FROM table WHERE status=@status";
            SqlCommand ordersBeingPrepared = new SqlCommand(sqlOrdersBeingPrepared, sqlConnection);

            ordersBeingPrepared.Parameters.AddWithValue("@status", status);

            SqlDataReader dataReader = ordersBeingPrepared.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    /*
                        0 and 2 are the indexes for the orderNumber and status columns in your database.
                        
                        Now, if the order's status isn't at index 2, change the value to 3 or whatever the case may be.
                     *//**

                    string order = dataReader.GetString(0) + "\t" + dataReader.GetString(2);
                    lstBusy.Items.Add(order);
                }
            }

            dataReader.Close();

            sqlConnection.Close();
        }**/

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand("UPDATE tblOrder Set order_done = 1 WHERE order_num = @id", conn);
                comm.Parameters.AddWithValue("@id", ordernum);

                comm.ExecuteNonQuery();
                conn.Close();
                LoadAll();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void frmOrders_M_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAll();

                MessageBox.Show("Connection successful");
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dbViewBusy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dbViewBusy.Rows[index];

                ordernum = selectedRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You cant select the header");
            }
        }

        private void dbViewDone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dbViewDone.Rows[index];

                ordernum = selectedRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You cant select the header");
            }
        }

        private void btnCollected_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand("UPDATE tblOrder Set order_collected = 1 WHERE order_num = @id", conn);
                comm.Parameters.AddWithValue("@id", ordernum);

                comm.ExecuteNonQuery();
                conn.Close();
                LoadAll();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand("UPDATE tblOrder Set order_done = 0 WHERE order_num = @id", conn);
                comm.Parameters.AddWithValue("@id", ordernum);

                comm.ExecuteNonQuery();
                conn.Close();
                LoadAll();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
