
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewBusy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewDone)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 68);
            this.label1.TabIndex = 9;
            this.label1.Text = "Busy ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(566, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ready for collection";
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(337, 459);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(94, 29);
            this.btnReady.TabIndex = 11;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnCollected
            // 
            this.btnCollected.Location = new System.Drawing.Point(534, 459);
            this.btnCollected.Name = "btnCollected";
            this.btnCollected.Size = new System.Drawing.Size(94, 29);
            this.btnCollected.TabIndex = 12;
            this.btnCollected.Text = "Collected";
            this.btnCollected.UseVisualStyleBackColor = true;
            this.btnCollected.Click += new System.EventHandler(this.btnCollected_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(427, 531);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dbViewBusy
            // 
            this.dbViewBusy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewBusy.Location = new System.Drawing.Point(46, 158);
            this.dbViewBusy.Name = "dbViewBusy";
            this.dbViewBusy.RowHeadersWidth = 51;
            this.dbViewBusy.RowTemplate.Height = 29;
            this.dbViewBusy.Size = new System.Drawing.Size(385, 271);
            this.dbViewBusy.TabIndex = 14;
            this.dbViewBusy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbViewBusy_CellClick);
            // 
            // dbViewDone
            // 
            this.dbViewDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewDone.Location = new System.Drawing.Point(534, 158);
            this.dbViewDone.Name = "dbViewDone";
            this.dbViewDone.RowHeadersWidth = 51;
            this.dbViewDone.RowTemplate.Height = 29;
            this.dbViewDone.Size = new System.Drawing.Size(394, 271);
            this.dbViewDone.TabIndex = 15;
            this.dbViewDone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbViewDone_CellClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(110, 531);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 29);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "net vir manager";
            // 
            // frmOrders_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(955, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dbViewDone);
            this.Controls.Add(this.dbViewBusy);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCollected);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmOrders_M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrders_M";
            this.Load += new System.EventHandler(this.frmOrders_M_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewBusy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewDone)).EndInit();
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
    }
}