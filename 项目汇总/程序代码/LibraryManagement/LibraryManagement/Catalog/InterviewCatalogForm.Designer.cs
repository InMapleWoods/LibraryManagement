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
            ((System.ComponentModel.ISupportInitialize)(this.interviewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // interviewDataGridView
            // 
            this.interviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interviewDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.interviewDataGridView.Location = new System.Drawing.Point(0, 0);
            this.interviewDataGridView.Name = "interviewDataGridView";
            this.interviewDataGridView.RowHeadersWidth = 62;
            this.interviewDataGridView.RowTemplate.Height = 30;
            this.interviewDataGridView.Size = new System.Drawing.Size(1050, 211);
            this.interviewDataGridView.TabIndex = 0;
            // 
            // catalogDataGridView
            // 
            this.catalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.catalogDataGridView.Location = new System.Drawing.Point(0, 427);
            this.catalogDataGridView.Name = "catalogDataGridView";
            this.catalogDataGridView.RowHeadersWidth = 62;
            this.catalogDataGridView.RowTemplate.Height = 30;
            this.catalogDataGridView.Size = new System.Drawing.Size(1050, 217);
            this.catalogDataGridView.TabIndex = 1;
            // 
            // catalogBtn
            // 
            this.catalogBtn.Location = new System.Drawing.Point(716, 284);
            this.catalogBtn.Name = "catalogBtn";
            this.catalogBtn.Size = new System.Drawing.Size(96, 95);
            this.catalogBtn.TabIndex = 2;
            this.catalogBtn.Text = "编目";
            this.catalogBtn.UseVisualStyleBackColor = true;
            // 
            // cancelCatalogBtn
            // 
            this.cancelCatalogBtn.Location = new System.Drawing.Point(860, 284);
            this.cancelCatalogBtn.Name = "cancelCatalogBtn";
            this.cancelCatalogBtn.Size = new System.Drawing.Size(139, 95);
            this.cancelCatalogBtn.TabIndex = 3;
            this.cancelCatalogBtn.Text = "取消编目";
            this.cancelCatalogBtn.UseVisualStyleBackColor = true;
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
            // InterviewCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 644);
            this.Controls.Add(this.interviewIdTextBox);
            this.Controls.Add(this.interviewIdLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cancelCatalogBtn);
            this.Controls.Add(this.catalogBtn);
            this.Controls.Add(this.catalogDataGridView);
            this.Controls.Add(this.interviewDataGridView);
            this.Name = "InterviewCatalogForm";
            this.Text = "InterviewCatalogForm";
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
    }
}