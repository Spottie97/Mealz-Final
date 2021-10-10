
using System;

namespace Mealz_Demo
{
    partial class frmTransactions
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
            this.lblPaymentHeading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbTerms = new System.Windows.Forms.CheckBox();
            this.lbTermAndCon = new System.Windows.Forms.ListBox();
            this.dbTransactionHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbTransactionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPaymentHeading
            // 
            this.lblPaymentHeading.AutoSize = true;
            this.lblPaymentHeading.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentHeading.Location = new System.Drawing.Point(146, 9);
            this.lblPaymentHeading.Name = "lblPaymentHeading";
            this.lblPaymentHeading.Size = new System.Drawing.Size(282, 37);
            this.lblPaymentHeading.TabIndex = 1;
            this.lblPaymentHeading.Text = "Payment Confirmation";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClose.Location = new System.Drawing.Point(321, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.Location = new System.Drawing.Point(457, 548);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 43);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnConfirm.Location = new System.Drawing.Point(12, 548);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 43);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 380);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(584, 15);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "If the above order is correct and you are willing to processed, please tik the ap" +
    "propirate box and click confirm.";
            // 
            // cbTerms
            // 
            this.cbTerms.AutoSize = true;
            this.cbTerms.Location = new System.Drawing.Point(12, 418);
            this.cbTerms.Name = "cbTerms";
            this.cbTerms.Size = new System.Drawing.Size(289, 19);
            this.cbTerms.TabIndex = 7;
            this.cbTerms.Text = "By checking this box you agree to the T\'s and C\'s .";
            this.cbTerms.UseVisualStyleBackColor = true;
            // 
            // lbTermAndCon
            // 
            this.lbTermAndCon.FormattingEnabled = true;
            this.lbTermAndCon.ItemHeight = 15;
            this.lbTermAndCon.Items.AddRange(new object[] {
            "#1 Payment will be charged to your Student Account",
            "#2 We can not be held accountable for orders not collected.",
            "#3 Orders not collected will still be charged to your Account."});
            this.lbTermAndCon.Location = new System.Drawing.Point(12, 443);
            this.lbTermAndCon.Name = "lbTermAndCon";
            this.lbTermAndCon.Size = new System.Drawing.Size(334, 94);
            this.lbTermAndCon.TabIndex = 8;
            // 
            // dbTransactionHistory
            // 
            this.dbTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbTransactionHistory.Location = new System.Drawing.Point(50, 67);
            this.dbTransactionHistory.Name = "dbTransactionHistory";
            this.dbTransactionHistory.RowTemplate.Height = 25;
            this.dbTransactionHistory.Size = new System.Drawing.Size(489, 300);
            this.dbTransactionHistory.TabIndex = 9;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(599, 603);
            this.Controls.Add(this.dbTransactionHistory);
            this.Controls.Add(this.lbTermAndCon);
            this.Controls.Add(this.cbTerms);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPaymentHeading);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Name = "frmTransactions";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbTransactionHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lblPaymentHeading;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox cbTerms;
        private System.Windows.Forms.ListBox lbTermAndCon;
        private System.Windows.Forms.DataGridView dbTransactionHistory;
    }
}