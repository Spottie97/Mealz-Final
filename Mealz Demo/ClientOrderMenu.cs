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

                comm = new SqlCommand("SELECT stock_Id, stock_name, stock_price, menu FROM tblStock WHERE menu = 1 AND stock_Id LIKE 'BR%'", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                red = comm.ExecuteReader();

                while (red.Read())
                {
                    if (red.HasRows)
                    {
                        clbBreakfast.Items.Add(red.GetValue(1) + "\t" + "\t" + "R " + red.GetValue(2));
                        breakfastStockIDs.Add(red.GetValue(0).ToString());
                    }
                }

                red.Close();

                ///////////////////////////////////////////////////////////////////

                comm = new SqlCommand("SELECT stock_Id, stock_name, stock_price,menu FROM tblStock WHERE stock_Id LIKE 'IM%' AND menu = 1", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                red = comm.ExecuteReader();

                while (red.Read())
                {
                    if (red.HasRows)
                    {
                        clbLunch.Items.Add(red.GetValue(1) + "\t" + "\t" + "R " + red.GetValue(2));
                        lunchDinnerStockIDs.Add(red.GetValue(0).ToString());
                    }
                }


                red.Close();

                //////////////////////////////////////////////////////////////////

                comm = new SqlCommand("SELECT stock_Id, stock_name, stock_price,menu FROM tblStock WHERE stock_Id LIKE 'NM%' AND menu = 1", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                red = comm.ExecuteReader();

                while (red.Read())
                {
                    if (red.HasRows)
                    {
                        clbLunch.Items.Add(red.GetValue(1) + "\t" + "\t" + "R " + red.GetValue(2));
                        lunchDinnerStockIDs.Add(red.GetValue(0).ToString());
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

        


        private Boolean addToQuantity(string item)
        {
            int quantity = getStockQuantity(item)+1;

            try
            {
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");
                comm = new SqlCommand("UPDATE tblStock SET quantity = @quantity WHERE stock_Id = @stock_id", conn);
                
                comm.Parameters.AddWithValue("@quantity", quantity);
                comm.Parameters.AddWithValue("@stock_id", item);

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
            comm = new SqlCommand("UPDATE tblStock SET quantity = @quantity WHERE stock_Id = @stock_id", conn);

            comm.Parameters.AddWithValue("@quantity", quantity);
            comm.Parameters.AddWithValue("@stock_id", item);

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

        private int getStockQuantity(string stockID)
        {
        int quantity = 0;

        try
        {
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");
            comm = new SqlCommand("SELECT * FROM SET tblStock WHERE stock_Id = @stock_id", conn);

            comm.Parameters.AddWithValue("@stock_d", stockID);
            SqlDataReader dataReader = comm.ExecuteReader();

            if (dataReader.HasRows)
            {

                quantity += Int32.Parse(dataReader.GetValue(0).ToString());
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

        private Boolean placeOrder()
        {
            try
            {
                string sqlconnectionString = @"Data Source =.; Initial Catalog = Mealz_db; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(sqlconnectionString);

                sqlConnection.Open();

                string sqlOrderBeingPrepared = "INSERT INTO tblOrder(user_id, order_done, order_collected, order_date) VALUES(@student_id, @order_done, @order_collect, @order_date";
                SqlCommand sqlCommand = new SqlCommand(sqlOrderBeingPrepared, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@user_id", Form1.Globals.StudID);
                sqlCommand.Parameters.AddWithValue("@order_done", 0);
                sqlCommand.Parameters.AddWithValue("@order_collect", 0);
                sqlCommand.Parameters.AddWithValue("@order_date", DateTime.Now.ToString("yyyy/mm/dd"));
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            for(int i = 0; i<clbBreakfast.Items.Count;i++)
            {
                if(clbBreakfast.GetItemChecked(i))
                {
                    lbOrderCart.Items.Add(clbBreakfast.Items[i].ToString());
                    removeFromQuantity(breakfastStockIDs[i]);

                }
            }
            for (int i = 0; i < clbLunch.Items.Count; i++)
            {
                if (clbLunch.GetItemChecked(i))
                {
                    lbOrderCart.Items.Add(clbLunch.Items[i].ToString()); 
                    removeFromQuantity(lunchDinnerStockIDs[i]);

                }
            }
            /*foreach (string item in clbBreakfast.SelectedItems)
            {
                lbOrderCart.Items.Add(item);

                int index = clbBreakfast.Items.IndexOf(item);
                removeFromQuantity(breakfastStockIDs[index]);
               
            }

            foreach (string item in clbLunch.SelectedItems)
            {
                lbOrderCart.Items.Add(item);

                int index = clbLunch.Items.IndexOf(item);
                removeFromQuantity(lunchDinnerStockIDs[index]);

            }*/
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            foreach (string item in lbOrderCart.Items)
            {
                addToQuantity(item);
            }
            foreach (object item in lbOrderCart.SelectedItems)
            {
                lbOrderCart.Items.Remove(item);
            }
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            placeOrder();
            for (int i = 0; i < clbBreakfast.Items.Count; i++)
            {
                string stockID = breakfastStockIDs[i];
                removeFromQuantity(stockID);
            }
            for (int i = 0; i < clbLunch.Items.Count; i++)
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

    }
}

