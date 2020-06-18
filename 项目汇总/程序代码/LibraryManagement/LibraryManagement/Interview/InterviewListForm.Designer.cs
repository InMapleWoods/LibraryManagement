namespace LibraryManagement.Interview
{
    partial class InterviewListForm
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.InterviewIdTextBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.PublishingHouseLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DocumentTypeLabel = new System.Windows.Forms.Label();
            this.OrderStatusLabel = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.DocumentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.PublishingHouseComboBox = new System.Windows.Forms.ComboBox();
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(814, 193);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(74, 134);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(52, 15);
            this.IdLabel.TabIndex = 21;
            this.IdLabel.Text = "清单号";
            // 
            // InterviewIdTextBox
            // 
            this.InterviewIdTextBox.Location = new System.Drawing.Point(132, 131);
            this.InterviewIdTextBox.Name = "InterviewIdTextBox";
            this.InterviewIdTextBox.Size = new System.Drawing.Size(100, 25);
            this.InterviewIdTextBox.TabIndex = 22;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(80, 185);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(37, 15);
            this.AuthorLabel.TabIndex = 23;
            this.AuthorLabel.Text = "作者";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(78, 240);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(39, 15);
            this.ISBNLabel.TabIndex = 24;
            this.ISBNLabel.Text = "ISBN";
            // 
            // PublishingHouseLabel
            // 
            this.PublishingHouseLabel.AutoSize = true;
            this.PublishingHouseLabel.Location = new System.Drawing.Point(484, 161);
            this.PublishingHouseLabel.Name = "PublishingHouseLabel";
            this.PublishingHouseLabel.Size = new System.Drawing.Size(52, 15);
            this.PublishingHouseLabel.TabIndex = 25;
            this.PublishingHouseLabel.Text = "出版社";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(80, 342);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(37, 15);
            this.PriceLabel.TabIndex = 26;
            this.PriceLabel.Text = "价格";
            // 
            // DocumentTypeLabel
            // 
            this.DocumentTypeLabel.AutoSize = true;
            this.DocumentTypeLabel.Location = new System.Drawing.Point(469, 217);
            this.DocumentTypeLabel.Name = "DocumentTypeLabel";
            this.DocumentTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.DocumentTypeLabel.TabIndex = 27;
            this.DocumentTypeLabel.Text = "文献类型";
            // 
            // OrderStatusLabel
            // 
            this.OrderStatusLabel.AutoSize = true;
            this.OrderStatusLabel.Location = new System.Drawing.Point(469, 268);
            this.OrderStatusLabel.Name = "OrderStatusLabel";
            this.OrderStatusLabel.Size = new System.Drawing.Size(67, 15);
            this.OrderStatusLabel.TabIndex = 28;
            this.OrderStatusLabel.Text = "订购状态";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(132, 182);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(100, 25);
            this.AuthorTextBox.TabIndex = 29;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(132, 237);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(100, 25);
            this.ISBNTextBox.TabIndex = 30;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(132, 339);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 25);
            this.PriceTextBox.TabIndex = 32;
            // 
            // DocumentTypeComboBox
            // 
            this.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypeComboBox.FormattingEnabled = true;
            this.DocumentTypeComboBox.Items.AddRange(new object[] {
            "期刊",
            "专著"});
            this.DocumentTypeComboBox.Location = new System.Drawing.Point(560, 214);
            this.DocumentTypeComboBox.Name = "DocumentTypeComboBox";
            this.DocumentTypeComboBox.Size = new System.Drawing.Size(100, 23);
            this.DocumentTypeComboBox.TabIndex = 35;
            // 
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Items.AddRange(new object[] {
            "采访",
            "验收"});
            this.OrderStatusComboBox.Location = new System.Drawing.Point(560, 266);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(100, 23);
            this.OrderStatusComboBox.TabIndex = 36;
            // 
            // PublishingHouseComboBox
            // 
            this.PublishingHouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PublishingHouseComboBox.FormattingEnabled = true;
            this.PublishingHouseComboBox.Location = new System.Drawing.Point(560, 158);
            this.PublishingHouseComboBox.Name = "PublishingHouseComboBox";
            this.PublishingHouseComboBox.Size = new System.Drawing.Size(100, 23);
            this.PublishingHouseComboBox.TabIndex = 33;
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(814, 88);
            this.scriptUserControl1.TabIndex = 38;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(80, 292);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(37, 15);
            this.BookNameLabel.TabIndex = 39;
            this.BookNameLabel.Text = "书名";
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(132, 289);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.BookNameTextBox.TabIndex = 31;
            // 
            // InterviewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 608);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.scriptUserControl1);
            this.Controls.Add(this.PublishingHouseComboBox);
            this.Controls.Add(this.OrderStatusComboBox);
            this.Controls.Add(this.DocumentTypeComboBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.OrderStatusLabel);
            this.Controls.Add(this.DocumentTypeLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PublishingHouseLabel);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.InterviewIdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "InterviewListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterviewListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterviewListForm_FormClosing);
            this.Load += new System.EventHandler(this.InterviewListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox InterviewIdTextBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label PublishingHouseLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DocumentTypeLabel;
        private System.Windows.Forms.Label OrderStatusLabel;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.ComboBox DocumentTypeComboBox;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.ComboBox PublishingHouseComboBox;
        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.TextBox BookNameTextBox;
    }
}