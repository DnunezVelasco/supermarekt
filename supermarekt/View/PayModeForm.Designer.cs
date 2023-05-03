namespace supermarekt.View
{
    partial class PayModeForm
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
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.GroupBox();
            this.DgPayMode = new System.Windows.Forms.DataGridView();
            this.IdPaymode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePayMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(76, 27);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(103, 23);
            this.TxtId.TabIndex = 0;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(76, 83);
            this.TxtName.Name = "TxtName";
            this.TxtName.PlaceholderText = "Pay mode name";
            this.TxtName.Size = new System.Drawing.Size(103, 23);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::supermarekt.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(558, 40);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(102, 81);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "&New";
            this.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::supermarekt.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(558, 139);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(102, 80);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::supermarekt.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(558, 324);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(102, 72);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "&Close";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Data
            // 
            this.Data.Controls.Add(this.label2);
            this.Data.Controls.Add(this.label1);
            this.Data.Controls.Add(this.TxtName);
            this.Data.Controls.Add(this.TxtId);
            this.Data.Location = new System.Drawing.Point(39, 40);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(445, 193);
            this.Data.TabIndex = 8;
            this.Data.TabStop = false;
            this.Data.Text = "Data";
            this.Data.Enter += new System.EventHandler(this.Data_Enter);
            // 
            // DgPayMode
            // 
            this.DgPayMode.AllowUserToAddRows = false;
            this.DgPayMode.AllowUserToDeleteRows = false;
            this.DgPayMode.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DgPayMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPayMode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaymode,
            this.NamePayMode});
            this.DgPayMode.Location = new System.Drawing.Point(39, 246);
            this.DgPayMode.Name = "DgPayMode";
            this.DgPayMode.ReadOnly = true;
            this.DgPayMode.RowTemplate.Height = 25;
            this.DgPayMode.Size = new System.Drawing.Size(445, 175);
            this.DgPayMode.TabIndex = 9;
            this.DgPayMode.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPayMode_CellContentClick);
            this.DgPayMode.Click += new System.EventHandler(this.DgPayMode_Click);
            // 
            // IdPaymode
            // 
            this.IdPaymode.HeaderText = "Id";
            this.IdPaymode.Name = "IdPaymode";
            this.IdPaymode.ReadOnly = true;
            this.IdPaymode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NamePayMode
            // 
            this.NamePayMode.HeaderText = "Name";
            this.NamePayMode.Name = "NamePayMode";
            this.NamePayMode.ReadOnly = true;
            this.NamePayMode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NamePayMode.Width = 300;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::supermarekt.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(558, 237);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(102, 68);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // PayModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.DgPayMode);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PayModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay Mode Management";
            this.Load += new System.EventHandler(this.PayModeForm_Load);
            this.Data.ResumeLayout(false);
            this.Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox TxtId;
        private TextBox TxtName;
        private Label label1;
        private Label label2;
        private Button BtnNew;
        private Button BtnEdit;
        private Button BtnClose;
        private GroupBox Data;
        private DataGridView DgPayMode;
        private DataGridViewTextBoxColumn IdPaymode;
        private DataGridViewTextBoxColumn NamePayMode;
        private Button BtnDelete;
    }
}