namespace DataBaseInterface
{
    partial class LoginForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.AdminBtn = new System.Windows.Forms.Button();
            this.VisitorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminBtn
            // 
            resources.ApplyResources(this.AdminBtn, "AdminBtn");
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // VisitorBtn
            // 
            resources.ApplyResources(this.VisitorBtn, "VisitorBtn");
            this.VisitorBtn.Name = "VisitorBtn";
            this.VisitorBtn.UseVisualStyleBackColor = true;
            this.VisitorBtn.Click += new System.EventHandler(this.VisitorBtn_Click);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VisitorBtn);
            this.Controls.Add(this.AdminBtn);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Button VisitorBtn;
    }
}

