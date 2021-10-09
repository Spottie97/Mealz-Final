
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
            this.lstBusy = new System.Windows.Forms.ListBox();
            this.lstReady = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnCollected = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(718, 373);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 74);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mealz_Demo.Properties.Resources.Mealz_logos_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(17, -81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lstBusy
            // 
            this.lstBusy.FormattingEnabled = true;
            this.lstBusy.ItemHeight = 15;
            this.lstBusy.Location = new System.Drawing.Point(112, 135);
            this.lstBusy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBusy.Name = "lstBusy";
            this.lstBusy.Size = new System.Drawing.Size(243, 184);
            this.lstBusy.TabIndex = 7;
            // 
            // lstReady
            // 
            this.lstReady.FormattingEnabled = true;
            this.lstReady.ItemHeight = 15;
            this.lstReady.Location = new System.Drawing.Point(486, 123);
            this.lstReady.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstReady.Name = "lstReady";
            this.lstReady.Size = new System.Drawing.Size(243, 184);
            this.lstReady.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Busy ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(457, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ready for collection";
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(295, 358);
            this.btnReady.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(82, 22);
            this.btnReady.TabIndex = 11;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            // 
            // btnCollected
            // 
            this.btnCollected.Location = new System.Drawing.Point(457, 358);
            this.btnCollected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCollected.Name = "btnCollected";
            this.btnCollected.Size = new System.Drawing.Size(82, 22);
            this.btnCollected.TabIndex = 12;
            this.btnCollected.Text = "Collected";
            this.btnCollected.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(374, 398);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 22);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmOrders_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(836, 444);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCollected);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstReady);
            this.Controls.Add(this.lstBusy);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOrders_M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrders_M";
            this.Load += new System.EventHandler(this.frmOrders_M_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstBusy;
        private System.Windows.Forms.ListBox lstReady;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnCollected;
        private System.Windows.Forms.Button btnRefresh;
    }
}