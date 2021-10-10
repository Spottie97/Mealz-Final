
namespace Mealz_Demo
{
    partial class ClientReport
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
            this.lblHeadingTrans = new System.Windows.Forms.Label();
            this.dbHistory = new System.Windows.Forms.DataGridView();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadingTrans
            // 
            this.lblHeadingTrans.AutoSize = true;
            this.lblHeadingTrans.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingTrans.Location = new System.Drawing.Point(69, 30);
            this.lblHeadingTrans.Name = "lblHeadingTrans";
            this.lblHeadingTrans.Size = new System.Drawing.Size(216, 32);
            this.lblHeadingTrans.TabIndex = 0;
            this.lblHeadingTrans.Text = "Transaction History";
            // 
            // dbHistory
            // 
            this.dbHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbHistory.Location = new System.Drawing.Point(69, 86);
            this.dbHistory.Name = "dbHistory";
            this.dbHistory.RowTemplate.Height = 25;
            this.dbHistory.Size = new System.Drawing.Size(502, 184);
            this.dbHistory.TabIndex = 1;
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTotal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTotal.Location = new System.Drawing.Point(69, 321);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(108, 40);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "Total ";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(69, 288);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 21);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.Location = new System.Drawing.Point(463, 321);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.AutoSize = true;
            this.lblTotalOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalOutput.Location = new System.Drawing.Point(143, 288);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(0, 21);
            this.lblTotalOutput.TabIndex = 5;
            // 
            // ClientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.lblTotalOutput);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.dbHistory);
            this.Controls.Add(this.lblHeadingTrans);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Name = "ClientReport";
            this.Text = "ClientReport";
            this.Load += new System.EventHandler(this.ClientReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingTrans;
        private System.Windows.Forms.DataGridView dbHistory;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalOutput;
    }
}