using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mealz_Demo
{
    public partial class MenuConcept : Form
    {
        frmCart myCart = new frmCart();
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

        public MenuConcept()
        {
            InitializeComponent();
        }

        private void MenuConcept_Load(object sender, EventArgs e)
        {

        }

        private void breakfastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void lunchDinnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }
        }

        private void getBreakfastItems()
        {
            sqlConnection.Open();

            string sqlOrdersBeingPrepared = "SELECT * FROM table WHERE status=@status";
            SqlCommand ordersBeingPrepared = new SqlCommand(sqlOrdersBeingPrepared, sqlConnection);

            ordersBeingPrepared.Parameters.AddWithValue("@status", 1);

            SqlDataReader dataReader = ordersBeingPrepared.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    /*
                        0 and 2 are the indexes for the orderNumber and status columns in your database.
                        
                        Now, if the order's status isn't at index 2, change the value to 3 or whatever the case may be.
                     */

                    string order = dataReader.GetString(0) + "\t" + dataReader.GetString(2);
                    checkedListBox1.Items.Add(order);
                }
            }

            dataReader.Close();

            sqlConnection.Close();
        }

        private void getLunchAndDinnerItems()
        {
            sqlConnection.Open();

            string sqlOrdersBeingPrepared = "SELECT * FROM table WHERE status=@status";
            SqlCommand ordersBeingPrepared = new SqlCommand(sqlOrdersBeingPrepared, sqlConnection);

            ordersBeingPrepared.Parameters.AddWithValue("@status", 1);

            SqlDataReader dataReader = ordersBeingPrepared.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    /*
                        0 and 2 are the indexes for the orderNumber and status columns in your database.
                        
                        Now, if the order's status isn't at index 2, change the value to 3 or whatever the case may be.
                     */

                    string order = dataReader.GetString(0) + "\t" + dataReader.GetString(2);
                    checkedListBox2.Items.Add(order);
                }
            }

            dataReader.Close();

            sqlConnection.Close();
        }

        private void addBreakfastToCart()
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        myCart.addToCart(checkedListBox1.Items[i].ToString());
                    }
                }
            }
        }

        private void addLunchAndDinnerToCart()
        {
            if (checkedListBox2.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    if (checkedListBox2.GetItemChecked(i))
                    {
                        myCart.addToCart(checkedListBox2.Items[i].ToString());
                    }
                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            addBreakfastToCart();
            addLunchAndDinnerToCart();

            myCart.Show();
            this.Hide();
        }
    }
}
