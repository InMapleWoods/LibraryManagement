using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;

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
        /// 删除一条读者记录
        /// </summary>
        /// <param name="userNumber">读者编号</param>
        /// <returns>删除是否成功</returns>
        public bool deleteAReader(string userNumber)
        {
            bool result;
            try
            {
                result = userManagementDal.deleteAReader(userNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }


        /// <summary>
        /// 修改一条读者信息记录
        /// </summary>
        /// <param name="order">读者信息</param>
        /// <returns>修改成功与否</returns>
        public bool UpdateReaderInfo(UserManagementReaderInfo info, int id, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (info.UserNumber == "")
                {
                    errorMsg.Add("UserNumber Error");
                    return false;
                }
                if (!UserManagementReaderInfo.isNull(info))//是否有空项
                {
                    if (UserManagementReaderInfo.isNormative(info, ref errorMsg))//是否符合规范
                    {
                        result = userManagementDal.UpdateReaderInfo(info, id);
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
            catch (Exception e)
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
                    if (UserManagementLogin.isNormative(login, ref errorMsg))//是否符合规范
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

        /// <summary>
        /// 管理员登陆
        /// 格式错误 415
        /// </summary>
        /// <param name="login">登录信息</param>
        /// <returns>状态码</returns>
        public int adminLogin(UserManagementLogin login, out UserManagementAdmin admin, ref List<string> errorMsg)
        {
            int result = 415;
            try
            {
                if (!UserManagementLogin.isNull(login))//是否有空项
                {
                    if (UserManagementLogin.isNormative(login, ref errorMsg))//是否符合规范
                    {
                        return userManagementDal.adminLogin(login, out admin);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            admin = null;
            return result;
        }
        #endregion

        #region 读者权限管理
        public bool UpdateReaderLevel(UserManagementReaderLevel level, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (level.UserNumber == "")
                {
                    errorMsg.Add("UserNumber Error");
                    return false;
                }
                if (!UserManagementReaderLevel.isNull(level))//是否有空项
                {
                    if (UserManagementReaderLevel.isNormative(level, ref errorMsg))//是否符合规范
                    {
                        switch (level.ReaderLevelName)
                        {
                            case "1":
                                result = userManagementDal.ChangeReaderLevelToOne(level);
                                break;
                            case "2":
                                result = userManagementDal.ChangeReaderLevelToTwo(level);
                                break;
                            case "3":
                                result = userManagementDal.ChangeReaderLevelToThree(level);
                                break;
                            case "4":
                                result = userManagementDal.ChangeReaderLevelToFour(level);
                                break;
                            case "5":
                                result = userManagementDal.ChangeReaderLevelToFive(level);
                                break;
                            default:
                                result = false;
                                break;
                        }
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
        /// 获取全部读者权限
        /// </summary>
        /// <returns>全部读者权限</returns>
        public DataTable GetAllReadersLevel()
        {
            DataTable dt;
            try
            {
                dt = userManagementDal.GetAllReadersLevel();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return dt;
        }
        #endregion

        #region 添加管理员
        /// <summary>
        /// 增加一条管理员记录
        /// </summary>
        /// <param name="info">管理员信息</param>
        /// <returns>增加成功与否</returns>
        public bool addANewAdmin(UserManagementAdminInfo info, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!UserManagementAdminInfo.isNull(info))
                {
                    if (UserManagementAdminInfo.isNormative(info, ref errorMsg))
                    {
                        result = userManagementDal.addANewAdmin(info);
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
        /// 删除一条管理员记录
        /// </summary>
        /// <param name="userNumber">管理员信息</param>
        /// <returns>删除是否成功</returns>
        public bool deleteAAdmin(UserManagementAdminInfo info)
        {
            bool result;
            try
            {
                result = userManagementDal.deleteAAdmin(info);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取全部管理员信息
        /// </summary>
        /// <returns>全部管理员信息</returns>
        public DataTable GetAllAdminInfo()
        {
            DataTable dt;
            try
            {
                dt = userManagementDal.GetAllAdminInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return dt;
        }
        #endregion
    }
}
