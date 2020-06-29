namespace LibraryManagementFunctionTest.Maintainace
{
    partial class DictionaryBookSellerEdit
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
            this.comboBox_Dictionary = new System.Windows.Forms.ComboBox();
            this.dataGV_DictionaryShow = new System.Windows.Forms.DataGridView();
            this.lab_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.lab_Location = new System.Windows.Forms.Label();
            this.textBox_CorPL = new System.Windows.Forms.TextBox();
            this.lab_CorPL = new System.Windows.Forms.Label();
            this.textBox_Postcodes = new System.Windows.Forms.TextBox();
            this.lab_Call = new System.Windows.Forms.Label();
            this.textBox_BankName = new System.Windows.Forms.TextBox();
            this.lab_Postcodes = new System.Windows.Forms.Label();
            this.textBox_Call = new System.Windows.Forms.TextBox();
            this.lab_BankName = new System.Windows.Forms.Label();
            this.lab_Remark = new System.Windows.Forms.Label();
            this.textBox_Remark = new System.Windows.Forms.TextBox();
            this.comboBox_chooseType = new System.Windows.Forms.ComboBox();
            this.btn_reflashCase = new System.Windows.Forms.Button();
            this.btn_removeCase = new System.Windows.Forms.Button();
            this.btn_addCase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DictionaryShow)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Dictionary
            // 
            this.comboBox_Dictionary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Dictionary.FormattingEnabled = true;
            this.comboBox_Dictionary.Items.AddRange(new object[] {
            "书商字典",
            "出版社字典"});
            this.comboBox_Dictionary.Location = new System.Drawing.Point(469, 110);
            this.comboBox_Dictionary.Name = "comboBox_Dictionary";
            this.comboBox_Dictionary.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Dictionary.TabIndex = 0;
            this.comboBox_Dictionary.SelectedIndexChanged += new System.EventHandler(this.comboBox_Dictionary_SelectedIndexChanged);
            // 
            // dataGV_DictionaryShow
            // 
            this.dataGV_DictionaryShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DictionaryShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGV_DictionaryShow.Location = new System.Drawing.Point(0, 345);
            this.dataGV_DictionaryShow.Name = "dataGV_DictionaryShow";
            this.dataGV_DictionaryShow.ReadOnly = true;
            this.dataGV_DictionaryShow.RowHeadersVisible = false;
            this.dataGV_DictionaryShow.RowHeadersWidth = 51;
            this.dataGV_DictionaryShow.RowTemplate.Height = 23;
            this.dataGV_DictionaryShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_DictionaryShow.Size = new System.Drawing.Size(800, 105);
            this.dataGV_DictionaryShow.TabIndex = 1;
            this.dataGV_DictionaryShow.CurrentCellChanged += new System.EventHandler(this.dataGV_DictionaryShow_CurrentCellChanged);
            this.dataGV_DictionaryShow.SelectionChanged += new System.EventHandler(this.dataGV_DictionaryShow_SelectionChanged);
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(73, 113);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(53, 12);
            this.lab_Name.TabIndex = 3;
            this.lab_Name.Text = "书商名称";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(132, 110);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 21);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(132, 153);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(100, 21);
            this.textBox_Adress.TabIndex = 6;
            // 
            // lab_Location
            // 
            this.lab_Location.AutoSize = true;
            this.lab_Location.Location = new System.Drawing.Point(85, 156);
            this.lab_Location.Name = "lab_Location";
            this.lab_Location.Size = new System.Drawing.Size(29, 12);
            this.lab_Location.TabIndex = 5;
            this.lab_Location.Text = "地址";
            // 
            // textBox_CorPL
            // 
            this.textBox_CorPL.Location = new System.Drawing.Point(132, 192);
            this.textBox_CorPL.Name = "textBox_CorPL";
            this.textBox_CorPL.Size = new System.Drawing.Size(100, 21);
            this.textBox_CorPL.TabIndex = 8;
            // 
            // lab_CorPL
            // 
            this.lab_CorPL.AutoSize = true;
            this.lab_CorPL.Location = new System.Drawing.Point(85, 195);
            this.lab_CorPL.Name = "lab_CorPL";
            this.lab_CorPL.Size = new System.Drawing.Size(41, 12);
            this.lab_CorPL.TabIndex = 7;
            this.lab_CorPL.Text = "联系人";
            // 
            // textBox_Postcodes
            // 
            this.textBox_Postcodes.Location = new System.Drawing.Point(322, 153);
            this.textBox_Postcodes.Name = "textBox_Postcodes";
            this.textBox_Postcodes.Size = new System.Drawing.Size(100, 21);
            this.textBox_Postcodes.TabIndex = 10;
            // 
            // lab_Call
            // 
            this.lab_Call.AutoSize = true;
            this.lab_Call.Location = new System.Drawing.Point(275, 113);
            this.lab_Call.Name = "lab_Call";
            this.lab_Call.Size = new System.Drawing.Size(29, 12);
            this.lab_Call.TabIndex = 9;
            this.lab_Call.Text = "电话";
            // 
            // textBox_BankName
            // 
            this.textBox_BankName.Location = new System.Drawing.Point(322, 192);
            this.textBox_BankName.Name = "textBox_BankName";
            this.textBox_BankName.Size = new System.Drawing.Size(100, 21);
            this.textBox_BankName.TabIndex = 12;
            // 
            // lab_Postcodes
            // 
            this.lab_Postcodes.AutoSize = true;
            this.lab_Postcodes.Location = new System.Drawing.Point(275, 156);
            this.lab_Postcodes.Name = "lab_Postcodes";
            this.lab_Postcodes.Size = new System.Drawing.Size(29, 12);
            this.lab_Postcodes.TabIndex = 11;
            this.lab_Postcodes.Text = "邮编";
            // 
            // textBox_Call
            // 
            this.textBox_Call.Location = new System.Drawing.Point(322, 110);
            this.textBox_Call.Name = "textBox_Call";
            this.textBox_Call.Size = new System.Drawing.Size(100, 21);
            this.textBox_Call.TabIndex = 14;
            // 
            // lab_BankName
            // 
            this.lab_BankName.AutoSize = true;
            this.lab_BankName.Location = new System.Drawing.Point(275, 195);
            this.lab_BankName.Name = "lab_BankName";
            this.lab_BankName.Size = new System.Drawing.Size(41, 12);
            this.lab_BankName.TabIndex = 13;
            this.lab_BankName.Text = "开户行";
            // 
            // lab_Remark
            // 
            this.lab_Remark.AutoSize = true;
            this.lab_Remark.Location = new System.Drawing.Point(85, 238);
            this.lab_Remark.Name = "lab_Remark";
            this.lab_Remark.Size = new System.Drawing.Size(29, 12);
            this.lab_Remark.TabIndex = 16;
            this.lab_Remark.Text = "备注";
            // 
            // textBox_Remark
            // 
            this.textBox_Remark.Location = new System.Drawing.Point(132, 235);
            this.textBox_Remark.Name = "textBox_Remark";
            this.textBox_Remark.Size = new System.Drawing.Size(336, 21);
            this.textBox_Remark.TabIndex = 15;
            this.textBox_Remark.TextChanged += new System.EventHandler(this.textBox_Remark_TextChanged);
            // 
            // comboBox_chooseType
            // 
            this.comboBox_chooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chooseType.FormattingEnabled = true;
            this.comboBox_chooseType.Items.AddRange(new object[] {
            "增加",
            "修改"});
            this.comboBox_chooseType.Location = new System.Drawing.Point(612, 48);
            this.comboBox_chooseType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_chooseType.Name = "comboBox_chooseType";
            this.comboBox_chooseType.Size = new System.Drawing.Size(92, 20);
            this.comboBox_chooseType.TabIndex = 35;
            this.comboBox_chooseType.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseType_SelectedIndexChanged);
            // 
            // btn_reflashCase
            // 
            this.btn_reflashCase.Location = new System.Drawing.Point(442, 37);
            this.btn_reflashCase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reflashCase.Name = "btn_reflashCase";
            this.btn_reflashCase.Size = new System.Drawing.Size(120, 41);
            this.btn_reflashCase.TabIndex = 34;
            this.btn_reflashCase.Text = "刷新用例";
            this.btn_reflashCase.UseVisualStyleBackColor = true;
            this.btn_reflashCase.Click += new System.EventHandler(this.btn_reflashCase_Click);
            // 
            // btn_removeCase
            // 
            this.btn_removeCase.Location = new System.Drawing.Point(269, 37);
            this.btn_removeCase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_removeCase.Name = "btn_removeCase";
            this.btn_removeCase.Size = new System.Drawing.Size(121, 41);
            this.btn_removeCase.TabIndex = 33;
            this.btn_removeCase.Text = "删除用例";
            this.btn_removeCase.UseVisualStyleBackColor = true;
            this.btn_removeCase.Click += new System.EventHandler(this.btn_removeCase_Click);
            // 
            // btn_addCase
            // 
            this.btn_addCase.Location = new System.Drawing.Point(75, 37);
            this.btn_addCase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addCase.Name = "btn_addCase";
            this.btn_addCase.Size = new System.Drawing.Size(127, 41);
            this.btn_addCase.TabIndex = 32;
            this.btn_addCase.Text = "增加用例";
            this.btn_addCase.UseVisualStyleBackColor = true;
            this.btn_addCase.Click += new System.EventHandler(this.btn_addCase_Click);
            // 
            // DictionaryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_chooseType);
            this.Controls.Add(this.btn_reflashCase);
            this.Controls.Add(this.btn_removeCase);
            this.Controls.Add(this.btn_addCase);
            this.Controls.Add(this.lab_Remark);
            this.Controls.Add(this.textBox_Remark);
            this.Controls.Add(this.textBox_Call);
            this.Controls.Add(this.lab_BankName);
            this.Controls.Add(this.textBox_BankName);
            this.Controls.Add(this.lab_Postcodes);
            this.Controls.Add(this.textBox_Postcodes);
            this.Controls.Add(this.lab_Call);
            this.Controls.Add(this.textBox_CorPL);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.lab_CorPL);
            this.Controls.Add(this.dataGV_DictionaryShow);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.comboBox_Dictionary);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.lab_Location);
            this.Name = "DictionaryEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字典编辑";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DictionaryEditForm_FormClosing);
            this.Load += new System.EventHandler(this.DictionaryEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DictionaryShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Dictionary;
        private System.Windows.Forms.DataGridView dataGV_DictionaryShow;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.Label lab_Location;
        private System.Windows.Forms.TextBox textBox_CorPL;
        private System.Windows.Forms.Label lab_CorPL;
        private System.Windows.Forms.TextBox textBox_Postcodes;
        private System.Windows.Forms.Label lab_Call;
        private System.Windows.Forms.TextBox textBox_BankName;
        private System.Windows.Forms.Label lab_Postcodes;
        private System.Windows.Forms.TextBox textBox_Call;
        private System.Windows.Forms.Label lab_BankName;
        private System.Windows.Forms.Label lab_Remark;
        private System.Windows.Forms.TextBox textBox_Remark;
        private System.Windows.Forms.ComboBox comboBox_chooseType;
        private System.Windows.Forms.Button btn_reflashCase;
        private System.Windows.Forms.Button btn_removeCase;
        private System.Windows.Forms.Button btn_addCase;
    }
}