namespace supermarekt
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProvidersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PayModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FILE,
            this.aaToolStripMenuItem,
            this.asdToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(800, 24);
            this.MenuMain.TabIndex = 0;
            this.MenuMain.Text = "menuStrip1";
            this.MenuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuMain_ItemClicked);
            // 
            // FILE
            // 
            this.FILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.FILE.Name = "FILE";
            this.FILE.Size = new System.Drawing.Size(40, 20);
            this.FILE.Text = "File ";
            this.FILE.Click += new System.EventHandler(this.aaaToolStripMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(96, 22);
            this.ExitMenuItem.Text = "Exit ";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsMenuItem,
            this.ProvidersMenuItem,
            this.CategoriesMenuItem,
            this.PayModeMenuItem});
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aaToolStripMenuItem.Text = "Master ";
            this.aaToolStripMenuItem.Click += new System.EventHandler(this.aaToolStripMenuItem_Click);
            // 
            // ProductsMenuItem
            // 
            this.ProductsMenuItem.Name = "ProductsMenuItem";
            this.ProductsMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ProductsMenuItem.Text = "Products ";
            this.ProductsMenuItem.Click += new System.EventHandler(this.ProductsMenuItem_Click);
            // 
            // ProvidersMenuItem
            // 
            this.ProvidersMenuItem.Name = "ProvidersMenuItem";
            this.ProvidersMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ProvidersMenuItem.Text = "Providers ";
            this.ProvidersMenuItem.Click += new System.EventHandler(this.ProvidersMenuItem_Click);
            // 
            // CategoriesMenuItem
            // 
            this.CategoriesMenuItem.Name = "CategoriesMenuItem";
            this.CategoriesMenuItem.Size = new System.Drawing.Size(133, 22);
            this.CategoriesMenuItem.Text = "Categories ";
            this.CategoriesMenuItem.Click += new System.EventHandler(this.CategoriesMenuItem_Click);
            // 
            // PayModeMenuItem
            // 
            this.PayModeMenuItem.Name = "PayModeMenuItem";
            this.PayModeMenuItem.Size = new System.Drawing.Size(133, 22);
            this.PayModeMenuItem.Text = "Pay Mode";
            this.PayModeMenuItem.Click += new System.EventHandler(this.PayModeMenuItem_Click);
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SellMenuItem,
            this.PurchaseMenuItem});
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.asdToolStripMenuItem.Text = "Transactions";
            this.asdToolStripMenuItem.Click += new System.EventHandler(this.asdToolStripMenuItem_Click);
            // 
            // SellMenuItem
            // 
            this.SellMenuItem.Name = "SellMenuItem";
            this.SellMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SellMenuItem.Text = "Sell ";
            this.SellMenuItem.Click += new System.EventHandler(this.SellMenuItem_Click);
            // 
            // PurchaseMenuItem
            // 
            this.PurchaseMenuItem.Name = "PurchaseMenuItem";
            this.PurchaseMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PurchaseMenuItem.Text = "Purchase ";
            this.PurchaseMenuItem.Click += new System.EventHandler(this.PurchaseMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(110, 22);
            this.AboutMenuItem.Text = "About ";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuMain;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuMain;
        private ToolStripMenuItem FILE;
        private ToolStripMenuItem aaToolStripMenuItem;
        private ToolStripMenuItem asdToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem AboutMenuItem;
        private ToolStripMenuItem ProductsMenuItem;
        private ToolStripMenuItem ProvidersMenuItem;
        private ToolStripMenuItem CategoriesMenuItem;
        private ToolStripMenuItem PayModeMenuItem;
        private ToolStripMenuItem SellMenuItem;
        private ToolStripMenuItem PurchaseMenuItem;
    }
}