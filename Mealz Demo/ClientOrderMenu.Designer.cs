
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
            this.dbMenu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuHeading
            // 
            this.lblMenuHeading.AutoSize = true;
            this.lblMenuHeading.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblMenuHeading.Location = new System.Drawing.Point(248, 28);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
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
            // dbMenu
            // 
            this.dbMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbMenu.Location = new System.Drawing.Point(33, 91);
            this.dbMenu.Name = "dbMenu";
            this.dbMenu.RowTemplate.Height = 25;
            this.dbMenu.Size = new System.Drawing.Size(523, 244);
            this.dbMenu.TabIndex = 12;
            this.dbMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbMenu_CellContentClick);
            // 
            // ClientOrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(843, 425);
            this.Controls.Add(this.dbMenu);
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
            ((System.ComponentModel.ISupportInitialize)(this.dbMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuHeading;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOrderHeading;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbOrderCart;
        private System.Windows.Forms.DataGridView dbMenu;
    }
}