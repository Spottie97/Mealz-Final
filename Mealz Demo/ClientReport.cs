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
    public partial class ClientReport : Form
    {
        SqlConnection sqlconnection;
        SqlCommand sqlcommand;
        string ConnectionString = @"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True";
        string Query;
        DataSet dataset;
        DataTable datatable;
        SqlDataAdapter sqladapter;
        string StudentNum = Form1.Globals.StudID;

        public ClientReport()
        {
            InitializeComponent();
        }

        private void ClientReport_Load(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(ConnectionString);
            Query = "SELECT * from ReportHistoryClient WHERE user_id=@StudentNum";
            sqlcommand = new SqlCommand(Query, sqlconnection);
            sqladapter = new SqlDataAdapter();
            datatable = new DataTable();
            sqladapter.SelectCommand = sqlcommand;
            sqladapter.Fill(datatable);
            dbHistory.DataSource = datatable;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(ConnectionString);
            string query = "SELECT SUM(Total) FROM tblorder_detail WHERE StudentNum = @StudentNum";
            SqlCommand comm = new SqlCommand(query,sqlconnection);
            //comm.Parameters.Add("@StudentNum", SqlDbType.Int).Value;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClientMain_M Main = new ClientMain_M();
            Main.Show();
            this.Close();
        }
    }
}
