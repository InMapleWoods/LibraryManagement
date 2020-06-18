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
    }
}
