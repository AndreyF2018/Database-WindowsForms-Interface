namespace DataBaseInterface
{
    partial class SumOfDeliviresForm
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
            this.FirstDatetxt = new System.Windows.Forms.TextBox();
            this.SecondDatetxt = new System.Windows.Forms.TextBox();
            this.SumOfDeliveriesBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SumOfDeliveirestxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первая дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(73, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вторая дата";
            // 
            // FirstDatetxt
            // 
            this.FirstDatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstDatetxt.Location = new System.Drawing.Point(212, 88);
            this.FirstDatetxt.Name = "FirstDatetxt";
            this.FirstDatetxt.Size = new System.Drawing.Size(140, 24);
            this.FirstDatetxt.TabIndex = 2;
            // 
            // SecondDatetxt
            // 
            this.SecondDatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondDatetxt.Location = new System.Drawing.Point(212, 176);
            this.SecondDatetxt.Name = "SecondDatetxt";
            this.SecondDatetxt.Size = new System.Drawing.Size(140, 24);
            this.SecondDatetxt.TabIndex = 3;
            // 
            // SumOfDeliveriesBtn
            // 
            this.SumOfDeliveriesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumOfDeliveriesBtn.Location = new System.Drawing.Point(152, 305);
            this.SumOfDeliveriesBtn.Name = "SumOfDeliveriesBtn";
            this.SumOfDeliveriesBtn.Size = new System.Drawing.Size(93, 34);
            this.SumOfDeliveriesBtn.TabIndex = 4;
            this.SumOfDeliveriesBtn.Text = "Ввод";
            this.SumOfDeliveriesBtn.UseVisualStyleBackColor = true;
            this.SumOfDeliveriesBtn.Click += new System.EventHandler(this.SumOfDeliveriesBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма за период = ";
            // 
            // SumOfDeliveirestxt
            // 
            this.SumOfDeliveirestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumOfDeliveirestxt.Location = new System.Drawing.Point(212, 234);
            this.SumOfDeliveirestxt.Name = "SumOfDeliveirestxt";
            this.SumOfDeliveirestxt.Size = new System.Drawing.Size(140, 24);
            this.SumOfDeliveirestxt.TabIndex = 6;
            // 
            // SumOfDeliviresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 383);
            this.Controls.Add(this.SumOfDeliveirestxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumOfDeliveriesBtn);
            this.Controls.Add(this.SecondDatetxt);
            this.Controls.Add(this.FirstDatetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SumOfDeliviresForm";
            this.Text = "SumOfDeliviresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstDatetxt;
        private System.Windows.Forms.TextBox SecondDatetxt;
        private System.Windows.Forms.Button SumOfDeliveriesBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumOfDeliveirestxt;
    }
}