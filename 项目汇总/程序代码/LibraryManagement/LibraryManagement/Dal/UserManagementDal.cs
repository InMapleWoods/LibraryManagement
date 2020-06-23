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
        //    // 基本信息表
        //    string sqlBasic = "INSERT INTO tb_BasicInformation" +
        //        "(UserName," +
        //        "UserNumber" +
        //        "Gender" +
        //        "Birthday" +
        //        "Address" +
        //        "Contact) " +
        //        "VALUES(" +
        //        "@userName," +
        //        "@userNumber," +
        //        "@gender," +
        //        "@birthday," +
        //        "@address," +
        //        "@contact" +
        //        ")";
        //    MySqlParameter[] paraBasic = new MySqlParameter[]
        //    {
        //        new MySqlParameter("@userName", info.UserName),
        //        new MySqlParameter("@userNumber", info.UserNumber),
        //        new MySqlParameter("@gender", info.Gender),
        //        new MySqlParameter("@birthday", info.Birthday),
        //        new MySqlParameter("@address", info.Address),
        //        new MySqlParameter("@contact", info.Contact)
        //    };
        //    int countBasicInformation = helper.ExecuteNonQuery(sqlBasic, paraBasic, CommandType.Text);


        //    // 从 tb_BasicInformation 表获取新添加读者的用户ID UserId
        //    string sqlUserId = "SELECT UserId FROM tb_BasicInformation WHERE UserNumber = @departmentNum";
        //    MySqlParameter[] paraUserId = new MySqlParameter[]
        //    {
        //        new MySqlParameter("departmentNum", info.DepartmentNum)
        //    };
        //    DataTable dtUserId = helper.ExecuteQuery(sqlUserId, paraUserId, CommandType.Text);
        //    string userId = (string)dtUserId.Rows[0][0];


        //    // 从 tb_ReaderDepartment 表获取新添加读者的院系编号 departmentId
        //    string sqlDepartmentId = "SELECT Id FROM tb_ReaderInformation WHERE DepartmentName = @departmentNum";
        //    MySqlParameter[] paraDepartmentId = new MySqlParameter[]
        //    {
        //        new MySqlParameter("@departmentNum", info.DepartmentNum)
        //    };
        //    DataTable dtDepartmentId = helper.ExecuteQuery(sqlDepartmentId, paraDepartmentId, CommandType.Text);
        //    string departmentId = (string)dtDepartmentId.Rows[0][0];


        //    // 向 tb_ReaderInformation 表添加数据
        //    string sqlReader = "INSERT INTO tb_ReaderInformation" +
        //        "(LibraryCardNum," +
        //        "UserId" +
        //        "DepartmentId)" +
        //        "VALUES(" +
        //        "@libraryCardNum," +
        //        "@userId," +
        //        "departmentId" +
        //        ")";
        //    MySqlParameter[] paraReader = new MySqlParameter[]
        //    {
        //        new MySqlParameter("@libraryCardNum", info.LibraryCardNum),
        //        new MySqlParameter("@userId", userId),
        //        new MySqlParameter("@departmentId", departmentId)
        //    };
        //    int countReaderInformation = helper.ExecuteNonQuery(sqlReader, paraReader, CommandType.Text);

        //    // 向 tb_Login 表添加数据
        //    string sqlLogin = "INSERT INTO tb_Login (UserId, Password) VALUES (@userId, @password)";
        //    MySqlParameter[] paraLogin = new MySqlParameter[]
        //    {
        //        new MySqlParameter("@userId", userId),
        //        new MySqlParameter("@password", info.Contact.Substring(5,11))
        //    };
        //    int countLogin = helper.ExecuteNonQuery(sqlLogin, paraLogin, CommandType.Text);

        //    if (countBasicInformation > 0 && countReaderInformation > 0 && countLogin > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
                return false;
            //}
        }
        #endregion

        #region 管理员登录
        /// <summary>
        /// 管理员登陆
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool adminLogin(UserManagementLogin login)
        {
            bool result;
            SQLHelper helper = new SQLHelper();
            string pwd = helper.GetMD5(login.Password);
            string sql = "SELECT * " + 
                "FROM tb_Login, tb_BasicInformation " +
                "WHERE " +
                "tb_Login.UserId = tb_BasicInformation.UserId " +
                "AND tb_BasicInformation.UserNumber = @userNumber "+
                "AND tb_Login.Password = @password";
            MySqlParameter[] adminPara = new MySqlParameter[]
            {
                new MySqlParameter("@userNumber", login.UserNumber),
                new MySqlParameter("@password", pwd)
            };
            DataTable dt = helper.ExecuteQuery(sql, adminPara, CommandType.Text);
            if(dt.Rows.Count == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        #endregion

    }
}
