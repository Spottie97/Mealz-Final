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

        int amountDue = 0;

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

            foreach(object item in lbBreakfast.Items)
            {
                if (removeFromQuantity(item))
                {
                    lbOrderCart.Items.Add(item.ToString());
                }
            }

            foreach (object item in lbBreakfast.Items)
            {
                if (removeFromQuantity(item))
                {
                    lbOrderCart.Items.Add(item.ToString());
                }
            }

            setAmountDue();
        }

        private void lbLunch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach(object item in lbOrderCart.Items)
            {
                addToQuantity(item);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            //This button should just navigate to frmTransaction

            frmTransactions frmTransactions = new frmTransactions();
            frmTransactions.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean addToQuantity(object item)
        {
            int quantity = getStockQuantity(item);

            try
            {
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");
                comm = new SqlCommand("UPDATE tblStock SET quantity = @quantity WHERE stock_id = @stock_id", conn);

                comm.Parameters.AddWithValue("@quantity", quantity);
                comm.Parameters.AddWithValue("@stock_id", item.ToString());

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        private Boolean removeFromQuantity(object item)
        {
            try
            {
                int quantity = getStockQuantity(item) - 1;

                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");
                comm = new SqlCommand("UPDATE tblStock SET quantity = @quantity WHERE stock_id = @stock_id", conn);

                comm.Parameters.AddWithValue("@quantity", quantity);
                comm.Parameters.AddWithValue("@stock_id", item.ToString());

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return false;
            }

            return true;
        }

        private int getStockQuantity(object item)
        {
            int quantity = 0;

            try
            {
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");
                comm = new SqlCommand("SELECT * FROM SET tblStock WHERE stock_name = @stock_name", conn);

                comm.Parameters.AddWithValue("@stock_name", item.ToString());
                SqlDataReader dataReader = comm.ExecuteReader();

                if (dataReader.HasRows)
                {

                    quantity += Int32.Parse(dataReader["quantity"].ToString());
                }

                dataReader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                return quantity;
            }

            return quantity;
        }

        private Boolean setAmountDue()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");
                comm = new SqlCommand("UPDATE tblStudents SET amountDue = @amountDue WHERE studentId = @studentId", conn);

                comm.Parameters.AddWithValue("@studentId", Form1.Globals.StudID);
                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }
    }
}
