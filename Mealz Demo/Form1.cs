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
    public partial class Form1 : Form
    {
        public class Globals
        {
            public static string StudID = "";
        }

        string studentnum;
        string stnum;

        public Form1()
        {
            InitializeComponent();
        }

        SqlDataAdapter adap;
        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataReader red;

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean test = true;

            try
            {
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db;Integrated Security=True");

                conn.Open();

                comm = new SqlCommand("SELECT user_id, user_pass, user_manager, user_employee, user_customer FROM tblUser WHERE user_id = '" + txtStudentNum.Text + "' AND user_pass = '" + txtPass.Text + "'", conn);
                adap = new SqlDataAdapter();
                ds = new DataSet();

                adap.SelectCommand = comm;
                adap.Fill(ds, "tblUser");

                red = comm.ExecuteReader();

                while (red.Read() && test)
                {
                    if (red.GetValue(2).ToString() == "True")
                    {
                        Globals.StudID = txtStudentNum.Text;
                        frmMain_M myMain = new frmMain_M();  //manager
                        myMain.Show();
                        test = false;
                        this.Hide();
                    }
                    else if (red.GetValue(3).ToString() == "True")
                    {
                        Globals.StudID = txtStudentNum.Text;
                        frmMain_M myMain = new frmMain_M();  //employee
                        myMain.Show();
                        test = false;
                        this.Hide();
                    }
                    else
                    {
                        Globals.StudID = txtStudentNum.Text;
                        ClientMain_M myMain = new ClientMain_M();  //customer
                        myMain.Show();
                        test = false;
                        this.Hide();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

            private void lblLoginCreateAcc_Click(object sender, EventArgs e)
            {
                Create_NewAcc myCreate = new Create_NewAcc();
                myCreate.Show();
                this.Hide();
            }

            private void lblLoginForgetPass_Click(object sender, EventArgs e)
            {
                studentnum = txtStudentNum.Text;

            Pass_Recovery frmRecover = new Pass_Recovery();
            frmRecover.Display(studentnum.ToString());
            frmRecover.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStudentNum.Text = stnum;
            txtPass.Text = "";
        }

        public void Display(string stnum)
        {
            this.stnum = stnum.ToString();
        }

        private void txtStudentNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtStudentNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
