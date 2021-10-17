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
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db2.0;Integrated Security=True");

                conn.Open();

                comm = new SqlCommand("SELECT user_id,user_email, user_cell, user_manager, user_employee, user_customer, user_pass  FROM tblUser WHERE user_id = '" + txtStudentNum.Text + "'", conn);
                adap = new SqlDataAdapter();
                ds = new DataSet();

                adap.SelectCommand = comm;
                adap.Fill(ds, "tblUser");

                red = comm.ExecuteReader();

                while (red.Read() && test)
                {
                    if(txtNumber.Text.StartsWith('0'))
                    {
                        MessageBox.Show("Make sure your number is correct. Remember +27 is 0.");
                    }
                    else
                    {

                        if (red.GetValue(0).ToString() == txtStudentNum.Text && red.GetValue(1).ToString() == txtEmail.Text && red.GetValue(2).ToString() == txtNumber.Text && red.GetValue(3).ToString() == "True")
                        {
                            MessageBox.Show(red.GetValue(6).ToString());        //manager
                            test = false;
                            Form1 myOne = new Form1();
                            myOne.Show();
                            this.Close();
                        }
                        else if (red.GetValue(0).ToString() == txtStudentNum.Text && red.GetValue(1).ToString() == txtEmail.Text && red.GetValue(2).ToString() == txtNumber.Text && red.GetValue(4).ToString() == "True")
                        {
                            MessageBox.Show(red.GetValue(6).ToString());        //employee
                            test = false;
                            Form1 myOne = new Form1();
                            myOne.Show();
                            this.Close();
                        }
                        else if (red.GetValue(0).ToString() == txtStudentNum.Text && red.GetValue(1).ToString() == txtEmail.Text && red.GetValue(2).ToString() == txtNumber.Text && red.GetValue(5).ToString() == "True")
                        {
                            MessageBox.Show(red.GetValue(6).ToString());        //customer
                            test = false;
                            Form1 myOne = new Form1();
                            myOne.Show();
                            this.Close();
                        }
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

        private void txtStudentNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
