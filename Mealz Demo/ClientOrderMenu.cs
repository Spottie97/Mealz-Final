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
        List<string> breakfastStockIDs = new List<string>();
        List<string> lunchDinnerStockIDs = new List<string>();
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
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db2.0;Integrated Security=True");

                conn.Open();

                comm = new SqlCommand("SELECT stock_name, stock_price, menu FROM tblStock WHERE menu = 1 AND stock_Id LIKE 'BR%'", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                red = comm.ExecuteReader();
                lbBreakfast.Items.Add("============================================");

                while (red.Read())
                {
                    if (red.HasRows)
                    {
                        lbBreakfast.Items.Add(red.GetValue(0) + "\t" + "\t" + "R " + red.GetValue(1));
                        breakfastStockIDs.Add(red.GetValue(2).ToString());
                    }
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
                    if (red.HasRows)
                    {
                        lbLunch.Items.Add(red.GetValue(0) + "\t" + "\t" + "R " + red.GetValue(1));
                        lunchDinnerStockIDs.Add(red.GetValue(2).ToString());
                    }
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
                    if (red.HasRows)
                    {
                        lbLunch.Items.Add(red.GetValue(0) + "\t" + "\t" + "R " + red.GetValue(1));
                        lunchDinnerStockIDs.Add(red.GetValue(2).ToString());
                    }
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

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            foreach (string item in lbBreakfast.Items)
            {

                if (removeFromQuantity(item))
                {
                    lbOrderCart.Items.Add(item.ToString());
                }
            }

            foreach (string item in lbLunch.Items)
            {
                if (removeFromQuantity(item))
                {
                    lbOrderCart.Items.Add(item.ToString());
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            //This button should add the selected item in the menu list to the order/cart list and then update the SQl database to show the item was removed from stock quantity




            foreach (string item in lbBreakfast.Items)
            {

                if (removeFromQuantity(item))
                {
                    lbOrderCart.Items.Add(item.ToString());
                }
            }

            foreach (string item in lbLunch.Items)
            {
                if (removeFromQuantity(item))
                {
                    lbOrderCart.Items.Add(item.ToString());
                }
            }

            //setAmountDue();

        }

    

        private void lbLunch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
        foreach (string item in lbOrderCart.Items)
        {
            addToQuantity(item);
        }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
        for (int i = 0; i < lbBreakfast.Items.Count; i++)
        {
            string stockID = breakfastStockIDs[i];
            removeFromQuantity(stockID);
        }
        for (int i = 0; i < lbLunch.Items.Count; i++)
        {
            string stockID = lunchDinnerStockIDs[i];
            removeFromQuantity(stockID);
        }

        //This button should just navigate to frmTransaction

        ClientOrderStatus status = new ClientOrderStatus();
        status.Show();
        this.Close();

        //This button should just navigate to frmTransaction
        //add to Tblorder_detail (stock_id, stock_quantity)
        //subtract from tblStock (stock_quantity - stock Quantity bought)

        }

        


        private Boolean addToQuantity(string item)
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

        private Boolean removeFromQuantity(string item)
        {
        try
        {
            int quantity = getStockQuantity(item) - 1;

            conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");
            comm = new SqlCommand("UPDATE tblStock SET quantity = @quantity WHERE stock_id = @stock_id", conn);

            comm.Parameters.AddWithValue("@quantity", quantity + 1);
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

        private int getStockQuantity(string item)
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

        /*private Boolean setAmountDue()
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

        }*/
    }
}

