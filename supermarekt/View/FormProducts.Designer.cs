namespace supermarekt.View
{
    partial class FormProducts
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
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.IdProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_idProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.albel2 = new System.Windows.Forms.Label();
            this.albel3 = new System.Windows.Forms.Label();
            this.albel4 = new System.Windows.Forms.Label();
            this.albel5 = new System.Windows.Forms.Label();
            this.TxtCategory_id = new System.Windows.Forms.ComboBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::supermarekt.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(26, 12);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(120, 62);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New";
            this.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::supermarekt.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(26, 80);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(120, 62);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::supermarekt.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(26, 216);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(120, 58);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::supermarekt.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(26, 148);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 62);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delate";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducts,
            this.NameProducts,
            this.PriceProducts,
            this.StockProducts,
            this.Category_idProducts});
            this.dataGridViewProducts.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewProducts.Location = new System.Drawing.Point(26, 280);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowTemplate.Height = 25;
            this.dataGridViewProducts.Size = new System.Drawing.Size(529, 262);
            this.dataGridViewProducts.TabIndex = 4;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            this.dataGridViewProducts.Click += new System.EventHandler(this.dataGridViewProducts_Click);
            // 
            // IdProducts
            // 
            this.IdProducts.HeaderText = "Id";
            this.IdProducts.Name = "IdProducts";
            this.IdProducts.ReadOnly = true;
            this.IdProducts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NameProducts
            // 
            this.NameProducts.HeaderText = "Name";
            this.NameProducts.Name = "NameProducts";
            this.NameProducts.ReadOnly = true;
            this.NameProducts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PriceProducts
            // 
            this.PriceProducts.HeaderText = "Price";
            this.PriceProducts.Name = "PriceProducts";
            this.PriceProducts.ReadOnly = true;
            this.PriceProducts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StockProducts
            // 
            this.StockProducts.HeaderText = "Stock";
            this.StockProducts.Name = "StockProducts";
            this.StockProducts.ReadOnly = true;
            this.StockProducts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Category_idProducts
            // 
            this.Category_idProducts.HeaderText = "Category_id";
            this.Category_idProducts.Name = "Category_idProducts";
            this.Category_idProducts.ReadOnly = true;
            this.Category_idProducts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // albel2
            // 
            this.albel2.AutoSize = true;
            this.albel2.Location = new System.Drawing.Point(193, 89);
            this.albel2.Name = "albel2";
            this.albel2.Size = new System.Drawing.Size(39, 15);
            this.albel2.TabIndex = 6;
            this.albel2.Text = "Name";
            // 
            // albel3
            // 
            this.albel3.AutoSize = true;
            this.albel3.Location = new System.Drawing.Point(199, 127);
            this.albel3.Name = "albel3";
            this.albel3.Size = new System.Drawing.Size(33, 15);
            this.albel3.TabIndex = 7;
            this.albel3.Text = "Price";
            // 
            // albel4
            // 
            this.albel4.AutoSize = true;
            this.albel4.Location = new System.Drawing.Point(199, 158);
            this.albel4.Name = "albel4";
            this.albel4.Size = new System.Drawing.Size(36, 15);
            this.albel4.TabIndex = 8;
            this.albel4.Text = "Stock";
            // 
            // albel5
            // 
            this.albel5.AutoSize = true;
            this.albel5.Location = new System.Drawing.Point(162, 194);
            this.albel5.Name = "albel5";
            this.albel5.Size = new System.Drawing.Size(70, 15);
            this.albel5.TabIndex = 9;
            this.albel5.Text = "Categoty_id";
            // 
            // TxtCategory_id
            // 
            this.TxtCategory_id.Enabled = false;
            this.TxtCategory_id.FormattingEnabled = true;
            this.TxtCategory_id.Location = new System.Drawing.Point(238, 191);
            this.TxtCategory_id.Name = "TxtCategory_id";
            this.TxtCategory_id.Size = new System.Drawing.Size(100, 23);
            this.TxtCategory_id.TabIndex = 10;
            this.TxtCategory_id.SelectedIndexChanged += new System.EventHandler(this.TxtCategory_id_SelectedIndexChanged);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(238, 60);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 23);
            this.TxtId.TabIndex = 11;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(238, 89);
            this.TxtName.Name = "TxtName";
            this.TxtName.PlaceholderText = "Pay mode name";
            this.TxtName.Size = new System.Drawing.Size(100, 23);
            this.TxtName.TabIndex = 12;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtPrice
            // 
            this.TxtPrice.Enabled = false;
            this.TxtPrice.Location = new System.Drawing.Point(238, 124);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 23);
            this.TxtPrice.TabIndex = 13;
            // 
            // TxtStock
            // 
            this.TxtStock.Enabled = false;
            this.TxtStock.Location = new System.Drawing.Point(238, 158);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(100, 23);
            this.TxtStock.TabIndex = 14;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(781, 586);
            this.ControlBox = false;
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtCategory_id);
            this.Controls.Add(this.albel5);
            this.Controls.Add(this.albel4);
            this.Controls.Add(this.albel3);
            this.Controls.Add(this.albel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnNew;
        private Button BtnEdit;
        private Button BtnClose;
        private Button BtnDelete;
        private DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn IdProducts;
        private DataGridViewTextBoxColumn NameProducts;
        private DataGridViewTextBoxColumn PriceProducts;
        private DataGridViewTextBoxColumn StockProducts;
        private DataGridViewTextBoxColumn Category_idProducts;
        private Label label1;
        private Label albel2;
        private Label albel3;
        private Label albel4;
        private Label albel5;
        private ComboBox TxtCategory_id;
        private TextBox TxtId;
        private TextBox TxtName;
        private TextBox TxtPrice;
        private TextBox TxtStock;
    }
}