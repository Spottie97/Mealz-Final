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
        public ClientOrderStatus()
        {
            InitializeComponent();
        }

        private void ClientOrderStatus_Load(object sender, EventArgs e)
        {
            string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reinhardt\Desktop\Mealz\Mealz Demo\Order Status.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);

            sqlConnection.Open();


        }
    }
}
