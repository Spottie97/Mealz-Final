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
    public partial class frmStock_M : Form
    {
        public string stock_id;

        public frmStock_M()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void LoadAll()
        {
            conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();
            comm = new SqlCommand("SELECT stock_id, stock_name, stock_price, stock_quantity FROM tblStock", conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "tblStock");

            dbView.DataSource = ds;
            dbView.DataMember = "tblStock";

            conn.Close();
        }

        private void frmStock_M_Load(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            LoadAll();
            txtSearch.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand($"SELECT stock_id, stock_name, stock_price, stock_quantity FROM tblStock WHERE stock_name LIKE '%{txtSearch.Text}%'", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                dbView.DataSource = ds;
                dbView.DataMember = "tblStock";

                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand($"DELETE FROM tblStock WHERE stock_id = '{stock_id}'", conn);
                adapt = new SqlDataAdapter();
                adapt.DeleteCommand = comm;
                adapt.DeleteCommand.ExecuteNonQuery();

                conn.Close();

                LoadAll();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_M myadd = new frmAdd_M();
            myadd.ShowDialog();
        }

        public void Update(string id, string name, string price, string quantity)
        {

        }

        private void dbView_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dbView.Rows[index];

                stock_id = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtPrice.Text = selectedRow.Cells[2].Value.ToString();
                txtQuantity.Text = selectedRow.Cells[3].Value.ToString();

            }
            catch(Exception)
            {
                MessageBox.Show("You cant select the header");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand("UPDATE tblStock Set stock_name = @name, stock_price = @price, stock_quantity = '" + txtQuantity.Text + "' WHERE stock_id = @id", conn);
                comm.Parameters.AddWithValue("@id", stock_id);
                comm.Parameters.AddWithValue("@name", txtName.Text);
                comm.Parameters.AddWithValue("@price", txtPrice.Text);

                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
