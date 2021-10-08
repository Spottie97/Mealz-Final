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
        public frmTransactions(string studentName)
        {
            InitializeComponent();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            // Form myForm = new Form();

            string studentId = ""; // string studentId = myForm.getStudentId();
            label1.Text = "studentName's transactions";

            string sqlConnectionString = ""; // Replace "" with the connection string to your database.
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString); // Replace "" with sqlConnectionString

            sqlConnection.Open();

            string selectTransactions = "SELECT * FROM table WHERE student_id=@student_id";
            SqlCommand sqlCommand = new SqlCommand(selectTransactions, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@student_id", studentId);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    /*
                       GetString(index)

                        Add a dataReader.GetString(index) for every single column that you want to display in the textBox.
                     */

                    string transaction = "\n" + dataReader.GetString(0) + "\t" + dataReader.GetString(0);
                    textBox1.AppendText(transaction);
                }
            }

            dataReader.Close();

            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
