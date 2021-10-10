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
    public partial class frmMaintainMenu_M : Form
    {
        public string stock_id;
        public frmMaintainMenu_M()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;

        public void LoadAll()
        {
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db2.0;Integrated Security=True");

            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();
            comm = new SqlCommand("SELECT * FROM tblStock", conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "tblStock");

            dbView.DataSource = ds;
            dbView.DataMember = "tblStock";

            conn.Close();
        }

        private void frmMaintainMenu_M_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand("UPDATE tblStock Set menu = 1 WHERE stock_id = @id", conn);
                comm.Parameters.AddWithValue("@id", stock_id);

                comm.ExecuteNonQuery();
                conn.Close();
                LoadAll();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dbView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dbView.Rows[index];
                stock_id = selectedRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You cant select the header");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand("UPDATE tblStock Set menu = 0 WHERE stock_id = @id", conn);
                comm.Parameters.AddWithValue("@id", stock_id);

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
