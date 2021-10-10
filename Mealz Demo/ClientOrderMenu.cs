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
        public static string Productname = "";
        public static string ProductPrice = "";
        public static string ProductQuantity = "";
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
            Boolean test = true;

            try
            {
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");

                conn.Open();

                comm = new SqlCommand("SELECT stock_name, stock_price, menu FROM tblStock WHERE menu = 1 AND stock_Id LIKE 'BR%'", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                red = comm.ExecuteReader();
                lbBreakfast.Items.Add("============================================");

                while (red.Read() && test)
                {
                    lbBreakfast.Items.Add(red.GetValue(0) + "\t" + "\t" + "R " + red.GetValue(1));
                }

                red.Close();

                ///////////////////////////////////////////////////////////////////

                comm = new SqlCommand("SELECT stock_name, stock_price,menu FROM tblStock WHERE stock_Id LIKE 'IM%' AND menu = 1", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                red = comm.ExecuteReader();

                lbLunch.Items.Add("The Meats on the menu");
                lbLunch.Items.Add("============================================");

                while (red.Read())
                {
                    lbLunch.Items.Add(red.GetValue(0) + "\t" + "\t" + "R " + red.GetValue(1));
                }

                lbLunch.Items.Add("");
                lbLunch.Items.Add("Non Meats");
                lbLunch.Items.Add("=============================================");

                red.Close();

                //////////////////////////////////////////////////////////////////

                comm = new SqlCommand("SELECT stock_name, stock_price,menu FROM tblStock WHERE stock_Id LIKE 'NM%' AND menu = 1", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                red = comm.ExecuteReader();

                while (red.Read())
                {
                    lbLunch.Items.Add(red.GetValue(0) + "\t" + "\t" + "R " + red.GetValue(1));
                }

                /////////////////////////////////////////////////////////

                conn.Close();

                MessageBox.Show("Connection successful");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //This button should add the selected item in the menu list to the order/cart list and then update the SQl database to show the item was removed from stock quantity
            //Aswell as update the clients Amount Due.
            foreach(var item in lbBreakfast.SelectedItems)
            {
                lbOrderCart.Items.Add(item);

            }
            foreach (var item in lbLunch.SelectedItems)
            {
                lbOrderCart.Items.Add(item);
            }

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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
