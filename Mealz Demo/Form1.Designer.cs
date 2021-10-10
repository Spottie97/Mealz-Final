
namespace Mealz_Demo
{
    partial class Form1
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbLoginPic1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.lblLoginStudentNum = new System.Windows.Forms.Label();
            this.pbLoginPic2 = new System.Windows.Forms.PictureBox();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.lblLoginForgetPass = new System.Windows.Forms.Label();
            this.lblLoginCreateAcc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginPic2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLogin.Location = new System.Drawing.Point(301, 393);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(201, 71);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbLoginPic1
            // 
            this.pbLoginPic1.Image = global::Mealz_Demo.Properties.Resources.Mealz_logos__2_;
            this.pbLoginPic1.Location = new System.Drawing.Point(14, 16);
            this.pbLoginPic1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLoginPic1.Name = "pbLoginPic1";
            this.pbLoginPic1.Size = new System.Drawing.Size(232, 248);
            this.pbLoginPic1.TabIndex = 1;
            this.pbLoginPic1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(301, 216);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(201, 27);
            this.txtPass.TabIndex = 3;
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(301, 121);
            this.txtStudentNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentNum.MaxLength = 8;
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(201, 27);
            this.txtStudentNum.TabIndex = 4;
            this.txtStudentNum.TextChanged += new System.EventHandler(this.txtStudentNum_TextChanged);
            this.txtStudentNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentNum_KeyPress);
            // 
            // lblLoginStudentNum
            // 
            this.lblLoginStudentNum.AutoSize = true;
            this.lblLoginStudentNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginStudentNum.Location = new System.Drawing.Point(301, 89);
            this.lblLoginStudentNum.Name = "lblLoginStudentNum";
            this.lblLoginStudentNum.Size = new System.Drawing.Size(161, 28);
            this.lblLoginStudentNum.TabIndex = 5;
            this.lblLoginStudentNum.Text = "Student Number:";
            // 
            // pbLoginPic2
            // 
            this.pbLoginPic2.Image = global::Mealz_Demo.Properties.Resources.Mealz_logos__2_;
            this.pbLoginPic2.Location = new System.Drawing.Point(519, 16);
            this.pbLoginPic2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLoginPic2.Name = "pbLoginPic2";
            this.pbLoginPic2.Size = new System.Drawing.Size(233, 248);
            this.pbLoginPic2.TabIndex = 6;
            this.pbLoginPic2.TabStop = false;
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginPass.Location = new System.Drawing.Point(301, 184);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(97, 28);
            this.lblLoginPass.TabIndex = 7;
            this.lblLoginPass.Text = "Password:";
            this.lblLoginPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLoginForgetPass
            // 
            this.lblLoginForgetPass.AutoSize = true;
            this.lblLoginForgetPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginForgetPass.Location = new System.Drawing.Point(161, 497);
            this.lblLoginForgetPass.Name = "lblLoginForgetPass";
            this.lblLoginForgetPass.Size = new System.Drawing.Size(156, 28);
            this.lblLoginForgetPass.TabIndex = 8;
            this.lblLoginForgetPass.Text = "Forget Password";
            this.lblLoginForgetPass.Click += new System.EventHandler(this.lblLoginForgetPass_Click);
            // 
            // lblLoginCreateAcc
            // 
            this.lblLoginCreateAcc.AutoSize = true;
            this.lblLoginCreateAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginCreateAcc.Location = new System.Drawing.Point(497, 497);
            this.lblLoginCreateAcc.Name = "lblLoginCreateAcc";
            this.lblLoginCreateAcc.Size = new System.Drawing.Size(189, 28);
            this.lblLoginCreateAcc.TabIndex = 9;
            this.lblLoginCreateAcc.Text = "Create New Account";
            this.lblLoginCreateAcc.Click += new System.EventHandler(this.lblLoginCreateAcc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(797, 660);
            this.Controls.Add(this.lblLoginCreateAcc);
            this.Controls.Add(this.lblLoginForgetPass);
            this.Controls.Add(this.lblLoginPass);
            this.Controls.Add(this.pbLoginPic2);
            this.Controls.Add(this.lblLoginStudentNum);
            this.Controls.Add(this.txtStudentNum);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pbLoginPic1);
            this.Controls.Add(this.btnLogin);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginPic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbLoginPic1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtStudentNum;
        private System.Windows.Forms.Label lblLoginStudentNum;
        private System.Windows.Forms.PictureBox pbLoginPic2;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.Label lblLoginForgetPass;
        private System.Windows.Forms.Label lblLoginCreateAcc;
    }
}