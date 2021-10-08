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
        public frmMain_M()
        {
            InitializeComponent();
        }

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

        }
    }
}
