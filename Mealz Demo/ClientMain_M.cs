using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mealz_Demo
{
    public partial class ClientMain_M : Form
    {
        public ClientMain_M()
        {
            InitializeComponent();
        }

        private void ClientMain_M_Load(object sender, EventArgs e)
        {

        }

        private void orderMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientOrderMenu myCon = new ClientOrderMenu();
            myCon.MdiParent = this;
            myCon.Show();

        }

        private void orderStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientOrderStatus myCon = new ClientOrderStatus();
            myCon.MdiParent = this;
            myCon.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientReport ClientReport = new ClientReport();
            ClientReport.MdiParent = this;
            ClientReport.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.Globals.StudID = "";
            Form1 Login = new Form1();
            Login.Show();
            this.Close();
        }
    }
}
