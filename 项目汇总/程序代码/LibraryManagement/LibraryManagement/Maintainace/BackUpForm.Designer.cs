namespace LibraryManagement.Maintainace
{
    partial class BackUpForm
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
            this.label_FilePath = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_selectpath = new System.Windows.Forms.Button();
            this.label_MysqlDumPath = new System.Windows.Forms.Label();
            this.textBox_MysqlDumpPath = new System.Windows.Forms.TextBox();
            this.btn_Backupcommit = new System.Windows.Forms.Button();
            this.checkBox_ClosingProgramBackupCheck = new System.Windows.Forms.CheckBox();
            this.btn_Recovery = new System.Windows.Forms.Button();
            this.btn_selectDumpPath = new System.Windows.Forms.Button();
            this.label_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_FilePath
            // 
            this.label_FilePath.AutoSize = true;
            this.label_FilePath.Location = new System.Drawing.Point(46, 60);
            this.label_FilePath.Name = "label_FilePath";
            this.label_FilePath.Size = new System.Drawing.Size(113, 12);
            this.label_FilePath.TabIndex = 0;
            this.label_FilePath.Text = "请输入备份文件路径";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(165, 57);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(100, 21);
            this.textBox_Path.TabIndex = 1;
            this.textBox_Path.Text = "D:\\DbLibraryManagementBackup";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btn_selectpath
            // 
            this.btn_selectpath.Location = new System.Drawing.Point(271, 57);
            this.btn_selectpath.Name = "btn_selectpath";
            this.btn_selectpath.Size = new System.Drawing.Size(36, 21);
            this.btn_selectpath.TabIndex = 2;
            this.btn_selectpath.Text = "...";
            this.btn_selectpath.UseVisualStyleBackColor = true;
            this.btn_selectpath.Click += new System.EventHandler(this.btn_selectpath_Click);
            // 
            // label_MysqlDumPath
            // 
            this.label_MysqlDumPath.AutoSize = true;
            this.label_MysqlDumPath.Location = new System.Drawing.Point(46, 105);
            this.label_MysqlDumPath.Name = "label_MysqlDumPath";
            this.label_MysqlDumPath.Size = new System.Drawing.Size(119, 12);
            this.label_MysqlDumPath.TabIndex = 3;
            this.label_MysqlDumPath.Text = "请输入Mysqldump路径";
            // 
            // textBox_MysqlDumpPath
            // 
            this.textBox_MysqlDumpPath.Location = new System.Drawing.Point(165, 102);
            this.textBox_MysqlDumpPath.Name = "textBox_MysqlDumpPath";
            this.textBox_MysqlDumpPath.Size = new System.Drawing.Size(100, 21);
            this.textBox_MysqlDumpPath.TabIndex = 4;
            // 
            // btn_Backupcommit
            // 
            this.btn_Backupcommit.Location = new System.Drawing.Point(72, 166);
            this.btn_Backupcommit.Name = "btn_Backupcommit";
            this.btn_Backupcommit.Size = new System.Drawing.Size(75, 23);
            this.btn_Backupcommit.TabIndex = 5;
            this.btn_Backupcommit.Text = "备份";
            this.btn_Backupcommit.UseVisualStyleBackColor = true;
            this.btn_Backupcommit.Click += new System.EventHandler(this.btn_Backupcommit_Click);
            // 
            // checkBox_ClosingProgramBackupCheck
            // 
            this.checkBox_ClosingProgramBackupCheck.AutoSize = true;
            this.checkBox_ClosingProgramBackupCheck.Location = new System.Drawing.Point(112, 144);
            this.checkBox_ClosingProgramBackupCheck.Name = "checkBox_ClosingProgramBackupCheck";
            this.checkBox_ClosingProgramBackupCheck.Size = new System.Drawing.Size(168, 16);
            this.checkBox_ClosingProgramBackupCheck.TabIndex = 6;
            this.checkBox_ClosingProgramBackupCheck.Text = "每次关闭软件时自动备份？";
            this.checkBox_ClosingProgramBackupCheck.UseVisualStyleBackColor = true;
            // 
            // btn_Recovery
            // 
            this.btn_Recovery.Location = new System.Drawing.Point(208, 165);
            this.btn_Recovery.Name = "btn_Recovery";
            this.btn_Recovery.Size = new System.Drawing.Size(75, 23);
            this.btn_Recovery.TabIndex = 7;
            this.btn_Recovery.Text = "恢复";
            this.btn_Recovery.UseVisualStyleBackColor = true;
            this.btn_Recovery.Click += new System.EventHandler(this.btn_Recovery_Click);
            // 
            // btn_selectDumpPath
            // 
            this.btn_selectDumpPath.Location = new System.Drawing.Point(271, 101);
            this.btn_selectDumpPath.Name = "btn_selectDumpPath";
            this.btn_selectDumpPath.Size = new System.Drawing.Size(36, 21);
            this.btn_selectDumpPath.TabIndex = 8;
            this.btn_selectDumpPath.Text = "...";
            this.btn_selectDumpPath.UseVisualStyleBackColor = true;
            this.btn_selectDumpPath.Click += new System.EventHandler(this.btn_selectDumpPath_Click);
            // 
            // label_msg
            // 
            this.label_msg.AutoSize = true;
            this.label_msg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_msg.Location = new System.Drawing.Point(12, 105);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(29, 12);
            this.label_msg.TabIndex = 9;
            this.label_msg.Text = "必选";
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 236);
            this.Controls.Add(this.label_msg);
            this.Controls.Add(this.btn_selectDumpPath);
            this.Controls.Add(this.btn_Recovery);
            this.Controls.Add(this.checkBox_ClosingProgramBackupCheck);
            this.Controls.Add(this.btn_Backupcommit);
            this.Controls.Add(this.textBox_MysqlDumpPath);
            this.Controls.Add(this.label_MysqlDumPath);
            this.Controls.Add(this.btn_selectpath);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.label_FilePath);
            this.Name = "BackUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "备份/恢复";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackUpForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FilePath;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_selectpath;
        private System.Windows.Forms.Label label_MysqlDumPath;
        private System.Windows.Forms.TextBox textBox_MysqlDumpPath;
        private System.Windows.Forms.Button btn_Backupcommit;
        private System.Windows.Forms.CheckBox checkBox_ClosingProgramBackupCheck;
        private System.Windows.Forms.Button btn_Recovery;
        private System.Windows.Forms.Button btn_selectDumpPath;
        private System.Windows.Forms.Label label_msg;
    }
}