using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Bll
{
    /// <summary>
    /// 用户管理子系统操作类
    /// </summary>
    class UserManagementBll
    {
        /// <summary>
        /// 用户管理数据操作对象
        /// </summary>
        UserManagementDal userManagementDal = new UserManagementDal();

        /// <summary>
        /// 增加一条读者记录
        /// </summary>
        /// <param name="info">读者信息</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>增加成功与否</returns>
        public bool addANewReader(UserManagementReaderInfo info, ref List<string> errorMsg)
        {
            bool result;
            try
            {
                result = userManagementDal.addANewReader(info);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
    }
}
