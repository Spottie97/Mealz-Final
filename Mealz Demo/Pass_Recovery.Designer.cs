
namespace Mealz_Demo
{
    partial class Pass_Recovery
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
            this.lblHeadingPassRec = new System.Windows.Forms.Label();
            this.lblPassEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassCell = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeadingPassRec
            // 
            this.lblHeadingPassRec.AutoSize = true;
            this.lblHeadingPassRec.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingPassRec.Location = new System.Drawing.Point(113, 9);
            this.lblHeadingPassRec.Name = "lblHeadingPassRec";
            this.lblHeadingPassRec.Size = new System.Drawing.Size(274, 38);
            this.lblHeadingPassRec.TabIndex = 0;
            this.lblHeadingPassRec.Text = "Password Recovery:";
            // 
            // lblPassEmail
            // 
            this.lblPassEmail.AutoSize = true;
            this.lblPassEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassEmail.Location = new System.Drawing.Point(175, 143);
            this.lblPassEmail.Name = "lblPassEmail";
            this.lblPassEmail.Size = new System.Drawing.Size(134, 25);
            this.lblPassEmail.TabIndex = 4;
            this.lblPassEmail.Text = "Email Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 172);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // lblPassCell
            // 
            this.lblPassCell.AutoSize = true;
            this.lblPassCell.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassCell.Location = new System.Drawing.Point(175, 223);
            this.lblPassCell.Name = "lblPassCell";
            this.lblPassCell.Size = new System.Drawing.Size(122, 25);
            this.lblPassCell.TabIndex = 7;
            this.lblPassCell.Text = "Cell Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(141, 252);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.MaxLength = 10;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(197, 27);
            this.txtNumber.TabIndex = 8;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValidate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnValidate.Location = new System.Drawing.Point(141, 322);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(202, 47);
            this.btnValidate.TabIndex = 9;
            this.btnValidate.Text = "Validate Information";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(430, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(141, 102);
            this.txtStudentNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentNum.MaxLength = 8;
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(197, 27);
            this.txtStudentNum.TabIndex = 12;
            this.txtStudentNum.TextChanged += new System.EventHandler(this.txtStudentNum_TextChanged);
            this.txtStudentNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(175, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student Number";
            // 
            // Pass_Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(536, 403);
            this.Controls.Add(this.txtStudentNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblPassCell);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassEmail);
            this.Controls.Add(this.lblHeadingPassRec);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pass_Recovery";
            this.Text = "Password Recovery";
            this.Load += new System.EventHandler(this.Pass_Recovery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingPassRec;
        private System.Windows.Forms.Label lblPassEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassCell;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtStudentNum;
        private System.Windows.Forms.Label label1;
    }
}