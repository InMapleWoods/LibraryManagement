using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 登录信息
    /// </summary>
    class UserManagementLogin
    {
        /// <summary>
        /// 读者编号
        /// </summary>
        public string UserNumber = "";

        /// <summary>
        /// 密码
        /// </summary>
        public string Password = "";

        /// <summary>
        /// 判断登录信息是否为空
        /// </summary>
        /// <returns></returns>
        public static bool isNull(UserManagementLogin login)
        {
            if(login.UserNumber == "")
            {
                return true;
            }
            if(login.Password == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断登录信息是否规范
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static bool isNormative(UserManagementLogin login, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            Match userNumber = Regex.Match(login.UserNumber, @"(\d{12}|\d{10}|\d{8})");
            if(!userNumber.Success)
            {
                errorList.Add("UserNumber Error");
            }
            Match password = Regex.Match(login.Password, @"\S{6,16}");
            if(!password.Success)
            {
                errorList.Add("Password Error");
            }
            errorMsg = errorList;
            if(errorList.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
