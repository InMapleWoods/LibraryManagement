namespace LibraryManagementFunctionTest.Circulation
{
    partial class BookDamageForm
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
            this.label_State = new System.Windows.Forms.Label();
            this.comboBox_State = new System.Windows.Forms.ComboBox();
            this.btn_reflashCase = new System.Windows.Forms.Button();
            this.btn_removeCase = new System.Windows.Forms.Button();
            this.btn_addCase = new System.Windows.Forms.Button();
            this.comboBox_chooseType = new System.Windows.Forms.ComboBox();
            this.label_checkerId = new System.Windows.Forms.Label();
            this.textBox_checkerId = new System.Windows.Forms.TextBox();
            this.label_bookId = new System.Windows.Forms.Label();
            this.textBox_bookId = new System.Windows.Forms.TextBox();
            this.label_detail = new System.Windows.Forms.Label();
            this.textBox_detail = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(187, 221);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(37, 15);
            this.label_State.TabIndex = 26;
            this.label_State.Text = "状态";
            // 
            // comboBox_State
            // 
            this.comboBox_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_State.FormattingEnabled = true;
            this.comboBox_State.Items.AddRange(new object[] {
            "已修复",
            "待修复",
            "修复失败"});
            this.comboBox_State.Location = new System.Drawing.Point(288, 216);
            this.comboBox_State.Name = "comboBox_State";
            this.comboBox_State.Size = new System.Drawing.Size(330, 23);
            this.comboBox_State.TabIndex = 27;
            // 
            // btn_reflashCase
            // 
            this.btn_reflashCase.Location = new System.Drawing.Point(650, 46);
            this.btn_reflashCase.Name = "btn_reflashCase";
            this.btn_reflashCase.Size = new System.Drawing.Size(160, 51);
            this.btn_reflashCase.TabIndex = 30;
            this.btn_reflashCase.Text = "刷新用例";
            this.btn_reflashCase.UseVisualStyleBackColor = true;
            this.btn_reflashCase.Click += new System.EventHandler(this.btn_reflashCase_Click);
            // 
            // btn_removeCase
            // 
            this.btn_removeCase.Location = new System.Drawing.Point(382, 47);
            this.btn_removeCase.Name = "btn_removeCase";
            this.btn_removeCase.Size = new System.Drawing.Size(161, 51);
            this.btn_removeCase.TabIndex = 29;
            this.btn_removeCase.Text = "删除用例";
            this.btn_removeCase.UseVisualStyleBackColor = true;
            this.btn_removeCase.Click += new System.EventHandler(this.btn_removeCase_Click);
            // 
            // btn_addCase
            // 
            this.btn_addCase.Location = new System.Drawing.Point(123, 47);
            this.btn_addCase.Name = "btn_addCase";
            this.btn_addCase.Size = new System.Drawing.Size(169, 51);
            this.btn_addCase.TabIndex = 28;
            this.btn_addCase.Text = "增加用例";
            this.btn_addCase.UseVisualStyleBackColor = true;
            this.btn_addCase.Click += new System.EventHandler(this.btn_addCase_Click);
            // 
            // comboBox_chooseType
            // 
            this.comboBox_chooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chooseType.FormattingEnabled = true;
            this.comboBox_chooseType.Items.AddRange(new object[] {
            "增加",
            "修改"});
            this.comboBox_chooseType.Location = new System.Drawing.Point(839, 61);
            this.comboBox_chooseType.Name = "comboBox_chooseType";
            this.comboBox_chooseType.Size = new System.Drawing.Size(121, 23);
            this.comboBox_chooseType.TabIndex = 31;
            this.comboBox_chooseType.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseType_SelectedIndexChanged);
            // 
            // label_checkerId
            // 
            this.label_checkerId.AutoSize = true;
            this.label_checkerId.Location = new System.Drawing.Point(187, 159);
            this.label_checkerId.Name = "label_checkerId";
            this.label_checkerId.Size = new System.Drawing.Size(82, 15);
            this.label_checkerId.TabIndex = 32;
            this.label_checkerId.Text = "检查人编号";
            // 
            // textBox_checkerId
            // 
            this.textBox_checkerId.Location = new System.Drawing.Point(288, 154);
            this.textBox_checkerId.Name = "textBox_checkerId";
            this.textBox_checkerId.Size = new System.Drawing.Size(330, 25);
            this.textBox_checkerId.TabIndex = 33;
            // 
            // label_bookId
            // 
            this.label_bookId.AutoSize = true;
            this.label_bookId.Location = new System.Drawing.Point(187, 190);
            this.label_bookId.Name = "label_bookId";
            this.label_bookId.Size = new System.Drawing.Size(67, 15);
            this.label_bookId.TabIndex = 32;
            this.label_bookId.Text = "书籍编号";
            // 
            // textBox_bookId
            // 
            this.textBox_bookId.Location = new System.Drawing.Point(288, 185);
            this.textBox_bookId.Name = "textBox_bookId";
            this.textBox_bookId.Size = new System.Drawing.Size(330, 25);
            this.textBox_bookId.TabIndex = 33;
            // 
            // label_detail
            // 
            this.label_detail.AutoSize = true;
            this.label_detail.Location = new System.Drawing.Point(187, 250);
            this.label_detail.Name = "label_detail";
            this.label_detail.Size = new System.Drawing.Size(97, 15);
            this.label_detail.TabIndex = 32;
            this.label_detail.Text = "详细破损信息";
            // 
            // textBox_detail
            // 
            this.textBox_detail.Location = new System.Drawing.Point(288, 245);
            this.textBox_detail.Name = "textBox_detail";
            this.textBox_detail.Size = new System.Drawing.Size(330, 25);
            this.textBox_detail.TabIndex = 33;
            // 
            // BookDamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 608);
            this.Controls.Add(this.textBox_detail);
            this.Controls.Add(this.label_detail);
            this.Controls.Add(this.textBox_bookId);
            this.Controls.Add(this.label_bookId);
            this.Controls.Add(this.textBox_checkerId);
            this.Controls.Add(this.label_checkerId);
            this.Controls.Add(this.comboBox_chooseType);
            this.Controls.Add(this.btn_reflashCase);
            this.Controls.Add(this.btn_removeCase);
            this.Controls.Add(this.btn_addCase);
            this.Controls.Add(this.comboBox_State);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookDamageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书损坏处理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookDamageForm_FormClosing);
            this.Load += new System.EventHandler(this.BookDamageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.ComboBox comboBox_State;
        private System.Windows.Forms.Button btn_reflashCase;
        private System.Windows.Forms.Button btn_removeCase;
        private System.Windows.Forms.Button btn_addCase;
        private System.Windows.Forms.ComboBox comboBox_chooseType;
        private System.Windows.Forms.Label label_checkerId;
        private System.Windows.Forms.TextBox textBox_checkerId;
        private System.Windows.Forms.Label label_bookId;
        private System.Windows.Forms.TextBox textBox_bookId;
        private System.Windows.Forms.Label label_detail;
        private System.Windows.Forms.TextBox textBox_detail;
    }
}