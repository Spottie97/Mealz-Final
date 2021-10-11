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
    public partial class frmMain_M : Form
    {
        int studentnum = Int32.Parse(Form1.Globals.StudID);
        public frmMain_M()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;
        SqlDataReader red;

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders_M myCon = new frmOrders_M();
            myCon.MdiParent = this;
            myCon.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock_M myCon = new frmStock_M();
            myCon.MdiParent = this;
            myCon.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistics_M myCon = new frmStatistics_M();
            myCon.MdiParent = this;
            myCon.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers_M myCon = new frmUsers_M();
            myCon.MdiParent = this;
            myCon.Show();
        }

        private void seeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenu_M myCon = new frmMenu_M();
            myCon.MdiParent = this;
            myCon.Show();
        }

        private void maintainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainMenu_M myCon = new frmMaintainMenu_M();
            myCon.MdiParent = this;
            myCon.Show();
        }

        private void frmMain_M_Load(object sender, EventArgs e)
        {
            Boolean test = true;

            try
            {
                conn = new SqlConnection(@"Data Source=ARRIES-PC\SQLEXPRESS;Initial Catalog=Mealz;Integrated Security=True");

                conn.Open();

                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand("SELECT user_manager, user_employee FROM tblUser WHERE user_id ='" + studentnum + "'", conn);
                red = comm.ExecuteReader();

                while (red.Read() && test)
                {
                    if(red.GetValue(0).ToString() == "True")
                    {
                        menuStrip1.Items[0].Enabled = true;
                        menuStrip1.Items[2].Enabled = true;
                        menuStrip1.Items[3].Enabled = true;
                        menuStrip1.Items[4].Enabled = true;

                        test = false;
                    }
                    else
                    {
                        menuStrip1.Items[0].Enabled = false;
                        menuStrip1.Items[2].Enabled = false;
                        menuStrip1.Items[3].Enabled = false;
                        menuStrip1.Items[4].Enabled = false;

                        test = false;
                    }
                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }
    }
}
