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
            this.orderNumTextBox = new System.Windows.Forms.TextBox();
            this.orderNumberLabel = new System.Windows.Forms.Label();
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
            // 
            // ReturnListDataGridView
            // 
            this.ReturnListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReturnListDataGridView.Location = new System.Drawing.Point(0, 532);
            this.ReturnListDataGridView.Name = "ReturnListDataGridView";
            this.ReturnListDataGridView.RowTemplate.Height = 27;
            this.ReturnListDataGridView.Size = new System.Drawing.Size(813, 150);
            this.ReturnListDataGridView.TabIndex = 1;
            // 
            // publishingHouseComboBox
            // 
            this.publishingHouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publishingHouseComboBox.FormattingEnabled = true;
            this.publishingHouseComboBox.Location = new System.Drawing.Point(574, 349);
            this.publishingHouseComboBox.Name = "publishingHouseComboBox";
            this.publishingHouseComboBox.Size = new System.Drawing.Size(149, 23);
            this.publishingHouseComboBox.TabIndex = 38;
            // 
            // subDatePicker
            // 
            this.subDatePicker.Location = new System.Drawing.Point(142, 293);
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
            this.documentTypeComboBox.Location = new System.Drawing.Point(574, 404);
            this.documentTypeComboBox.Name = "documentTypeComboBox";
            this.documentTypeComboBox.Size = new System.Drawing.Size(149, 23);
            this.documentTypeComboBox.TabIndex = 36;
            // 
            // literatureTypeLabel
            // 
            this.literatureTypeLabel.AutoSize = true;
            this.literatureTypeLabel.Location = new System.Drawing.Point(492, 407);
            this.literatureTypeLabel.Name = "literatureTypeLabel";
            this.literatureTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.literatureTypeLabel.TabIndex = 35;
            this.literatureTypeLabel.Text = "文献类型";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(507, 349);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(52, 15);
            this.publisherLabel.TabIndex = 34;
            this.publisherLabel.Text = "出版社";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(574, 292);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(149, 25);
            this.priceTextBox.TabIndex = 33;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(522, 295);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 15);
            this.priceLabel.TabIndex = 32;
            this.priceLabel.Text = "价格";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(574, 234);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(149, 25);
            this.bookNameTextBox.TabIndex = 31;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(522, 237);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(37, 15);
            this.bookNameLabel.TabIndex = 30;
            this.bookNameLabel.Text = "书名";
            // 
            // SubscriberTextBox
            // 
            this.SubscriberTextBox.Location = new System.Drawing.Point(142, 404);
            this.SubscriberTextBox.Name = "SubscriberTextBox";
            this.SubscriberTextBox.Size = new System.Drawing.Size(149, 25);
            this.SubscriberTextBox.TabIndex = 29;
            // 
            // subscriberLabel
            // 
            this.subscriberLabel.AutoSize = true;
            this.subscriberLabel.Location = new System.Drawing.Point(59, 407);
            this.subscriberLabel.Name = "subscriberLabel";
            this.subscriberLabel.Size = new System.Drawing.Size(68, 15);
            this.subscriberLabel.TabIndex = 28;
            this.subscriberLabel.Text = "订购人ID";
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(142, 349);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(149, 25);
            this.ISBNtextBox.TabIndex = 27;
            // 
            // ISBNlabel
            // 
            this.ISBNlabel.AutoSize = true;
            this.ISBNlabel.Location = new System.Drawing.Point(88, 352);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(39, 15);
            this.ISBNlabel.TabIndex = 26;
            this.ISBNlabel.Text = "ISBN";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(60, 295);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(67, 15);
            this.orderDateLabel.TabIndex = 25;
            this.orderDateLabel.Text = "订购日期";
            // 
            // orderNumTextBox
            // 
            this.orderNumTextBox.Location = new System.Drawing.Point(142, 234);
            this.orderNumTextBox.Name = "orderNumTextBox";
            this.orderNumTextBox.Size = new System.Drawing.Size(149, 25);
            this.orderNumTextBox.TabIndex = 24;
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Location = new System.Drawing.Point(75, 237);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(52, 15);
            this.orderNumberLabel.TabIndex = 23;
            this.orderNumberLabel.Text = "订单号";
            // 
            // ReturnListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 682);
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
            this.Controls.Add(this.orderNumTextBox);
            this.Controls.Add(this.orderNumberLabel);
            this.Controls.Add(this.ReturnListDataGridView);
            this.Controls.Add(this.OrderDataGridView);
            this.MaximizeBox = false;
            this.Name = "ReturnListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退货信息";
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
        private System.Windows.Forms.DateTimePicker subDatePicker;
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
        private System.Windows.Forms.TextBox orderNumTextBox;
        private System.Windows.Forms.Label orderNumberLabel;
    }
}