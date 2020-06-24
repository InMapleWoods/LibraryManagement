namespace LibraryManagement.Interview
{
    partial class ReturnListForm
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
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.ReturnListDataGridView = new System.Windows.Forms.DataGridView();
            this.publishingHouseComboBox = new System.Windows.Forms.ComboBox();
            this.subDatePicker = new System.Windows.Forms.DateTimePicker();
            this.documentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.literatureTypeLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.SubscriberTextBox = new System.Windows.Forms.TextBox();
            this.subscriberLabel = new System.Windows.Forms.Label();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.ISBNlabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.NumTextBox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.RowTemplate.Height = 27;
            this.OrderDataGridView.Size = new System.Drawing.Size(813, 150);
            this.OrderDataGridView.TabIndex = 0;
            this.OrderDataGridView.CurrentCellChanged += new System.EventHandler(this.OrderDataGridView_CurrentCellChanged);
            this.OrderDataGridView.SelectionChanged += new System.EventHandler(this.OrderDataGridView_SelectionChanged);
            // 
            // ReturnListDataGridView
            // 
            this.ReturnListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReturnListDataGridView.Location = new System.Drawing.Point(0, 504);
            this.ReturnListDataGridView.Name = "ReturnListDataGridView";
            this.ReturnListDataGridView.RowTemplate.Height = 27;
            this.ReturnListDataGridView.Size = new System.Drawing.Size(813, 178);
            this.ReturnListDataGridView.TabIndex = 1;
            this.ReturnListDataGridView.CurrentCellChanged += new System.EventHandler(this.ReturnListDataGridView_CurrentCellChanged);
            this.ReturnListDataGridView.SelectionChanged += new System.EventHandler(this.ReturnListDataGridView_SelectionChanged);
            // 
            // publishingHouseComboBox
            // 
            this.publishingHouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publishingHouseComboBox.FormattingEnabled = true;
            this.publishingHouseComboBox.Location = new System.Drawing.Point(577, 294);
            this.publishingHouseComboBox.Name = "publishingHouseComboBox";
            this.publishingHouseComboBox.Size = new System.Drawing.Size(149, 23);
            this.publishingHouseComboBox.TabIndex = 38;
            // 
            // subDatePicker
            // 
            this.subDatePicker.Location = new System.Drawing.Point(145, 238);
            this.subDatePicker.Name = "subDatePicker";
            this.subDatePicker.Size = new System.Drawing.Size(149, 25);
            this.subDatePicker.TabIndex = 37;
            // 
            // documentTypeComboBox
            // 
            this.documentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.documentTypeComboBox.FormattingEnabled = true;
            this.documentTypeComboBox.Items.AddRange(new object[] {
            "期刊",
            "专著",
            "论文",
            "专利",
            "电子文献"});
            this.documentTypeComboBox.Location = new System.Drawing.Point(577, 349);
            this.documentTypeComboBox.Name = "documentTypeComboBox";
            this.documentTypeComboBox.Size = new System.Drawing.Size(149, 23);
            this.documentTypeComboBox.TabIndex = 36;
            // 
            // literatureTypeLabel
            // 
            this.literatureTypeLabel.AutoSize = true;
            this.literatureTypeLabel.Location = new System.Drawing.Point(495, 352);
            this.literatureTypeLabel.Name = "literatureTypeLabel";
            this.literatureTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.literatureTypeLabel.TabIndex = 35;
            this.literatureTypeLabel.Text = "文献类型";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(510, 294);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(52, 15);
            this.publisherLabel.TabIndex = 34;
            this.publisherLabel.Text = "出版社";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(577, 237);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(149, 25);
            this.priceTextBox.TabIndex = 33;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(525, 240);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 15);
            this.priceLabel.TabIndex = 32;
            this.priceLabel.Text = "价格";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(577, 179);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.ReadOnly = true;
            this.bookNameTextBox.Size = new System.Drawing.Size(149, 25);
            this.bookNameTextBox.TabIndex = 31;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(525, 182);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(37, 15);
            this.bookNameLabel.TabIndex = 30;
            this.bookNameLabel.Text = "书名";
            // 
            // SubscriberTextBox
            // 
            this.SubscriberTextBox.Location = new System.Drawing.Point(145, 349);
            this.SubscriberTextBox.Name = "SubscriberTextBox";
            this.SubscriberTextBox.Size = new System.Drawing.Size(149, 25);
            this.SubscriberTextBox.TabIndex = 29;
            // 
            // subscriberLabel
            // 
            this.subscriberLabel.AutoSize = true;
            this.subscriberLabel.Location = new System.Drawing.Point(62, 352);
            this.subscriberLabel.Name = "subscriberLabel";
            this.subscriberLabel.Size = new System.Drawing.Size(68, 15);
            this.subscriberLabel.TabIndex = 28;
            this.subscriberLabel.Text = "订购人ID";
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(145, 294);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.ReadOnly = true;
            this.ISBNtextBox.Size = new System.Drawing.Size(149, 25);
            this.ISBNtextBox.TabIndex = 27;
            // 
            // ISBNlabel
            // 
            this.ISBNlabel.AutoSize = true;
            this.ISBNlabel.Location = new System.Drawing.Point(91, 297);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(39, 15);
            this.ISBNlabel.TabIndex = 26;
            this.ISBNlabel.Text = "ISBN";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(63, 240);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(67, 15);
            this.orderDateLabel.TabIndex = 25;
            this.orderDateLabel.Text = "订购日期";
            // 
            // NumTextBox
            // 
            this.NumTextBox.Location = new System.Drawing.Point(145, 179);
            this.NumTextBox.Name = "NumTextBox";
            this.NumTextBox.ReadOnly = true;
            this.NumTextBox.Size = new System.Drawing.Size(149, 25);
            this.NumTextBox.TabIndex = 24;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(78, 182);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(37, 15);
            this.NumberLabel.TabIndex = 23;
            this.NumberLabel.Text = "单号";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(132, 406);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 75);
            this.AddButton.TabIndex = 39;
            this.AddButton.Text = "添加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(371, 406);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 75);
            this.PrintButton.TabIndex = 40;
            this.PrintButton.Text = "打印";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(608, 406);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 75);
            this.ReturnButton.TabIndex = 41;
            this.ReturnButton.Text = "返回";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ReturnListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 682);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.publishingHouseComboBox);
            this.Controls.Add(this.subDatePicker);
            this.Controls.Add(this.documentTypeComboBox);
            this.Controls.Add(this.literatureTypeLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.SubscriberTextBox);
            this.Controls.Add(this.subscriberLabel);
            this.Controls.Add(this.ISBNtextBox);
            this.Controls.Add(this.ISBNlabel);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.NumTextBox);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.ReturnListDataGridView);
            this.Controls.Add(this.OrderDataGridView);
            this.MaximizeBox = false;
            this.Name = "ReturnListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退货信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnListForm_FormClosing);
            this.Load += new System.EventHandler(this.ReturnListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.DataGridView ReturnListDataGridView;
        private System.Windows.Forms.ComboBox publishingHouseComboBox;
        private System.Windows.Forms.ComboBox documentTypeComboBox;
        private System.Windows.Forms.Label literatureTypeLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.TextBox SubscriberTextBox;
        private System.Windows.Forms.Label subscriberLabel;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.Label ISBNlabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.TextBox NumTextBox;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.DateTimePicker subDatePicker;
        private System.Windows.Forms.Button ReturnButton;
    }
}