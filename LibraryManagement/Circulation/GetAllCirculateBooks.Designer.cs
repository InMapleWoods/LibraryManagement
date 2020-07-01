namespace LibraryManagement.Circulation
{
    partial class GetAllCirculateBooks
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_search = new System.Windows.Forms.Button();
            this.officialTitleTextBox = new System.Windows.Forms.TextBox();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.officialTitleLabel = new System.Windows.Forms.Label();
            this.IsbnLabel = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label_documentType = new System.Windows.Forms.Label();
            this.textBox_documentType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 310);
            this.dataGridView1.TabIndex = 19;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(613, 115);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(137, 67);
            this.button_search.TabIndex = 16;
            this.button_search.Text = "查询";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // officialTitleTextBox
            // 
            this.officialTitleTextBox.Location = new System.Drawing.Point(286, 115);
            this.officialTitleTextBox.Name = "officialTitleTextBox";
            this.officialTitleTextBox.Size = new System.Drawing.Size(270, 25);
            this.officialTitleTextBox.TabIndex = 15;
            this.officialTitleTextBox.TextChanged += new System.EventHandler(this.officialTitleTextBox_TextChanged);
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Location = new System.Drawing.Point(286, 85);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.Size = new System.Drawing.Size(270, 25);
            this.IsbnTextBox.TabIndex = 14;
            this.IsbnTextBox.TextChanged += new System.EventHandler(this.IsbnTextBox_TextChanged);
            // 
            // officialTitleLabel
            // 
            this.officialTitleLabel.AutoSize = true;
            this.officialTitleLabel.Location = new System.Drawing.Point(206, 120);
            this.officialTitleLabel.Name = "officialTitleLabel";
            this.officialTitleLabel.Size = new System.Drawing.Size(52, 15);
            this.officialTitleLabel.TabIndex = 18;
            this.officialTitleLabel.Text = "正刊名";
            // 
            // IsbnLabel
            // 
            this.IsbnLabel.AutoSize = true;
            this.IsbnLabel.Location = new System.Drawing.Point(206, 90);
            this.IsbnLabel.Name = "IsbnLabel";
            this.IsbnLabel.Size = new System.Drawing.Size(63, 15);
            this.IsbnLabel.TabIndex = 17;
            this.IsbnLabel.Text = "I S B N";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(206, 150);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(37, 15);
            this.label_Author.TabIndex = 18;
            this.label_Author.Text = "作者";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(286, 145);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(270, 25);
            this.textBox_author.TabIndex = 15;
            this.textBox_author.TextChanged += new System.EventHandler(this.textBox_author_TextChanged);
            // 
            // label_documentType
            // 
            this.label_documentType.AutoSize = true;
            this.label_documentType.Location = new System.Drawing.Point(206, 180);
            this.label_documentType.Name = "label_documentType";
            this.label_documentType.Size = new System.Drawing.Size(67, 15);
            this.label_documentType.TabIndex = 18;
            this.label_documentType.Text = "文献类型";
            // 
            // textBox_documentType
            // 
            this.textBox_documentType.Location = new System.Drawing.Point(286, 175);
            this.textBox_documentType.Name = "textBox_documentType";
            this.textBox_documentType.Size = new System.Drawing.Size(270, 25);
            this.textBox_documentType.TabIndex = 15;
            this.textBox_documentType.TextChanged += new System.EventHandler(this.textBox_documentType_TextChanged);
            // 
            // GetAllCirculateBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 578);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_documentType);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.label_documentType);
            this.Controls.Add(this.officialTitleTextBox);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.IsbnTextBox);
            this.Controls.Add(this.officialTitleLabel);
            this.Controls.Add(this.IsbnLabel);
            this.Name = "GetAllCirculateBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "全部图书";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetAllCirculateBooks_FormClosing);
            this.Load += new System.EventHandler(this.GetAllCirculateBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox officialTitleTextBox;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.Label officialTitleLabel;
        private System.Windows.Forms.Label IsbnLabel;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Label label_documentType;
        private System.Windows.Forms.TextBox textBox_documentType;
    }
}