namespace LibraryManagement.Catalog
{
    partial class CatalogQueryForm
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
            this.queryDataGridView = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.queryBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // queryDataGridView
            // 
            this.queryDataGridView.AllowUserToAddRows = false;
            this.queryDataGridView.AllowUserToDeleteRows = false;
            this.queryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.queryDataGridView.Location = new System.Drawing.Point(0, 207);
            this.queryDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryDataGridView.Name = "queryDataGridView";
            this.queryDataGridView.ReadOnly = true;
            this.queryDataGridView.RowHeadersVisible = false;
            this.queryDataGridView.RowHeadersWidth = 62;
            this.queryDataGridView.RowTemplate.Height = 30;
            this.queryDataGridView.Size = new System.Drawing.Size(1018, 296);
            this.queryDataGridView.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(48, 106);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(37, 15);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "编号";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(140, 103);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(188, 25);
            this.iDTextBox.TabIndex = 12;
            this.iDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(413, 97);
            this.queryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(82, 33);
            this.queryBtn.TabIndex = 13;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(545, 97);
            this.printBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(87, 33);
            this.printBtn.TabIndex = 14;
            this.printBtn.Text = "打印";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(689, 97);
            this.previewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(85, 33);
            this.previewBtn.TabIndex = 15;
            this.previewBtn.Text = "打印预览";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // CatalogQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 503);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.queryDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CatalogQueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编目查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CatalogQueryForm_FormClosing);
            this.Load += new System.EventHandler(this.CatalogQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView queryDataGridView;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button previewBtn;
    }
}