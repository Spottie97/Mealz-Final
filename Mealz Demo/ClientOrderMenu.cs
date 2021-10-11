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
    public partial class ClientOrderMenu : Form
    {
        public class Globals
        {
            public static string Cheese;
        }

        string stock_name;
        string stock_price;
        string stock_id;
        int quantity;
        int totalAmount;
        int StudentNum = Int32.Parse(Form1.Globals.StudID);
        string date;
        string order_num;


        public ClientOrderMenu()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;
        SqlDataReader red;

        int amountDue = 0;

        private void ClientOrderMenu_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

                conn.Open();

                comm = new SqlCommand($"INSERT INTO tblOrder(user_id,order_done,order_collected, order_date) VALUES({StudentNum},{0},{0},'{date}')", conn);
                adapt = new SqlDataAdapter();

                adapt.InsertCommand = comm;
                adapt.InsertCommand.ExecuteNonQuery();

                conn.Close();

                LoadBreakfast();
                LoadLunch();

                lstDisplay.Items.Add("Receipt");
                lstDisplay.Items.Add("====================================");
                
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void LoadBreakfast()
        {
            conn.Open();

            comm = new SqlCommand("SELECT stock_name, stock_price, stock_id FROM tblStock WHERE menu = 1 AND stock_Id LIKE 'BR%'", conn);
            adapt = new SqlDataAdapter();
            ds = new DataSet();

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "tblStock");

            dbBreackfast.DataSource = ds;
            dbBreackfast.DataMember = "tblStock";

            conn.Close();
        }

        public void LoadLunch()
        {
            conn.Open();

            comm = new SqlCommand("SELECT stock_name, stock_price, stock_id, stock_quantity FROM tblStock WHERE stock_Id LIKE 'IM%' AND menu = 1 OR stock_id LIKE 'NM%' AND menu = 1", conn);
            adapt = new SqlDataAdapter();
            ds = new DataSet();

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "tblStock");

            dbLunch.DataSource = ds;
            dbLunch.DataMember = "tblStock";

            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtQuan.Text == "")
            {
                MessageBox.Show("Please enter a quantity amount.");
            }
            else
            {
                quantity = Int32.Parse(txtQuan.Text);
                lstDisplay.Items.Add(stock_name + ":" + "\t" + quantity + "\t" + (quantity * (Int32.Parse(stock_price))));
                totalAmount = totalAmount + (quantity * (Int32.Parse(stock_price)));
                dbBreackfast.ClearSelection();
                txtQuan.Text = "";

                try
                {
                    conn.Open();

                    comm = new SqlCommand("UPDATE tblStock SET stock_quantity = stock_quantity - '" + quantity + "' WHERE stock_id = @id", conn);
                    comm.Parameters.AddWithValue("@id", stock_id);

                    comm.ExecuteNonQuery();
                    conn.Close();

                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                try
                {
                    comm = new SqlCommand("SELECT order_num FROM tblOrder ", conn);

                    conn.Open();

                    adapt = new SqlDataAdapter();
                    ds = new DataSet();

                    adapt.SelectCommand = comm;
                    adapt.Fill(ds, "tblOrder");

                    red = comm.ExecuteReader();

                    while (red.Read())
                    {
                       Globals.Cheese = red.GetValue(0).ToString();
                       order_num = red.GetValue(0).ToString();
                    }
                   
                    conn.Close();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                try
                {
                    conn.Open();

                    comm = new SqlCommand($"INSERT INTO tblorder_detail(order_num,stock_id,quantity) VALUES({order_num},'{stock_id}',{quantity})", conn);
                    adapt = new SqlDataAdapter();

                    adapt.InsertCommand = comm;
                    adapt.InsertCommand.ExecuteNonQuery();

                    conn.Close();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void lbLunch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClientOrderStatus frmStatus = new ClientOrderStatus();
            frmStatus.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dbBreackfast_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dbLunch.Rows[index];

                stock_name = selectedRow.Cells[0].Value.ToString();
                stock_price = selectedRow.Cells[1].Value.ToString();
                stock_id = selectedRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You cant select the header");
            }
        }

        private void txtQuan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Add("");
            lstDisplay.Items.Add("The total amount: R" + totalAmount);
            totalAmount = 0;
        }

        private void dbLunch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dbLunch.Rows[index];

                stock_name = selectedRow.Cells[0].Value.ToString();
                stock_price = selectedRow.Cells[1].Value.ToString();
                stock_id = selectedRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You cant select the header");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLunch_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime myDate = new DateTime();
            date = myDate.ToString();
        }

    }
}

