namespace Stedex
{
    partial class ViewIncomeForm
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
            this.incomesView = new System.Windows.Forms.DataGridView();
            this.GoBackBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incomesView)).BeginInit();
            this.SuspendLayout();
            // 
            // incomesView
            // 
            this.incomesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomesView.Location = new System.Drawing.Point(12, 60);
            this.incomesView.Name = "incomesView";
            this.incomesView.RowHeadersWidth = 51;
            this.incomesView.RowTemplate.Height = 29;
            this.incomesView.Size = new System.Drawing.Size(457, 320);
            this.incomesView.TabIndex = 0;
            // 
            // GoBackBTN
            // 
            this.GoBackBTN.Location = new System.Drawing.Point(12, 14);
            this.GoBackBTN.Name = "GoBackBTN";
            this.GoBackBTN.Size = new System.Drawing.Size(29, 29);
            this.GoBackBTN.TabIndex = 1;
            this.GoBackBTN.Text = "<";
            this.GoBackBTN.UseVisualStyleBackColor = true;
            this.GoBackBTN.Click += new System.EventHandler(this.GoBackBTN_Click);
            // 
            // ViewIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 408);
            this.Controls.Add(this.GoBackBTN);
            this.Controls.Add(this.incomesView);
            this.Name = "ViewIncomeForm";
            this.Text = "ViewIncomeForm";
            this.Load += new System.EventHandler(this.ViewIncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView incomesView;
        private Button GoBackBTN;
    }
}