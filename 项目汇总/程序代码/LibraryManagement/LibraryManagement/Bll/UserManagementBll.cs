using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        #region 管理员操作
        /// <summary>
        /// 增加一条读者记录
        /// </summary>
        /// <param name="info">读者信息</param>
        /// <returns>增加成功与否</returns>
        public bool addANewReader(UserManagementReaderInfo info, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!UserManagementReaderInfo.isNull(info))
                {
                    if (UserManagementReaderInfo.isNormative(info, ref errorMsg))
                    {
                        result = userManagementDal.addANewReader(info);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取全部读者信息
        /// </summary>
        /// <returns>全部读者信息</returns>
        public DataTable GetAllReadersInfo()
        {
            DataTable dt;
            try
            {
                dt = userManagementDal.GetAllReadersInfo();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return dt;
        }
        #endregion

        #region 管理员登陆
        /// <summary>
        /// 管理员登陆
        /// 格式错误 415
        /// </summary>
        /// <param name="login">登录信息</param>
        /// <returns>状态码</returns>
        public int adminLogin(UserManagementLogin login, ref List<string> errorMsg)
        {
            int result = 415;
            try
            {
                if (!UserManagementLogin.isNull(login))//是否有空项
                {
                    if(UserManagementLogin.isNormative(login, ref errorMsg))//是否符合规范
                    {
                        result = userManagementDal.adminLogin(login);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        #endregion
    }
}
