namespace LibraryManagementFunctionTest.UserManagement
{
    partial class UserManagementForm
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
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Login = new System.Windows.Forms.TextBox();
            this.btn_reflashCase = new System.Windows.Forms.Button();
            this.btn_removeCase = new System.Windows.Forms.Button();
            this.btn_addCase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(225, 221);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(215, 25);
            this.txb_Password.TabIndex = 6;
            this.txb_Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "登陆密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "登陆账号";
            // 
            // txb_Login
            // 
            this.txb_Login.Location = new System.Drawing.Point(225, 154);
            this.txb_Login.Name = "txb_Login";
            this.txb_Login.Size = new System.Drawing.Size(215, 25);
            this.txb_Login.TabIndex = 5;
            // 
            // btn_reflashCase
            // 
            this.btn_reflashCase.Location = new System.Drawing.Point(396, 34);
            this.btn_reflashCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reflashCase.Name = "btn_reflashCase";
            this.btn_reflashCase.Size = new System.Drawing.Size(88, 51);
            this.btn_reflashCase.TabIndex = 12;
            this.btn_reflashCase.Text = "刷新用例";
            this.btn_reflashCase.UseVisualStyleBackColor = true;
            this.btn_reflashCase.Click += new System.EventHandler(this.btn_reflashCase_Click);
            // 
            // btn_removeCase
            // 
            this.btn_removeCase.Location = new System.Drawing.Point(232, 34);
            this.btn_removeCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_removeCase.Name = "btn_removeCase";
            this.btn_removeCase.Size = new System.Drawing.Size(89, 51);
            this.btn_removeCase.TabIndex = 11;
            this.btn_removeCase.Text = "删除用例";
            this.btn_removeCase.UseVisualStyleBackColor = true;
            this.btn_removeCase.Click += new System.EventHandler(this.btn_removeCase_Click);
            // 
            // btn_addCase
            // 
            this.btn_addCase.Location = new System.Drawing.Point(69, 34);
            this.btn_addCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addCase.Name = "btn_addCase";
            this.btn_addCase.Size = new System.Drawing.Size(97, 51);
            this.btn_addCase.TabIndex = 10;
            this.btn_addCase.Text = "增加用例";
            this.btn_addCase.UseVisualStyleBackColor = true;
            this.btn_addCase.Click += new System.EventHandler(this.btn_addCase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(567, 297);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_reflashCase);
            this.Controls.Add(this.btn_removeCase);
            this.Controls.Add(this.btn_addCase);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Login);
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Login;
        private System.Windows.Forms.Button btn_reflashCase;
        private System.Windows.Forms.Button btn_removeCase;
        private System.Windows.Forms.Button btn_addCase;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}