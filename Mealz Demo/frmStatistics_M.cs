using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mealz_Demo
{
    public partial class frmStatistics_M : Form
    {
        public frmStatistics_M()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;

        private void frmStatistics_M_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAll();

                MessageBox.Show("Connection successful");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void LoadAll()
        {
            conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();
            comm = new SqlCommand("SELECT * FROM stock_view", conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "tblOrder");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tblOrder";

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand($"SELECT * FROM stock_view WHERE stock_name = '{txtFilter.Text}'", conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblOrder");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tblOrder";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void mcDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            string selecDate = mcDate.SelectionStart.ToShortDateString();
            label1.Text = selecDate;

            try
            {
                conn.Open();

                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand($"SELECT * FROM stock_view WHERE order_date = '" + selecDate + "'", conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblOrder");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tblOrder";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mcDate_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand($"SELECT * FROM stock_view WHERE stock_name LIKE '%{txtFilter.Text}%'", conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblOrder");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tblOrder";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
