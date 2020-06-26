namespace LibraryManagement.Interview
{
    partial class AcceptanceListForm
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
            this.PurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.AcceptanceDataGridView = new System.Windows.Forms.DataGridView();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.BookSellerLabel = new System.Windows.Forms.Label();
            this.BookSellerComboBox = new System.Windows.Forms.ComboBox();
            this.PublishingHouseLabel = new System.Windows.Forms.Label();
            this.PublishingHouseComboBox = new System.Windows.Forms.ComboBox();
            this.OrdererLabel = new System.Windows.Forms.Label();
            this.OrdererTextBox = new System.Windows.Forms.TextBox();
            this.AcceptorLabel = new System.Windows.Forms.Label();
            this.AcceptorTextBox = new System.Windows.Forms.TextBox();
            this.DocumentTypeLabel = new System.Windows.Forms.Label();
            this.DocumentTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseDataGridView
            // 
            this.PurchaseDataGridView.AllowUserToAddRows = false;
            this.PurchaseDataGridView.AllowUserToDeleteRows = false;
            this.PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.PurchaseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PurchaseDataGridView.Name = "PurchaseDataGridView";
            this.PurchaseDataGridView.ReadOnly = true;
            this.PurchaseDataGridView.RowHeadersVisible = false;
            this.PurchaseDataGridView.RowHeadersWidth = 51;
            this.PurchaseDataGridView.RowTemplate.Height = 27;
            this.PurchaseDataGridView.Size = new System.Drawing.Size(872, 185);
            this.PurchaseDataGridView.TabIndex = 20;
            // 
            // AcceptanceDataGridView
            // 
            this.AcceptanceDataGridView.AllowUserToAddRows = false;
            this.AcceptanceDataGridView.AllowUserToDeleteRows = false;
            this.AcceptanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcceptanceDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AcceptanceDataGridView.Location = new System.Drawing.Point(0, 518);
            this.AcceptanceDataGridView.Name = "AcceptanceDataGridView";
            this.AcceptanceDataGridView.ReadOnly = true;
            this.AcceptanceDataGridView.RowHeadersVisible = false;
            this.AcceptanceDataGridView.RowHeadersWidth = 51;
            this.AcceptanceDataGridView.RowTemplate.Height = 27;
            this.AcceptanceDataGridView.Size = new System.Drawing.Size(872, 185);
            this.AcceptanceDataGridView.TabIndex = 21;
            this.AcceptanceDataGridView.CurrentCellChanged += new System.EventHandler(this.AcceptanceDataGridView_CurrentCellChanged);
            this.AcceptanceDataGridView.SelectionChanged += new System.EventHandler(this.AcceptanceDataGridView_SelectionChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(46, 237);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(52, 15);
            this.IdLabel.TabIndex = 22;
            this.IdLabel.Text = "清单号";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(119, 234);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(121, 25);
            this.IdTextBox.TabIndex = 23;
            // 
            // BookSellerLabel
            // 
            this.BookSellerLabel.AutoSize = true;
            this.BookSellerLabel.Location = new System.Drawing.Point(46, 299);
            this.BookSellerLabel.Name = "BookSellerLabel";
            this.BookSellerLabel.Size = new System.Drawing.Size(52, 15);
            this.BookSellerLabel.TabIndex = 24;
            this.BookSellerLabel.Text = "书商名";
            // 
            // BookSellerComboBox
            // 
            this.BookSellerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookSellerComboBox.FormattingEnabled = true;
            this.BookSellerComboBox.Location = new System.Drawing.Point(119, 296);
            this.BookSellerComboBox.Name = "BookSellerComboBox";
            this.BookSellerComboBox.Size = new System.Drawing.Size(121, 23);
            this.BookSellerComboBox.TabIndex = 25;
            // 
            // PublishingHouseLabel
            // 
            this.PublishingHouseLabel.AutoSize = true;
            this.PublishingHouseLabel.Location = new System.Drawing.Point(46, 362);
            this.PublishingHouseLabel.Name = "PublishingHouseLabel";
            this.PublishingHouseLabel.Size = new System.Drawing.Size(52, 15);
            this.PublishingHouseLabel.TabIndex = 26;
            this.PublishingHouseLabel.Text = "出版社";
            // 
            // PublishingHouseComboBox
            // 
            this.PublishingHouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PublishingHouseComboBox.FormattingEnabled = true;
            this.PublishingHouseComboBox.Location = new System.Drawing.Point(119, 359);
            this.PublishingHouseComboBox.Name = "PublishingHouseComboBox";
            this.PublishingHouseComboBox.Size = new System.Drawing.Size(121, 23);
            this.PublishingHouseComboBox.TabIndex = 27;
            // 
            // OrdererLabel
            // 
            this.OrdererLabel.AutoSize = true;
            this.OrdererLabel.Location = new System.Drawing.Point(498, 237);
            this.OrdererLabel.Name = "OrdererLabel";
            this.OrdererLabel.Size = new System.Drawing.Size(52, 15);
            this.OrdererLabel.TabIndex = 28;
            this.OrdererLabel.Text = "订购人";
            // 
            // OrdererTextBox
            // 
            this.OrdererTextBox.Location = new System.Drawing.Point(571, 234);
            this.OrdererTextBox.Name = "OrdererTextBox";
            this.OrdererTextBox.Size = new System.Drawing.Size(121, 25);
            this.OrdererTextBox.TabIndex = 29;
            // 
            // AcceptorLabel
            // 
            this.AcceptorLabel.AutoSize = true;
            this.AcceptorLabel.Location = new System.Drawing.Point(498, 299);
            this.AcceptorLabel.Name = "AcceptorLabel";
            this.AcceptorLabel.Size = new System.Drawing.Size(52, 15);
            this.AcceptorLabel.TabIndex = 30;
            this.AcceptorLabel.Text = "验收人";
            // 
            // AcceptorTextBox
            // 
            this.AcceptorTextBox.Location = new System.Drawing.Point(571, 296);
            this.AcceptorTextBox.Name = "AcceptorTextBox";
            this.AcceptorTextBox.Size = new System.Drawing.Size(121, 25);
            this.AcceptorTextBox.TabIndex = 31;
            // 
            // DocumentTypeLabel
            // 
            this.DocumentTypeLabel.AutoSize = true;
            this.DocumentTypeLabel.Location = new System.Drawing.Point(483, 359);
            this.DocumentTypeLabel.Name = "DocumentTypeLabel";
            this.DocumentTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.DocumentTypeLabel.TabIndex = 32;
            this.DocumentTypeLabel.Text = "文献类型";
            // 
            // DocumentTypeComboBox
            // 
            this.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypeComboBox.FormattingEnabled = true;
            this.DocumentTypeComboBox.Items.AddRange(new object[] {
            "期刊",
            "专著",
            "论文",
            "专利",
            "电子文献"});
            this.DocumentTypeComboBox.Location = new System.Drawing.Point(571, 356);
            this.DocumentTypeComboBox.Name = "DocumentTypeComboBox";
            this.DocumentTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.DocumentTypeComboBox.TabIndex = 33;
            // 
            // AcceptanceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 703);
            this.Controls.Add(this.DocumentTypeComboBox);
            this.Controls.Add(this.DocumentTypeLabel);
            this.Controls.Add(this.AcceptorTextBox);
            this.Controls.Add(this.AcceptorLabel);
            this.Controls.Add(this.OrdererTextBox);
            this.Controls.Add(this.OrdererLabel);
            this.Controls.Add(this.PublishingHouseComboBox);
            this.Controls.Add(this.PublishingHouseLabel);
            this.Controls.Add(this.BookSellerComboBox);
            this.Controls.Add(this.BookSellerLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.AcceptanceDataGridView);
            this.Controls.Add(this.PurchaseDataGridView);
            this.MaximizeBox = false;
            this.Name = "AcceptanceListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcceptanceListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AcceptanceListForm_FormClosing);
            this.Load += new System.EventHandler(this.AcceptanceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptanceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchaseDataGridView;
        private System.Windows.Forms.DataGridView AcceptanceDataGridView;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label BookSellerLabel;
        private System.Windows.Forms.ComboBox BookSellerComboBox;
        private System.Windows.Forms.Label PublishingHouseLabel;
        private System.Windows.Forms.ComboBox PublishingHouseComboBox;
        private System.Windows.Forms.Label OrdererLabel;
        private System.Windows.Forms.TextBox OrdererTextBox;
        private System.Windows.Forms.Label AcceptorLabel;
        private System.Windows.Forms.TextBox AcceptorTextBox;
        private System.Windows.Forms.Label DocumentTypeLabel;
        private System.Windows.Forms.ComboBox DocumentTypeComboBox;
    }
}