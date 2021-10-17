
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
            this.components = new System.ComponentModel.Container();
            this.lblMenuHeading = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOrderHeading = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.lbOrderCart = new System.Windows.Forms.ListBox();
            this.lbLunch = new System.Windows.Forms.ListBox();
            this.dbBreackfast = new System.Windows.Forms.DataGridView();
            this.dbLunch = new System.Windows.Forms.DataGridView();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbBreackfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLunch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuHeading
            // 
            this.lblMenuHeading.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblMenuHeading.Location = new System.Drawing.Point(392, -9);
            this.lblMenuHeading.Name = "lblMenuHeading";
            this.lblMenuHeading.Size = new System.Drawing.Size(116, 50);
            this.lblMenuHeading.TabIndex = 0;
            this.lblMenuHeading.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(232, 474);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 59);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblOrderHeading
            // 
            this.lblOrderHeading.AutoSize = true;
            this.lblOrderHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderHeading.Location = new System.Drawing.Point(731, 75);
            this.lblOrderHeading.Name = "lblOrderHeading";
            this.lblOrderHeading.Size = new System.Drawing.Size(75, 32);
            this.lblOrderHeading.TabIndex = 3;
            this.lblOrderHeading.Text = "Order";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCheck.Location = new System.Drawing.Point(746, 506);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(109, 48);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Checkout";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 15;
            this.lstDisplay.Location = new System.Drawing.Point(667, 121);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(282, 319);
            this.lstDisplay.TabIndex = 11;
            // 
            // lbOrderCart
            // 
            this.lbOrderCart.Location = new System.Drawing.Point(0, 0);
            this.lbOrderCart.Name = "lbOrderCart";
            this.lbOrderCart.Size = new System.Drawing.Size(120, 96);
            this.lbOrderCart.TabIndex = 0;
            // 
            // lbLunch
            // 
            this.lbLunch.Location = new System.Drawing.Point(0, 0);
            this.lbLunch.Name = "lbLunch";
            this.lbLunch.Size = new System.Drawing.Size(120, 96);
            this.lbLunch.TabIndex = 0;
            // 
            // dbBreackfast
            // 
            this.dbBreackfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbBreackfast.Location = new System.Drawing.Point(12, 132);
            this.dbBreackfast.Name = "dbBreackfast";
            this.dbBreackfast.RowHeadersWidth = 51;
            this.dbBreackfast.RowTemplate.Height = 29;
            this.dbBreackfast.Size = new System.Drawing.Size(300, 302);
            this.dbBreackfast.TabIndex = 18;
            this.dbBreackfast.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbBreackfast_CellClick);
            this.dbBreackfast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dbLunch
            // 
            this.dbLunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbLunch.Location = new System.Drawing.Point(335, 132);
            this.dbLunch.Name = "dbLunch";
            this.dbLunch.RowHeadersWidth = 51;
            this.dbLunch.RowTemplate.Height = 29;
            this.dbLunch.Size = new System.Drawing.Size(300, 302);
            this.dbLunch.TabIndex = 19;
            this.dbLunch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbLunch_CellClick);
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(250, 440);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(125, 23);
            this.txtQuan.TabIndex = 20;
            this.txtQuan.TextChanged += new System.EventHandler(this.txtQuan_TextChanged);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(746, 452);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(119, 47);
            this.btnTotal.TabIndex = 21;
            this.btnTotal.Text = "Receipt";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Breakfast";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(397, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lunch/Dinner";
            // 
            // ClientOrderMenu
            // 
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1164, 609);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.dbLunch);
            this.Controls.Add(this.dbBreackfast);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblOrderHeading);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMenuHeading);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClientOrderMenu";
            this.Text = "Order Menu";
            this.Load += new System.EventHandler(this.ClientOrderMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBreackfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLunch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnClose_Click(object sender, EventArgs e)
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
        private Label lblOrderHeading;

        public Button btnRemove { get; private set; }

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ListBox lstDisplay;
        private ListBox lbOrderCart;
        private ListBox lbLunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dbBreackfast;
        private System.Windows.Forms.DataGridView dbLunch;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private Control btnClose;
        private Control btnPayment;
    }
}