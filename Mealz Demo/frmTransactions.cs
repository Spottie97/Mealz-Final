﻿using System;
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
        public frmTransactions(string studentName)
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

            //Insert into tblOrder user_id and Order_date
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
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
    }
}
