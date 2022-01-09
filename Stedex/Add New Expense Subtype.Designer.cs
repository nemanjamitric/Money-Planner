namespace Stedex
{
    partial class Add_New_Expense_Subtype
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
            this.subtypeNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.necessityBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subtypesComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GoBackBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.necessityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // subtypeNameTB
            // 
            this.subtypeNameTB.Location = new System.Drawing.Point(34, 64);
            this.subtypeNameTB.Name = "subtypeNameTB";
            this.subtypeNameTB.Size = new System.Drawing.Size(334, 27);
            this.subtypeNameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense Subtype Name";
            // 
            // necessityBar
            // 
            this.necessityBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.necessityBar.Location = new System.Drawing.Point(33, 165);
            this.necessityBar.Maximum = 5;
            this.necessityBar.Minimum = 1;
            this.necessityBar.Name = "necessityBar";
            this.necessityBar.Size = new System.Drawing.Size(334, 56);
            this.necessityBar.TabIndex = 2;
            this.necessityBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.necessityBar.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Necessity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "1          2          3          4          5";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subtypes Type";
            // 
            // subtypesComboBox
            // 
            this.subtypesComboBox.FormattingEnabled = true;
            this.subtypesComboBox.Location = new System.Drawing.Point(33, 330);
            this.subtypesComboBox.Name = "subtypesComboBox";
            this.subtypesComboBox.Size = new System.Drawing.Size(333, 28);
            this.subtypesComboBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add New Expense Type";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 69);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GoBackBTN
            // 
            this.GoBackBTN.Location = new System.Drawing.Point(12, 12);
            this.GoBackBTN.Name = "GoBackBTN";
            this.GoBackBTN.Size = new System.Drawing.Size(29, 29);
            this.GoBackBTN.TabIndex = 16;
            this.GoBackBTN.Text = "<";
            this.GoBackBTN.UseVisualStyleBackColor = true;
            this.GoBackBTN.Click += new System.EventHandler(this.GoBackBTN_Click);
            // 
            // Add_New_Expense_Subtype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 464);
            this.Controls.Add(this.GoBackBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subtypesComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.necessityBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtypeNameTB);
            this.Name = "Add_New_Expense_Subtype";
            this.Text = "Add_New_Expense_Subtype";
            this.Load += new System.EventHandler(this.Add_New_Expense_Subtype_Load);
            ((System.ComponentModel.ISupportInitialize)(this.necessityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox subtypeNameTB;
        private Label label1;
        private TrackBar necessityBar;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox subtypesComboBox;
        private Button button1;
        private Button button2;
        private Button GoBackBTN;
        private Button button3;
    }
}