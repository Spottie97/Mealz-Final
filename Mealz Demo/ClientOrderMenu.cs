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
        public ClientOrderMenu()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;
        SqlDataReader red;
        

        private void ClientOrderMenu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db2.0;Integrated Security=True");

            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();
            comm = new SqlCommand("SELECT * FROM tblStock", conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "tblStock");

            dbMenu.DataSource = ds;
            dbMenu.DataMember = "tblStock";

            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
        }

        private void lbLunch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //This button should undo what the add button does
            foreach(var item in lbOrderCart.SelectedItems)
            {
                lbOrderCart.Items.Remove(item);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
          //This button should just navigate to frmTransaction
          //add to Tblorder_detail (stock_id, stock_quantity)
          //subtract from tblStock (stock_quantity - stock Quantity bought)
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
