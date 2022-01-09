namespace Stedex
{
    partial class Register
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
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.pwdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpwdTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.GoBackBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnameTB
            // 
            this.lnameTB.Location = new System.Drawing.Point(384, 86);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(261, 27);
            this.lnameTB.TabIndex = 0;
            // 
            // fnameTB
            // 
            this.fnameTB.Location = new System.Drawing.Point(34, 86);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(263, 27);
            this.fnameTB.TabIndex = 1;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(36, 194);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(261, 27);
            this.emailTB.TabIndex = 2;
            // 
            // pwdTB
            // 
            this.pwdTB.Location = new System.Drawing.Point(384, 194);
            this.pwdTB.Name = "pwdTB";
            this.pwdTB.Size = new System.Drawing.Size(261, 27);
            this.pwdTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // cpwdTB
            // 
            this.cpwdTB.Location = new System.Drawing.Point(383, 300);
            this.cpwdTB.Name = "cpwdTB";
            this.cpwdTB.Size = new System.Drawing.Size(261, 27);
            this.cpwdTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirm Password";
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(36, 281);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(119, 46);
            this.regBtn.TabIndex = 10;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // GoBackBTN
            // 
            this.GoBackBTN.Location = new System.Drawing.Point(34, 12);
            this.GoBackBTN.Name = "GoBackBTN";
            this.GoBackBTN.Size = new System.Drawing.Size(29, 29);
            this.GoBackBTN.TabIndex = 15;
            this.GoBackBTN.Text = "<";
            this.GoBackBTN.UseVisualStyleBackColor = true;
            this.GoBackBTN.Click += new System.EventHandler(this.GoBackBTN_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 380);
            this.Controls.Add(this.GoBackBTN);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cpwdTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwdTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.fnameTB);
            this.Controls.Add(this.lnameTB);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox lnameTB;
        private TextBox fnameTB;
        private TextBox emailTB;
        private TextBox pwdTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox cpwdTB;
        private Label label5;
        private Button regBtn;
        private Button GoBackBTN;
    }
}