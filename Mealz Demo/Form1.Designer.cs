
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
            this.tbLoginPass = new System.Windows.Forms.TextBox();
            this.tbLoginStudentNum = new System.Windows.Forms.TextBox();
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
            this.btnLogin.Location = new System.Drawing.Point(263, 295);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(176, 53);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbLoginPic1
            // 
            this.pbLoginPic1.Image = global::Mealz_Demo.Properties.Resources.Mealz_logos__2_;
            this.pbLoginPic1.Location = new System.Drawing.Point(12, 12);
            this.pbLoginPic1.Name = "pbLoginPic1";
            this.pbLoginPic1.Size = new System.Drawing.Size(231, 247);
            this.pbLoginPic1.TabIndex = 1;
            this.pbLoginPic1.TabStop = false;
            // 
            // tbLoginPass
            // 
            this.tbLoginPass.Location = new System.Drawing.Point(263, 162);
            this.tbLoginPass.Name = "tbLoginPass";
            this.tbLoginPass.Size = new System.Drawing.Size(176, 23);
            this.tbLoginPass.TabIndex = 3;
            // 
            // tbLoginStudentNum
            // 
            this.tbLoginStudentNum.Location = new System.Drawing.Point(263, 91);
            this.tbLoginStudentNum.Name = "tbLoginStudentNum";
            this.tbLoginStudentNum.Size = new System.Drawing.Size(176, 23);
            this.tbLoginStudentNum.TabIndex = 4;
            // 
            // lblLoginStudentNum
            // 
            this.lblLoginStudentNum.AutoSize = true;
            this.lblLoginStudentNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginStudentNum.Location = new System.Drawing.Point(263, 67);
            this.lblLoginStudentNum.Name = "lblLoginStudentNum";
            this.lblLoginStudentNum.Size = new System.Drawing.Size(128, 21);
            this.lblLoginStudentNum.TabIndex = 5;
            this.lblLoginStudentNum.Text = "Student Number:";
            // 
            // pbLoginPic2
            // 
            this.pbLoginPic2.Image = global::Mealz_Demo.Properties.Resources.Mealz_logos__2_;
            this.pbLoginPic2.Location = new System.Drawing.Point(454, 12);
            this.pbLoginPic2.Name = "pbLoginPic2";
            this.pbLoginPic2.Size = new System.Drawing.Size(231, 247);
            this.pbLoginPic2.TabIndex = 6;
            this.pbLoginPic2.TabStop = false;
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginPass.Location = new System.Drawing.Point(263, 138);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(79, 21);
            this.lblLoginPass.TabIndex = 7;
            this.lblLoginPass.Text = "Password:";
            this.lblLoginPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLoginForgetPass
            // 
            this.lblLoginForgetPass.AutoSize = true;
            this.lblLoginForgetPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginForgetPass.Location = new System.Drawing.Point(141, 373);
            this.lblLoginForgetPass.Name = "lblLoginForgetPass";
            this.lblLoginForgetPass.Size = new System.Drawing.Size(125, 21);
            this.lblLoginForgetPass.TabIndex = 8;
            this.lblLoginForgetPass.Text = "Forget Password";
            // 
            // lblLoginCreateAcc
            // 
            this.lblLoginCreateAcc.AutoSize = true;
            this.lblLoginCreateAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginCreateAcc.Location = new System.Drawing.Point(435, 373);
            this.lblLoginCreateAcc.Name = "lblLoginCreateAcc";
            this.lblLoginCreateAcc.Size = new System.Drawing.Size(151, 21);
            this.lblLoginCreateAcc.TabIndex = 9;
            this.lblLoginCreateAcc.Text = "Create New Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(697, 495);
            this.Controls.Add(this.lblLoginCreateAcc);
            this.Controls.Add(this.lblLoginForgetPass);
            this.Controls.Add(this.lblLoginPass);
            this.Controls.Add(this.pbLoginPic2);
            this.Controls.Add(this.lblLoginStudentNum);
            this.Controls.Add(this.tbLoginStudentNum);
            this.Controls.Add(this.tbLoginPass);
            this.Controls.Add(this.pbLoginPic1);
            this.Controls.Add(this.btnLogin);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginPic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbLoginPic1;
        private System.Windows.Forms.TextBox tbLoginPass;
        private System.Windows.Forms.TextBox tbLoginStudentNum;
        private System.Windows.Forms.Label lblLoginStudentNum;
        private System.Windows.Forms.PictureBox pbLoginPic2;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.Label lblLoginForgetPass;
        private System.Windows.Forms.Label lblLoginCreateAcc;
    }
}