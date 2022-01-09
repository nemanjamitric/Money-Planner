namespace Stedex
{
    partial class Add_Income
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
            this.saveExpenseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutTB = new System.Windows.Forms.TextBox();
            this.GoBackBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveExpenseBtn
            // 
            this.saveExpenseBtn.Location = new System.Drawing.Point(73, 241);
            this.saveExpenseBtn.Name = "saveExpenseBtn";
            this.saveExpenseBtn.Size = new System.Drawing.Size(107, 56);
            this.saveExpenseBtn.TabIndex = 12;
            this.saveExpenseBtn.Text = "Save";
            this.saveExpenseBtn.UseVisualStyleBackColor = true;
            this.saveExpenseBtn.Click += new System.EventHandler(this.saveExpenseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Amount";
            // 
            // amountBox
            // 
            this.amountBox.DecimalPlaces = 2;
            this.amountBox.Location = new System.Drawing.Point(75, 171);
            this.amountBox.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(107, 27);
            this.amountBox.TabIndex = 10;
            this.amountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amountBox.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "About income";
            // 
            // aboutTB
            // 
            this.aboutTB.Location = new System.Drawing.Point(15, 68);
            this.aboutTB.Name = "aboutTB";
            this.aboutTB.Size = new System.Drawing.Size(243, 27);
            this.aboutTB.TabIndex = 13;
            // 
            // GoBackBTN
            // 
            this.GoBackBTN.Location = new System.Drawing.Point(15, 12);
            this.GoBackBTN.Name = "GoBackBTN";
            this.GoBackBTN.Size = new System.Drawing.Size(29, 29);
            this.GoBackBTN.TabIndex = 14;
            this.GoBackBTN.Text = "<";
            this.GoBackBTN.UseVisualStyleBackColor = true;
            this.GoBackBTN.Click += new System.EventHandler(this.GoBackBTN_Click);
            // 
            // Add_Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 316);
            this.Controls.Add(this.GoBackBTN);
            this.Controls.Add(this.aboutTB);
            this.Controls.Add(this.saveExpenseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label1);
            this.Name = "Add_Income";
            this.Text = "Add_Income";
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveExpenseBtn;
        private Label label2;
        private NumericUpDown amountBox;
        private Label label1;
        private TextBox aboutTB;
        private Button GoBackBTN;
    }
}