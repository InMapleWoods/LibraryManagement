namespace LibraryManagement.UserManagement
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
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_userNumber = new System.Windows.Forms.TextBox();
            this.txb_userName = new System.Windows.Forms.TextBox();
            this.txb_adminDepartment = new System.Windows.Forms.TextBox();
            this.txb_adminRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(800, 94);
            this.scriptUserControl1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 297);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "读者编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "管理员科室";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "管理员角色";
            // 
            // txb_userNumber
            // 
            this.txb_userNumber.Location = new System.Drawing.Point(197, 145);
            this.txb_userNumber.Name = "txb_userNumber";
            this.txb_userNumber.Size = new System.Drawing.Size(140, 25);
            this.txb_userNumber.TabIndex = 6;
            // 
            // txb_userName
            // 
            this.txb_userName.Location = new System.Drawing.Point(498, 146);
            this.txb_userName.Name = "txb_userName";
            this.txb_userName.ReadOnly = true;
            this.txb_userName.Size = new System.Drawing.Size(152, 25);
            this.txb_userName.TabIndex = 7;
            // 
            // txb_adminDepartment
            // 
            this.txb_adminDepartment.Location = new System.Drawing.Point(197, 219);
            this.txb_adminDepartment.Name = "txb_adminDepartment";
            this.txb_adminDepartment.Size = new System.Drawing.Size(140, 25);
            this.txb_adminDepartment.TabIndex = 8;
            // 
            // txb_adminRole
            // 
            this.txb_adminRole.Location = new System.Drawing.Point(498, 219);
            this.txb_adminRole.Name = "txb_adminRole";
            this.txb_adminRole.Size = new System.Drawing.Size(152, 25);
            this.txb_adminRole.TabIndex = 9;
            // 
            // AdminAddNewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.txb_adminRole);
            this.Controls.Add(this.txb_adminDepartment);
            this.Controls.Add(this.txb_userName);
            this.Controls.Add(this.txb_userNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.scriptUserControl1);
            this.Name = "AdminAddNewAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加管理员";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminAddNewAdmin_FormClosing);
            this.Load += new System.EventHandler(this.AdminAddNewAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_userNumber;
        private System.Windows.Forms.TextBox txb_userName;
        private System.Windows.Forms.TextBox txb_adminDepartment;
        private System.Windows.Forms.TextBox txb_adminRole;
    }
}