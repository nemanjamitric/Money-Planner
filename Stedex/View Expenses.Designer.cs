namespace Stedex
{
    partial class View_Expenses
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
            this.GoBackBTN = new System.Windows.Forms.Button();
            this.expensesView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.expensesView)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBackBTN
            // 
            this.GoBackBTN.Location = new System.Drawing.Point(12, 12);
            this.GoBackBTN.Name = "GoBackBTN";
            this.GoBackBTN.Size = new System.Drawing.Size(29, 29);
            this.GoBackBTN.TabIndex = 3;
            this.GoBackBTN.Text = "<";
            this.GoBackBTN.UseVisualStyleBackColor = true;
            this.GoBackBTN.Click += new System.EventHandler(this.GoBackBTN_Click);
            // 
            // expensesView
            // 
            this.expensesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensesView.Location = new System.Drawing.Point(12, 58);
            this.expensesView.Name = "expensesView";
            this.expensesView.RowHeadersWidth = 51;
            this.expensesView.RowTemplate.Height = 29;
            this.expensesView.Size = new System.Drawing.Size(457, 320);
            this.expensesView.TabIndex = 2;
            // 
            // View_Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 392);
            this.Controls.Add(this.GoBackBTN);
            this.Controls.Add(this.expensesView);
            this.Name = "View_Expenses";
            this.Text = "View_Expenses";
            this.Load += new System.EventHandler(this.View_Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expensesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button GoBackBTN;
        private DataGridView expensesView;
    }
}