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
    public partial class frmDisplayOrder_M : Form
    {
        string order_num;
        string user_id;

        public frmDisplayOrder_M()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Display(string order_num, string user_id)
        {
            this.order_num = order_num.ToString();
            this.user_id = user_id.ToString();
        }

        private void frmDisplayOrder_M_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

                conn.Open();

                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand("SELECT stock_name, quantity FROM stock_view WHERE order_num = '" + order_num + "'", conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "stock_view");

                dbView.DataSource = ds;
                dbView.DataMember = "stock_view";

                conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
