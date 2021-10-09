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
        string sqlConnectionString = ""; // Replace "" with the connection string to your database.
        SqlConnection sqlConnection = new SqlConnection(""); // Replace "" with sqlConnectionString

        public frmOrders_M()
        {
            InitializeComponent();
        }

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
                     */

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
                     */

                    string order = dataReader.GetString(0) + "\t" + dataReader.GetString(2);
                    lstBusy.Items.Add(order);
                }
            }

            dataReader.Close();

            sqlConnection.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
