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
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
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
            this.PurchaseDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PurchaseDataGridView.Name = "PurchaseDataGridView";
            this.PurchaseDataGridView.ReadOnly = true;
            this.PurchaseDataGridView.RowHeadersVisible = false;
            this.PurchaseDataGridView.RowHeadersWidth = 51;
            this.PurchaseDataGridView.RowTemplate.Height = 27;
            this.PurchaseDataGridView.Size = new System.Drawing.Size(981, 222);
            this.PurchaseDataGridView.TabIndex = 20;
            // 
            // AcceptanceDataGridView
            // 
            this.AcceptanceDataGridView.AllowUserToAddRows = false;
            this.AcceptanceDataGridView.AllowUserToDeleteRows = false;
            this.AcceptanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcceptanceDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AcceptanceDataGridView.Location = new System.Drawing.Point(0, 622);
            this.AcceptanceDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AcceptanceDataGridView.Name = "AcceptanceDataGridView";
            this.AcceptanceDataGridView.ReadOnly = true;
            this.AcceptanceDataGridView.RowHeadersVisible = false;
            this.AcceptanceDataGridView.RowHeadersWidth = 51;
            this.AcceptanceDataGridView.RowTemplate.Height = 27;
            this.AcceptanceDataGridView.Size = new System.Drawing.Size(981, 222);
            this.AcceptanceDataGridView.TabIndex = 21;
            this.AcceptanceDataGridView.CurrentCellChanged += new System.EventHandler(this.AcceptanceDataGridView_CurrentCellChanged);
            this.AcceptanceDataGridView.SelectionChanged += new System.EventHandler(this.AcceptanceDataGridView_SelectionChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(52, 284);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(62, 18);
            this.IdLabel.TabIndex = 22;
            this.IdLabel.Text = "清单号";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(134, 281);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(136, 28);
            this.IdTextBox.TabIndex = 23;
            // 
            // BookSellerLabel
            // 
            this.BookSellerLabel.AutoSize = true;
            this.BookSellerLabel.Location = new System.Drawing.Point(52, 359);
            this.BookSellerLabel.Name = "BookSellerLabel";
            this.BookSellerLabel.Size = new System.Drawing.Size(62, 18);
            this.BookSellerLabel.TabIndex = 24;
            this.BookSellerLabel.Text = "书商名";
            // 
            // BookSellerComboBox
            // 
            this.BookSellerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookSellerComboBox.FormattingEnabled = true;
            this.BookSellerComboBox.Location = new System.Drawing.Point(134, 355);
            this.BookSellerComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookSellerComboBox.Name = "BookSellerComboBox";
            this.BookSellerComboBox.Size = new System.Drawing.Size(136, 26);
            this.BookSellerComboBox.TabIndex = 25;
            // 
            // PublishingHouseLabel
            // 
            this.PublishingHouseLabel.AutoSize = true;
            this.PublishingHouseLabel.Location = new System.Drawing.Point(52, 434);
            this.PublishingHouseLabel.Name = "PublishingHouseLabel";
            this.PublishingHouseLabel.Size = new System.Drawing.Size(62, 18);
            this.PublishingHouseLabel.TabIndex = 26;
            this.PublishingHouseLabel.Text = "出版社";
            // 
            // PublishingHouseComboBox
            // 
            this.PublishingHouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PublishingHouseComboBox.FormattingEnabled = true;
            this.PublishingHouseComboBox.Location = new System.Drawing.Point(134, 431);
            this.PublishingHouseComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PublishingHouseComboBox.Name = "PublishingHouseComboBox";
            this.PublishingHouseComboBox.Size = new System.Drawing.Size(136, 26);
            this.PublishingHouseComboBox.TabIndex = 27;
            // 
            // OrdererLabel
            // 
            this.OrdererLabel.AutoSize = true;
            this.OrdererLabel.Location = new System.Drawing.Point(560, 284);
            this.OrdererLabel.Name = "OrdererLabel";
            this.OrdererLabel.Size = new System.Drawing.Size(62, 18);
            this.OrdererLabel.TabIndex = 28;
            this.OrdererLabel.Text = "订购人";
            // 
            // OrdererTextBox
            // 
            this.OrdererTextBox.Location = new System.Drawing.Point(642, 281);
            this.OrdererTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdererTextBox.Name = "OrdererTextBox";
            this.OrdererTextBox.Size = new System.Drawing.Size(136, 28);
            this.OrdererTextBox.TabIndex = 29;
            this.OrdererTextBox.TextChanged += new System.EventHandler(this.OrdererTextBox_TextChanged);
            // 
            // AcceptorLabel
            // 
            this.AcceptorLabel.AutoSize = true;
            this.AcceptorLabel.Location = new System.Drawing.Point(560, 359);
            this.AcceptorLabel.Name = "AcceptorLabel";
            this.AcceptorLabel.Size = new System.Drawing.Size(62, 18);
            this.AcceptorLabel.TabIndex = 30;
            this.AcceptorLabel.Text = "验收人";
            // 
            // AcceptorTextBox
            // 
            this.AcceptorTextBox.Location = new System.Drawing.Point(642, 355);
            this.AcceptorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AcceptorTextBox.Name = "AcceptorTextBox";
            this.AcceptorTextBox.Size = new System.Drawing.Size(136, 28);
            this.AcceptorTextBox.TabIndex = 31;
            // 
            // DocumentTypeLabel
            // 
            this.DocumentTypeLabel.AutoSize = true;
            this.DocumentTypeLabel.Location = new System.Drawing.Point(543, 431);
            this.DocumentTypeLabel.Name = "DocumentTypeLabel";
            this.DocumentTypeLabel.Size = new System.Drawing.Size(80, 18);
            this.DocumentTypeLabel.TabIndex = 32;
            this.DocumentTypeLabel.Text = "文献类型";
            // 
            // DocumentTypeComboBox
            // 
            this.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypeComboBox.FormattingEnabled = true;
            this.DocumentTypeComboBox.Items.AddRange(new object[] {
            "期刊",
            "专著"});
            this.DocumentTypeComboBox.Location = new System.Drawing.Point(642, 427);
            this.DocumentTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DocumentTypeComboBox.Name = "DocumentTypeComboBox";
            this.DocumentTypeComboBox.Size = new System.Drawing.Size(136, 26);
            this.DocumentTypeComboBox.TabIndex = 33;
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 514);
            this.scriptUserControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(981, 108);
            this.scriptUserControl1.TabIndex = 34;
            // 
            // AcceptanceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 844);
            this.Controls.Add(this.scriptUserControl1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
    }
}