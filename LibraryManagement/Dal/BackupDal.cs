using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Dal
{
    class BackupDal
    {
       //调用mysqldump备份mysql数据库的语句
        public string backupsql = string.Format("mysqldump --host={0} --default-character-set=utf8 --lock-tables  --routines --force --port=3306 --user={1} --password={2} --quick  ", "MySQL数据库服务器", "数据库的账号", "数据库密码");
        //mysqldump的路径
        string mysqldump = "C:\\Program Files\\MySQL\\MySQL Server 5.6\\bin";
        //需要备份的数据库名称
        string strDB = "db_LibraryManagement";
        public bool BackupDataBase(BackupInfo backupInfo)
        {
            
            //备份数据库的路径
            string strDBpath = @backupInfo.BackupPath;

            //判断备份的数据库路径是否存在
            if (!Directory.Exists(strDBpath))
            {
                Directory.CreateDirectory(strDBpath);
            }

            //备份数据库
            if (!string.IsNullOrEmpty(strDB))
            {
                string filePath = strDBpath +backupInfo.BackupTime.ToString("yyyyMMdd_HHmmss") + strDB + ".sql";
                string cmd = backupsql + strDB + " >" + filePath;
                string result = RunCmd(mysqldump, cmd);

                return true;

            }
            return false;
        }
        private string RunCmd(string mysqldumPath, string strCmd)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = mysqldumPath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(strCmd);
            p.StandardInput.WriteLine("exit");
            return p.StandardError.ReadToEnd();
        }
    }
}
