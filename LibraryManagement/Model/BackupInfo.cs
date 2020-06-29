using System;

namespace LibraryManagement.Model
{
    public class BackupInfo
    {
        public int Id;
        public DateTime BackupTime;
        public string BackupPath;
        public string MysqldumpPath;
        public static bool isNull(BackupInfo backupInfo)
        {

            if (backupInfo.BackupTime == null)
            {
                return true;
            }
            if (backupInfo.BackupPath == "")
            {
                return true;
            }
            if (backupInfo.MysqldumpPath == "")
            {
                return true;
            }
            return false;
        }
    }
}
