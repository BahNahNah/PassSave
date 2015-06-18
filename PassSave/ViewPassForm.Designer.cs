namespace PassSave
{
    partial class ViewPassForm
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
            this.uTxtBox = new System.Windows.Forms.TextBox();
            this.pTxtbox = new System.Windows.Forms.TextBox();
            this.wTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Website:";
            // 
            // uTxtBox
            // 
            this.uTxtBox.Location = new System.Drawing.Point(72, 6);
            this.uTxtBox.Name = "uTxtBox";
            this.uTxtBox.ReadOnly = true;
            this.uTxtBox.Size = new System.Drawing.Size(246, 20);
            this.uTxtBox.TabIndex = 3;
            // 
            // pTxtbox
            // 
            this.pTxtbox.Location = new System.Drawing.Point(72, 32);
            this.pTxtbox.Name = "pTxtbox";
            this.pTxtbox.ReadOnly = true;
            this.pTxtbox.Size = new System.Drawing.Size(246, 20);
            this.pTxtbox.TabIndex = 4;
            this.pTxtbox.UseSystemPasswordChar = true;
            this.pTxtbox.MouseEnter += new System.EventHandler(this.pTxtbox_MouseEnter);
            this.pTxtbox.MouseLeave += new System.EventHandler(this.pTxtbox_MouseLeave);
            // 
            // wTxtBox
            // 
            this.wTxtBox.Location = new System.Drawing.Point(72, 59);
            this.wTxtBox.Name = "wTxtBox";
            this.wTxtBox.ReadOnly = true;
            this.wTxtBox.Size = new System.Drawing.Size(246, 20);
            this.wTxtBox.TabIndex = 5;
            this.wTxtBox.MouseEnter += new System.EventHandler(this.wTxtBox_MouseEnter);
            // 
            // ViewPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 84);
            this.Controls.Add(this.wTxtBox);
            this.Controls.Add(this.pTxtbox);
            this.Controls.Add(this.uTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewPassForm";
            this.Text = "View";
            this.Load += new System.EventHandler(this.ViewPassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uTxtBox;
        private System.Windows.Forms.TextBox pTxtbox;
        private System.Windows.Forms.TextBox wTxtBox;
    }
}