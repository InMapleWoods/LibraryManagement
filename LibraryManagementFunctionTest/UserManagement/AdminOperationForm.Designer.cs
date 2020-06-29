namespace LibraryManagementFunctionTest.UserManagement
{
    partial class AdminOperationForm
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
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_DormitoryNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_BuildingNo = new System.Windows.Forms.ComboBox();
            this.dtp_Birthday = new System.Windows.Forms.DateTimePicker();
            this.cbb_Department = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_Contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_Gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_UserNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_LibraryCardNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_chooseType = new System.Windows.Forms.ComboBox();
            this.btn_reflashCase = new System.Windows.Forms.Button();
            this.btn_removeCase = new System.Windows.Forms.Button();
            this.btn_addCase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 394);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 293);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(175, 269);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(220, 25);
            this.txb_UserName.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 60;
            this.label9.Text = "姓   名";
            // 
            // txb_DormitoryNo
            // 
            this.txb_DormitoryNo.Location = new System.Drawing.Point(645, 221);
            this.txb_DormitoryNo.Name = "txb_DormitoryNo";
            this.txb_DormitoryNo.Size = new System.Drawing.Size(127, 25);
            this.txb_DormitoryNo.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "#";
            // 
            // cbb_BuildingNo
            // 
            this.cbb_BuildingNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_BuildingNo.FormattingEnabled = true;
            this.cbb_BuildingNo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbb_BuildingNo.Location = new System.Drawing.Point(554, 221);
            this.cbb_BuildingNo.Name = "cbb_BuildingNo";
            this.cbb_BuildingNo.Size = new System.Drawing.Size(66, 23);
            this.cbb_BuildingNo.TabIndex = 57;
            // 
            // dtp_Birthday
            // 
            this.dtp_Birthday.Location = new System.Drawing.Point(552, 176);
            this.dtp_Birthday.Name = "dtp_Birthday";
            this.dtp_Birthday.Size = new System.Drawing.Size(220, 25);
            this.dtp_Birthday.TabIndex = 56;
            // 
            // cbb_Department
            // 
            this.cbb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Department.FormattingEnabled = true;
            this.cbb_Department.Items.AddRange(new object[] {
            "计算机系"});
            this.cbb_Department.Location = new System.Drawing.Point(554, 313);
            this.cbb_Department.Name = "cbb_Department";
            this.cbb_Department.Size = new System.Drawing.Size(218, 23);
            this.cbb_Department.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "所在院系";
            // 
            // txb_Contact
            // 
            this.txb_Contact.Location = new System.Drawing.Point(554, 268);
            this.txb_Contact.Name = "txb_Contact";
            this.txb_Contact.Size = new System.Drawing.Size(218, 25);
            this.txb_Contact.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "联系电话";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "地   址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "出生日期";
            // 
            // cbb_Gender
            // 
            this.cbb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Gender.FormattingEnabled = true;
            this.cbb_Gender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbb_Gender.Location = new System.Drawing.Point(175, 313);
            this.cbb_Gender.Name = "cbb_Gender";
            this.cbb_Gender.Size = new System.Drawing.Size(220, 23);
            this.cbb_Gender.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "性   别";
            // 
            // txb_UserNumber
            // 
            this.txb_UserNumber.Location = new System.Drawing.Point(175, 221);
            this.txb_UserNumber.Name = "txb_UserNumber";
            this.txb_UserNumber.Size = new System.Drawing.Size(220, 25);
            this.txb_UserNumber.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "读者编号";
            // 
            // txb_LibraryCardNum
            // 
            this.txb_LibraryCardNum.Location = new System.Drawing.Point(175, 176);
            this.txb_LibraryCardNum.Name = "txb_LibraryCardNum";
            this.txb_LibraryCardNum.Size = new System.Drawing.Size(220, 25);
            this.txb_LibraryCardNum.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "借书证号";
            // 
            // comboBox_chooseType
            // 
            this.comboBox_chooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chooseType.FormattingEnabled = true;
            this.comboBox_chooseType.Items.AddRange(new object[] {
            "增加",
            "修改"});
            this.comboBox_chooseType.Location = new System.Drawing.Point(641, 77);
            this.comboBox_chooseType.Name = "comboBox_chooseType";
            this.comboBox_chooseType.Size = new System.Drawing.Size(121, 23);
            this.comboBox_chooseType.TabIndex = 66;
            this.comboBox_chooseType.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseType_SelectedIndexChanged);
            // 
            // btn_reflashCase
            // 
            this.btn_reflashCase.Location = new System.Drawing.Point(434, 62);
            this.btn_reflashCase.Name = "btn_reflashCase";
            this.btn_reflashCase.Size = new System.Drawing.Size(129, 51);
            this.btn_reflashCase.TabIndex = 65;
            this.btn_reflashCase.Text = "刷新用例";
            this.btn_reflashCase.UseVisualStyleBackColor = true;
            this.btn_reflashCase.Click += new System.EventHandler(this.btn_reflashCase_Click);
            // 
            // btn_removeCase
            // 
            this.btn_removeCase.Location = new System.Drawing.Point(243, 62);
            this.btn_removeCase.Name = "btn_removeCase";
            this.btn_removeCase.Size = new System.Drawing.Size(129, 51);
            this.btn_removeCase.TabIndex = 64;
            this.btn_removeCase.Text = "删除用例";
            this.btn_removeCase.UseVisualStyleBackColor = true;
            this.btn_removeCase.Click += new System.EventHandler(this.btn_removeCase_Click);
            // 
            // btn_addCase
            // 
            this.btn_addCase.Location = new System.Drawing.Point(59, 62);
            this.btn_addCase.Name = "btn_addCase";
            this.btn_addCase.Size = new System.Drawing.Size(129, 51);
            this.btn_addCase.TabIndex = 63;
            this.btn_addCase.Text = "增加用例";
            this.btn_addCase.UseVisualStyleBackColor = true;
            this.btn_addCase.Click += new System.EventHandler(this.btn_addCase_Click);
            // 
            // AdminOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.comboBox_chooseType);
            this.Controls.Add(this.btn_reflashCase);
            this.Controls.Add(this.btn_removeCase);
            this.Controls.Add(this.btn_addCase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_DormitoryNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_BuildingNo);
            this.Controls.Add(this.dtp_Birthday);
            this.Controls.Add(this.cbb_Department);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_Contact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_Gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_UserNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_LibraryCardNum);
            this.Controls.Add(this.label1);
            this.Name = "AdminOperationForm";
            this.Text = "AdminOperationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminOperationForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminOperationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_DormitoryNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_BuildingNo;
        private System.Windows.Forms.DateTimePicker dtp_Birthday;
        private System.Windows.Forms.ComboBox cbb_Department;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_Contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_Gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_UserNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_LibraryCardNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_chooseType;
        private System.Windows.Forms.Button btn_reflashCase;
        private System.Windows.Forms.Button btn_removeCase;
        private System.Windows.Forms.Button btn_addCase;
    }
}