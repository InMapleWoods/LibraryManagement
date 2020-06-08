namespace LibraryManagement.Maintainace
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
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
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
            this.comboBox_Dictionary.Location = new System.Drawing.Point(667, 88);
            this.comboBox_Dictionary.Name = "comboBox_Dictionary";
            this.comboBox_Dictionary.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Dictionary.TabIndex = 0;
            this.comboBox_Dictionary.SelectedIndexChanged += new System.EventHandler(this.comboBox_Dictionary_SelectedIndexChanged);
            // 
            // dataGV_DictionaryShow
            // 
            this.dataGV_DictionaryShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DictionaryShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGV_DictionaryShow.Location = new System.Drawing.Point(0, 319);
            this.dataGV_DictionaryShow.MultiSelect = false;
            this.dataGV_DictionaryShow.Name = "dataGV_DictionaryShow";
            this.dataGV_DictionaryShow.ReadOnly = true;
            this.dataGV_DictionaryShow.RowHeadersWidth = 51;
            this.dataGV_DictionaryShow.RowTemplate.Height = 23;
            this.dataGV_DictionaryShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_DictionaryShow.Size = new System.Drawing.Size(800, 131);
            this.dataGV_DictionaryShow.TabIndex = 1;
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
            this.lab_Location.Click += new System.EventHandler(this.lab_Location_Click);
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
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(800, 83);
            this.scriptUserControl1.TabIndex = 2;
            // 
            // DictionaryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.scriptUserControl1);
            this.Controls.Add(this.lab_CorPL);
            this.Controls.Add(this.dataGV_DictionaryShow);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.comboBox_Dictionary);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.lab_Location);
            this.Name = "DictionaryEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DictionaryEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DictionaryEditForm_FormClosing);
            this.Load += new System.EventHandler(this.DictionaryEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DictionaryShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Dictionary;
        private System.Windows.Forms.DataGridView dataGV_DictionaryShow;
        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
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
    }
}