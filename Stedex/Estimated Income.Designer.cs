namespace Stedex
{
    partial class Estimated_Income
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GoBackBTN = new System.Windows.Forms.Button();
            this.estIncBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.estIncBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is your monthly income?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoBackBTN
            // 
            this.GoBackBTN.Location = new System.Drawing.Point(12, 12);
            this.GoBackBTN.Name = "GoBackBTN";
            this.GoBackBTN.Size = new System.Drawing.Size(29, 29);
            this.GoBackBTN.TabIndex = 15;
            this.GoBackBTN.Text = "<";
            this.GoBackBTN.UseVisualStyleBackColor = true;
            this.GoBackBTN.Click += new System.EventHandler(this.GoBackBTN_Click);
            // 
            // estIncBox
            // 
            this.estIncBox.DecimalPlaces = 2;
            this.estIncBox.Location = new System.Drawing.Point(90, 134);
            this.estIncBox.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.estIncBox.Name = "estIncBox";
            this.estIncBox.Size = new System.Drawing.Size(107, 27);
            this.estIncBox.TabIndex = 16;
            this.estIncBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.estIncBox.ThousandsSeparator = true;
            // 
            // Estimated_Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 289);
            this.Controls.Add(this.estIncBox);
            this.Controls.Add(this.GoBackBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Estimated_Income";
            this.Text = "Estimated_Income";
            ((System.ComponentModel.ISupportInitialize)(this.estIncBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button button1;
        private Button GoBackBTN;
        private NumericUpDown estIncBox;
    }
}