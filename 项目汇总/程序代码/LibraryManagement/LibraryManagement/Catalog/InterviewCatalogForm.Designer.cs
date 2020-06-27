namespace LibraryManagement.Catalog
{
    partial class InterviewCatalogForm
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
            this.interviewDataGridView = new System.Windows.Forms.DataGridView();
            this.catalogDataGridView = new System.Windows.Forms.DataGridView();
            this.catalogBtn = new System.Windows.Forms.Button();
            this.cancelCatalogBtn = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.interviewIdLabel = new System.Windows.Forms.Label();
            this.interviewIdTextBox = new System.Windows.Forms.TextBox();
            this.allCatalogBtn = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.changeStateBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.interviewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // interviewDataGridView
            // 
            this.interviewDataGridView.AllowUserToAddRows = false;
            this.interviewDataGridView.AllowUserToDeleteRows = false;
            this.interviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interviewDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.interviewDataGridView.Location = new System.Drawing.Point(0, 0);
            this.interviewDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.interviewDataGridView.Name = "interviewDataGridView";
            this.interviewDataGridView.ReadOnly = true;
            this.interviewDataGridView.RowHeadersVisible = false;
            this.interviewDataGridView.RowHeadersWidth = 62;
            this.interviewDataGridView.RowTemplate.Height = 30;
            this.interviewDataGridView.Size = new System.Drawing.Size(933, 176);
            this.interviewDataGridView.TabIndex = 0;
            this.interviewDataGridView.CurrentCellChanged += new System.EventHandler(this.interviewDataGridView_CurrentCellChanged);
            this.interviewDataGridView.SelectionChanged += new System.EventHandler(this.interviewDataGridView_SelectionChanged);
            // 
            // catalogDataGridView
            // 
            this.catalogDataGridView.AllowUserToAddRows = false;
            this.catalogDataGridView.AllowUserToDeleteRows = false;
            this.catalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.catalogDataGridView.Location = new System.Drawing.Point(0, 356);
            this.catalogDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catalogDataGridView.Name = "catalogDataGridView";
            this.catalogDataGridView.ReadOnly = true;
            this.catalogDataGridView.RowHeadersVisible = false;
            this.catalogDataGridView.RowHeadersWidth = 62;
            this.catalogDataGridView.RowTemplate.Height = 30;
            this.catalogDataGridView.Size = new System.Drawing.Size(933, 181);
            this.catalogDataGridView.TabIndex = 1;
            this.catalogDataGridView.CurrentCellChanged += new System.EventHandler(this.catalogDataGridView_CurrentCellChanged);
            this.catalogDataGridView.SelectionChanged += new System.EventHandler(this.catalogDataGridView_SelectionChanged);
            // 
            // catalogBtn
            // 
            this.catalogBtn.Location = new System.Drawing.Point(542, 201);
            this.catalogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catalogBtn.Name = "catalogBtn";
            this.catalogBtn.Size = new System.Drawing.Size(85, 55);
            this.catalogBtn.TabIndex = 2;
            this.catalogBtn.Text = "编目";
            this.catalogBtn.UseVisualStyleBackColor = true;
            this.catalogBtn.Click += new System.EventHandler(this.catalogBtn_Click);
            // 
            // cancelCatalogBtn
            // 
            this.cancelCatalogBtn.Location = new System.Drawing.Point(770, 201);
            this.cancelCatalogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelCatalogBtn.Name = "cancelCatalogBtn";
            this.cancelCatalogBtn.Size = new System.Drawing.Size(124, 55);
            this.cancelCatalogBtn.TabIndex = 3;
            this.cancelCatalogBtn.Text = "取消编目";
            this.cancelCatalogBtn.UseVisualStyleBackColor = true;
            this.cancelCatalogBtn.Click += new System.EventHandler(this.cancelCatalogBtn_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(232, 203);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(23, 15);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(283, 201);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(210, 25);
            this.idTextBox.TabIndex = 5;
            // 
            // interviewIdLabel
            // 
            this.interviewIdLabel.AutoSize = true;
            this.interviewIdLabel.Location = new System.Drawing.Point(205, 252);
            this.interviewIdLabel.Name = "interviewIdLabel";
            this.interviewIdLabel.Size = new System.Drawing.Size(67, 15);
            this.interviewIdLabel.TabIndex = 6;
            this.interviewIdLabel.Text = "采访编号";
            // 
            // interviewIdTextBox
            // 
            this.interviewIdTextBox.Location = new System.Drawing.Point(283, 243);
            this.interviewIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.interviewIdTextBox.Name = "interviewIdTextBox";
            this.interviewIdTextBox.Size = new System.Drawing.Size(210, 25);
            this.interviewIdTextBox.TabIndex = 7;
            // 
            // allCatalogBtn
            // 
            this.allCatalogBtn.Location = new System.Drawing.Point(46, 219);
            this.allCatalogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allCatalogBtn.Name = "allCatalogBtn";
            this.allCatalogBtn.Size = new System.Drawing.Size(100, 68);
            this.allCatalogBtn.TabIndex = 8;
            this.allCatalogBtn.Text = "可编目书籍全部入库";
            this.allCatalogBtn.UseVisualStyleBackColor = true;
            this.allCatalogBtn.Click += new System.EventHandler(this.allCatalogBtn_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(224, 301);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(37, 15);
            this.stateLabel.TabIndex = 9;
            this.stateLabel.Text = "状态";
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "可编目",
            "退回"});
            this.stateComboBox.Location = new System.Drawing.Point(283, 298);
            this.stateComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(210, 23);
            this.stateComboBox.TabIndex = 10;
            // 
            // changeStateBtn
            // 
            this.changeStateBtn.Location = new System.Drawing.Point(656, 201);
            this.changeStateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeStateBtn.Name = "changeStateBtn";
            this.changeStateBtn.Size = new System.Drawing.Size(86, 55);
            this.changeStateBtn.TabIndex = 11;
            this.changeStateBtn.Text = "修改状态";
            this.changeStateBtn.UseVisualStyleBackColor = true;
            this.changeStateBtn.Click += new System.EventHandler(this.changeStateBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(601, 281);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(79, 47);
            this.printBtn.TabIndex = 12;
            this.printBtn.Text = "打印";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(718, 282);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(75, 46);
            this.previewBtn.TabIndex = 13;
            this.previewBtn.Text = "打印预览";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // InterviewCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 537);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.changeStateBtn);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.allCatalogBtn);
            this.Controls.Add(this.interviewIdTextBox);
            this.Controls.Add(this.interviewIdLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cancelCatalogBtn);
            this.Controls.Add(this.catalogBtn);
            this.Controls.Add(this.catalogDataGridView);
            this.Controls.Add(this.interviewDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterviewCatalogForm";
            this.Text = "采访编目";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterviewCatalogForm_FormClosing);
            this.Load += new System.EventHandler(this.InterviewCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interviewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView interviewDataGridView;
        private System.Windows.Forms.DataGridView catalogDataGridView;
        private System.Windows.Forms.Button catalogBtn;
        private System.Windows.Forms.Button cancelCatalogBtn;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label interviewIdLabel;
        private System.Windows.Forms.TextBox interviewIdTextBox;
        private System.Windows.Forms.Button allCatalogBtn;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Button changeStateBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button previewBtn;
    }
}