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
    public partial class Pass_Recovery : Form
    {
        string studentnum;
        public Pass_Recovery()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adap;
        SqlDataReader red;

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frmOne = new Form1();
            frmOne.Show();
            this.Close();
        }

        private void Pass_Recovery_Load(object sender, EventArgs e)
        {
            txtStudentNum.Text = studentnum;
        }

        public void Display(string studentnumber)
        {
            studentnum = studentnumber.ToString();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            Boolean test = true;

            try
            {
                conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

                conn.Open();

                comm = new SqlCommand("SELECT user_id,user_email, user_cell, user_manager, user_employee, user_customer  FROM tblUser WHERE user_id = '" + txtStudentNum.Text + "'", conn);
                adap = new SqlDataAdapter();
                ds = new DataSet();

                adap.SelectCommand = comm;
                adap.Fill(ds, "tblUser");

                red = comm.ExecuteReader();

                while (red.Read() && test)
                {
                    if (red.GetValue(0).ToString() == txtStudentNum.Text && red.GetValue(1).ToString() == txtEmail.Text && red.GetValue(2).ToString() == txtNumber.Text && red.GetValue(3).ToString() == "True")
                    {
                        frmMain_M myMain = new frmMain_M(); //manager
                        myMain.ShowDialog();
                        test = false;
                    }
                    else if (red.GetValue(0).ToString() == txtStudentNum.Text && red.GetValue(1).ToString() == txtEmail.Text && red.GetValue(2).ToString() == txtNumber.Text && red.GetValue(4).ToString() == "True")
                    {
                        frmMain_M myMain = new frmMain_M();    //employee
                        myMain.ShowDialog();
                        test = false;
                    }
                    else if (red.GetValue(0).ToString() == txtStudentNum.Text && red.GetValue(1).ToString() == txtEmail.Text && red.GetValue(2).ToString() == txtNumber.Text && red.GetValue(5).ToString() == "True")
                    {
                        frmMain_M myMain = new frmMain_M();        //customer
                        myMain.ShowDialog();
                        test = false;
                    }
                }
                if (test)
                {
                    MessageBox.Show("Make sure you entered the correct values or have an account");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            conn.Close();
        }
    }
}
