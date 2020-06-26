﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    class BackupInfo
    {
       public int Id;
       public DateTime BackupTime;
       public String BackupPath;
       public String MysqldumpPath;
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
