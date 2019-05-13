namespace DataBaseInterface
{
    partial class VisitorForm
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
            this.DisountMenuBtn = new System.Windows.Forms.Button();
            this.ToOrderBtn = new System.Windows.Forms.Button();
            this.TableIDLabel = new System.Windows.Forms.Label();
            this.TitleDishLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.TableIDtxt = new System.Windows.Forms.TextBox();
            this.TitleDishtxt = new System.Windows.Forms.TextBox();
            this.Quantitytxt = new System.Windows.Forms.TextBox();
            this.EnterOrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisountMenuBtn
            // 
            this.DisountMenuBtn.Location = new System.Drawing.Point(78, 58);
            this.DisountMenuBtn.Name = "DisountMenuBtn";
            this.DisountMenuBtn.Size = new System.Drawing.Size(133, 54);
            this.DisountMenuBtn.TabIndex = 0;
            this.DisountMenuBtn.Text = "Меню со скидками";
            this.DisountMenuBtn.UseVisualStyleBackColor = true;
            this.DisountMenuBtn.Click += new System.EventHandler(this.DisountMenuBtn_Click);
            // 
            // ToOrderBtn
            // 
            this.ToOrderBtn.Location = new System.Drawing.Point(78, 163);
            this.ToOrderBtn.Name = "ToOrderBtn";
            this.ToOrderBtn.Size = new System.Drawing.Size(133, 54);
            this.ToOrderBtn.TabIndex = 1;
            this.ToOrderBtn.Text = "Сделать заказ";
            this.ToOrderBtn.UseVisualStyleBackColor = true;
            this.ToOrderBtn.Click += new System.EventHandler(this.ToOrderBtn_Click);
            // 
            // TableIDLabel
            // 
            this.TableIDLabel.AutoSize = true;
            this.TableIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableIDLabel.Location = new System.Drawing.Point(255, 124);
            this.TableIDLabel.Name = "TableIDLabel";
            this.TableIDLabel.Size = new System.Drawing.Size(129, 18);
            this.TableIDLabel.TabIndex = 2;
            this.TableIDLabel.Text = "Номер столика";
            this.TableIDLabel.Visible = false;
            // 
            // TitleDishLabel
            // 
            this.TitleDishLabel.AutoSize = true;
            this.TitleDishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleDishLabel.Location = new System.Drawing.Point(245, 180);
            this.TitleDishLabel.Name = "TitleDishLabel";
            this.TitleDishLabel.Size = new System.Drawing.Size(139, 18);
            this.TitleDishLabel.TabIndex = 3;
            this.TitleDishLabel.Text = "Название блюда";
            this.TitleDishLabel.Visible = false;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityLabel.Location = new System.Drawing.Point(282, 234);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(102, 18);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Количество";
            this.QuantityLabel.Visible = false;
            // 
            // TableIDtxt
            // 
            this.TableIDtxt.Location = new System.Drawing.Point(429, 125);
            this.TableIDtxt.Name = "TableIDtxt";
            this.TableIDtxt.Size = new System.Drawing.Size(100, 20);
            this.TableIDtxt.TabIndex = 5;
            this.TableIDtxt.Visible = false;
            // 
            // TitleDishtxt
            // 
            this.TitleDishtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleDishtxt.Location = new System.Drawing.Point(429, 178);
            this.TitleDishtxt.Name = "TitleDishtxt";
            this.TitleDishtxt.Size = new System.Drawing.Size(100, 21);
            this.TitleDishtxt.TabIndex = 6;
            this.TitleDishtxt.Visible = false;
            // 
            // Quantitytxt
            // 
            this.Quantitytxt.Location = new System.Drawing.Point(429, 235);
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.Size = new System.Drawing.Size(100, 20);
            this.Quantitytxt.TabIndex = 7;
            this.Quantitytxt.Visible = false;
            // 
            // EnterOrderBtn
            // 
            this.EnterOrderBtn.Location = new System.Drawing.Point(417, 274);
            this.EnterOrderBtn.Name = "EnterOrderBtn";
            this.EnterOrderBtn.Size = new System.Drawing.Size(122, 32);
            this.EnterOrderBtn.TabIndex = 8;
            this.EnterOrderBtn.Text = "Заказать";
            this.EnterOrderBtn.UseVisualStyleBackColor = true;
            this.EnterOrderBtn.Visible = false;
            this.EnterOrderBtn.Click += new System.EventHandler(this.EnterOrderBtn_Click);
            // 
            // VisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 467);
            this.Controls.Add(this.EnterOrderBtn);
            this.Controls.Add(this.Quantitytxt);
            this.Controls.Add(this.TitleDishtxt);
            this.Controls.Add(this.TableIDtxt);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.TitleDishLabel);
            this.Controls.Add(this.TableIDLabel);
            this.Controls.Add(this.ToOrderBtn);
            this.Controls.Add(this.DisountMenuBtn);
            this.Name = "VisitorForm";
            this.Text = "VisitorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisountMenuBtn;
        private System.Windows.Forms.Button ToOrderBtn;
        private System.Windows.Forms.Label TableIDLabel;
        private System.Windows.Forms.Label TitleDishLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox TableIDtxt;
        private System.Windows.Forms.TextBox TitleDishtxt;
        private System.Windows.Forms.TextBox Quantitytxt;
        private System.Windows.Forms.Button EnterOrderBtn;
    }
}