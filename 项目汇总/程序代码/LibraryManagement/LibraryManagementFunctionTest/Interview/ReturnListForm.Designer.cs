namespace LibraryManagementFunctionTest.Interview
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
            this.comboBox_chooseType = new System.Windows.Forms.ComboBox();
            this.btn_reflashCase = new System.Windows.Forms.Button();
            this.btn_removeCase = new System.Windows.Forms.Button();
            this.btn_addCase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnListDataGridView
            // 
            this.ReturnListDataGridView.AllowUserToAddRows = false;
            this.ReturnListDataGridView.AllowUserToDeleteRows = false;
            this.ReturnListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReturnListDataGridView.Location = new System.Drawing.Point(0, 368);
            this.ReturnListDataGridView.Name = "ReturnListDataGridView";
            this.ReturnListDataGridView.ReadOnly = true;
            this.ReturnListDataGridView.RowHeadersVisible = false;
            this.ReturnListDataGridView.RowTemplate.Height = 27;
            this.ReturnListDataGridView.Size = new System.Drawing.Size(813, 249);
            this.ReturnListDataGridView.TabIndex = 1;
            this.ReturnListDataGridView.CurrentCellChanged += new System.EventHandler(this.ReturnListDataGridView_CurrentCellChanged);
            this.ReturnListDataGridView.SelectionChanged += new System.EventHandler(this.ReturnListDataGridView_SelectionChanged);
            // 
            // publishingHouseComboBox
            // 
            this.publishingHouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publishingHouseComboBox.FormattingEnabled = true;
            this.publishingHouseComboBox.Items.AddRange(new object[] {
            "出版社"});
            this.publishingHouseComboBox.Location = new System.Drawing.Point(583, 168);
            this.publishingHouseComboBox.Name = "publishingHouseComboBox";
            this.publishingHouseComboBox.Size = new System.Drawing.Size(149, 23);
            this.publishingHouseComboBox.TabIndex = 38;
            // 
            // subDatePicker
            // 
            this.subDatePicker.Location = new System.Drawing.Point(151, 112);
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
            this.documentTypeComboBox.Location = new System.Drawing.Point(583, 223);
            this.documentTypeComboBox.Name = "documentTypeComboBox";
            this.documentTypeComboBox.Size = new System.Drawing.Size(149, 23);
            this.documentTypeComboBox.TabIndex = 36;
            // 
            // literatureTypeLabel
            // 
            this.literatureTypeLabel.AutoSize = true;
            this.literatureTypeLabel.Location = new System.Drawing.Point(501, 226);
            this.literatureTypeLabel.Name = "literatureTypeLabel";
            this.literatureTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.literatureTypeLabel.TabIndex = 35;
            this.literatureTypeLabel.Text = "文献类型";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(516, 168);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(52, 15);
            this.publisherLabel.TabIndex = 34;
            this.publisherLabel.Text = "出版社";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(583, 111);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(149, 25);
            this.priceTextBox.TabIndex = 33;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(531, 114);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 15);
            this.priceLabel.TabIndex = 32;
            this.priceLabel.Text = "价格";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(583, 53);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(149, 25);
            this.bookNameTextBox.TabIndex = 31;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(531, 56);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(37, 15);
            this.bookNameLabel.TabIndex = 30;
            this.bookNameLabel.Text = "书名";
            // 
            // SubscriberTextBox
            // 
            this.SubscriberTextBox.Location = new System.Drawing.Point(151, 223);
            this.SubscriberTextBox.Name = "SubscriberTextBox";
            this.SubscriberTextBox.Size = new System.Drawing.Size(149, 25);
            this.SubscriberTextBox.TabIndex = 29;
            // 
            // subscriberLabel
            // 
            this.subscriberLabel.AutoSize = true;
            this.subscriberLabel.Location = new System.Drawing.Point(68, 226);
            this.subscriberLabel.Name = "subscriberLabel";
            this.subscriberLabel.Size = new System.Drawing.Size(68, 15);
            this.subscriberLabel.TabIndex = 28;
            this.subscriberLabel.Text = "订购人ID";
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(151, 168);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(149, 25);
            this.ISBNtextBox.TabIndex = 27;
            // 
            // ISBNlabel
            // 
            this.ISBNlabel.AutoSize = true;
            this.ISBNlabel.Location = new System.Drawing.Point(97, 171);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(39, 15);
            this.ISBNlabel.TabIndex = 26;
            this.ISBNlabel.Text = "ISBN";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(69, 114);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(67, 15);
            this.orderDateLabel.TabIndex = 25;
            this.orderDateLabel.Text = "订购日期";
            // 
            // NumTextBox
            // 
            this.NumTextBox.Location = new System.Drawing.Point(151, 53);
            this.NumTextBox.Name = "NumTextBox";
            this.NumTextBox.Size = new System.Drawing.Size(149, 25);
            this.NumTextBox.TabIndex = 24;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(97, 56);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(37, 15);
            this.NumberLabel.TabIndex = 23;
            this.NumberLabel.Text = "单号";
            // 
            // comboBox_chooseType
            // 
            this.comboBox_chooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chooseType.FormattingEnabled = true;
            this.comboBox_chooseType.Items.AddRange(new object[] {
            "增加",
            "修改"});
            this.comboBox_chooseType.Location = new System.Drawing.Point(640, 320);
            this.comboBox_chooseType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_chooseType.Name = "comboBox_chooseType";
            this.comboBox_chooseType.Size = new System.Drawing.Size(160, 23);
            this.comboBox_chooseType.TabIndex = 53;
            this.comboBox_chooseType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_chooseType_SelectedIndexChanged);
            // 
            // btn_reflashCase
            // 
            this.btn_reflashCase.Location = new System.Drawing.Point(445, 292);
            this.btn_reflashCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reflashCase.Name = "btn_reflashCase";
            this.btn_reflashCase.Size = new System.Drawing.Size(160, 51);
            this.btn_reflashCase.TabIndex = 52;
            this.btn_reflashCase.Text = "刷新用例";
            this.btn_reflashCase.UseVisualStyleBackColor = true;
            this.btn_reflashCase.Click += new System.EventHandler(this.Btn_reflashCase_Click);
            // 
            // btn_removeCase
            // 
            this.btn_removeCase.Location = new System.Drawing.Point(237, 292);
            this.btn_removeCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_removeCase.Name = "btn_removeCase";
            this.btn_removeCase.Size = new System.Drawing.Size(161, 51);
            this.btn_removeCase.TabIndex = 51;
            this.btn_removeCase.Text = "删除用例";
            this.btn_removeCase.UseVisualStyleBackColor = true;
            this.btn_removeCase.Click += new System.EventHandler(this.Btn_removeCase_Click);
            // 
            // btn_addCase
            // 
            this.btn_addCase.Location = new System.Drawing.Point(25, 292);
            this.btn_addCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addCase.Name = "btn_addCase";
            this.btn_addCase.Size = new System.Drawing.Size(169, 51);
            this.btn_addCase.TabIndex = 50;
            this.btn_addCase.Text = "增加用例";
            this.btn_addCase.UseVisualStyleBackColor = true;
            this.btn_addCase.Click += new System.EventHandler(this.Btn_addCase_Click);
            // 
            // ReturnListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 617);
            this.Controls.Add(this.comboBox_chooseType);
            this.Controls.Add(this.btn_reflashCase);
            this.Controls.Add(this.btn_removeCase);
            this.Controls.Add(this.btn_addCase);
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
            this.MaximizeBox = false;
            this.Name = "ReturnListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退货信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnListForm_FormClosing);
            this.Load += new System.EventHandler(this.ReturnListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DateTimePicker subDatePicker;
        private System.Windows.Forms.ComboBox comboBox_chooseType;
        private System.Windows.Forms.Button btn_reflashCase;
        private System.Windows.Forms.Button btn_removeCase;
        private System.Windows.Forms.Button btn_addCase;
    }
}