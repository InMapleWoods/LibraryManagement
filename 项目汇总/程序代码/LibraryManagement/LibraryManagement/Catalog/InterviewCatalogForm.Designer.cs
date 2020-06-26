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
            this.interviewDataGridView.Name = "interviewDataGridView";
            this.interviewDataGridView.ReadOnly = true;
            this.interviewDataGridView.RowHeadersVisible = false;
            this.interviewDataGridView.RowHeadersWidth = 62;
            this.interviewDataGridView.RowTemplate.Height = 30;
            this.interviewDataGridView.Size = new System.Drawing.Size(1050, 211);
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
            this.catalogDataGridView.Location = new System.Drawing.Point(0, 427);
            this.catalogDataGridView.Name = "catalogDataGridView";
            this.catalogDataGridView.ReadOnly = true;
            this.catalogDataGridView.RowHeadersVisible = false;
            this.catalogDataGridView.RowHeadersWidth = 62;
            this.catalogDataGridView.RowTemplate.Height = 30;
            this.catalogDataGridView.Size = new System.Drawing.Size(1050, 217);
            this.catalogDataGridView.TabIndex = 1;
            this.catalogDataGridView.CurrentCellChanged += new System.EventHandler(this.catalogDataGridView_CurrentCellChanged);
            this.catalogDataGridView.SelectionChanged += new System.EventHandler(this.catalogDataGridView_SelectionChanged);
            // 
            // catalogBtn
            // 
            this.catalogBtn.Location = new System.Drawing.Point(610, 284);
            this.catalogBtn.Name = "catalogBtn";
            this.catalogBtn.Size = new System.Drawing.Size(96, 95);
            this.catalogBtn.TabIndex = 2;
            this.catalogBtn.Text = "编目";
            this.catalogBtn.UseVisualStyleBackColor = true;
            this.catalogBtn.Click += new System.EventHandler(this.catalogBtn_Click);
            // 
            // cancelCatalogBtn
            // 
            this.cancelCatalogBtn.Location = new System.Drawing.Point(860, 284);
            this.cancelCatalogBtn.Name = "cancelCatalogBtn";
            this.cancelCatalogBtn.Size = new System.Drawing.Size(139, 95);
            this.cancelCatalogBtn.TabIndex = 3;
            this.cancelCatalogBtn.Text = "取消编目";
            this.cancelCatalogBtn.UseVisualStyleBackColor = true;
            this.cancelCatalogBtn.Click += new System.EventHandler(this.cancelCatalogBtn_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(261, 244);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 18);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(318, 241);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(236, 28);
            this.idTextBox.TabIndex = 5;
            // 
            // interviewIdLabel
            // 
            this.interviewIdLabel.AutoSize = true;
            this.interviewIdLabel.Location = new System.Drawing.Point(231, 302);
            this.interviewIdLabel.Name = "interviewIdLabel";
            this.interviewIdLabel.Size = new System.Drawing.Size(80, 18);
            this.interviewIdLabel.TabIndex = 6;
            this.interviewIdLabel.Text = "采访编号";
            // 
            // interviewIdTextBox
            // 
            this.interviewIdTextBox.Location = new System.Drawing.Point(318, 292);
            this.interviewIdTextBox.Name = "interviewIdTextBox";
            this.interviewIdTextBox.Size = new System.Drawing.Size(236, 28);
            this.interviewIdTextBox.TabIndex = 7;
            // 
            // allCatalogBtn
            // 
            this.allCatalogBtn.Location = new System.Drawing.Point(52, 263);
            this.allCatalogBtn.Name = "allCatalogBtn";
            this.allCatalogBtn.Size = new System.Drawing.Size(113, 82);
            this.allCatalogBtn.TabIndex = 8;
            this.allCatalogBtn.Text = "可编目书籍全部入库";
            this.allCatalogBtn.UseVisualStyleBackColor = true;
            this.allCatalogBtn.Click += new System.EventHandler(this.allCatalogBtn_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(252, 361);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(44, 18);
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
            this.stateComboBox.Location = new System.Drawing.Point(318, 358);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(236, 26);
            this.stateComboBox.TabIndex = 10;
            // 
            // changeStateBtn
            // 
            this.changeStateBtn.Location = new System.Drawing.Point(733, 284);
            this.changeStateBtn.Name = "changeStateBtn";
            this.changeStateBtn.Size = new System.Drawing.Size(97, 95);
            this.changeStateBtn.TabIndex = 11;
            this.changeStateBtn.Text = "修改状态";
            this.changeStateBtn.UseVisualStyleBackColor = true;
            this.changeStateBtn.Click += new System.EventHandler(this.changeStateBtn_Click);
            // 
            // InterviewCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 644);
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
    }
}