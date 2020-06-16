namespace LibraryManagementFunctionTest.Maintainace
{
    partial class DictionaryEditForm
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
            this.panel_option = new System.Windows.Forms.Panel();
            this.panel_deltailInfo = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DictionaryShow)).BeginInit();
            this.panel_option.SuspendLayout();
            this.panel_deltailInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Dictionary
            // 
            this.comboBox_Dictionary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Dictionary.FormattingEnabled = true;
            this.comboBox_Dictionary.Items.AddRange(new object[] {
            "书商字典",
            "出版社字典"});
            this.comboBox_Dictionary.Location = new System.Drawing.Point(648, 22);
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
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(59, 30);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(53, 12);
            this.lab_Name.TabIndex = 3;
            this.lab_Name.Text = "书商名称";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(118, 27);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 21);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(118, 70);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(100, 21);
            this.textBox_Adress.TabIndex = 6;
            // 
            // lab_Location
            // 
            this.lab_Location.AutoSize = true;
            this.lab_Location.Location = new System.Drawing.Point(71, 73);
            this.lab_Location.Name = "lab_Location";
            this.lab_Location.Size = new System.Drawing.Size(29, 12);
            this.lab_Location.TabIndex = 5;
            this.lab_Location.Text = "地址";
            // 
            // textBox_CorPL
            // 
            this.textBox_CorPL.Location = new System.Drawing.Point(118, 109);
            this.textBox_CorPL.Name = "textBox_CorPL";
            this.textBox_CorPL.Size = new System.Drawing.Size(100, 21);
            this.textBox_CorPL.TabIndex = 8;
            // 
            // lab_CorPL
            // 
            this.lab_CorPL.AutoSize = true;
            this.lab_CorPL.Location = new System.Drawing.Point(71, 112);
            this.lab_CorPL.Name = "lab_CorPL";
            this.lab_CorPL.Size = new System.Drawing.Size(41, 12);
            this.lab_CorPL.TabIndex = 7;
            this.lab_CorPL.Text = "联系人";
            // 
            // textBox_Postcodes
            // 
            this.textBox_Postcodes.Location = new System.Drawing.Point(308, 70);
            this.textBox_Postcodes.Name = "textBox_Postcodes";
            this.textBox_Postcodes.Size = new System.Drawing.Size(100, 21);
            this.textBox_Postcodes.TabIndex = 10;
            // 
            // lab_Call
            // 
            this.lab_Call.AutoSize = true;
            this.lab_Call.Location = new System.Drawing.Point(261, 30);
            this.lab_Call.Name = "lab_Call";
            this.lab_Call.Size = new System.Drawing.Size(29, 12);
            this.lab_Call.TabIndex = 9;
            this.lab_Call.Text = "电话";
            // 
            // textBox_BankName
            // 
            this.textBox_BankName.Location = new System.Drawing.Point(308, 109);
            this.textBox_BankName.Name = "textBox_BankName";
            this.textBox_BankName.Size = new System.Drawing.Size(100, 21);
            this.textBox_BankName.TabIndex = 12;
            // 
            // lab_Postcodes
            // 
            this.lab_Postcodes.AutoSize = true;
            this.lab_Postcodes.Location = new System.Drawing.Point(261, 73);
            this.lab_Postcodes.Name = "lab_Postcodes";
            this.lab_Postcodes.Size = new System.Drawing.Size(29, 12);
            this.lab_Postcodes.TabIndex = 11;
            this.lab_Postcodes.Text = "邮编";
            // 
            // textBox_Call
            // 
            this.textBox_Call.Location = new System.Drawing.Point(308, 27);
            this.textBox_Call.Name = "textBox_Call";
            this.textBox_Call.Size = new System.Drawing.Size(100, 21);
            this.textBox_Call.TabIndex = 14;
            // 
            // lab_BankName
            // 
            this.lab_BankName.AutoSize = true;
            this.lab_BankName.Location = new System.Drawing.Point(261, 112);
            this.lab_BankName.Name = "lab_BankName";
            this.lab_BankName.Size = new System.Drawing.Size(41, 12);
            this.lab_BankName.TabIndex = 13;
            this.lab_BankName.Text = "开户行";
            // 
            // lab_Remark
            // 
            this.lab_Remark.AutoSize = true;
            this.lab_Remark.Location = new System.Drawing.Point(71, 155);
            this.lab_Remark.Name = "lab_Remark";
            this.lab_Remark.Size = new System.Drawing.Size(29, 12);
            this.lab_Remark.TabIndex = 16;
            this.lab_Remark.Text = "备注";
            // 
            // textBox_Remark
            // 
            this.textBox_Remark.Location = new System.Drawing.Point(118, 152);
            this.textBox_Remark.Name = "textBox_Remark";
            this.textBox_Remark.Size = new System.Drawing.Size(336, 21);
            this.textBox_Remark.TabIndex = 15;
            // 
            // panel_option
            // 
            this.panel_option.Controls.Add(this.btn_delete);
            this.panel_option.Controls.Add(this.btn_update);
            this.panel_option.Controls.Add(this.btn_add);
            this.panel_option.Controls.Add(this.btn_clear);
            this.panel_option.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_option.Location = new System.Drawing.Point(0, 0);
            this.panel_option.Name = "panel_option";
            this.panel_option.Size = new System.Drawing.Size(800, 58);
            this.panel_option.TabIndex = 17;
            // 
            // panel_deltailInfo
            // 
            this.panel_deltailInfo.Controls.Add(this.lab_Remark);
            this.panel_deltailInfo.Controls.Add(this.textBox_Remark);
            this.panel_deltailInfo.Controls.Add(this.textBox_Call);
            this.panel_deltailInfo.Controls.Add(this.comboBox_Dictionary);
            this.panel_deltailInfo.Controls.Add(this.lab_BankName);
            this.panel_deltailInfo.Controls.Add(this.textBox_BankName);
            this.panel_deltailInfo.Controls.Add(this.lab_Postcodes);
            this.panel_deltailInfo.Controls.Add(this.textBox_Postcodes);
            this.panel_deltailInfo.Controls.Add(this.lab_Call);
            this.panel_deltailInfo.Controls.Add(this.textBox_CorPL);
            this.panel_deltailInfo.Controls.Add(this.lab_Name);
            this.panel_deltailInfo.Controls.Add(this.lab_CorPL);
            this.panel_deltailInfo.Controls.Add(this.textBox_Name);
            this.panel_deltailInfo.Controls.Add(this.textBox_Adress);
            this.panel_deltailInfo.Controls.Add(this.lab_Location);
            this.panel_deltailInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_deltailInfo.Location = new System.Drawing.Point(0, 64);
            this.panel_deltailInfo.Name = "panel_deltailInfo";
            this.panel_deltailInfo.Size = new System.Drawing.Size(800, 281);
            this.panel_deltailInfo.TabIndex = 18;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(73, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(132, 33);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "清除";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(223, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 33);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "增加";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(375, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(132, 33);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "更新";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(526, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 33);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // DictionaryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_deltailInfo);
            this.Controls.Add(this.panel_option);
            this.Controls.Add(this.dataGV_DictionaryShow);
            this.Name = "DictionaryEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DictionaryEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DictionaryEditForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DictionaryShow)).EndInit();
            this.panel_option.ResumeLayout(false);
            this.panel_deltailInfo.ResumeLayout(false);
            this.panel_deltailInfo.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel_option;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel_deltailInfo;
    }
}