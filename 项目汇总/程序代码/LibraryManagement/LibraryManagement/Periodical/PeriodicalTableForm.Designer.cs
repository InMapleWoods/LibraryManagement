namespace LibraryManagement.Periodical
{
    partial class PeriodicalTableForm
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
            this.officialTitleTextBox = new System.Windows.Forms.TextBox();
            this.orderPriceTextBox = new System.Windows.Forms.TextBox();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.orderNumTextBox = new System.Windows.Forms.TextBox();
            this.orderPriceLabel = new System.Windows.Forms.Label();
            this.officialTitleLabel = new System.Windows.Forms.Label();
            this.IsbnLabel = new System.Windows.Forms.Label();
            this.orderNumLabel = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.button_preview = new System.Windows.Forms.Button();
            this.checkBox_arrived = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // officialTitleTextBox
            // 
            this.officialTitleTextBox.Location = new System.Drawing.Point(155, 130);
            this.officialTitleTextBox.Name = "officialTitleTextBox";
            this.officialTitleTextBox.Size = new System.Drawing.Size(270, 25);
            this.officialTitleTextBox.TabIndex = 3;
            this.officialTitleTextBox.TextChanged += new System.EventHandler(this._TextBox_TextChanged);
            // 
            // orderPriceTextBox
            // 
            this.orderPriceTextBox.Location = new System.Drawing.Point(155, 160);
            this.orderPriceTextBox.Name = "orderPriceTextBox";
            this.orderPriceTextBox.Size = new System.Drawing.Size(270, 25);
            this.orderPriceTextBox.TabIndex = 4;
            this.orderPriceTextBox.TextChanged += new System.EventHandler(this._TextBox_TextChanged);
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Location = new System.Drawing.Point(155, 100);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.Size = new System.Drawing.Size(270, 25);
            this.IsbnTextBox.TabIndex = 2;
            this.IsbnTextBox.TextChanged += new System.EventHandler(this._TextBox_TextChanged);
            // 
            // orderNumTextBox
            // 
            this.orderNumTextBox.Location = new System.Drawing.Point(155, 70);
            this.orderNumTextBox.Name = "orderNumTextBox";
            this.orderNumTextBox.Size = new System.Drawing.Size(270, 25);
            this.orderNumTextBox.TabIndex = 1;
            this.orderNumTextBox.TextChanged += new System.EventHandler(this._TextBox_TextChanged);
            // 
            // orderPriceLabel
            // 
            this.orderPriceLabel.AutoSize = true;
            this.orderPriceLabel.Location = new System.Drawing.Point(75, 165);
            this.orderPriceLabel.Name = "orderPriceLabel";
            this.orderPriceLabel.Size = new System.Drawing.Size(52, 15);
            this.orderPriceLabel.TabIndex = 12;
            this.orderPriceLabel.Text = "订购价";
            // 
            // officialTitleLabel
            // 
            this.officialTitleLabel.AutoSize = true;
            this.officialTitleLabel.Location = new System.Drawing.Point(75, 135);
            this.officialTitleLabel.Name = "officialTitleLabel";
            this.officialTitleLabel.Size = new System.Drawing.Size(52, 15);
            this.officialTitleLabel.TabIndex = 11;
            this.officialTitleLabel.Text = "正刊名";
            // 
            // IsbnLabel
            // 
            this.IsbnLabel.AutoSize = true;
            this.IsbnLabel.Location = new System.Drawing.Point(75, 105);
            this.IsbnLabel.Name = "IsbnLabel";
            this.IsbnLabel.Size = new System.Drawing.Size(63, 15);
            this.IsbnLabel.TabIndex = 10;
            this.IsbnLabel.Text = "I S B N";
            // 
            // orderNumLabel
            // 
            this.orderNumLabel.AutoSize = true;
            this.orderNumLabel.Location = new System.Drawing.Point(75, 75);
            this.orderNumLabel.Name = "orderNumLabel";
            this.orderNumLabel.Size = new System.Drawing.Size(52, 15);
            this.orderNumLabel.TabIndex = 9;
            this.orderNumLabel.Text = "订单号";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(462, 100);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(137, 67);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "查询";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(605, 100);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(137, 67);
            this.button_print.TabIndex = 7;
            this.button_print.Text = "打印报表";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_preview
            // 
            this.button_preview.Location = new System.Drawing.Point(748, 100);
            this.button_preview.Name = "button_preview";
            this.button_preview.Size = new System.Drawing.Size(137, 67);
            this.button_preview.TabIndex = 8;
            this.button_preview.Text = "打印预览";
            this.button_preview.UseVisualStyleBackColor = true;
            this.button_preview.Click += new System.EventHandler(this.button_preview_Click);
            // 
            // checkBox_arrived
            // 
            this.checkBox_arrived.AutoSize = true;
            this.checkBox_arrived.Location = new System.Drawing.Point(496, 70);
            this.checkBox_arrived.Name = "checkBox_arrived";
            this.checkBox_arrived.Size = new System.Drawing.Size(74, 19);
            this.checkBox_arrived.TabIndex = 5;
            this.checkBox_arrived.Text = "已验收";
            this.checkBox_arrived.UseVisualStyleBackColor = true;
            this.checkBox_arrived.CheckedChanged += new System.EventHandler(this.checkBox_arrived_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(969, 310);
            this.dataGridView1.TabIndex = 13;
            // 
            // PeriodicalTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox_arrived);
            this.Controls.Add(this.button_preview);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.officialTitleTextBox);
            this.Controls.Add(this.orderPriceTextBox);
            this.Controls.Add(this.IsbnTextBox);
            this.Controls.Add(this.orderNumTextBox);
            this.Controls.Add(this.orderPriceLabel);
            this.Controls.Add(this.officialTitleLabel);
            this.Controls.Add(this.IsbnLabel);
            this.Controls.Add(this.orderNumLabel);
            this.Name = "PeriodicalTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeriodicalTableForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PeriodicalTableForm_FormClosing);
            this.Load += new System.EventHandler(this.PeriodicalTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox officialTitleTextBox;
        private System.Windows.Forms.TextBox orderPriceTextBox;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.TextBox orderNumTextBox;
        private System.Windows.Forms.Label orderPriceLabel;
        private System.Windows.Forms.Label officialTitleLabel;
        private System.Windows.Forms.Label IsbnLabel;
        private System.Windows.Forms.Label orderNumLabel;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_preview;
        private System.Windows.Forms.CheckBox checkBox_arrived;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}