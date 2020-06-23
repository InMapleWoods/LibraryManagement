namespace LibraryManagement.Interview
{
    partial class BookOrderForm
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
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.orderNumTextBox = new System.Windows.Forms.TextBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.ISBNlabel = new System.Windows.Forms.Label();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.subscriberLabel = new System.Windows.Forms.Label();
            this.SubscriberTextBox = new System.Windows.Forms.TextBox();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.literatureTypeLabel = new System.Windows.Forms.Label();
            this.documentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.subDatePicker = new System.Windows.Forms.DateTimePicker();
            this.publishingHouseComboBox = new System.Windows.Forms.ComboBox();
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
            this.InterviewDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterviewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Location = new System.Drawing.Point(78, 309);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(52, 15);
            this.orderNumberLabel.TabIndex = 1;
            this.orderNumberLabel.Text = "订单号";
            // 
            // orderNumTextBox
            // 
            this.orderNumTextBox.Location = new System.Drawing.Point(145, 306);
            this.orderNumTextBox.Name = "orderNumTextBox";
            this.orderNumTextBox.Size = new System.Drawing.Size(149, 25);
            this.orderNumTextBox.TabIndex = 2;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(63, 345);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(67, 15);
            this.orderDateLabel.TabIndex = 3;
            this.orderDateLabel.Text = "订购日期";
            // 
            // ISBNlabel
            // 
            this.ISBNlabel.AutoSize = true;
            this.ISBNlabel.Location = new System.Drawing.Point(91, 382);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(39, 15);
            this.ISBNlabel.TabIndex = 5;
            this.ISBNlabel.Text = "ISBN";
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(145, 379);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(149, 25);
            this.ISBNtextBox.TabIndex = 6;
            // 
            // subscriberLabel
            // 
            this.subscriberLabel.AutoSize = true;
            this.subscriberLabel.Location = new System.Drawing.Point(62, 420);
            this.subscriberLabel.Name = "subscriberLabel";
            this.subscriberLabel.Size = new System.Drawing.Size(68, 15);
            this.subscriberLabel.TabIndex = 7;
            this.subscriberLabel.Text = "订购人ID";
            // 
            // SubscriberTextBox
            // 
            this.SubscriberTextBox.Location = new System.Drawing.Point(145, 417);
            this.SubscriberTextBox.Name = "SubscriberTextBox";
            this.SubscriberTextBox.Size = new System.Drawing.Size(149, 25);
            this.SubscriberTextBox.TabIndex = 8;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(555, 301);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(37, 15);
            this.bookNameLabel.TabIndex = 9;
            this.bookNameLabel.Text = "书名";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(607, 298);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(149, 25);
            this.bookNameTextBox.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(555, 337);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 15);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "价格";
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(607, 334);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(149, 25);
            this.pricetextBox.TabIndex = 12;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(540, 379);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(52, 15);
            this.publisherLabel.TabIndex = 13;
            this.publisherLabel.Text = "出版社";
            // 
            // literatureTypeLabel
            // 
            this.literatureTypeLabel.AutoSize = true;
            this.literatureTypeLabel.Location = new System.Drawing.Point(525, 421);
            this.literatureTypeLabel.Name = "literatureTypeLabel";
            this.literatureTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.literatureTypeLabel.TabIndex = 15;
            this.literatureTypeLabel.Text = "文献类型";
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
            this.documentTypeComboBox.Location = new System.Drawing.Point(607, 418);
            this.documentTypeComboBox.Name = "documentTypeComboBox";
            this.documentTypeComboBox.Size = new System.Drawing.Size(149, 23);
            this.documentTypeComboBox.TabIndex = 16;
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AllowUserToAddRows = false;
            this.OrderDataGridView.AllowUserToDeleteRows = false;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderDataGridView.Location = new System.Drawing.Point(0, 492);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.ReadOnly = true;
            this.OrderDataGridView.RowHeadersVisible = false;
            this.OrderDataGridView.RowHeadersWidth = 51;
            this.OrderDataGridView.RowTemplate.Height = 27;
            this.OrderDataGridView.Size = new System.Drawing.Size(866, 185);
            this.OrderDataGridView.TabIndex = 19;
            this.OrderDataGridView.CurrentCellChanged += new System.EventHandler(this.OrderDataGridView_CurrentCellChanged);
            this.OrderDataGridView.SelectionChanged += new System.EventHandler(this.OrderDataGridView_SelectionChanged);
            // 
            // subDatePicker
            // 
            this.subDatePicker.Location = new System.Drawing.Point(145, 343);
            this.subDatePicker.Name = "subDatePicker";
            this.subDatePicker.Size = new System.Drawing.Size(149, 25);
            this.subDatePicker.TabIndex = 21;
            // 
            // publishingHouseComboBox
            // 
            this.publishingHouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publishingHouseComboBox.FormattingEnabled = true;
            this.publishingHouseComboBox.Location = new System.Drawing.Point(607, 379);
            this.publishingHouseComboBox.Name = "publishingHouseComboBox";
            this.publishingHouseComboBox.Size = new System.Drawing.Size(149, 23);
            this.publishingHouseComboBox.TabIndex = 22;
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 183);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(866, 82);
            this.scriptUserControl1.TabIndex = 20;
            // 
            // InterviewDataGridView
            // 
            this.InterviewDataGridView.AllowUserToAddRows = false;
            this.InterviewDataGridView.AllowUserToDeleteRows = false;
            this.InterviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InterviewDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.InterviewDataGridView.Location = new System.Drawing.Point(0, 0);
            this.InterviewDataGridView.Name = "InterviewDataGridView";
            this.InterviewDataGridView.ReadOnly = true;
            this.InterviewDataGridView.RowHeadersVisible = false;
            this.InterviewDataGridView.RowHeadersWidth = 51;
            this.InterviewDataGridView.RowTemplate.Height = 27;
            this.InterviewDataGridView.Size = new System.Drawing.Size(866, 185);
            this.InterviewDataGridView.TabIndex = 23;
            // 
            // BookOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 677);
            this.Controls.Add(this.InterviewDataGridView);
            this.Controls.Add(this.publishingHouseComboBox);
            this.Controls.Add(this.subDatePicker);
            this.Controls.Add(this.scriptUserControl1);
            this.Controls.Add(this.OrderDataGridView);
            this.Controls.Add(this.documentTypeComboBox);
            this.Controls.Add(this.literatureTypeLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.pricetextBox);
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
            this.MaximizeBox = false;
            this.Name = "BookOrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订购新书";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.BookOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterviewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.TextBox orderNumTextBox;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label ISBNlabel;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.Label subscriberLabel;
        private System.Windows.Forms.TextBox SubscriberTextBox;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label literatureTypeLabel;
        private System.Windows.Forms.ComboBox documentTypeComboBox;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
        private System.Windows.Forms.DateTimePicker subDatePicker;
        private System.Windows.Forms.ComboBox publishingHouseComboBox;
        private System.Windows.Forms.DataGridView InterviewDataGridView;
    }
}