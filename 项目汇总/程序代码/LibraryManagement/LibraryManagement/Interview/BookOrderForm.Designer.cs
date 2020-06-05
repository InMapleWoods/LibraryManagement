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
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.orderNumTextBox = new System.Windows.Forms.TextBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderDateTextBox = new System.Windows.Forms.TextBox();
            this.ISBNlabel = new System.Windows.Forms.Label();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.subscriberLabel = new System.Windows.Forms.Label();
            this.SubscriberTextBox = new System.Windows.Forms.TextBox();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.literatureTypeLabel = new System.Windows.Forms.Label();
            this.literatureTypeComboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(23, 12);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(75, 75);
            this.AddOrderButton.TabIndex = 0;
            this.AddOrderButton.Text = "添加订单";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Location = new System.Drawing.Point(35, 110);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(52, 15);
            this.orderNumberLabel.TabIndex = 1;
            this.orderNumberLabel.Text = "订单号";
            // 
            // orderNumTextBox
            // 
            this.orderNumTextBox.Location = new System.Drawing.Point(102, 107);
            this.orderNumTextBox.Name = "orderNumTextBox";
            this.orderNumTextBox.Size = new System.Drawing.Size(641, 25);
            this.orderNumTextBox.TabIndex = 2;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(20, 146);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(67, 15);
            this.orderDateLabel.TabIndex = 3;
            this.orderDateLabel.Text = "订购日期";
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.Location = new System.Drawing.Point(102, 143);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.Size = new System.Drawing.Size(641, 25);
            this.orderDateTextBox.TabIndex = 4;
            // 
            // ISBNlabel
            // 
            this.ISBNlabel.AutoSize = true;
            this.ISBNlabel.Location = new System.Drawing.Point(48, 183);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(39, 15);
            this.ISBNlabel.TabIndex = 5;
            this.ISBNlabel.Text = "ISBN";
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(102, 180);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(641, 25);
            this.ISBNtextBox.TabIndex = 6;
            // 
            // subscriberLabel
            // 
            this.subscriberLabel.AutoSize = true;
            this.subscriberLabel.Location = new System.Drawing.Point(35, 221);
            this.subscriberLabel.Name = "subscriberLabel";
            this.subscriberLabel.Size = new System.Drawing.Size(52, 15);
            this.subscriberLabel.TabIndex = 7;
            this.subscriberLabel.Text = "订购人";
            // 
            // SubscriberTextBox
            // 
            this.SubscriberTextBox.Location = new System.Drawing.Point(102, 218);
            this.SubscriberTextBox.Name = "SubscriberTextBox";
            this.SubscriberTextBox.Size = new System.Drawing.Size(641, 25);
            this.SubscriberTextBox.TabIndex = 8;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(50, 260);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(37, 15);
            this.bookNameLabel.TabIndex = 9;
            this.bookNameLabel.Text = "书名";
            this.bookNameLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(102, 257);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(641, 25);
            this.bookNameTextBox.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(50, 296);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 15);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "价格";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(641, 25);
            this.textBox1.TabIndex = 12;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(35, 338);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(52, 15);
            this.publisherLabel.TabIndex = 13;
            this.publisherLabel.Text = "出版社";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(102, 335);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(641, 25);
            this.publisherTextBox.TabIndex = 14;
            // 
            // literatureTypeLabel
            // 
            this.literatureTypeLabel.AutoSize = true;
            this.literatureTypeLabel.Location = new System.Drawing.Point(20, 380);
            this.literatureTypeLabel.Name = "literatureTypeLabel";
            this.literatureTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.literatureTypeLabel.TabIndex = 15;
            this.literatureTypeLabel.Text = "文献类型";
            // 
            // literatureTypeComboBox
            // 
            this.literatureTypeComboBox.FormattingEnabled = true;
            this.literatureTypeComboBox.Location = new System.Drawing.Point(102, 377);
            this.literatureTypeComboBox.Name = "literatureTypeComboBox";
            this.literatureTypeComboBox.Size = new System.Drawing.Size(641, 23);
            this.literatureTypeComboBox.TabIndex = 16;
            this.literatureTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.Label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 426);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(760, 171);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // BookOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 609);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.literatureTypeComboBox);
            this.Controls.Add(this.literatureTypeLabel);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.SubscriberTextBox);
            this.Controls.Add(this.subscriberLabel);
            this.Controls.Add(this.ISBNtextBox);
            this.Controls.Add(this.ISBNlabel);
            this.Controls.Add(this.orderDateTextBox);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.orderNumTextBox);
            this.Controls.Add(this.orderNumberLabel);
            this.Controls.Add(this.AddOrderButton);
            this.Name = "BookOrderForm";
            this.ShowIcon = false;
            this.Text = "订购新书";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.TextBox orderNumTextBox;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.TextBox orderDateTextBox;
        private System.Windows.Forms.Label ISBNlabel;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.Label subscriberLabel;
        private System.Windows.Forms.TextBox SubscriberTextBox;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label literatureTypeLabel;
        private System.Windows.Forms.ComboBox literatureTypeComboBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}