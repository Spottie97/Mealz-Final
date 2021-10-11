
namespace Mealz_Demo
{
    partial class frmOrders_M
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnCollected = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dbViewBusy = new System.Windows.Forms.DataGridView();
            this.dbViewDone = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisplayOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHelpOne = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lstHelp = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewBusy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewDone)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(821, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 99);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mealz_Demo.Properties.Resources.Mealz_logos_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(19, -108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Busy ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(578, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ready for collection";
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(15, 16);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(109, 50);
            this.btnReady.TabIndex = 11;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnCollected
            // 
            this.btnCollected.Location = new System.Drawing.Point(15, 128);
            this.btnCollected.Name = "btnCollected";
            this.btnCollected.Size = new System.Drawing.Size(109, 50);
            this.btnCollected.TabIndex = 12;
            this.btnCollected.Text = "Collected";
            this.btnCollected.UseVisualStyleBackColor = true;
            this.btnCollected.Click += new System.EventHandler(this.btnCollected_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(425, 497);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 50);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dbViewBusy
            // 
            this.dbViewBusy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewBusy.Location = new System.Drawing.Point(61, 149);
            this.dbViewBusy.Name = "dbViewBusy";
            this.dbViewBusy.RowHeadersWidth = 51;
            this.dbViewBusy.RowTemplate.Height = 29;
            this.dbViewBusy.Size = new System.Drawing.Size(310, 350);
            this.dbViewBusy.TabIndex = 14;
            this.dbViewBusy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbViewBusy_CellClick);
            // 
            // dbViewDone
            // 
            this.dbViewDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewDone.Location = new System.Drawing.Point(593, 149);
            this.dbViewDone.Name = "dbViewDone";
            this.dbViewDone.RowHeadersWidth = 51;
            this.dbViewDone.RowTemplate.Height = 29;
            this.dbViewDone.Size = new System.Drawing.Size(310, 350);
            this.dbViewDone.TabIndex = 15;
            this.dbViewDone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbViewDone_CellClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(15, 72);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 50);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(275, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 62);
            this.label3.TabIndex = 17;
            this.label3.Text = "Orders that is....";
            // 
            // btnDisplayOrder
            // 
            this.btnDisplayOrder.Location = new System.Drawing.Point(15, 184);
            this.btnDisplayOrder.Name = "btnDisplayOrder";
            this.btnDisplayOrder.Size = new System.Drawing.Size(109, 50);
            this.btnDisplayOrder.TabIndex = 18;
            this.btnDisplayOrder.Text = "Display Order";
            this.btnDisplayOrder.UseVisualStyleBackColor = true;
            this.btnDisplayOrder.Click += new System.EventHandler(this.btnDisplayOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btnCollected);
            this.panel2.Controls.Add(this.btnDisplayOrder);
            this.panel2.Controls.Add(this.btnReady);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Location = new System.Drawing.Point(410, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 247);
            this.panel2.TabIndex = 19;
            // 
            // btnHelpOne
            // 
            this.btnHelpOne.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelpOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHelpOne.Location = new System.Drawing.Point(-2, 548);
            this.btnHelpOne.Name = "btnHelpOne";
            this.btnHelpOne.Size = new System.Drawing.Size(45, 48);
            this.btnHelpOne.TabIndex = 20;
            this.btnHelpOne.Text = "?";
            this.btnHelpOne.UseVisualStyleBackColor = true;
            this.btnHelpOne.Visible = false;
            this.btnHelpOne.Click += new System.EventHandler(this.btnHelpOne_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHelp.Location = new System.Drawing.Point(-3, 548);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(45, 48);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lstHelp
            // 
            this.lstHelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHelp.FormattingEnabled = true;
            this.lstHelp.ItemHeight = 20;
            this.lstHelp.Items.AddRange(new object[] {
            "READY BUTTON",
            "-------------------------------------------------------",
            "Moves the order from BUSY table to the ",
            "READY FOR COLLECTION table.",
            "=================================",
            "RETURN BUTTON",
            "-------------------------------------------------------",
            "If you selected the wrong order when you pressed",
            "ready, you must just select the order in the other \t",
            "table and press the RETURN button to get it back\t",
            "in the busy table.",
            "=================================",
            "COLLECTED BUTTON",
            "-------------------------------------------------------",
            "When the user collected their order you press the\t",
            "COLLECTED button",
            "=================================",
            "DISPLAY ORDER BUTTON",
            "-------------------------------------------------------",
            "You press DISPLAY ORDER button when you want\t",
            "to see what the order consists of.",
            "=================================",
            "REFRESH BUTTON",
            "-------------------------------------------------------",
            "This button just set the forms back to normal."});
            this.lstHelp.Location = new System.Drawing.Point(297, 151);
            this.lstHelp.Name = "lstHelp";
            this.lstHelp.Size = new System.Drawing.Size(375, 340);
            this.lstHelp.TabIndex = 22;
            this.lstHelp.Visible = false;
            // 
            // frmOrders_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(955, 592);
            this.Controls.Add(this.lstHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnHelpOne);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dbViewDone);
            this.Controls.Add(this.dbViewBusy);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmOrders_M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.frmOrders_M_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewBusy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewDone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnCollected;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dbViewBusy;
        private System.Windows.Forms.DataGridView dbViewDone;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDisplayOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHelpOne;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListBox lstHelp;
    }
}