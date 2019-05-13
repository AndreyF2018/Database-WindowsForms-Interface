namespace DataBaseInterface
{
    partial class AdminForm
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
            this.AdmMenuBtn = new System.Windows.Forms.Button();
            this.EditMenubtn = new System.Windows.Forms.Button();
            this.SumDeliveriesBtn = new System.Windows.Forms.Button();
            this.CompleteOrderBtn = new System.Windows.Forms.Button();
            this.OrderIDtxt = new System.Windows.Forms.TextBox();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.FulfillmentOrderBtn = new System.Windows.Forms.Button();
            this.DismissalBtn = new System.Windows.Forms.Button();
            this.WarehouseControlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdmMenuBtn
            // 
            this.AdmMenuBtn.Location = new System.Drawing.Point(40, 39);
            this.AdmMenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdmMenuBtn.Name = "AdmMenuBtn";
            this.AdmMenuBtn.Size = new System.Drawing.Size(134, 50);
            this.AdmMenuBtn.TabIndex = 0;
            this.AdmMenuBtn.Text = "Просмотр меню";
            this.AdmMenuBtn.UseVisualStyleBackColor = true;
            this.AdmMenuBtn.Click += new System.EventHandler(this.AdmMenuBtn_Click);
            // 
            // EditMenubtn
            // 
            this.EditMenubtn.Location = new System.Drawing.Point(40, 127);
            this.EditMenubtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditMenubtn.Name = "EditMenubtn";
            this.EditMenubtn.Size = new System.Drawing.Size(134, 50);
            this.EditMenubtn.TabIndex = 1;
            this.EditMenubtn.Text = "Редактировать меню";
            this.EditMenubtn.UseVisualStyleBackColor = true;
            this.EditMenubtn.Click += new System.EventHandler(this.EditMenubtn_Click);
            // 
            // SumDeliveriesBtn
            // 
            this.SumDeliveriesBtn.Location = new System.Drawing.Point(40, 215);
            this.SumDeliveriesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SumDeliveriesBtn.Name = "SumDeliveriesBtn";
            this.SumDeliveriesBtn.Size = new System.Drawing.Size(134, 50);
            this.SumDeliveriesBtn.TabIndex = 2;
            this.SumDeliveriesBtn.Text = "Посмотреть сумму доставок за период";
            this.SumDeliveriesBtn.UseVisualStyleBackColor = true;
            this.SumDeliveriesBtn.Click += new System.EventHandler(this.SumDeliveriesBtn_Click);
            // 
            // CompleteOrderBtn
            // 
            this.CompleteOrderBtn.Location = new System.Drawing.Point(269, 39);
            this.CompleteOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CompleteOrderBtn.Name = "CompleteOrderBtn";
            this.CompleteOrderBtn.Size = new System.Drawing.Size(134, 50);
            this.CompleteOrderBtn.TabIndex = 3;
            this.CompleteOrderBtn.Text = "Выполнить заказ";
            this.CompleteOrderBtn.UseVisualStyleBackColor = true;
            this.CompleteOrderBtn.Click += new System.EventHandler(this.CompleteOrderBtn_Click);
            // 
            // OrderIDtxt
            // 
            this.OrderIDtxt.Location = new System.Drawing.Point(554, 52);
            this.OrderIDtxt.Name = "OrderIDtxt";
            this.OrderIDtxt.Size = new System.Drawing.Size(100, 20);
            this.OrderIDtxt.TabIndex = 4;
            this.OrderIDtxt.Visible = false;
            this.OrderIDtxt.VisibleChanged += new System.EventHandler(this.CompleteOrderBtn_Click);
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderIDLabel.Location = new System.Drawing.Point(422, 54);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(85, 18);
            this.OrderIDLabel.TabIndex = 5;
            this.OrderIDLabel.Text = "ID Заказа";
            this.OrderIDLabel.Visible = false;
            // 
            // FulfillmentOrderBtn
            // 
            this.FulfillmentOrderBtn.Location = new System.Drawing.Point(508, 89);
            this.FulfillmentOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FulfillmentOrderBtn.Name = "FulfillmentOrderBtn";
            this.FulfillmentOrderBtn.Size = new System.Drawing.Size(77, 24);
            this.FulfillmentOrderBtn.TabIndex = 6;
            this.FulfillmentOrderBtn.Text = "Выполнить";
            this.FulfillmentOrderBtn.UseVisualStyleBackColor = true;
            this.FulfillmentOrderBtn.Visible = false;
            this.FulfillmentOrderBtn.Click += new System.EventHandler(this.FulfillmentOrderBtn_Click);
            // 
            // DismissalBtn
            // 
            this.DismissalBtn.Location = new System.Drawing.Point(269, 127);
            this.DismissalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DismissalBtn.Name = "DismissalBtn";
            this.DismissalBtn.Size = new System.Drawing.Size(163, 50);
            this.DismissalBtn.TabIndex = 7;
            this.DismissalBtn.Text = "Уволить самого возрастного официанта";
            this.DismissalBtn.UseVisualStyleBackColor = true;
            this.DismissalBtn.Click += new System.EventHandler(this.DismissalBtn_Click);
            // 
            // WarehouseControlBtn
            // 
            this.WarehouseControlBtn.Location = new System.Drawing.Point(269, 215);
            this.WarehouseControlBtn.Margin = new System.Windows.Forms.Padding(2);
            this.WarehouseControlBtn.Name = "WarehouseControlBtn";
            this.WarehouseControlBtn.Size = new System.Drawing.Size(163, 50);
            this.WarehouseControlBtn.TabIndex = 8;
            this.WarehouseControlBtn.Text = "Проверить склад";
            this.WarehouseControlBtn.UseVisualStyleBackColor = true;
            this.WarehouseControlBtn.Click += new System.EventHandler(this.WarehouseControlBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 516);
            this.Controls.Add(this.WarehouseControlBtn);
            this.Controls.Add(this.DismissalBtn);
            this.Controls.Add(this.FulfillmentOrderBtn);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.OrderIDtxt);
            this.Controls.Add(this.CompleteOrderBtn);
            this.Controls.Add(this.SumDeliveriesBtn);
            this.Controls.Add(this.EditMenubtn);
            this.Controls.Add(this.AdmMenuBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdmMenuBtn;
        private System.Windows.Forms.Button EditMenubtn;
        private System.Windows.Forms.Button SumDeliveriesBtn;
        private System.Windows.Forms.Button CompleteOrderBtn;
        private System.Windows.Forms.TextBox OrderIDtxt;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Button FulfillmentOrderBtn;
        private System.Windows.Forms.Button DismissalBtn;
        private System.Windows.Forms.Button WarehouseControlBtn;
    }
}