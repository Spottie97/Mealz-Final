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
    public partial class Create_NewAcc : Form
    {
        public Create_NewAcc()
        {
            InitializeComponent();
        }

        SqlDataAdapter adap;
        SqlConnection conn;
        SqlCommand comm;

        private void btnCreate_Click(object sender, EventArgs e)
        {
             try
             {
                 conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

                 if (txtName.Text == "" || txtSurname.Text == "" || txtPass.Text == "" || txtNumber.Text == "" || txtEmail.Text == "" || txtStudentNum.Text == "" && (!rbCustomer.Checked || !rbEmployee.Checked || !rbManager.Checked))
                 {
                     MessageBox.Show("Please make sure all fields contain data.");
                 }
                 else
                 {
                    if (rbCustomer.Checked)
                    {
                        conn.Open();

                        comm = new SqlCommand($"INSERT INTO tblUser(user_id, user_name, user_surname, user_email, user_cell, user_manager, user_employee, user_customer, user_pass) VALUES({txtStudentNum.Text},'{txtName.Text}','{txtSurname.Text}','{txtEmail.Text}',{txtNumber.Text},{0},{0},{1},{txtPass.Text})", conn);
                        adap = new SqlDataAdapter();

                        adap.InsertCommand = comm;
                        adap.InsertCommand.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("Customer account was created successfully.");
                    }
                    else if (rbManager.Checked)
                    {
                        if (txtCode.Text == "manager1")
                        {
                            conn.Open();

                            comm = new SqlCommand($"INSERT INTO tblUser(user_id, user_name, user_surname, user_email, user_cell, user_manager, user_employee, user_customer) VALUES({txtStudentNum.Text},'{txtName.Text}','{txtSurname.Text}','{txtEmail.Text}',{txtNumber.Text},{1},{0},{0})", conn);
                            adap = new SqlDataAdapter();

                            adap.InsertCommand = comm;
                            adap.InsertCommand.ExecuteNonQuery();

                            conn.Close();
                            MessageBox.Show("Manager account was created successfully.");
                        }
                        else { MessageBox.Show("Please enter the Verification Code"); }
                    }
                    else
                    {
                        if (txtCode.Text == "employee1")
                        {
                            conn.Open();

                            comm = new SqlCommand($"INSERT INTO tblUser(user_id, user_name, user_surname, user_email, user_cell, user_manager, user_employee, user_customer) VALUES({txtStudentNum.Text},'{txtName.Text}','{txtSurname.Text}','{txtEmail.Text}',{txtNumber.Text},{0},{1},{0})", conn);
                            adap = new SqlDataAdapter();

                            adap.InsertCommand = comm;
                            adap.InsertCommand.ExecuteNonQuery();

                            conn.Close();
                            MessageBox.Show("Employee account was created successfully.");
                        }
                        else { MessageBox.Show("Please enter the Verification Code"); }
                    }               
                }
             }
             catch (SqlException error)
             {
                 MessageBox.Show(error.Message);
             }

             if(rbManager.Checked)
             {
                frmMain_M myCreate = new frmMain_M();
                myCreate.Show();
                this.Close();
             }else if (rbEmployee.Checked)
             {
                frmMain_M myCreate = new frmMain_M();;                
                myCreate.Show();
                this.Close();
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
    }
}
