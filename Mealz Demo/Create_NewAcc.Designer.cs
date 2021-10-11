
namespace Mealz_Demo
{
    partial class Create_NewAcc
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
            this.lblCreateName = new System.Windows.Forms.Label();
            this.lblHeadingCreateNew = new System.Windows.Forms.Label();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.lblCreateStudNum = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblCreateCell = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblCreateEmail = new System.Windows.Forms.Label();
            this.lblCreateSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateName
            // 
            this.lblCreateName.AutoSize = true;
            this.lblCreateName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateName.Location = new System.Drawing.Point(38, 199);
            this.lblCreateName.Name = "lblCreateName";
            this.lblCreateName.Size = new System.Drawing.Size(101, 25);
            this.lblCreateName.TabIndex = 2;
            this.lblCreateName.Text = "Full Name:";
            // 
            // lblHeadingCreateNew
            // 
            this.lblHeadingCreateNew.AutoSize = true;
            this.lblHeadingCreateNew.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingCreateNew.Location = new System.Drawing.Point(56, 28);
            this.lblHeadingCreateNew.Name = "lblHeadingCreateNew";
            this.lblHeadingCreateNew.Size = new System.Drawing.Size(488, 62);
            this.lblHeadingCreateNew.TabIndex = 3;
            this.lblHeadingCreateNew.Text = "Create New Account:";
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(38, 165);
            this.txtStudentNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentNum.MaxLength = 8;
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(223, 27);
            this.txtStudentNum.TabIndex = 0;
            this.txtStudentNum.TextChanged += new System.EventHandler(this.txtStudentNum_TextChanged);
            this.txtStudentNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentNum_KeyPress);
            // 
            // lblCreateStudNum
            // 
            this.lblCreateStudNum.AutoSize = true;
            this.lblCreateStudNum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateStudNum.Location = new System.Drawing.Point(38, 136);
            this.lblCreateStudNum.Name = "lblCreateStudNum";
            this.lblCreateStudNum.Size = new System.Drawing.Size(154, 25);
            this.lblCreateStudNum.TabIndex = 18;
            this.lblCreateStudNum.Text = "Student Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(381, 238);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.MaxLength = 9;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(184, 27);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // lblCreateCell
            // 
            this.lblCreateCell.AutoSize = true;
            this.lblCreateCell.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateCell.Location = new System.Drawing.Point(346, 200);
            this.lblCreateCell.Name = "lblCreateCell";
            this.lblCreateCell.Size = new System.Drawing.Size(122, 25);
            this.lblCreateCell.TabIndex = 16;
            this.lblCreateCell.Text = "Cell Number:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(346, 169);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 27);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(38, 297);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(223, 27);
            this.txtSurname.TabIndex = 2;
            // 
            // lblCreateEmail
            // 
            this.lblCreateEmail.AutoSize = true;
            this.lblCreateEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateEmail.Location = new System.Drawing.Point(346, 139);
            this.lblCreateEmail.Name = "lblCreateEmail";
            this.lblCreateEmail.Size = new System.Drawing.Size(134, 25);
            this.lblCreateEmail.TabIndex = 13;
            this.lblCreateEmail.Text = "Email Address:";
            // 
            // lblCreateSurname
            // 
            this.lblCreateSurname.AutoSize = true;
            this.lblCreateSurname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateSurname.Location = new System.Drawing.Point(38, 268);
            this.lblCreateSurname.Name = "lblCreateSurname";
            this.lblCreateSurname.Size = new System.Drawing.Size(91, 25);
            this.lblCreateSurname.TabIndex = 12;
            this.lblCreateSurname.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(38, 229);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 27);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(159, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Please indicate your account type:";
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(86, 496);
            this.rbManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(89, 24);
            this.rbManager.TabIndex = 26;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(234, 496);
            this.rbEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(96, 24);
            this.rbEmployee.TabIndex = 27;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(388, 496);
            this.rbCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(150, 24);
            this.rbCustomer.TabIndex = 28;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer/Student";
            this.rbCustomer.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(211, 573);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(188, 48);
            this.btnCreate.TabIndex = 29;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCode
            // 
            this.txtCode.ForeColor = System.Drawing.Color.Silver;
            this.txtCode.Location = new System.Drawing.Point(212, 390);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(187, 27);
            this.txtCode.TabIndex = 6;
            this.txtCode.Text = "Manager/Employee only";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(227, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Verification Code";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(346, 301);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(219, 27);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(346, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(497, 653);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 35);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(346, 238);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 27);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "+27";
            // 
            // Create_NewAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(599, 701);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rbCustomer);
            this.Controls.Add(this.rbEmployee);
            this.Controls.Add(this.rbManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentNum);
            this.Controls.Add(this.lblCreateStudNum);
            this.Controls.Add(this.lblCreateCell);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblCreateEmail);
            this.Controls.Add(this.lblCreateSurname);
            this.Controls.Add(this.lblHeadingCreateNew);
            this.Controls.Add(this.lblCreateName);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Create_NewAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_NewAcc";
            this.Load += new System.EventHandler(this.Create_NewAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateName;
        private System.Windows.Forms.Label lblHeadingCreateNew;
        private System.Windows.Forms.TextBox txtStudentNum;
        private System.Windows.Forms.Label lblCreateStudNum;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblCreateCell;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblCreateEmail;
        private System.Windows.Forms.Label lblCreateSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox1;
    }
}