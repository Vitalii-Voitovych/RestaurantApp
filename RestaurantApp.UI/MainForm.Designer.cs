namespace RestaurantApp.UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сутностіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сутностіToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сутностіToolStripMenuItem
            // 
            this.сутностіToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.dishToolStripMenuItem,
            this.typeProductToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.сутностіToolStripMenuItem.Name = "сутностіToolStripMenuItem";
            this.сутностіToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.сутностіToolStripMenuItem.Text = "Сутності";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Користувачі";
            // 
            // dishToolStripMenuItem
            // 
            this.dishToolStripMenuItem.Name = "dishToolStripMenuItem";
            this.dishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dishToolStripMenuItem.Text = "Страва";
            this.dishToolStripMenuItem.Click += new System.EventHandler(this.DishToolStripMenuItem_Click);
            // 
            // typeProductToolStripMenuItem
            // 
            this.typeProductToolStripMenuItem.Name = "typeProductToolStripMenuItem";
            this.typeProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.typeProductToolStripMenuItem.Text = "Вид страви";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderToolStripMenuItem.Text = "Замовлення";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paymentToolStripMenuItem.Text = "Оплата";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 388);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem сутностіToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem dishToolStripMenuItem;
        private ToolStripMenuItem typeProductToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
    }
}