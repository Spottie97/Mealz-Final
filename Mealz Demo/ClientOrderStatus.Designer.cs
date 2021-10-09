
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
            this.lbOrderPrep = new System.Windows.Forms.ListBox();
            this.lbOrderReady = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblOrderPrepHeading = new System.Windows.Forms.Label();
            this.lblOrderReadyHeading = new System.Windows.Forms.Label();
            this.lblClientStatHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOrderPrep
            // 
            this.lbOrderPrep.FormattingEnabled = true;
            this.lbOrderPrep.ItemHeight = 15;
            this.lbOrderPrep.Location = new System.Drawing.Point(56, 138);
            this.lbOrderPrep.Name = "lbOrderPrep";
            this.lbOrderPrep.Size = new System.Drawing.Size(262, 274);
            this.lbOrderPrep.TabIndex = 0;
            // 
            // lbOrderReady
            // 
            this.lbOrderReady.FormattingEnabled = true;
            this.lbOrderReady.ItemHeight = 15;
            this.lbOrderReady.Location = new System.Drawing.Point(429, 138);
            this.lbOrderReady.Name = "lbOrderReady";
            this.lbOrderReady.Size = new System.Drawing.Size(262, 274);
            this.lbOrderReady.TabIndex = 1;
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
            // lblOrderPrepHeading
            // 
            this.lblOrderPrepHeading.AutoSize = true;
            this.lblOrderPrepHeading.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderPrepHeading.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblOrderPrepHeading.Location = new System.Drawing.Point(56, 102);
            this.lblOrderPrepHeading.Name = "lblOrderPrepHeading";
            this.lblOrderPrepHeading.Size = new System.Drawing.Size(185, 25);
            this.lblOrderPrepHeading.TabIndex = 3;
            this.lblOrderPrepHeading.Text = "Order being prepared";
            // 
            // lblOrderReadyHeading
            // 
            this.lblOrderReadyHeading.AutoSize = true;
            this.lblOrderReadyHeading.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderReadyHeading.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblOrderReadyHeading.Location = new System.Drawing.Point(429, 102);
            this.lblOrderReadyHeading.Name = "lblOrderReadyHeading";
            this.lblOrderReadyHeading.Size = new System.Drawing.Size(222, 25);
            this.lblOrderReadyHeading.TabIndex = 4;
            this.lblOrderReadyHeading.Text = "Order Ready for Collection";
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
            // ClientOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(746, 645);
            this.Controls.Add(this.lblClientStatHeading);
            this.Controls.Add(this.lblOrderReadyHeading);
            this.Controls.Add(this.lblOrderPrepHeading);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbOrderReady);
            this.Controls.Add(this.lbOrderPrep);
            this.Name = "ClientOrderStatus";
            this.Text = "Order Status";
            this.Load += new System.EventHandler(this.ClientOrderStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrderPrep;
        private System.Windows.Forms.ListBox lbOrderReady;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblOrderPrepHeading;
        private System.Windows.Forms.Label lblOrderReadyHeading;
        private System.Windows.Forms.Label lblClientStatHeading;
    }
}