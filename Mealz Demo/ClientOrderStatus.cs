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
    public partial class ClientOrderStatus : Form
    {
        private int ticks;
        Boolean test = true;
        int StudentNum =Int32.Parse(Form1.Globals.StudID);

        public ClientOrderStatus()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;
        SqlDataReader red;

        private void ClientOrderStatus_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            this.BackColor = Color.Maroon;

            try
            {
                LoadAll(test);
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        public void LoadAll(Boolean test)
        {
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db2.0;Integrated Security=True");

            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();
            comm = new SqlCommand("SELECT order_done FROM tblOrder WHERE user_id='" + StudentNum + "'", conn);

            red = comm.ExecuteReader();

            while (red.Read() && test)
            {
                if(red.GetValue(1).ToString() == "True")
                {
                    label1.Visible = true;
                    this.BackColor = Color.Green;
                }
            }
            red.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;

            while(this.BackColor != Color.Green)
            {
                if (ticks/5 == 0)
                {
                    try
                    {
                        LoadAll(test);
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                timer1.Dispose();
            } 
        }
    }
}
