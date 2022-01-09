namespace Stedex
{
    partial class Delete_Goal
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
            this.goalsView = new System.Windows.Forms.DataGridView();
            this.GoBackBTN = new System.Windows.Forms.Button();
            this.goalsComboBox = new System.Windows.Forms.ComboBox();
            this.Select = new System.Windows.Forms.Label();
            this.DeleteGoalBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goalsView)).BeginInit();
            this.SuspendLayout();
            // 
            // goalsView
            // 
            this.goalsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goalsView.Location = new System.Drawing.Point(397, 12);
            this.goalsView.Name = "goalsView";
            this.goalsView.RowHeadersWidth = 51;
            this.goalsView.RowTemplate.Height = 29;
            this.goalsView.Size = new System.Drawing.Size(450, 427);
            this.goalsView.TabIndex = 0;
            // 
            // GoBackBTN
            // 
            this.GoBackBTN.Location = new System.Drawing.Point(12, 12);
            this.GoBackBTN.Name = "GoBackBTN";
            this.GoBackBTN.Size = new System.Drawing.Size(29, 29);
            this.GoBackBTN.TabIndex = 17;
            this.GoBackBTN.Text = "<";
            this.GoBackBTN.UseVisualStyleBackColor = true;
            this.GoBackBTN.Click += new System.EventHandler(this.GoBackBTN_Click);
            // 
            // goalsComboBox
            // 
            this.goalsComboBox.FormattingEnabled = true;
            this.goalsComboBox.Location = new System.Drawing.Point(34, 144);
            this.goalsComboBox.Name = "goalsComboBox";
            this.goalsComboBox.Size = new System.Drawing.Size(316, 28);
            this.goalsComboBox.TabIndex = 18;
            // 
            // Select
            // 
            this.Select.AutoSize = true;
            this.Select.Location = new System.Drawing.Point(118, 110);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(152, 20);
            this.Select.TabIndex = 19;
            this.Select.Text = "Select Goal To Delete";
            // 
            // DeleteGoalBTN
            // 
            this.DeleteGoalBTN.Location = new System.Drawing.Point(34, 280);
            this.DeleteGoalBTN.Name = "DeleteGoalBTN";
            this.DeleteGoalBTN.Size = new System.Drawing.Size(94, 64);
            this.DeleteGoalBTN.TabIndex = 20;
            this.DeleteGoalBTN.Text = "Delete";
            this.DeleteGoalBTN.UseVisualStyleBackColor = true;
            this.DeleteGoalBTN.Click += new System.EventHandler(this.DeleteGoalBTN_Click);
            // 
            // Delete_Goal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.DeleteGoalBTN);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.goalsComboBox);
            this.Controls.Add(this.GoBackBTN);
            this.Controls.Add(this.goalsView);
            this.Name = "Delete_Goal";
            this.Text = "Delete_Goal";
            this.Load += new System.EventHandler(this.Delete_Goal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goalsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView goalsView;
        private Button GoBackBTN;
        private ComboBox goalsComboBox;
        private Label Select;
        private Button DeleteGoalBTN;
    }
}