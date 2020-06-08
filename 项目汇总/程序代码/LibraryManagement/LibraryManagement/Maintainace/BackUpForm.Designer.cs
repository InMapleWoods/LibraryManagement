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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_selectpath = new System.Windows.Forms.Button();
            this.label_FileName = new System.Windows.Forms.Label();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.btn_Backupcommit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_FilePath
            // 
            this.label_FilePath.AutoSize = true;
            this.label_FilePath.Location = new System.Drawing.Point(61, 75);
            this.label_FilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FilePath.Name = "label_FilePath";
            this.label_FilePath.Size = new System.Drawing.Size(142, 15);
            this.label_FilePath.TabIndex = 0;
            this.label_FilePath.Text = "请输入备份文件路径";
            this.label_FilePath.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 1;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btn_selectpath
            // 
            this.btn_selectpath.Location = new System.Drawing.Point(361, 71);
            this.btn_selectpath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_selectpath.Name = "btn_selectpath";
            this.btn_selectpath.Size = new System.Drawing.Size(48, 26);
            this.btn_selectpath.TabIndex = 2;
            this.btn_selectpath.Text = "...";
            this.btn_selectpath.UseVisualStyleBackColor = true;
            // 
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Location = new System.Drawing.Point(93, 131);
            this.label_FileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(112, 15);
            this.label_FileName.TabIndex = 3;
            this.label_FileName.Text = "请输入文件名称";
            this.label_FileName.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(220, 128);
            this.textBox_FileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(132, 25);
            this.textBox_FileName.TabIndex = 4;
            // 
            // btn_Backupcommit
            // 
            this.btn_Backupcommit.Location = new System.Drawing.Point(220, 208);
            this.btn_Backupcommit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Backupcommit.Name = "btn_Backupcommit";
            this.btn_Backupcommit.Size = new System.Drawing.Size(100, 29);
            this.btn_Backupcommit.TabIndex = 5;
            this.btn_Backupcommit.Text = "备份";
            this.btn_Backupcommit.UseVisualStyleBackColor = true;
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 295);
            this.Controls.Add(this.btn_Backupcommit);
            this.Controls.Add(this.textBox_FileName);
            this.Controls.Add(this.label_FileName);
            this.Controls.Add(this.btn_selectpath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_FilePath);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BackUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "备份/恢复";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FilePath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_selectpath;
        private System.Windows.Forms.Label label_FileName;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.Button btn_Backupcommit;
    }
}