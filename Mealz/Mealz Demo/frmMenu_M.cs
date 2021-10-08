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
    public partial class frmMenu_M : Form
    {
        public frmMenu_M()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;
        SqlDataReader red;


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_M_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

                conn.Open();

                comm = new SqlCommand("SELECT stock_name, stock_price,menu FROM tblStock where stock_Id LIKE 'BR%'", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                red = comm.ExecuteReader();
                lstOutput.Items.Add("============================================");
                
                while (red.Read())
                {
                    if(red.GetValue(2) == "True")
                    {
                        lstOutput.Items.Add(red.GetValue(0) + "\t" + "\t" + "R " + red.GetValue(1));
                    }                 
                }

                red.Close();

                ///////////////////////////////////////////////////////////////////

                comm = new SqlCommand("SELECT stock_name, stock_price,menu FROM tblStock where stock_Id LIKE 'IM%'", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                red = comm.ExecuteReader();

                lstDisplay.Items.Add("The Meats on the menu");
                lstDisplay.Items.Add("============================================");

                while (red.Read())
                {
                    lstDisplay.Items.Add(red.GetValue(0) + "\t" + "\t" +"R " + red.GetValue(1));
                }

                lstDisplay.Items.Add("");
                lstDisplay.Items.Add("Non Meats");
                lstDisplay.Items.Add("=============================================");

                red.Close();

                //////////////////////////////////////////////////////////////////

                comm = new SqlCommand("SELECT stock_name, stock_price,menu FROM tblStock where stock_Id LIKE 'NM%'", conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "tblStock");

                red = comm.ExecuteReader();

                while (red.Read())
                {
                    lstDisplay.Items.Add(red.GetValue(0) + "\t" + "\t" +"R " + red.GetValue(1));
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
    }
}
