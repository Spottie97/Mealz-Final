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
    public partial class frmUsers_M : Form
    {
        string employee_delete;

        public frmUsers_M()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand($"DELETE FROM tblUser WHERE user_id = '{employee_delete}'", conn);
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

        public void LoadAll()
        {
            conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();
            comm = new SqlCommand("SELECT user_id, user_name, user_surname, user_email, user_cell FROM tblUser WHERE user_employee = 1", conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "tblUser");

            dbView.DataSource = ds;
            dbView.DataMember = "tblUser";

            conn.Close();
        }

        private void frmUsers_M_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void dbView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dbView.Rows[index];

            employee_delete = selectedRow.Cells[0].Value.ToString();
        }
    }
}
