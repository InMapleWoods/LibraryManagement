namespace LibraryManagement.UserManagement
{
    partial class AddReaderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_LibraryCardNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_UserNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_Gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_Contact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_Department = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_Birthday = new System.Windows.Forms.DateTimePicker();
            this.cbb_BuildingNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_DormitoryNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "借书证号";
            // 
            // txb_LibraryCardNum
            // 
            this.txb_LibraryCardNum.Location = new System.Drawing.Point(185, 34);
            this.txb_LibraryCardNum.Name = "txb_LibraryCardNum";
            this.txb_LibraryCardNum.Size = new System.Drawing.Size(243, 25);
            this.txb_LibraryCardNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "读者编号";
            // 
            // txb_UserNumber
            // 
            this.txb_UserNumber.Location = new System.Drawing.Point(185, 77);
            this.txb_UserNumber.Name = "txb_UserNumber";
            this.txb_UserNumber.Size = new System.Drawing.Size(243, 25);
            this.txb_UserNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "性   别";
            // 
            // cbb_Gender
            // 
            this.cbb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Gender.FormattingEnabled = true;
            this.cbb_Gender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbb_Gender.Location = new System.Drawing.Point(185, 157);
            this.cbb_Gender.Name = "cbb_Gender";
            this.cbb_Gender.Size = new System.Drawing.Size(91, 23);
            this.cbb_Gender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "出生日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "地   址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "联系电话";
            // 
            // txb_Contact
            // 
            this.txb_Contact.Location = new System.Drawing.Point(185, 306);
            this.txb_Contact.Name = "txb_Contact";
            this.txb_Contact.Size = new System.Drawing.Size(243, 25);
            this.txb_Contact.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "院   系";
            // 
            // cbb_Department
            // 
            this.cbb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Department.FormattingEnabled = true;
            this.cbb_Department.Location = new System.Drawing.Point(185, 351);
            this.cbb_Department.Name = "cbb_Department";
            this.cbb_Department.Size = new System.Drawing.Size(121, 23);
            this.cbb_Department.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_Birthday
            // 
            this.dtp_Birthday.Location = new System.Drawing.Point(185, 197);
            this.dtp_Birthday.Name = "dtp_Birthday";
            this.dtp_Birthday.Size = new System.Drawing.Size(200, 25);
            this.dtp_Birthday.TabIndex = 18;
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
            this.cbb_BuildingNo.Location = new System.Drawing.Point(185, 256);
            this.cbb_BuildingNo.Name = "cbb_BuildingNo";
            this.cbb_BuildingNo.Size = new System.Drawing.Size(91, 23);
            this.cbb_BuildingNo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "#";
            // 
            // txb_DormitoryNo
            // 
            this.txb_DormitoryNo.Location = new System.Drawing.Point(299, 256);
            this.txb_DormitoryNo.Name = "txb_DormitoryNo";
            this.txb_DormitoryNo.Size = new System.Drawing.Size(129, 25);
            this.txb_DormitoryNo.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "姓   名";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(185, 120);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(243, 25);
            this.txb_UserName.TabIndex = 24;
            // 
            // AddReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_DormitoryNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_BuildingNo);
            this.Controls.Add(this.dtp_Birthday);
            this.Controls.Add(this.button1);
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
            this.Name = "AddReaderForm";
            this.Text = "AddReaderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddReaderForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_LibraryCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_UserNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_Contact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_Department;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_Birthday;
        private System.Windows.Forms.ComboBox cbb_BuildingNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_DormitoryNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_UserName;
    }
}