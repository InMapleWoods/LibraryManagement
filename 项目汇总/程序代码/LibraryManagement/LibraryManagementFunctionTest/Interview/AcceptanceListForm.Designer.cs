namespace LibraryManagementFunctionTest.Interview
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
            this.AcceptanceDataGridView = new System.Windows.Forms.DataGridView();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.BookSellerLabel = new System.Windows.Forms.Label();
            this.BookSellerComboBox = new System.Windows.Forms.ComboBox();
            this.PublishingHouseLabel = new System.Windows.Forms.Label();
            this.OrdererLabel = new System.Windows.Forms.Label();
            this.OrdererTextBox = new System.Windows.Forms.TextBox();
            this.AcceptorLabel = new System.Windows.Forms.Label();
            this.AcceptorTextBox = new System.Windows.Forms.TextBox();
            this.DocumentTypeLabel = new System.Windows.Forms.Label();
            this.DocumentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox_chooseType = new System.Windows.Forms.ComboBox();
            this.btn_reflashCase = new System.Windows.Forms.Button();
            this.btn_removeCase = new System.Windows.Forms.Button();
            this.btn_addCase = new System.Windows.Forms.Button();
            this.PublishingHouseTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptanceDataGridView
            // 
            this.AcceptanceDataGridView.AllowUserToAddRows = false;
            this.AcceptanceDataGridView.AllowUserToDeleteRows = false;
            this.AcceptanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcceptanceDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AcceptanceDataGridView.Location = new System.Drawing.Point(0, 398);
            this.AcceptanceDataGridView.Name = "AcceptanceDataGridView";
            this.AcceptanceDataGridView.ReadOnly = true;
            this.AcceptanceDataGridView.RowHeadersVisible = false;
            this.AcceptanceDataGridView.RowHeadersWidth = 51;
            this.AcceptanceDataGridView.RowTemplate.Height = 27;
            this.AcceptanceDataGridView.Size = new System.Drawing.Size(872, 305);
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
            this.BookSellerComboBox.Items.AddRange(new object[] {
            "书商"});
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
            // comboBox_chooseType
            // 
            this.comboBox_chooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chooseType.FormattingEnabled = true;
            this.comboBox_chooseType.Items.AddRange(new object[] {
            "增加",
            "修改"});
            this.comboBox_chooseType.Location = new System.Drawing.Point(699, 102);
            this.comboBox_chooseType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_chooseType.Name = "comboBox_chooseType";
            this.comboBox_chooseType.Size = new System.Drawing.Size(160, 23);
            this.comboBox_chooseType.TabIndex = 57;
            this.comboBox_chooseType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_chooseType_SelectedIndexChanged);
            // 
            // btn_reflashCase
            // 
            this.btn_reflashCase.Location = new System.Drawing.Point(486, 74);
            this.btn_reflashCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reflashCase.Name = "btn_reflashCase";
            this.btn_reflashCase.Size = new System.Drawing.Size(160, 51);
            this.btn_reflashCase.TabIndex = 56;
            this.btn_reflashCase.Text = "刷新用例";
            this.btn_reflashCase.UseVisualStyleBackColor = true;
            this.btn_reflashCase.Click += new System.EventHandler(this.Btn_reflashCase_Click);
            // 
            // btn_removeCase
            // 
            this.btn_removeCase.Location = new System.Drawing.Point(265, 74);
            this.btn_removeCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_removeCase.Name = "btn_removeCase";
            this.btn_removeCase.Size = new System.Drawing.Size(161, 51);
            this.btn_removeCase.TabIndex = 55;
            this.btn_removeCase.Text = "删除用例";
            this.btn_removeCase.UseVisualStyleBackColor = true;
            this.btn_removeCase.Click += new System.EventHandler(this.Btn_removeCase_Click);
            // 
            // btn_addCase
            // 
            this.btn_addCase.Location = new System.Drawing.Point(40, 74);
            this.btn_addCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addCase.Name = "btn_addCase";
            this.btn_addCase.Size = new System.Drawing.Size(169, 51);
            this.btn_addCase.TabIndex = 54;
            this.btn_addCase.Text = "增加用例";
            this.btn_addCase.UseVisualStyleBackColor = true;
            this.btn_addCase.Click += new System.EventHandler(this.Btn_addCase_Click);
            // 
            // PublishingHouseTextBox
            // 
            this.PublishingHouseTextBox.Location = new System.Drawing.Point(119, 354);
            this.PublishingHouseTextBox.Name = "PublishingHouseTextBox";
            this.PublishingHouseTextBox.Size = new System.Drawing.Size(121, 25);
            this.PublishingHouseTextBox.TabIndex = 58;
            // 
            // AcceptanceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 703);
            this.Controls.Add(this.PublishingHouseTextBox);
            this.Controls.Add(this.comboBox_chooseType);
            this.Controls.Add(this.btn_reflashCase);
            this.Controls.Add(this.btn_removeCase);
            this.Controls.Add(this.btn_addCase);
            this.Controls.Add(this.DocumentTypeComboBox);
            this.Controls.Add(this.DocumentTypeLabel);
            this.Controls.Add(this.AcceptorTextBox);
            this.Controls.Add(this.AcceptorLabel);
            this.Controls.Add(this.OrdererTextBox);
            this.Controls.Add(this.OrdererLabel);
            this.Controls.Add(this.PublishingHouseLabel);
            this.Controls.Add(this.BookSellerComboBox);
            this.Controls.Add(this.BookSellerLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.AcceptanceDataGridView);
            this.MaximizeBox = false;
            this.Name = "AcceptanceListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "验收清单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AcceptanceListForm_FormClosing);
            this.Load += new System.EventHandler(this.AcceptanceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AcceptanceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView AcceptanceDataGridView;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label BookSellerLabel;
        private System.Windows.Forms.ComboBox BookSellerComboBox;
        private System.Windows.Forms.Label PublishingHouseLabel;
        private System.Windows.Forms.Label OrdererLabel;
        private System.Windows.Forms.TextBox OrdererTextBox;
        private System.Windows.Forms.Label AcceptorLabel;
        private System.Windows.Forms.TextBox AcceptorTextBox;
        private System.Windows.Forms.Label DocumentTypeLabel;
        private System.Windows.Forms.ComboBox DocumentTypeComboBox;
        private System.Windows.Forms.ComboBox comboBox_chooseType;
        private System.Windows.Forms.Button btn_reflashCase;
        private System.Windows.Forms.Button btn_removeCase;
        private System.Windows.Forms.Button btn_addCase;
        private System.Windows.Forms.TextBox PublishingHouseTextBox;
    }
}