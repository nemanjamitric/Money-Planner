namespace Stedex
{
    partial class AddGoal
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
            this.aboutTB = new System.Windows.Forms.TextBox();
            this.saveGoalBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.goalDate = new System.Windows.Forms.MonthCalendar();
            this.GoBackBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutTB
            // 
            this.aboutTB.Location = new System.Drawing.Point(14, 46);
            this.aboutTB.Name = "aboutTB";
            this.aboutTB.Size = new System.Drawing.Size(262, 27);
            this.aboutTB.TabIndex = 18;
            // 
            // saveGoalBtn
            // 
            this.saveGoalBtn.Location = new System.Drawing.Point(341, 170);
            this.saveGoalBtn.Name = "saveGoalBtn";
            this.saveGoalBtn.Size = new System.Drawing.Size(107, 56);
            this.saveGoalBtn.TabIndex = 17;
            this.saveGoalBtn.Text = "Save";
            this.saveGoalBtn.UseVisualStyleBackColor = true;
            this.saveGoalBtn.Click += new System.EventHandler(this.saveGoalBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Amount";
            // 
            // amountBox
            // 
            this.amountBox.DecimalPlaces = 2;
            this.amountBox.Location = new System.Drawing.Point(341, 42);
            this.amountBox.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(107, 27);
            this.amountBox.TabIndex = 15;
            this.amountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amountBox.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "About Goal";
            // 
            // goalDate
            // 
            this.goalDate.Location = new System.Drawing.Point(14, 85);
            this.goalDate.MaxSelectionCount = 1;
            this.goalDate.Name = "goalDate";
            this.goalDate.TabIndex = 19;
            // 
            // GoBackBTN
            // 
            this.GoBackBTN.Location = new System.Drawing.Point(12, 12);
            this.GoBackBTN.Name = "GoBackBTN";
            this.GoBackBTN.Size = new System.Drawing.Size(29, 29);
            this.GoBackBTN.TabIndex = 20;
            this.GoBackBTN.Text = "<";
            this.GoBackBTN.UseVisualStyleBackColor = true;
            this.GoBackBTN.Click += new System.EventHandler(this.GoBackBTN_Click);
            // 
            // AddGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 310);
            this.Controls.Add(this.GoBackBTN);
            this.Controls.Add(this.goalDate);
            this.Controls.Add(this.aboutTB);
            this.Controls.Add(this.saveGoalBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label1);
            this.Name = "AddGoal";
            this.Text = "AddGoal";
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox aboutTB;
        private Button saveGoalBtn;
        private Label label2;
        private NumericUpDown amountBox;
        private Label label1;
        private MonthCalendar goalDate;
        private Button GoBackBTN;
    }
}