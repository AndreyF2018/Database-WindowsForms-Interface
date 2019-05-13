namespace DataBaseInterface
{
    partial class MenuForm
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
            this.MenuDgv = new System.Windows.Forms.DataGridView();
            this.DishID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuDgv
            // 
            this.MenuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DishID,
            this.Title,
            this.Price});
            this.MenuDgv.Location = new System.Drawing.Point(0, 0);
            this.MenuDgv.Name = "MenuDgv";
            this.MenuDgv.RowTemplate.Height = 24;
            this.MenuDgv.Size = new System.Drawing.Size(526, 462);
            this.MenuDgv.TabIndex = 0;
            // 
            // DishID
            // 
            this.DishID.HeaderText = "DishID";
            this.DishID.Name = "DishID";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 474);
            this.Controls.Add(this.MenuDgv);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MenuDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}