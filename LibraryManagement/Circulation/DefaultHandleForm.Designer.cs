namespace LibraryManagement.Circulation
{
    partial class DefaultHandleForm
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
            this.borrowCardNumTextBox = new System.Windows.Forms.TextBox();
            this.borrowCardNumLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookCodeTextBox = new System.Windows.Forms.TextBox();
            this.bookCodeLabel = new System.Windows.Forms.Label();
            this.button_lost = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowCardNumTextBox
            // 
            this.borrowCardNumTextBox.Location = new System.Drawing.Point(336, 88);
            this.borrowCardNumTextBox.Name = "borrowCardNumTextBox";
            this.borrowCardNumTextBox.Size = new System.Drawing.Size(330, 25);
            this.borrowCardNumTextBox.TabIndex = 11;
            this.borrowCardNumTextBox.TextChanged += new System.EventHandler(this.borrowCardNumTextBox_TextChanged);
            // 
            // borrowCardNumLabel
            // 
            this.borrowCardNumLabel.AutoSize = true;
            this.borrowCardNumLabel.Location = new System.Drawing.Point(256, 93);
            this.borrowCardNumLabel.Name = "borrowCardNumLabel";
            this.borrowCardNumLabel.Size = new System.Drawing.Size(67, 15);
            this.borrowCardNumLabel.TabIndex = 10;
            this.borrowCardNumLabel.Text = "借书证号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 230);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // bookCodeTextBox
            // 
            this.bookCodeTextBox.Location = new System.Drawing.Point(336, 162);
            this.bookCodeTextBox.Name = "bookCodeTextBox";
            this.bookCodeTextBox.Size = new System.Drawing.Size(330, 25);
            this.bookCodeTextBox.TabIndex = 14;
            // 
            // bookCodeLabel
            // 
            this.bookCodeLabel.AutoSize = true;
            this.bookCodeLabel.Location = new System.Drawing.Point(256, 167);
            this.bookCodeLabel.Name = "bookCodeLabel";
            this.bookCodeLabel.Size = new System.Drawing.Size(82, 15);
            this.bookCodeLabel.TabIndex = 13;
            this.bookCodeLabel.Text = "书本条码号";
            // 
            // button_lost
            // 
            this.button_lost.Location = new System.Drawing.Point(259, 220);
            this.button_lost.Name = "button_lost";
            this.button_lost.Size = new System.Drawing.Size(205, 60);
            this.button_lost.TabIndex = 15;
            this.button_lost.Text = "图书丢失";
            this.button_lost.UseVisualStyleBackColor = true;
            this.button_lost.Click += new System.EventHandler(this.button_lost_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(470, 220);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(205, 60);
            this.btn_return.TabIndex = 15;
            this.btn_return.Text = "已还图书";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // DefaultHandleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 581);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.button_lost);
            this.Controls.Add(this.bookCodeTextBox);
            this.Controls.Add(this.bookCodeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.borrowCardNumTextBox);
            this.Controls.Add(this.borrowCardNumLabel);
            this.Name = "DefaultHandleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "违约处理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.defaultHandleForm_FormClosing);
            this.Load += new System.EventHandler(this.defaultHandleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox borrowCardNumTextBox;
        private System.Windows.Forms.Label borrowCardNumLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox bookCodeTextBox;
        private System.Windows.Forms.Label bookCodeLabel;
        private System.Windows.Forms.Button button_lost;
        private System.Windows.Forms.Button btn_return;
    }
}