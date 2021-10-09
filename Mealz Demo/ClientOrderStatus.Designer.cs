
namespace Mealz_Demo
{
    partial class ClientOrderStatus
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblClientStatHeading = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.Location = new System.Drawing.Point(551, 572);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblClientStatHeading
            // 
            this.lblClientStatHeading.AutoSize = true;
            this.lblClientStatHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblClientStatHeading.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblClientStatHeading.Location = new System.Drawing.Point(300, 25);
            this.lblClientStatHeading.Name = "lblClientStatHeading";
            this.lblClientStatHeading.Size = new System.Drawing.Size(146, 32);
            this.lblClientStatHeading.TabIndex = 5;
            this.lblClientStatHeading.Text = "Order Status";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderStatus.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblOrderStatus.Location = new System.Drawing.Point(218, 453);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(321, 25);
            this.lblOrderStatus.TabIndex = 3;
            this.lblOrderStatus.Text = "Your Order is being made...hang tight...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(113, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 303);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ClientOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(746, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblClientStatHeading);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.btnBack);
            this.Name = "ClientOrderStatus";
            this.Text = "Order Status";
            this.Load += new System.EventHandler(this.ClientOrderStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblClientStatHeading;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}