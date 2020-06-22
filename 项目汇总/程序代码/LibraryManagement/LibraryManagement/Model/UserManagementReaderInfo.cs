using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 读者信息
    /// </summary>
    class UserManagementReaderInfo
    {
        /// <summary>
        /// 借书证号
        /// </summary>
        public string LibraryCardNum = "";

        /// <summary>
        /// 读者编号
        /// </summary>
        public string UserNumber = "";

        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName = "";

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender = "";

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday = DateTime.Now;

        /// <summary>
        /// 地址
        /// </summary>
        public string Address = "";

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Contact = "";

        /// <summary>
        /// 院系编号
        /// </summary>
        public string DepartmentNum = "";

        /// <summary>
        /// 判断读者信息是否有空项
        /// </summary>
        /// <param name="info">待判定读者信息</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(UserManagementReaderInfo info)
        {
            if (info.LibraryCardNum == "")
            {
                return true;
            }
            if (info.UserNumber == "")
            {
                return true;
            }
            if (info.UserName == "")
            {
                return true;
            }
            if (info.Gender == "")
            {
                return true;
            }
            if (info.Address == "")
            {
                return true;
            }
            if (info.Contact == "")
            {
                return true;
            }
            if (info.DepartmentNum == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断读者信息是否符合规范
        /// </summary>
        /// <param name="info">带判定读者信息</param>
        /// <returns>读者信息是否符合规范</returns>
        public static bool isNormative(UserManagementReaderInfo info, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();



            errorMsg = errorList;
            return true;
        }
    }
}
