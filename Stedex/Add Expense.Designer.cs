namespace Stedex
{
    partial class Add_Expense
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
            this.artikliComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewSubtypeBtn = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.saveExpenseBtn = new System.Windows.Forms.Button();
            this.GoBackBTN = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // artikliComboBox
            // 
            this.artikliComboBox.FormattingEnabled = true;
            this.artikliComboBox.Location = new System.Drawing.Point(40, 72);
            this.artikliComboBox.Name = "artikliComboBox";
            this.artikliComboBox.Size = new System.Drawing.Size(243, 28);
            this.artikliComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Expense";
            // 
            // addNewSubtypeBtn
            // 
            this.addNewSubtypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewSubtypeBtn.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewSubtypeBtn.Location = new System.Drawing.Point(147, 106);
            this.addNewSubtypeBtn.Name = "addNewSubtypeBtn";
            this.addNewSubtypeBtn.Size = new System.Drawing.Size(136, 25);
            this.addNewSubtypeBtn.TabIndex = 2;
            this.addNewSubtypeBtn.Text = "Add new expense subtype";
            this.addNewSubtypeBtn.UseVisualStyleBackColor = true;
            this.addNewSubtypeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceBox
            // 
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Location = new System.Drawing.Point(100, 205);
            this.priceBox.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(107, 27);
            this.priceBox.TabIndex = 4;
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceBox.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // saveExpenseBtn
            // 
            this.saveExpenseBtn.Location = new System.Drawing.Point(100, 281);
            this.saveExpenseBtn.Name = "saveExpenseBtn";
            this.saveExpenseBtn.Size = new System.Drawing.Size(107, 56);
            this.saveExpenseBtn.TabIndex = 6;
            this.saveExpenseBtn.Text = "Save";
            this.saveExpenseBtn.UseVisualStyleBackColor = true;
            this.saveExpenseBtn.Click += new System.EventHandler(this.saveExpenseBtn_Click);
            // 
            // GoBackBTN
            // 
            this.GoBackBTN.Location = new System.Drawing.Point(12, 12);
            this.GoBackBTN.Name = "GoBackBTN";
            this.GoBackBTN.Size = new System.Drawing.Size(29, 29);
            this.GoBackBTN.TabIndex = 7;
            this.GoBackBTN.Text = "<";
            this.GoBackBTN.UseVisualStyleBackColor = true;
            this.GoBackBTN.Click += new System.EventHandler(this.GoBackBTN_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(12, 330);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(51, 20);
            this.messageLabel.TabIndex = 38;
            this.messageLabel.Text = "label7";
            // 
            // Add_Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 359);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.GoBackBTN);
            this.Controls.Add(this.saveExpenseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.addNewSubtypeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.artikliComboBox);
            this.Name = "Add_Expense";
            this.Text = "Add_Expense";
            this.Load += new System.EventHandler(this.Add_Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox artikliComboBox;
        private Label label1;
        private Button addNewSubtypeBtn;
        private NumericUpDown priceBox;
        private Label label2;
        private Button saveExpenseBtn;
        private Button GoBackBTN;
        private Label messageLabel;
    }
}