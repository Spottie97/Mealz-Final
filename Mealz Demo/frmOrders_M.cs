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
        string ordernum;
        string user_id_display;

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
            conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

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
                user_id_display = selectedRow.Cells[1].Value.ToString();
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

        private void btnDisplayOrder_Click(object sender, EventArgs e)
        {
            frmDisplayOrder_M frmDiplay = new frmDisplayOrder_M();
            frmDiplay.Display(ordernum, user_id_display);
            frmDiplay.Show();
        }

        private void btnHelpOne_Click(object sender, EventArgs e)
        {
            lstHelp.Visible = false;
            btnHelp.Visible = true;
            btnHelpOne.Visible = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            lstHelp.Visible = true;
            btnHelp.Visible = false;
            btnHelpOne.Visible = true;
        }
    }
}
