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
    public partial class frmTransactions : Form
    {
        SqlConnection conn;
        SqlCommand comm;

        public frmTransactions()
        {
            InitializeComponent();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            //We need the Order/Cart list to display
            //it needs to update the SQL database with the quantity of items bought by subtracting it from the Stock table
            //It needs to update the SQL database with the Total balance of that student for the month.
            //I have declared a Global variable that holds onto the student number that was logged in.
            //The Global variable used is StudID(if you are having trouble with it let me know its under Form1).
            //The checkbox is a required field and needs to be checked before they can confirm the order, by clicking confirm they SQL database order status should be updated to indicate order was received.




            /*
             * Do correct me if I'm wrong, but...
             * 
             * ClientOrderMenu.cs does not save the contents of lbCart to the database.
             * How are you then trying to retrieve transactions from the database to confirm the order if there aren't any transactions in there to begin with?
             * 
             * If what you're trying to do here is have the student confirm the contents of their cart before confirming the order,
             * replace the DataGridView with a ListBox which mirrors the contents of what was in lbOrderCart of ClientOrderMenu . . .
             * at which point you should then update the amount due once the student has actually confirmed the order.
             * 
             * 
             * 
             * There's some redundancy here. 
             * "update the SQL database with the quantity of items bought by subtracting it from the Stock table" was already done in ClientOrderMenu
             * as described by yourself or whoever in line 112. Are you updating the quantity twice for one order?
             * 
             * 
             * Lastly, how or why is the student confirming the order if you're already charged them for it by updating the amount due in ClientOrderMenu?
             * That renders the check box pretty useless since the student's already been charged for the order.
             */

            //Insert into tblOrder user_id and Order_date

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbTerms.Checked)
            {
                confirmOrder();
            }

            ClientOrderMenu Menu = new ClientOrderMenu();
            Menu.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClientOrderMenu Menu = new ClientOrderMenu();
            Menu.Show();
            this.Close();
        }

        private double getStudentBalance()
        {
            int balance = 0;

            try
            {
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");
                comm = new SqlCommand("SELECT * FROM SET tblStudents WHERE student_id = @student_id", conn);

                comm.Parameters.AddWithValue("@stock_name", Form1.Globals.StudID); ;
                SqlDataReader dataReader = comm.ExecuteReader();

                if (dataReader.HasRows)
                {

                    balance = Int32.Parse(dataReader["balance"].ToString());
                }

                dataReader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                return balance;
            }

            return balance;
        }

        private Boolean confirmOrder()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");
                comm = new SqlCommand("UPDATE students SET balance = @balance WHERE student_id = @student_id", conn);

                comm.Parameters.AddWithValue("@balance", getStudentBalance());
                comm.Parameters.AddWithValue("@student_id", Form1.Globals.StudID); ;
                comm.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
