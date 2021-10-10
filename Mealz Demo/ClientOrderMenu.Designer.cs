
using System;
using System.Windows.Forms;

namespace Mealz_Demo
{
    partial class ClientOrderMenu
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
            this.lblMenuHeading = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOrderHeading = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbOrderCart = new System.Windows.Forms.ListBox();
            this.lbBreakfast = new System.Windows.Forms.ListBox();
            this.lbLunch = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMenuHeading
            // 
            this.lblMenuHeading.AutoSize = true;
            this.lblMenuHeading.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblMenuHeading.Location = new System.Drawing.Point(377, -8);
            this.lblMenuHeading.Name = "lblMenuHeading";
            this.lblMenuHeading.Size = new System.Drawing.Size(95, 41);
            this.lblMenuHeading.TabIndex = 0;
            this.lblMenuHeading.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(12, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblOrderHeading
            // 
            this.lblOrderHeading.AutoSize = true;
            this.lblOrderHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderHeading.Location = new System.Drawing.Point(640, 56);
            this.lblOrderHeading.Name = "lblOrderHeading";
            this.lblOrderHeading.Size = new System.Drawing.Size(127, 32);
            this.lblOrderHeading.TabIndex = 3;
            this.lblOrderHeading.Text = "Order/Cart";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRemove.Location = new System.Drawing.Point(145, 355);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 44);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayment.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPayment.Location = new System.Drawing.Point(584, 355);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(125, 44);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClose.Location = new System.Drawing.Point(715, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 44);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbOrderCart
            // 
            this.lbOrderCart.FormattingEnabled = true;
            this.lbOrderCart.ItemHeight = 15;
            this.lbOrderCart.Location = new System.Drawing.Point(584, 91);
            this.lbOrderCart.Name = "lbOrderCart";
            this.lbOrderCart.Size = new System.Drawing.Size(247, 244);
            this.lbOrderCart.TabIndex = 11;
            // 
            // lbBreakfast
            // 
            this.lbBreakfast.FormattingEnabled = true;
            this.lbBreakfast.ItemHeight = 15;
            this.lbBreakfast.Location = new System.Drawing.Point(23, 91);
            this.lbBreakfast.Name = "lbBreakfast";
            this.lbBreakfast.Size = new System.Drawing.Size(247, 244);
            this.lbBreakfast.TabIndex = 12;
            // 
            // lbLunch
            // 
            this.lbLunch.FormattingEnabled = true;
            this.lbLunch.ItemHeight = 15;
            this.lbLunch.Location = new System.Drawing.Point(298, 90);
            this.lbLunch.Name = "lbLunch";
            this.lbLunch.Size = new System.Drawing.Size(247, 244);
            this.lbLunch.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(377, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lunch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Breakfast";
            // 
            // ClientOrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(843, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLunch);
            this.Controls.Add(this.lbBreakfast);
            this.Controls.Add(this.lbOrderCart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblOrderHeading);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMenuHeading);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Name = "ClientOrderMenu";
            this.Text = "Order Menu";
            this.Load += new System.EventHandler(this.ClientOrderMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dbMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblMenuHeading;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOrderHeading;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbOrderCart;
        private ListBox lbBreakfast;
        private ListBox lbLunch;
        private Label label1;
        private Label label2;
    }
}