using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mealz_Demo
{    public partial class frmAdd_M : Form
    {
        public frmStock_M obj = (frmStock_M)Application.OpenForms["frmStock_M"];
        public frmAdd_M()
        {
            InitializeComponent();
        }

        SqlDataAdapter adap;
        SqlConnection conn;
        SqlCommand comm;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

                if (txtId.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtQuan.Text == "")
                {
                    MessageBox.Show("Please make sure all fields contain data.");
                }
                else
                {
                     conn.Open();

                    comm = new SqlCommand($"INSERT INTO tblStock(stock_id, stock_name, stock_price, stock_quantity, menu) VALUES('{txtId.Text}','{txtName.Text}',{txtPrice.Text},{txtQuan.Text},{0})", conn);
                    adap = new SqlDataAdapter();

                    adap.InsertCommand = comm;
                    adap.InsertCommand.ExecuteNonQuery();

                    conn.Close();
                    this.Close();
                    obj.LoadAll();
                }  
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtMenu_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMenu_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_Leave(object sender, EventArgs e)
        {
 
        }

        private void txtId_Enter(object sender, EventArgs e)
        {

        }

        private void frmAdd_M_Load(object sender, EventArgs e)
        {
           
        }
    }
}
