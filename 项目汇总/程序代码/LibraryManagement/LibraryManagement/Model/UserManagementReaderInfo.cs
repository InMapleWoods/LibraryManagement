using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
        public int Gender = 0;

        /// <summary>
        /// 读者性别
        /// </summary>
        public string BitGender
        {
            set
            {
                Gender = (value == "男" ? 1 : 0);
            }
        }

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
        /// 院系名称
        /// </summary>
        public string DepartmentName = "";

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
            if (info.Address == "")
            {
                return true;
            }
            if (info.Contact == "")
            {
                return true;
            }
            if (info.DepartmentName == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断读者信息是否符合规范
        /// </summary>
        /// <param name="info">待判定读者信息</param>
        /// <returns>读者信息是否符合规范</returns>
        public static bool isNormative(UserManagementReaderInfo info, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            Match matchLibraryCardNum = Regex.Match(info.LibraryCardNum, @"\d{11}");
            if (!matchLibraryCardNum.Success)
            {
                errorList.Add("LibraryCardNum Error");
            }
            Match matchUserNumber = Regex.Match(info.UserNumber, @"(\d{12}|\d{10}|\d{8})");
            if (!matchUserNumber.Success)
            {
                errorList.Add("UserNumber Error");
            }
            Match matchUserName = Regex.Match(info.UserName, @"\S{2,20}");
            if (!matchUserName.Success)
            {
                errorList.Add("UserName Error");
            }
            Match matchAddress = Regex.Match(info.Address, @"\d{2}\#\d{3}");
            if (!matchAddress.Success)
            {
                errorList.Add("Address Error");
            }
            Match matchContact = Regex.Match(info.Contact, @"\d{11}");
            if (!matchContact.Success)
            {
                errorList.Add("Contact Error");
            }
            errorMsg = errorList;
            if (errorList.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
