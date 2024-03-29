﻿namespace DataBaseInterface
{
    partial class EditMenuForm
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
            this.DishIDtxt = new System.Windows.Forms.TextBox();
            this.TitleDishtxt = new System.Windows.Forms.TextBox();
            this.PriceDishtxt = new System.Windows.Forms.TextBox();
            this.EditMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "DishID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(117, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // DishIDtxt
            // 
            this.DishIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DishIDtxt.Location = new System.Drawing.Point(232, 87);
            this.DishIDtxt.Name = "DishIDtxt";
            this.DishIDtxt.Size = new System.Drawing.Size(100, 28);
            this.DishIDtxt.TabIndex = 4;
            // 
            // TitleDishtxt
            // 
            this.TitleDishtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleDishtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleDishtxt.Location = new System.Drawing.Point(232, 170);
            this.TitleDishtxt.Name = "TitleDishtxt";
            this.TitleDishtxt.Size = new System.Drawing.Size(100, 28);
            this.TitleDishtxt.TabIndex = 5;
            // 
            // PriceDishtxt
            // 
            this.PriceDishtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceDishtxt.Location = new System.Drawing.Point(232, 241);
            this.PriceDishtxt.Name = "PriceDishtxt";
            this.PriceDishtxt.Size = new System.Drawing.Size(100, 28);
            this.PriceDishtxt.TabIndex = 6;
            // 
            // EditMenuBtn
            // 
            this.EditMenuBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditMenuBtn.Location = new System.Drawing.Point(148, 336);
            this.EditMenuBtn.Name = "EditMenuBtn";
            this.EditMenuBtn.Size = new System.Drawing.Size(184, 63);
            this.EditMenuBtn.TabIndex = 7;
            this.EditMenuBtn.Text = "Изменить/Добавить блюдо";
            this.EditMenuBtn.UseVisualStyleBackColor = true;
            this.EditMenuBtn.Click += new System.EventHandler(this.EditMenuBtn_Click);
            // 
            // EditMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 455);
            this.Controls.Add(this.EditMenuBtn);
            this.Controls.Add(this.PriceDishtxt);
            this.Controls.Add(this.TitleDishtxt);
            this.Controls.Add(this.DishIDtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditMenuForm";
            this.Text = "EditMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DishIDtxt;
        private System.Windows.Forms.TextBox TitleDishtxt;
        private System.Windows.Forms.TextBox PriceDishtxt;
        private System.Windows.Forms.Button EditMenuBtn;
    }
}