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
            this.typeDishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeDish = new System.Windows.Forms.ComboBox();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.labelTableNumber = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сутностіToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сутностіToolStripMenuItem
            // 
            this.сутностіToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.dishToolStripMenuItem,
            this.typeDishToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.сутностіToolStripMenuItem.Name = "сутностіToolStripMenuItem";
            this.сутностіToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.сутностіToolStripMenuItem.Text = "Сутності";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.customerToolStripMenuItem.Text = "Користувачі";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // dishToolStripMenuItem
            // 
            this.dishToolStripMenuItem.Name = "dishToolStripMenuItem";
            this.dishToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dishToolStripMenuItem.Text = "Страва";
            this.dishToolStripMenuItem.Click += new System.EventHandler(this.DishToolStripMenuItem_Click);
            // 
            // typeDishToolStripMenuItem
            // 
            this.typeDishToolStripMenuItem.Name = "typeDishToolStripMenuItem";
            this.typeDishToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.typeDishToolStripMenuItem.Text = "Вид страви";
            this.typeDishToolStripMenuItem.Click += new System.EventHandler(this.TypeDishToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.orderToolStripMenuItem.Text = "Замовлення";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.OrderToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.paymentToolStripMenuItem.Text = "Оплата";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.PaymentToolStripMenuItem_Click);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 15;
            this.listBoxMenu.Location = new System.Drawing.Point(12, 72);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(264, 334);
            this.listBoxMenu.TabIndex = 1;
            this.listBoxMenu.SelectedIndexChanged += new System.EventHandler(this.ListBoxMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Меню";
            // 
            // comboBoxTypeDish
            // 
            this.comboBoxTypeDish.FormattingEnabled = true;
            this.comboBoxTypeDish.Location = new System.Drawing.Point(139, 50);
            this.comboBoxTypeDish.MaxDropDownItems = 15;
            this.comboBoxTypeDish.Name = "comboBoxTypeDish";
            this.comboBoxTypeDish.Size = new System.Drawing.Size(137, 23);
            this.comboBoxTypeDish.TabIndex = 3;
            this.comboBoxTypeDish.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeDish_SelectedIndexChanged);
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.ItemHeight = 15;
            this.listBoxCart.Location = new System.Drawing.Point(393, 72);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(304, 274);
            this.listBoxCart.TabIndex = 4;
            this.listBoxCart.SelectedIndexChanged += new System.EventHandler(this.ListBoxCart_SelectedIndexChanged);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomer.Location = new System.Drawing.Point(393, 48);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(61, 21);
            this.labelCustomer.TabIndex = 5;
            this.labelCustomer.Text = "Клієнт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(393, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "До оплати: ";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(393, 373);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 34);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Оплатити";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // labelTableNumber
            // 
            this.labelTableNumber.AutoSize = true;
            this.labelTableNumber.Location = new System.Drawing.Point(393, 33);
            this.labelTableNumber.Name = "labelTableNumber";
            this.labelTableNumber.Size = new System.Drawing.Size(63, 15);
            this.labelTableNumber.TabIndex = 8;
            this.labelTableNumber.Text = "Столик №";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(474, 372);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 34);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Чек";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 419);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.labelTableNumber);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.listBoxCart);
            this.Controls.Add(this.comboBoxTypeDish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private ToolStripMenuItem typeDishToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
        private ListBox listBoxMenu;
        private Label label1;
        private ComboBox comboBoxTypeDish;
        private ListBox listBoxCart;
        private Label labelCustomer;
        private Label label2;
        private Button btnPay;
        private Label labelTableNumber;
        private Button btnCheck;
    }
}