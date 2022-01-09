namespace Stedex
{
    partial class Add_New_Type
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
            this.typeNameTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GoBackBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type name";
            // 
            // typeNameTB
            // 
            this.typeNameTB.Location = new System.Drawing.Point(36, 71);
            this.typeNameTB.Name = "typeNameTB";
            this.typeNameTB.Size = new System.Drawing.Size(198, 27);
            this.typeNameTB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 48);
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
            // Add_New_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 204);
            this.Controls.Add(this.GoBackBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typeNameTB);
            this.Controls.Add(this.label1);
            this.Name = "Add_New_Type";
            this.Text = "Add_New_Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox typeNameTB;
        private Button button1;
        private Button GoBackBTN;
    }
}