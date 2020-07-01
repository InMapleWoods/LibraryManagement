namespace LibraryManagement.Catalog
{
    partial class MoveCatalogForm
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
            this.moveBtn = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 213);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(922, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(496, 55);
            this.moveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(91, 38);
            this.moveBtn.TabIndex = 1;
            this.moveBtn.Text = "移送";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(198, 67);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(37, 15);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 25);
            this.textBox1.TabIndex = 3;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(310, 142);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(103, 44);
            this.printBtn.TabIndex = 4;
            this.printBtn.Text = "打印";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(485, 142);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(102, 44);
            this.previewBtn.TabIndex = 5;
            this.previewBtn.Text = "打印预览";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // MoveCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 480);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MoveCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编目移送";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoveCatalogForm_FormClosing);
            this.Load += new System.EventHandler(this.MoveCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button previewBtn;
    }
}