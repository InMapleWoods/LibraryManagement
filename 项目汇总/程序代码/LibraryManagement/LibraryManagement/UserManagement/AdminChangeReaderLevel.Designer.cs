namespace LibraryManagement.UserManagement
{
    partial class AdminChangeReaderLevel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_userName = new System.Windows.Forms.TextBox();
            this.txb_borrowBookNum = new System.Windows.Forms.TextBox();
            this.txb_forfeitMul = new System.Windows.Forms.TextBox();
            this.txb_reserveBookNum = new System.Windows.Forms.TextBox();
            this.txb_renewNum = new System.Windows.Forms.TextBox();
            this.txb_renewDays = new System.Windows.Forms.TextBox();
            this.txb_borrowDays = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_userNum = new System.Windows.Forms.TextBox();
            this.txb_contact = new System.Windows.Forms.TextBox();
            this.cbb_readerLevel = new System.Windows.Forms.ComboBox();
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(878, 335);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "读者姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "可借阅图书数目";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "可借天数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "赔款倍数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "读者级别";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "可续借天数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "续借册数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "可预约图书数目";
            // 
            // txb_userName
            // 
            this.txb_userName.Location = new System.Drawing.Point(200, 111);
            this.txb_userName.Name = "txb_userName";
            this.txb_userName.Size = new System.Drawing.Size(175, 25);
            this.txb_userName.TabIndex = 12;
            // 
            // txb_borrowBookNum
            // 
            this.txb_borrowBookNum.Location = new System.Drawing.Point(200, 212);
            this.txb_borrowBookNum.Name = "txb_borrowBookNum";
            this.txb_borrowBookNum.ReadOnly = true;
            this.txb_borrowBookNum.Size = new System.Drawing.Size(175, 25);
            this.txb_borrowBookNum.TabIndex = 13;
            // 
            // txb_forfeitMul
            // 
            this.txb_forfeitMul.Location = new System.Drawing.Point(200, 316);
            this.txb_forfeitMul.Name = "txb_forfeitMul";
            this.txb_forfeitMul.ReadOnly = true;
            this.txb_forfeitMul.Size = new System.Drawing.Size(175, 25);
            this.txb_forfeitMul.TabIndex = 15;
            // 
            // txb_reserveBookNum
            // 
            this.txb_reserveBookNum.Location = new System.Drawing.Point(587, 212);
            this.txb_reserveBookNum.Name = "txb_reserveBookNum";
            this.txb_reserveBookNum.ReadOnly = true;
            this.txb_reserveBookNum.Size = new System.Drawing.Size(186, 25);
            this.txb_reserveBookNum.TabIndex = 17;
            // 
            // txb_renewNum
            // 
            this.txb_renewNum.Location = new System.Drawing.Point(587, 316);
            this.txb_renewNum.Name = "txb_renewNum";
            this.txb_renewNum.ReadOnly = true;
            this.txb_renewNum.Size = new System.Drawing.Size(186, 25);
            this.txb_renewNum.TabIndex = 19;
            // 
            // txb_renewDays
            // 
            this.txb_renewDays.Location = new System.Drawing.Point(587, 264);
            this.txb_renewDays.Name = "txb_renewDays";
            this.txb_renewDays.ReadOnly = true;
            this.txb_renewDays.Size = new System.Drawing.Size(186, 25);
            this.txb_renewDays.TabIndex = 20;
            // 
            // txb_borrowDays
            // 
            this.txb_borrowDays.Location = new System.Drawing.Point(200, 264);
            this.txb_borrowDays.Name = "txb_borrowDays";
            this.txb_borrowDays.ReadOnly = true;
            this.txb_borrowDays.Size = new System.Drawing.Size(175, 25);
            this.txb_borrowDays.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "读者编号";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "联系电话";
            // 
            // txb_userNum
            // 
            this.txb_userNum.Location = new System.Drawing.Point(200, 160);
            this.txb_userNum.Name = "txb_userNum";
            this.txb_userNum.Size = new System.Drawing.Size(175, 25);
            this.txb_userNum.TabIndex = 24;
            // 
            // txb_contact
            // 
            this.txb_contact.Location = new System.Drawing.Point(587, 160);
            this.txb_contact.Name = "txb_contact";
            this.txb_contact.ReadOnly = true;
            this.txb_contact.Size = new System.Drawing.Size(186, 25);
            this.txb_contact.TabIndex = 25;
            // 
            // cbb_readerLevel
            // 
            this.cbb_readerLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_readerLevel.FormattingEnabled = true;
            this.cbb_readerLevel.Location = new System.Drawing.Point(587, 111);
            this.cbb_readerLevel.Name = "cbb_readerLevel";
            this.cbb_readerLevel.Size = new System.Drawing.Size(186, 23);
            this.cbb_readerLevel.TabIndex = 26;
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(878, 83);
            this.scriptUserControl1.TabIndex = 2;
            // 
            // AdminChangeReaderLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 719);
            this.Controls.Add(this.cbb_readerLevel);
            this.Controls.Add(this.txb_contact);
            this.Controls.Add(this.txb_userNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_borrowDays);
            this.Controls.Add(this.txb_renewDays);
            this.Controls.Add(this.txb_renewNum);
            this.Controls.Add(this.txb_reserveBookNum);
            this.Controls.Add(this.txb_forfeitMul);
            this.Controls.Add(this.txb_borrowBookNum);
            this.Controls.Add(this.txb_userName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scriptUserControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminChangeReaderLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminChangeReaderLevel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminChangeReaderLevel_FormClosing);
            this.Load += new System.EventHandler(this.AdminChangeReaderLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_userName;
        private System.Windows.Forms.TextBox txb_borrowBookNum;
        private System.Windows.Forms.TextBox txb_forfeitMul;
        private System.Windows.Forms.TextBox txb_reserveBookNum;
        private System.Windows.Forms.TextBox txb_renewNum;
        private System.Windows.Forms.TextBox txb_renewDays;
        private System.Windows.Forms.TextBox txb_borrowDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_userNum;
        private System.Windows.Forms.TextBox txb_contact;
        private System.Windows.Forms.ComboBox cbb_readerLevel;
    }
}