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
        int totalOrders;
        int totalItems;
        float totalMoney;
        string convert;
        string placeHolderQuan;
        string placeHolderPrice;
        int totalItemsTwo;
        float totalMoneyTwo;
        string convertTwo;
        string placeHolderQuanTwo;
        string placeHolderPriceTwo;
        string choose;

        public frmStatistics_M()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;
        SqlDataReader red;

        private void frmStatistics_M_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAll();
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

            dbView.DataSource = ds;
            dbView.DataMember = "tblOrder";

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            totalItemsTwo = 0;
            totalMoneyTwo = 0;
            int i = 0;

            try
            {
                conn.Open();

                adapt = new SqlDataAdapter();
                ds = new DataSet();

                if (cbDate.Checked)
                {
                    comm = new SqlCommand($"SELECT * FROM stock_view WHERE stock_id = '" + choose + "' AND order_date = '" + dateTimePicker1.Value.ToShortDateString() + "'", conn);
                }
                else
                {
                    comm = new SqlCommand($"SELECT * FROM stock_view WHERE stock_id = '" + choose + "'", conn);
                }

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblOrder");

                dbView.DataSource = ds;
                dbView.DataMember = "tblOrder";

                red = comm.ExecuteReader();

                while (red.Read())
                {
                    convertTwo = red.GetValue(4).ToString();
                    i++;

                    totalItemsTwo = totalItemsTwo + Int32.Parse(convertTwo);

                    placeHolderPriceTwo = red.GetValue(3).ToString();
                    placeHolderQuanTwo = red.GetValue(4).ToString();

                    totalMoneyTwo = totalMoneyTwo + (Int32.Parse(placeHolderQuanTwo) * float.Parse(placeHolderPriceTwo));

                }

                label4.Text = "Total Items Sold: " + totalItemsTwo.ToString();
                label5.Text = "Total Money earned: R " + totalMoneyTwo.ToString();
                label7.Text = "Total Orders: " + i.ToString();

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
            totalOrders = 1;
            totalItems = 0;
            totalMoney = 0;

            try
            {
                conn.Open();

                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand($"SELECT * FROM stock_view WHERE order_date = '" + selecDate + "'", conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblOrder");

                dbView.DataSource = ds;
                dbView.DataMember = "tblOrder";

                red = comm.ExecuteReader();

                while (red.Read())
                {
                    if (red.GetValue(0).ToString() == totalOrders.ToString())
                    {
                        totalOrders++;
                    }

                    convert = red.GetValue(4).ToString();

                    totalItems = totalItems + Int32.Parse(convert);

                    placeHolderPrice = red.GetValue(3).ToString();
                    placeHolderQuan = red.GetValue(4).ToString();

                    totalMoney = totalMoney + (Int32.Parse(placeHolderQuan) * float.Parse(placeHolderPrice));

                }

                label1.Text = "Total Orders: " + (totalOrders - 1).ToString();
                label2.Text = "Total Items Sold: " + totalItems.ToString();
                label3.Text = "Total Money earned for the day: R " + totalMoney.ToString();

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

                dbView.DataSource = ds;
                dbView.DataMember = "tblOrder";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dbView.Rows[index];

            choose = selectedRow.Cells[1].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadAll();
            label7.Text = "";
            label5.Text = "";
            label4.Text = "";
            label3.Text = "";
            label2.Text = "";
            label1.Text = "";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            btnHelp.Visible = false;
            btnDone.Visible = true;
            lstHelp.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            btnDone.Visible = false;
            btnHelp.Visible = true;
            lstHelp.Visible = false;
        }
    }
}
