using LibraryManagement.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Dal
{
    /// <summary>
    /// 用户管理子系统数据操作类
    /// </summary>
    class UserManagementDal
    {
        /// <summary>
        /// 工具对象
        /// </summary>
        SQLHelper helper = new SQLHelper();

        #region 管理员操作
        /// <summary>
        /// 添加一条读者记录
        /// </summary>
        /// <param name="info">读者信息</param>
        /// <returns>增加成功与否</returns>
        public bool addANewReader(UserManagementReaderInfo info)
        {
            string sqlStr = "AddNewReader";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@returnValue", MySqlDbType.Int32, 1),
                new MySqlParameter("@_userName", info.UserName),
                new MySqlParameter("@_userNumber", info.UserNumber),
                new MySqlParameter("@_gender", info.Gender),
                new MySqlParameter("@_birthday", info.Birthday),
                new MySqlParameter("@_address", info.Address),
                new MySqlParameter("@_contact", info.Contact),
                new MySqlParameter("@_libraryCardNum", info.LibraryCardNum),
                new MySqlParameter("@_departmentName", info.DepartmentName),
                new MySqlParameter("@_password", helper.GetMD5(info.Contact.Substring(5, 6)))
            };
            paras[0].Direction = ParameterDirection.Output;//将第一个变量设置为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, paras, CommandType.StoredProcedure);
            if (paras[0].Value.ToString() == "-2")
            {
                throw new Exception("获取 UserId 失败");
            }
            else if (paras[0].Value.ToString() == "-3")
            {
                throw new Exception("获取 DepartmentId 失败");
            }
            else if (paras[0].Value.ToString() == "-4")
            {
                throw new Exception("登陆表信息录入失败");
            }
            return paras[0].Value.ToString() == "1";
        }

        /// <summary>
        /// 删除一条读者记录
        /// </summary>
        /// <param name="userNumber">读者编号</param>
        /// <returns>删除成功与否</returns>
        public bool deleteAReader(string userNumber)
        {
            string sql = "DeleteAReader";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@returnValue", MySqlDbType.Int32, 1),
                new MySqlParameter("@_userNumber", userNumber)
            };
            paras[0].Direction = ParameterDirection.Output;//将第一个变量设置为输出变量
            int count = helper.ExecuteNonQuery(sql, paras, CommandType.StoredProcedure);
            if (paras[0].Value.ToString() == "-1")
            {
                throw new Exception("获取 UserId 失败");
            }
            else if (paras[0].Value.ToString() == "-2")
            {
                throw new Exception("删除读者信息表失败");
            }
            else if (paras[0].Value.ToString() == "-3")
            {
                throw new Exception("删除登录表失败");
            }
            else if (paras[0].Value.ToString() == "-4")
            {
                throw new Exception("删除基本信息表失败");
            }
            return paras[0].Value.ToString() == "1";
        }

        /// <summary>
        /// 获取全部读者信息
        /// </summary>
        /// <returns>全部读者信息</returns>
        public DataTable GetAllReadersInfo()
        {
            string sql = "SELECT DISTINCT " +
                "tb_BasicInformation.UserId AS `用户编号`,  " +
                "tb_ReaderInformation.LibraryCardNum AS `借书证号`,  " +
                "tb_BasicInformation.UserName AS `读者姓名`,  " +
                "tb_BasicInformation.UserNumber AS `学号/职工号`,  " +
                "tb_ReaderDepartment.DepartmentName AS `所在院系`,  " +
                "tb_BasicInformation.Gender" + " AS `性别`,  " +
                "tb_BasicInformation.Birthday AS `出生日期`,  " +
                "tb_BasicInformation.Address AS `地址`,  " +
                "tb_BasicInformation.Contact AS `联系电话` " +
                "FROM " +
                "tb_Login " +
                "INNER JOIN " +
                "tb_BasicInformation " +
                "ON  " +
                "tb_Login.UserId = tb_BasicInformation.UserId " +
                "INNER JOIN " +
                "tb_ReaderInformation " +
                "ON  " +
                "tb_BasicInformation.UserId = tb_ReaderInformation.UserId " +
                "INNER JOIN " +
                "tb_ReaderLevel " +
                "ON  " +
                "tb_ReaderInformation.ReaderLevelId = tb_ReaderLevel.Id " +
                "INNER JOIN " +
                "tb_ReaderDepartment " +
                "ON  " +
                "tb_ReaderInformation.DepartmentId = tb_ReaderDepartment.Id, " +
                "tb_User ";
            MySqlParameter[] para = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sql, para, CommandType.Text); 
            return dataTable;
        }
        #endregion

        #region 管理员登录
        /// <summary>
        /// 管理员登陆
        /// 登陆成功 200
        /// 密码不正确 401
        /// 权限不足 403
        /// </summary>
        /// <param name="login"></param>
        /// <returns>状态码</returns>
        public int adminLogin(UserManagementLogin login)
        {
            int result;
            SQLHelper helper = new SQLHelper();
            string pwd = helper.GetMD5(login.Password);
            string role = "Administrator";
            string sql = "SELECT DISTINCT " +
                "*, " +
                "tb_Login.`Password`,  " +
                "tb_BasicInformation.UserNumber,  " +
                "tb_User.Role " +
                "FROM " +
                "tb_User, " +
                "tb_BasicInformation " +
                "INNER JOIN " +
                "tb_Login " +
                "ON  " +
                "tb_BasicInformation.UserId = tb_Login.UserId " +
                "WHERE " +
                "tb_User.Role = @role " +
                "AND " +
                "tb_BasicInformation.UserNumber = @userNumber ";
            MySqlParameter[] adminPara = new MySqlParameter[]
            {
                new MySqlParameter("@userNumber", login.UserNumber),
                new MySqlParameter("@role", role)
            };
            DataTable dt = helper.ExecuteQuery(sql, adminPara, CommandType.Text);
            if(dt.Rows.Count == 1)
            {
                if ((string)dt.Rows[0]["Password"] == pwd)
                {
                    result = 200;
                }
                else
                {
                    result = 401;
                }
            }
            else
            {
                result = 403;
            }
            return result;
        }
        #endregion

        #region 读者权限管理
        /// <summary>
        /// 修改读者权限级别为 1
        /// </summary>
        /// <param name="info">读者信息</param>
        /// <returns>修改是否成功</returns>
        private bool ChangeReaderLevelToOne(UserManagementReaderInfo info)
        {
            string sqlStr = "UPDATE tb_ReaderInformation " +
                "SET " +
                "ReaderLevelId = 1 " +
                "WHERE " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId " +
                "AND " +
                "tb_BasicInformation.UserNumber = @userNumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@userNumber", info.UserNumber)
            };
            int countUpdate = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
            if (countUpdate > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改读者权限级别为 2
        /// </summary>
        /// <param name="info">读者信息</param>
        /// <returns>修改是否成功</returns>
        private bool ChangeReaderLevelToTwo(UserManagementReaderInfo info)
        {
            string sqlStr = "UPDATE tb_ReaderInformation " +
                "SET " +
                "ReaderLevelId = 2 " +
                "WHERE " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId " +
                "AND " +
                "tb_BasicInformation.UserNumber = @userNumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@userNumber", info.UserNumber)
            };
            int countUpdate = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
            if (countUpdate > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改读者权限级别为 3
        /// </summary>
        /// <param name="info">读者信息</param>
        /// <returns>修改是否成功</returns>
        private bool ChangeReaderLevelToThree(UserManagementReaderInfo info)
        {
            string sqlStr = "UPDATE tb_ReaderInformation " +
                "SET " +
                "ReaderLevelId = 3 " +
                "WHERE " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId " +
                "AND " +
                "tb_BasicInformation.UserNumber = @userNumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@userNumber", info.UserNumber)
            };
            int countUpdate = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
            if (countUpdate > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改读者权限级别为 4
        /// </summary>
        /// <param name="info">读者信息</param>
        /// <returns>修改是否成功</returns>
        private bool ChangeReaderLevelToFour(UserManagementReaderInfo info)
        {
            string sqlStr = "UPDATE tb_ReaderInformation " +
                "SET " +
                "ReaderLevelId = 4 " +
                "WHERE " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId " +
                "AND " +
                "tb_BasicInformation.UserNumber = @userNumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@userNumber", info.UserNumber)
            };
            int countUpdate = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
            if (countUpdate > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改读者权限级别为 5
        /// </summary>
        /// <param name="info">读者信息</param>
        /// <returns>修改是否成功</returns>
        private bool ChangeReaderLevelToFive(UserManagementReaderInfo info)
        {
            string sqlStr = "UPDATE tb_ReaderInformation " +
                "SET " +
                "ReaderLevelId = 5 " +
                "WHERE " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId " +
                "AND " +
                "tb_BasicInformation.UserNumber = @userNumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@userNumber", info.UserNumber)
            };
            int countUpdate = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
            if (countUpdate > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
