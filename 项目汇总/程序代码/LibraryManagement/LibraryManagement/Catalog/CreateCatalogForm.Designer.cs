namespace LibraryManagement.Catalog
{
    partial class CreateCatalogForm
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.PrimaryLiabilityLabelTextBox = new System.Windows.Forms.TextBox();
            this.CatalogerIdTextBox = new System.Windows.Forms.TextBox();
            this.isbnNumberLabel = new System.Windows.Forms.Label();
            this.positiveTitleLabel = new System.Windows.Forms.Label();
            this.firstAuthorLabel = new System.Windows.Forms.Label();
            this.publishingHouseLabel = new System.Windows.Forms.Label();
            this.documentTypeLabel = new System.Windows.Forms.Label();
            this.primaryLiabilityLabel = new System.Windows.Forms.Label();
            this.catalogerLabel = new System.Windows.Forms.Label();
            this.catalogingDatLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.DocumentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CatalogDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PublishingHouseComboBox = new System.Windows.Forms.ComboBox();
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(177, 111);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(199, 28);
            this.idTextBox.TabIndex = 7;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(637, 111);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(199, 28);
            this.ISBNTextBox.TabIndex = 8;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(177, 145);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(199, 28);
            this.BookNameTextBox.TabIndex = 9;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(637, 145);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(199, 28);
            this.AuthorTextBox.TabIndex = 10;
            // 
            // PrimaryLiabilityLabelTextBox
            // 
            this.PrimaryLiabilityLabelTextBox.Location = new System.Drawing.Point(177, 211);
            this.PrimaryLiabilityLabelTextBox.Name = "PrimaryLiabilityLabelTextBox";
            this.PrimaryLiabilityLabelTextBox.Size = new System.Drawing.Size(199, 28);
            this.PrimaryLiabilityLabelTextBox.TabIndex = 13;
            // 
            // CatalogerIdTextBox
            // 
            this.CatalogerIdTextBox.Location = new System.Drawing.Point(637, 213);
            this.CatalogerIdTextBox.Name = "CatalogerIdTextBox";
            this.CatalogerIdTextBox.Size = new System.Drawing.Size(199, 28);
            this.CatalogerIdTextBox.TabIndex = 14;
            // 
            // isbnNumberLabel
            // 
            this.isbnNumberLabel.AutoSize = true;
            this.isbnNumberLabel.Location = new System.Drawing.Point(525, 114);
            this.isbnNumberLabel.Name = "isbnNumberLabel";
            this.isbnNumberLabel.Size = new System.Drawing.Size(62, 18);
            this.isbnNumberLabel.TabIndex = 16;
            this.isbnNumberLabel.Text = "ISBN号";
            // 
            // positiveTitleLabel
            // 
            this.positiveTitleLabel.AutoSize = true;
            this.positiveTitleLabel.Location = new System.Drawing.Point(77, 148);
            this.positiveTitleLabel.Name = "positiveTitleLabel";
            this.positiveTitleLabel.Size = new System.Drawing.Size(62, 18);
            this.positiveTitleLabel.TabIndex = 17;
            this.positiveTitleLabel.Text = "正题名";
            // 
            // firstAuthorLabel
            // 
            this.firstAuthorLabel.AutoSize = true;
            this.firstAuthorLabel.Location = new System.Drawing.Point(525, 148);
            this.firstAuthorLabel.Name = "firstAuthorLabel";
            this.firstAuthorLabel.Size = new System.Drawing.Size(80, 18);
            this.firstAuthorLabel.TabIndex = 18;
            this.firstAuthorLabel.Text = "第一作者";
            this.firstAuthorLabel.Click += new System.EventHandler(this.firstAuthorLabel_Click);
            // 
            // publishingHouseLabel
            // 
            this.publishingHouseLabel.AutoSize = true;
            this.publishingHouseLabel.Location = new System.Drawing.Point(77, 182);
            this.publishingHouseLabel.Name = "publishingHouseLabel";
            this.publishingHouseLabel.Size = new System.Drawing.Size(62, 18);
            this.publishingHouseLabel.TabIndex = 19;
            this.publishingHouseLabel.Text = "出版社";
            this.publishingHouseLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // documentTypeLabel
            // 
            this.documentTypeLabel.AutoSize = true;
            this.documentTypeLabel.Location = new System.Drawing.Point(525, 182);
            this.documentTypeLabel.Name = "documentTypeLabel";
            this.documentTypeLabel.Size = new System.Drawing.Size(80, 18);
            this.documentTypeLabel.TabIndex = 20;
            this.documentTypeLabel.Text = "文献类型";
            this.documentTypeLabel.Click += new System.EventHandler(this.documentTypeLabel_Click);
            // 
            // primaryLiabilityLabel
            // 
            this.primaryLiabilityLabel.AutoSize = true;
            this.primaryLiabilityLabel.Location = new System.Drawing.Point(77, 216);
            this.primaryLiabilityLabel.Name = "primaryLiabilityLabel";
            this.primaryLiabilityLabel.Size = new System.Drawing.Size(80, 18);
            this.primaryLiabilityLabel.TabIndex = 21;
            this.primaryLiabilityLabel.Text = "第一责任";
            // 
            // catalogerLabel
            // 
            this.catalogerLabel.AutoSize = true;
            this.catalogerLabel.Location = new System.Drawing.Point(525, 216);
            this.catalogerLabel.Name = "catalogerLabel";
            this.catalogerLabel.Size = new System.Drawing.Size(80, 18);
            this.catalogerLabel.TabIndex = 22;
            this.catalogerLabel.Text = "编目人员";
            // 
            // catalogingDatLabel
            // 
            this.catalogingDatLabel.AutoSize = true;
            this.catalogingDatLabel.Location = new System.Drawing.Point(77, 252);
            this.catalogingDatLabel.Name = "catalogingDatLabel";
            this.catalogingDatLabel.Size = new System.Drawing.Size(80, 18);
            this.catalogingDatLabel.TabIndex = 23;
            this.catalogingDatLabel.Text = "编目日期";
            this.catalogingDatLabel.Click += new System.EventHandler(this.catalogingDatLabel_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(77, 114);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 18);
            this.idLabel.TabIndex = 24;
            this.idLabel.Text = "ID";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // DocumentTypeComboBox
            // 
            this.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypeComboBox.FormattingEnabled = true;
            this.DocumentTypeComboBox.Location = new System.Drawing.Point(637, 179);
            this.DocumentTypeComboBox.Name = "DocumentTypeComboBox";
            this.DocumentTypeComboBox.Size = new System.Drawing.Size(199, 26);
            this.DocumentTypeComboBox.TabIndex = 25;
            // 
            // CatalogDateTimePicker
            // 
            this.CatalogDateTimePicker.Location = new System.Drawing.Point(177, 245);
            this.CatalogDateTimePicker.Name = "CatalogDateTimePicker";
            this.CatalogDateTimePicker.Size = new System.Drawing.Size(199, 28);
            this.CatalogDateTimePicker.TabIndex = 26;
            // 
            // PublishingHouseComboBox
            // 
            this.PublishingHouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PublishingHouseComboBox.FormattingEnabled = true;
            this.PublishingHouseComboBox.Location = new System.Drawing.Point(177, 179);
            this.PublishingHouseComboBox.Name = "PublishingHouseComboBox";
            this.PublishingHouseComboBox.Size = new System.Drawing.Size(199, 26);
            this.PublishingHouseComboBox.TabIndex = 27;
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(957, 104);
            this.scriptUserControl1.TabIndex = 28;
            this.scriptUserControl1.Load += new System.EventHandler(this.scriptUserControl1_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(957, 234);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // CreateCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.scriptUserControl1);
            this.Controls.Add(this.PublishingHouseComboBox);
            this.Controls.Add(this.CatalogDateTimePicker);
            this.Controls.Add(this.DocumentTypeComboBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.catalogingDatLabel);
            this.Controls.Add(this.catalogerLabel);
            this.Controls.Add(this.primaryLiabilityLabel);
            this.Controls.Add(this.documentTypeLabel);
            this.Controls.Add(this.publishingHouseLabel);
            this.Controls.Add(this.firstAuthorLabel);
            this.Controls.Add(this.positiveTitleLabel);
            this.Controls.Add(this.isbnNumberLabel);
            this.Controls.Add(this.CatalogerIdTextBox);
            this.Controls.Add(this.PrimaryLiabilityLabelTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "CreateCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采访编目";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateCatalogForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateCatalogListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox PrimaryLiabilityLabelTextBox;
        private System.Windows.Forms.TextBox CatalogerIdTextBox;
        private System.Windows.Forms.Label isbnNumberLabel;
        private System.Windows.Forms.Label positiveTitleLabel;
        private System.Windows.Forms.Label firstAuthorLabel;
        private System.Windows.Forms.Label publishingHouseLabel;
        private System.Windows.Forms.Label documentTypeLabel;
        private System.Windows.Forms.Label primaryLiabilityLabel;
        private System.Windows.Forms.Label catalogerLabel;
        private System.Windows.Forms.Label catalogingDatLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ComboBox DocumentTypeComboBox;
        private System.Windows.Forms.DateTimePicker CatalogDateTimePicker;
        private System.Windows.Forms.ComboBox PublishingHouseComboBox;
        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}