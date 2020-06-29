using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagementFunctionTest.Model
{
    /// <summary>
    /// 管理员信息
    /// </summary>
    class UserManagementAdminInfo
    {
        /// <summary>
        /// 读者编号
        /// </summary>
        public string UserNumber = "";

        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName = "";

        /// <summary>
        /// 管理员科室
        /// </summary>
        public string AdminDepartment = "";

        /// <summary>
        /// 管理员角色
        /// </summary>
        public string AdminRole = "";

        /// <summary>
        /// 判断管理员信息是否符合规范
        /// </summary>
        /// <param name="info">管理员信息</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(UserManagementAdminInfo info)
        {
            if (info.UserNumber == "")
            {
                return true;
            }
            if (info.UserName == "")
            {
                return true;
            }
            if (info.AdminDepartment == "")
            {
                return true;
            }
            if (info.AdminRole == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断管理员信息是否符合规范
        /// </summary>
        /// <param name="info">管理员信息</param>
        /// <returns>管理员信息是否符合规范</returns>
        public static bool isNormative(UserManagementAdminInfo info, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            Match matchUserNumber = Regex.Match(info.UserNumber,  @"^(\d{12}|\d{10}|\d{8})$");
            if (!matchUserNumber.Success)
            {
                errorList.Add("UserNumber Error");
            }
            Match matchUserName = Regex.Match(info.UserName,  @"^\S{2,20}$");
            if (!matchUserName.Success)
            {
                errorList.Add("UserName Error");
            }
            Match matchAdminDepartment = Regex.Match(info.AdminDepartment,  @"^\S{0,10}$");
            if (!matchAdminDepartment.Success)
            {
                errorList.Add("AdminDepartment Error");
            }
            Match matchAdminRole = Regex.Match(info.AdminRole,  @"^\S{0,20}$");
            if (!matchAdminRole.Success)
            {
                errorList.Add("AdminRole Error");
            }
            return true;
        }
    }
}
