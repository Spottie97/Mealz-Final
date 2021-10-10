
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
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOrderHeading = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuHeading
            // 
            this.lblMenuHeading.AutoSize = true;
            this.lblMenuHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuHeading.Location = new System.Drawing.Point(154, 46);
            this.lblMenuHeading.Name = "lblMenuHeading";
            this.lblMenuHeading.Size = new System.Drawing.Size(77, 32);
            this.lblMenuHeading.TabIndex = 0;
            this.lblMenuHeading.Text = "Menu";
            // 
            // lbMenu
            // 
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 15;
            this.lbMenu.Location = new System.Drawing.Point(21, 91);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(350, 259);
            this.lbMenu.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(21, 437);
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
            this.lblOrderHeading.Location = new System.Drawing.Point(584, 46);
            this.lblOrderHeading.Name = "lblOrderHeading";
            this.lblOrderHeading.Size = new System.Drawing.Size(127, 32);
            this.lblOrderHeading.TabIndex = 3;
            this.lblOrderHeading.Text = "Order/Cart";
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.ItemHeight = 15;
            this.lbOrder.Location = new System.Drawing.Point(464, 91);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(350, 259);
            this.lbOrder.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRemove.Location = new System.Drawing.Point(246, 437);
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
            this.btnPayment.Location = new System.Drawing.Point(464, 437);
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
            this.btnClose.Location = new System.Drawing.Point(689, 437);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 44);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ClientOrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(836, 529);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.lblOrderHeading);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.lblMenuHeading);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Name = "ClientOrderMenu";
            this.Text = "ClientOrderMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuHeading;
        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOrderHeading;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnClose;
    }
}