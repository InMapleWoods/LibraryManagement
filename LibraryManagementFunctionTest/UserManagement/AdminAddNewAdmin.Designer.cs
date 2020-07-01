namespace LibraryManagementFunctionTest.UserManagement
{
    partial class AdminAddNewAdmin
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
            this.txb_adminRole = new System.Windows.Forms.TextBox();
            this.txb_adminDepartment = new System.Windows.Forms.TextBox();
            this.txb_userName = new System.Windows.Forms.TextBox();
            this.txb_userNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_reflashCase = new System.Windows.Forms.Button();
            this.btn_removeCase = new System.Windows.Forms.Button();
            this.btn_addCase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_adminRole
            // 
            this.txb_adminRole.Location = new System.Drawing.Point(507, 230);
            this.txb_adminRole.Name = "txb_adminRole";
            this.txb_adminRole.Size = new System.Drawing.Size(152, 25);
            this.txb_adminRole.TabIndex = 18;
            // 
            // txb_adminDepartment
            // 
            this.txb_adminDepartment.Location = new System.Drawing.Point(206, 230);
            this.txb_adminDepartment.Name = "txb_adminDepartment";
            this.txb_adminDepartment.Size = new System.Drawing.Size(140, 25);
            this.txb_adminDepartment.TabIndex = 17;
            // 
            // txb_userName
            // 
            this.txb_userName.Location = new System.Drawing.Point(507, 157);
            this.txb_userName.Name = "txb_userName";
            this.txb_userName.Size = new System.Drawing.Size(152, 25);
            this.txb_userName.TabIndex = 16;
            // 
            // txb_userNumber
            // 
            this.txb_userNumber.Location = new System.Drawing.Point(206, 156);
            this.txb_userNumber.Name = "txb_userNumber";
            this.txb_userNumber.Size = new System.Drawing.Size(140, 25);
            this.txb_userNumber.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "管理员角色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "管理员科室";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "读者编号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 297);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_reflashCase
            // 
            this.btn_reflashCase.Location = new System.Drawing.Point(580, 44);
            this.btn_reflashCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reflashCase.Name = "btn_reflashCase";
            this.btn_reflashCase.Size = new System.Drawing.Size(160, 51);
            this.btn_reflashCase.TabIndex = 21;
            this.btn_reflashCase.Text = "刷新用例";
            this.btn_reflashCase.UseVisualStyleBackColor = true;
            this.btn_reflashCase.Click += new System.EventHandler(this.btn_reflashCase_Click);
            // 
            // btn_removeCase
            // 
            this.btn_removeCase.Location = new System.Drawing.Point(312, 44);
            this.btn_removeCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_removeCase.Name = "btn_removeCase";
            this.btn_removeCase.Size = new System.Drawing.Size(161, 51);
            this.btn_removeCase.TabIndex = 20;
            this.btn_removeCase.Text = "删除用例";
            this.btn_removeCase.UseVisualStyleBackColor = true;
            this.btn_removeCase.Click += new System.EventHandler(this.btn_removeCase_Click);
            // 
            // btn_addCase
            // 
            this.btn_addCase.Location = new System.Drawing.Point(53, 44);
            this.btn_addCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addCase.Name = "btn_addCase";
            this.btn_addCase.Size = new System.Drawing.Size(169, 51);
            this.btn_addCase.TabIndex = 19;
            this.btn_addCase.Text = "增加用例";
            this.btn_addCase.UseVisualStyleBackColor = true;
            this.btn_addCase.Click += new System.EventHandler(this.btn_addCase_Click);
            // 
            // AdminAddNewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.btn_reflashCase);
            this.Controls.Add(this.btn_removeCase);
            this.Controls.Add(this.btn_addCase);
            this.Controls.Add(this.txb_adminRole);
            this.Controls.Add(this.txb_adminDepartment);
            this.Controls.Add(this.txb_userName);
            this.Controls.Add(this.txb_userNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminAddNewAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAddNewAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminAddNewAdmin_FormClosing);
            this.Load += new System.EventHandler(this.AdminAddNewAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_adminRole;
        private System.Windows.Forms.TextBox txb_adminDepartment;
        private System.Windows.Forms.TextBox txb_userName;
        private System.Windows.Forms.TextBox txb_userNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_reflashCase;
        private System.Windows.Forms.Button btn_removeCase;
        private System.Windows.Forms.Button btn_addCase;
    }
}