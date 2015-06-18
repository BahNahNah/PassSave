namespace PassSave
{
    partial class AddNewPasswordForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unTxtBox = new System.Windows.Forms.TextBox();
            this.psTxtBox = new System.Windows.Forms.TextBox();
            this.wbTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Website:";
            // 
            // unTxtBox
            // 
            this.unTxtBox.Location = new System.Drawing.Point(66, 6);
            this.unTxtBox.Name = "unTxtBox";
            this.unTxtBox.Size = new System.Drawing.Size(235, 20);
            this.unTxtBox.TabIndex = 3;
            // 
            // psTxtBox
            // 
            this.psTxtBox.Location = new System.Drawing.Point(66, 33);
            this.psTxtBox.Name = "psTxtBox";
            this.psTxtBox.Size = new System.Drawing.Size(235, 20);
            this.psTxtBox.TabIndex = 4;
            // 
            // wbTxtBox
            // 
            this.wbTxtBox.Location = new System.Drawing.Point(66, 61);
            this.wbTxtBox.Name = "wbTxtBox";
            this.wbTxtBox.Size = new System.Drawing.Size(235, 20);
            this.wbTxtBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 115);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wbTxtBox);
            this.Controls.Add(this.psTxtBox);
            this.Controls.Add(this.unTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewPasswordForm";
            this.Text = "Add new Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox unTxtBox;
        private System.Windows.Forms.TextBox psTxtBox;
        private System.Windows.Forms.TextBox wbTxtBox;
        private System.Windows.Forms.Button button1;
    }
}