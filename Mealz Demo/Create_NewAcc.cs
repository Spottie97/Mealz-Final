using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Mealz_Demo
{
    public partial class Create_NewAcc : Form
    {
        string stnum;
        public Create_NewAcc()
        {
            InitializeComponent();
        }

        SqlDataAdapter adap;
        SqlConnection conn;
        SqlCommand comm;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            stnum = txtStudentNum.Text;
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            try
            {
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=Mealz_db2.0;Integrated Security=True");

                if (txtName.Text == "" || txtSurname.Text == "" || txtPass.Text == "" || txtNumber.Text == "" || txtEmail.Text == "" || txtStudentNum.Text == "" && (!rbCustomer.Checked || !rbEmployee.Checked || !rbManager.Checked))
                {
                    MessageBox.Show("Please make sure all fields contain data.");
                }
                else
                {
                    if (Regex.IsMatch(txtEmail.Text, pattern))
                    {
                        if (txtNumber.Text.StartsWith('0'))
                        {
                            MessageBox.Show("Make sure your number is correct. Remeber +27 is 0.");
                        }
                        else
                        {
                            if (txtPass.Text.StartsWith('0'))
                            {
                                MessageBox.Show("Make sure your password does not start with 0 as it violates our security protocols!");
                            }
                            else
                            {
                                if (rbCustomer.Checked)
                                {
                                    conn.Open();
                                    comm = new SqlCommand($"INSERT INTO tblUser(user_id, user_name, user_surname, user_email, user_cell, user_manager, user_employee, user_customer, user_pass) VALUES({txtStudentNum.Text},'{txtName.Text}','{txtSurname.Text}','{txtEmail.Text}',{txtNumber.Text},{0},{0},{1},{txtPass.Text})", conn);
                                    goAhead(stnum);
                                }
                                else if (rbManager.Checked)
                                {
                                    if (txtCode.Text == "manager1")
                                    {
                                        conn.Open();
                                        comm = new SqlCommand($"INSERT INTO tblUser(user_id, user_name, user_surname, user_email, user_cell, user_manager, user_employee, user_customer, user_pass) VALUES({txtStudentNum.Text},'{txtName.Text}','{txtSurname.Text}','{txtEmail.Text}',{txtNumber.Text},{1},{0},{0},{txtPass.Text})", conn);
                                        goAhead(stnum);
                                    }
                                    else { MessageBox.Show("Please enter the Verification Code"); }
                                }
                                else if (rbEmployee.Checked)
                                {
                                    if (txtCode.Text == "employee1")
                                    {
                                        conn.Open();
                                        comm = new SqlCommand($"INSERT INTO tblUser(user_id, user_name, user_surname, user_email, user_cell, user_manager, user_employee, user_customer, user_pass) VALUES({txtStudentNum.Text},'{txtName.Text}','{txtSurname.Text}','{txtEmail.Text}',{txtNumber.Text},{0},{1},{0},{txtPass.Text})", conn);
                                        goAhead(stnum);
                                    }
                                    else { MessageBox.Show("Please enter the Verification Code"); }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please make sure your email format is correct");
                    }
                }
            }
            catch (SqlException error)
            {
                 MessageBox.Show(error.Message);
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            if(txtCode.Text == "Manager/Employee only")
            {
                txtCode.Text = "";
                txtCode.ForeColor = Color.Black;
            }
        }

        public void goAhead(string stnum)
        {
            adap = new SqlDataAdapter();

            adap.InsertCommand = comm;
            adap.InsertCommand.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Account was created successfully.");


            Form1 myOne = new Form1();
            myOne.Display(stnum.ToString());
            myOne.Show();
            this.Close();
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                txtCode.Text = "Manager/Employee only";
                txtCode.ForeColor = Color.Silver;
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frmOne = new Form1();
            frmOne.Show();
            this.Close();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch!=46)
            {
                e.Handled = true;
            }
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

        private void Create_NewAcc_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("You can only enter a password that contain letters.");
            }
        }

        private void lblHeadingCreateNew_Click(object sender, EventArgs e)
        {

        }
    }
}
