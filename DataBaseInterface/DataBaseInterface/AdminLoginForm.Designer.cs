namespace DataBaseInterface
{
    partial class AdminLoginForm
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
            this.passlable = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passlable
            // 
            this.passlable.AutoSize = true;
            this.passlable.Location = new System.Drawing.Point(42, 132);
            this.passlable.Name = "passlable";
            this.passlable.Size = new System.Drawing.Size(69, 17);
            this.passlable.TabIndex = 0;
            this.passlable.Text = "Password";
            this.passlable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(149, 132);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(155, 22);
            this.PassTextBox.TabIndex = 1;
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            this.PassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTextBox_KeyPress);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(177, 192);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(85, 30);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 289);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.passlable);
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passlable;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button LoginBtn;
    }
}