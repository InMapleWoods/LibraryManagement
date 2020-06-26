using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagement.Maintainace
{
    public partial class BackUpForm : Form
    {
        Form parentForm;
        MaintainaceBll maintainaceBll = new MaintainaceBll();
        public BackUpForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btn_selectpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                textBox_Path.Text = dilog.SelectedPath;
            }
        }
        private void btn_selectDumpPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择Mysqldump路径";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                textBox_MysqlDumpPath.Text = dilog.SelectedPath;
            }
        }
        private void BackUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void btn_Backupcommit_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();
                BackupInfo backupInfo = getBackupInfo(ref errorList);
                if (maintainaceBll.BackupDb(backupInfo))
                {

                    MessageBox.Show("备份成功", "提示");
                }
                else
                {
                    MessageBox.Show("备份失败", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private BackupInfo getBackupInfo(ref List<string> error)
        {
            List<string> errorList = new List<string>();
            BackupInfo backupInfo = new BackupInfo()
            {
                BackupTime = DateTime.Now,
                BackupPath = textBox_Path.Text.ToString(),
                MysqldumpPath = textBox_MysqlDumpPath.Text.ToString(),
            };
            error = errorList;
            return backupInfo;
        }

        private void btn_Recovery_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //调用mysqldump备份mysql数据库的语句
                string backupsql = string.Format("mysql --host={0} --default-character-set=gbk  --port={1} --user={2} --password={3} ", "152.136.73.240", "1733", "Lsa", "llfllf");
                //mysql的路径
                string mysqldump = textBox_MysqlDumpPath.Text.ToString();
                //需要备份的数据库名称
                string strDB = "db_LibraryManagement";

                string filePath = ofd.FileName;
                MessageBox.Show(filePath, "当前选择的路径");

                string cmd = backupsql + strDB + " < \"" + filePath + "\"";
                RunCmd r = new RunCmd();
                string result = r.runCmd(mysqldump, cmd);

                MessageBox.Show("数据库恢复成功!", "MySQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
