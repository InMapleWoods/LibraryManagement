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
        // 基本信息表
            string sqlBasic = "INSERT INTO tb_BasicInformation" +
                "(UserName," +
                "UserNumber" +
                "Gender" +
                "Birthday" +
                "Address" +
                "Contact) " +
                "VALUES(" +
                "@userName," +
                "@userNumber," +
                "@gender," +
                "@birthday," +
                "@address," +
                "@contact" +
                ")";
            MySqlParameter[] paraBasic = new MySqlParameter[]
            {
                new MySqlParameter("@userName", info.UserName),
                new MySqlParameter("@userNumber", info.UserNumber),
                new MySqlParameter("@gender", info.Gender),
                new MySqlParameter("@birthday", info.Birthday),
                new MySqlParameter("@address", info.Address),
                new MySqlParameter("@contact", info.Contact)
            };
            int countBasicInformation = helper.ExecuteNonQuery(sqlBasic, paraBasic, CommandType.Text);


            // 从 tb_BasicInformation 表获取新添加读者的用户ID UserId
            string sqlUserId = "SELECT UserId FROM tb_BasicInformation WHERE UserNumber = @userNumber";
            MySqlParameter[] paraUserId = new MySqlParameter[]
            {
                new MySqlParameter("@userNumber", info.UserNumber)
            };
            DataTable dtUserId = helper.ExecuteQuery(sqlUserId, paraUserId, CommandType.Text);
            string userId = (string)dtUserId.Rows[0][0];


            // 从 tb_ReaderDepartment 表获取新添加读者的院系编号 departmentId
            string sqlDepartmentId = "SELECT Id FROM tb_ReaderInformation WHERE DepartmentName = @departmentName";
            MySqlParameter[] paraDepartmentId = new MySqlParameter[]
            {
                new MySqlParameter("@departmentName", info.DepartmentName)
            };
            DataTable dtDepartmentId = helper.ExecuteQuery(sqlDepartmentId, paraDepartmentId, CommandType.Text);
            string departmentId = (string)dtDepartmentId.Rows[0][0];


            // 向 tb_ReaderInformation 表添加数据
            string sqlReader = "INSERT INTO tb_ReaderInformation" +
                "(LibraryCardNum," +
                "UserId" +
                "DepartmentId)" +
                "VALUES(" +
                "@libraryCardNum," +
                "@userId," +
                "departmentId" +
                ")";
            MySqlParameter[] paraReader = new MySqlParameter[]
            {
                new MySqlParameter("@libraryCardNum", info.LibraryCardNum),
                new MySqlParameter("@userId", userId),
                new MySqlParameter("@departmentId", departmentId)
            };
            int countReaderInformation = helper.ExecuteNonQuery(sqlReader, paraReader, CommandType.Text);

            // 向 tb_Login 表添加数据
            string sqlLogin = "INSERT INTO tb_Login (UserId, Password) VALUES (@userId, @password)";
            MySqlParameter[] paraLogin = new MySqlParameter[]
            {
                new MySqlParameter("@userId", userId),
                new MySqlParameter("@password", info.Contact.Substring(5,11))//初始密码设置为联系电话后六位
            };
            int countLogin = helper.ExecuteNonQuery(sqlLogin, paraLogin, CommandType.Text);

            if (countBasicInformation > 0 && countReaderInformation > 0 && countLogin > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                "tb_BasicInformation.Gender AS `性别`,  " +
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

    }
}
