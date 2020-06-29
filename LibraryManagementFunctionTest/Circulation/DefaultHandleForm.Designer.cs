namespace LibraryManagementFunctionTest.Circulation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_reflashCase = new System.Windows.Forms.Button();
            this.btn_removeCase = new System.Windows.Forms.Button();
            this.btn_addCase = new System.Windows.Forms.Button();
            this.readerIdTextBox = new System.Windows.Forms.TextBox();
            this.readerIdLabel = new System.Windows.Forms.Label();
            this.textBox_bookId = new System.Windows.Forms.TextBox();
            this.label_bookId = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.comboBox_state = new System.Windows.Forms.ComboBox();
            this.label_PenaltyMultiple = new System.Windows.Forms.Label();
            this.textBox_PenaltyMultiple = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // btn_reflashCase
            // 
            this.btn_reflashCase.Location = new System.Drawing.Point(685, 35);
            this.btn_reflashCase.Name = "btn_reflashCase";
            this.btn_reflashCase.Size = new System.Drawing.Size(160, 51);
            this.btn_reflashCase.TabIndex = 34;
            this.btn_reflashCase.Text = "刷新用例";
            this.btn_reflashCase.UseVisualStyleBackColor = true;
            this.btn_reflashCase.Click += new System.EventHandler(this.btn_reflashCase_Click);
            // 
            // btn_removeCase
            // 
            this.btn_removeCase.Location = new System.Drawing.Point(417, 36);
            this.btn_removeCase.Name = "btn_removeCase";
            this.btn_removeCase.Size = new System.Drawing.Size(161, 51);
            this.btn_removeCase.TabIndex = 33;
            this.btn_removeCase.Text = "删除用例";
            this.btn_removeCase.UseVisualStyleBackColor = true;
            this.btn_removeCase.Click += new System.EventHandler(this.btn_removeCase_Click);
            // 
            // btn_addCase
            // 
            this.btn_addCase.Location = new System.Drawing.Point(158, 36);
            this.btn_addCase.Name = "btn_addCase";
            this.btn_addCase.Size = new System.Drawing.Size(169, 51);
            this.btn_addCase.TabIndex = 32;
            this.btn_addCase.Text = "增加用例";
            this.btn_addCase.UseVisualStyleBackColor = true;
            this.btn_addCase.Click += new System.EventHandler(this.btn_addCase_Click);
            // 
            // readerIdTextBox
            // 
            this.readerIdTextBox.Location = new System.Drawing.Point(365, 130);
            this.readerIdTextBox.Name = "readerIdTextBox";
            this.readerIdTextBox.Size = new System.Drawing.Size(330, 25);
            this.readerIdTextBox.TabIndex = 36;
            // 
            // readerIdLabel
            // 
            this.readerIdLabel.AutoSize = true;
            this.readerIdLabel.Location = new System.Drawing.Point(285, 135);
            this.readerIdLabel.Name = "readerIdLabel";
            this.readerIdLabel.Size = new System.Drawing.Size(67, 15);
            this.readerIdLabel.TabIndex = 35;
            this.readerIdLabel.Text = "读者编号";
            // 
            // textBox_bookId
            // 
            this.textBox_bookId.Location = new System.Drawing.Point(365, 165);
            this.textBox_bookId.Name = "textBox_bookId";
            this.textBox_bookId.Size = new System.Drawing.Size(330, 25);
            this.textBox_bookId.TabIndex = 38;
            // 
            // label_bookId
            // 
            this.label_bookId.AutoSize = true;
            this.label_bookId.Location = new System.Drawing.Point(285, 170);
            this.label_bookId.Name = "label_bookId";
            this.label_bookId.Size = new System.Drawing.Size(67, 15);
            this.label_bookId.TabIndex = 37;
            this.label_bookId.Text = "书籍编号";
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(285, 201);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(37, 15);
            this.label_state.TabIndex = 37;
            this.label_state.Text = "状态";
            // 
            // comboBox_state
            // 
            this.comboBox_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_state.FormattingEnabled = true;
            this.comboBox_state.Items.AddRange(new object[] {
            "待处理",
            "未交书",
            "未缴费",
            "已处理"});
            this.comboBox_state.Location = new System.Drawing.Point(365, 197);
            this.comboBox_state.Name = "comboBox_state";
            this.comboBox_state.Size = new System.Drawing.Size(330, 23);
            this.comboBox_state.TabIndex = 39;
            // 
            // label_PenaltyMultiple
            // 
            this.label_PenaltyMultiple.AutoSize = true;
            this.label_PenaltyMultiple.Location = new System.Drawing.Point(285, 231);
            this.label_PenaltyMultiple.Name = "label_PenaltyMultiple";
            this.label_PenaltyMultiple.Size = new System.Drawing.Size(67, 15);
            this.label_PenaltyMultiple.TabIndex = 37;
            this.label_PenaltyMultiple.Text = "罚金倍数";
            // 
            // textBox_PenaltyMultiple
            // 
            this.textBox_PenaltyMultiple.Location = new System.Drawing.Point(365, 226);
            this.textBox_PenaltyMultiple.Name = "textBox_PenaltyMultiple";
            this.textBox_PenaltyMultiple.Size = new System.Drawing.Size(330, 25);
            this.textBox_PenaltyMultiple.TabIndex = 38;
            // 
            // DefaultHandleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 581);
            this.Controls.Add(this.comboBox_state);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.textBox_PenaltyMultiple);
            this.Controls.Add(this.label_PenaltyMultiple);
            this.Controls.Add(this.textBox_bookId);
            this.Controls.Add(this.label_bookId);
            this.Controls.Add(this.readerIdTextBox);
            this.Controls.Add(this.readerIdLabel);
            this.Controls.Add(this.btn_reflashCase);
            this.Controls.Add(this.btn_removeCase);
            this.Controls.Add(this.btn_addCase);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_reflashCase;
        private System.Windows.Forms.Button btn_removeCase;
        private System.Windows.Forms.Button btn_addCase;
        private System.Windows.Forms.TextBox readerIdTextBox;
        private System.Windows.Forms.Label readerIdLabel;
        private System.Windows.Forms.TextBox textBox_bookId;
        private System.Windows.Forms.Label label_bookId;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.ComboBox comboBox_state;
        private System.Windows.Forms.Label label_PenaltyMultiple;
        private System.Windows.Forms.TextBox textBox_PenaltyMultiple;
    }
}