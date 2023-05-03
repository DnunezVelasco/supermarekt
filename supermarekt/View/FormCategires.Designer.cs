namespace supermarekt.View
{
    partial class FormCategires
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.DataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.IdCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(88, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(307, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(131, 71);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 23);
            this.TxtName.TabIndex = 3;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(131, 30);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 23);
            this.TxtId.TabIndex = 2;
            // 
            // DataGridViewCategories
            // 
            this.DataGridViewCategories.AllowUserToAddRows = false;
            this.DataGridViewCategories.AllowUserToDeleteRows = false;
            this.DataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCategories,
            this.NameCategories});
            this.DataGridViewCategories.Location = new System.Drawing.Point(88, 242);
            this.DataGridViewCategories.Name = "DataGridViewCategories";
            this.DataGridViewCategories.ReadOnly = true;
            this.DataGridViewCategories.RowTemplate.Height = 25;
            this.DataGridViewCategories.Size = new System.Drawing.Size(445, 150);
            this.DataGridViewCategories.TabIndex = 3;
            this.DataGridViewCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCategories_CellClick);
            this.DataGridViewCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCategories_CellContentClick);
            this.DataGridViewCategories.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCategories_CellValueChanged);
            this.DataGridViewCategories.Click += new System.EventHandler(this.DataGridViewCategories_Click);
            // 
            // IdCategories
            // 
            this.IdCategories.HeaderText = "Id";
            this.IdCategories.Name = "IdCategories";
            this.IdCategories.ReadOnly = true;
            this.IdCategories.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NameCategories
            // 
            this.NameCategories.HeaderText = "Name";
            this.NameCategories.Name = "NameCategories";
            this.NameCategories.ReadOnly = true;
            this.NameCategories.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameCategories.Width = 300;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::supermarekt.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(587, 42);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 46);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "New";
            this.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::supermarekt.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(587, 94);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 49);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::supermarekt.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(587, 149);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 49);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delate";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::supermarekt.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(587, 204);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 49);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "Close";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormCategires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.DataGridViewCategories);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCategires";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategires";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox TxtName;
        private TextBox TxtId;
        private DataGridView DataGridViewCategories;
        private DataGridViewTextBoxColumn IdCategories;
        private DataGridViewTextBoxColumn NameCategories;
        private Button BtnNew;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private ComboBox comboBox1;
    }
}