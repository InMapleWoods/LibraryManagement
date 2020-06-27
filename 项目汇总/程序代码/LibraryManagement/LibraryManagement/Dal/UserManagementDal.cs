using LibraryManagement.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;

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
        /// 修改一条读者信息记录
        /// </summary>
        /// <param name="info">读者信息</param>
        /// <param name="id">读者编号</param>
        /// <returns>修改成功与否</returns>
        public bool UpdateReaderInfo(UserManagementReaderInfo info, int id)
        {
            string sqlStr = "UpdateReaderInfo";
            //储存Datatable
            MySqlParameter[] paras = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@returnValue", MySqlDbType.Int32, 1),
                new MySqlParameter("@_userId", id),
                new MySqlParameter("@_userName", info.UserName),
                new MySqlParameter("@_userNumber", info.UserNumber),
                new MySqlParameter("@_gender", info.Gender),
                new MySqlParameter("@_birthday", info.Birthday),
                new MySqlParameter("@_address", info.Address),
                new MySqlParameter("@_contact", info.Contact),
                new MySqlParameter("@_libraryCardNum", info.LibraryCardNum),
                new MySqlParameter("@_departmentName", info.DepartmentName),
            };
            paras[0].Direction = ParameterDirection.Output;//将第一个变量设置为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, paras, CommandType.StoredProcedure);
            if (paras[0].Value.ToString() == "-1")
            {
                throw new Exception("获取院系编号失败");
            }
            else if (paras[0].Value.ToString() == "-2")
            {
                throw new Exception("修改基本信息表失败");
            }
            else if (paras[0].Value.ToString() == "-3")
            {
                throw new Exception("修改读者信息表失败");
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
        /// 未知错误 420
        /// </summary>
        /// <param name="login"></param>
        /// <returns>状态码</returns>
        public int adminLogin(UserManagementLogin login)
        {
            int result;
            SQLHelper helper = new SQLHelper();
            string pwd = helper.GetMD5(login.Password);
            string role = "Administrator";
            string sql = " SELECT " +
                " tb_Login.`Password`, " +
                " tb_BasicInformation.UserNumber, " +
                " tb_User.Role  " +
                " FROM " +
                " tb_User " +
                " INNER JOIN tb_BasicInformation ON tb_User.Id = tb_BasicInformation.UserId " +
                " INNER JOIN tb_Login ON tb_BasicInformation.UserId = tb_Login.UserId " +
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
            if (dt.Rows.Count == 1)
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
            else if (dt.Rows.Count == 0)
            {
                result = 403;
            }
            else
            {
                result = 420;
            }
            return result;
        }

        public int adminLogin(UserManagementLogin login, out UserManagementAdmin admin)
        {
            int result;
            SQLHelper helper = new SQLHelper();
            string pwd = helper.GetMD5(login.Password);
            string sql = " SELECT " +
                " tb_BasicInformation.UserId AS `编号`,  " +
                " tb_Login.`Password` AS `密码`,  " +
                " tb_BasicInformation.UserName AS `名称`,  " +
                " tb_BasicInformation.UserNumber AS `账号`,  " +
                " GROUP_CONCAT( tb_AdminInformation.AdminRole SEPARATOR '|') AS `角色` " +
                " FROM " +
                " tb_AdminInformation " +
                " INNER JOIN " +
                " tb_BasicInformation " +
                " ON  " +
                " tb_AdminInformation.UserId = tb_BasicInformation.UserId " +
                " INNER JOIN " +
                " tb_Login " +
                " ON  " +
                " tb_BasicInformation.UserId = tb_Login.UserId " +
                " WHERE " +
                " tb_BasicInformation.UserNumber =@userNumber  AND " +
                " tb_Login.`Password` = @password " +
                " GROUP BY " +
                " tb_BasicInformation.UserId,tb_Login.`Password` ;";
            MySqlParameter[] adminPara = new MySqlParameter[]
            {
                new MySqlParameter("@userNumber", login.UserNumber),
                new MySqlParameter("@password", pwd)
            };
            DataTable dt = helper.ExecuteQuery(sql, adminPara, CommandType.Text);
            if (dt.Rows.Count == 1)
            {
                if ((string)dt.Rows[0]["密码"] == pwd)
                {
                    result = 200;
                    admin = new UserManagementAdmin()
                    {
                        Id = (int)dt.Rows[0]["编号"],
                        Name = dt.Rows[0]["名称"].ToString(),
                        Number = dt.Rows[0]["账号"].ToString(),
                        Roles = dt.Rows[0]["角色"].ToString(),
                    };
                    return result;
                }
                else
                {
                    result = 401;
                }
            }
            else if (dt.Rows.Count == 0)
            {
                result = 403;
            }
            else
            {
                result = 420;
            }
            admin = null;
            return result;
        }
        #endregion

        #region 读者权限管理
        /// <summary>
        /// 获取全部读者权限
        /// </summary>
        /// <returns>全部读者权限</returns>
        public DataTable GetAllReadersLevel()
        {
            string sql = "SELECT " +
                "tb_BasicInformation.UserName AS `姓名`,  " +
                "tb_BasicInformation.UserNumber AS `学号/教工号`,  " +
                "tb_BasicInformation.Contact AS `联系电话`,  " +
                "tb_ReaderLevel.ReaderLevelName AS `读者级别`,  " +
                "tb_ReaderLevel.BorrowBookNumber AS `可借阅图书数目`,  " +
                "tb_ReaderLevel.ReserveBookNumber AS `可预约图书数目`,  " +
                "tb_ReaderLevel.BorrowBookDays AS `可借天数`,  " +
                "tb_ReaderLevel.RenewBookDays AS `可续借天数`,  " +
                "tb_ReaderLevel.ForfeitMultiples AS `罚款倍数`,  " +
                "tb_ReaderLevel.RenewBookNumber AS `续借册数` " +
                "FROM " +
                "tb_ReaderLevel " +
                "INNER JOIN " +
                "tb_ReaderInformation " +
                "ON  " +
                "tb_ReaderLevel.Id = tb_ReaderInformation.ReaderLevelId " +
                "INNER JOIN " +
                "tb_BasicInformation " +
                "ON  " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId ";
            MySqlParameter[] para = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sql, para, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 修改读者权限级别为 1
        /// </summary>
        /// <param name="info">读者信息</param>
        /// <returns>修改是否成功</returns>
        public bool ChangeReaderLevelToOne(UserManagementReaderLevel level)
        {
            string sqlStr = "UPDATE tb_ReaderInformation," +
                "tb_BasicInformation " +
                "SET " +
                "ReaderLevelId = 1 " +
                "WHERE " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId " +
                "AND " +
                "tb_BasicInformation.UserNumber = @_userNumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@_userNumber", level.UserNumber)
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
        public bool ChangeReaderLevelToTwo(UserManagementReaderLevel level)
        {
            string sqlStr = "UPDATE tb_ReaderInformation, " +
                "tb_BasicInformation " +
                "SET " +
                "ReaderLevelId = 2 " +
                "WHERE " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId " +
                "AND " +
                "tb_BasicInformation.UserNumber = @_userNumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@_userNumber", level.UserNumber)
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
        public bool ChangeReaderLevelToThree(UserManagementReaderLevel level)
        {
            string sqlStr = "UPDATE tb_ReaderInformation, " +
                "tb_BasicInformation " +
                "SET " +
                "ReaderLevelId = 3 " +
                "WHERE " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId " +
                "AND " +
                "tb_BasicInformation.UserNumber = @_userNumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@_userNumber", level.UserNumber)
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
        public bool ChangeReaderLevelToFour(UserManagementReaderLevel level)
        {
            string sqlStr = "UPDATE tb_ReaderInformation, " +
                "tb_BasicInformation " +
                "SET " +
                "ReaderLevelId = 4 " +
                "WHERE " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId " +
                "AND " +
                "tb_BasicInformation.UserNumber = @_userNumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@_userNumber", level.UserNumber)
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
        public bool ChangeReaderLevelToFive(UserManagementReaderLevel level)
        {
            string sqlStr = "UPDATE tb_ReaderInformation, " +
                "tb_BasicInformation " +
                "SET " +
                "ReaderLevelId = 5 " +
                "WHERE " +
                "tb_ReaderInformation.UserId = tb_BasicInformation.UserId " +
                "AND " +
                "tb_BasicInformation.UserNumber = @_userNumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@_userNumber", level.UserNumber)
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

        #region 添加管理员
        /// <summary>
        /// 添加一条管理员记录
        /// </summary>
        /// <param name="info">管理员信息</param>
        /// <returns>增加成功与否</returns>
        public bool addANewAdmin(UserManagementAdminInfo info)
        {
            string sqlStr = "AddNewAdmin";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@returnValue", MySqlDbType.Int32, 1),
                new MySqlParameter("@_userNumber", info.UserNumber),
                new MySqlParameter("@_adminDepartment", info.AdminDepartment),
                new MySqlParameter("@_adminRole", info.AdminRole)
            };
            paras[0].Direction = ParameterDirection.Output;//将第一个变量设置为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, paras, CommandType.StoredProcedure);
            if (paras[0].Value.ToString() == "-2")
            {
                throw new Exception("获取 UserId 失败");
            }
            else if (paras[0].Value.ToString() == "-3")
            {
                throw new Exception("添加管理员失败");
            }
            return paras[0].Value.ToString() == "1";
        }

        /// <summary>
        /// 删除一条管理员记录
        /// </summary>
        /// <param name="info">管理员信息</param>
        /// <returns>删除成功与否</returns>
        public bool deleteAAdmin(UserManagementAdminInfo info)
        {
            string sql = "DeleteAAdmin";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@returnValue", MySqlDbType.Int32, 1),
                new MySqlParameter("@_userNumber", info.UserNumber),
                new MySqlParameter("@_adminDepartment", info.AdminDepartment),
                new MySqlParameter("@_adminRole", info.AdminRole)
            };
            paras[0].Direction = ParameterDirection.Output;//将第一个变量设置为输出变量
            int count = helper.ExecuteNonQuery(sql, paras, CommandType.StoredProcedure);
            if (paras[0].Value.ToString() == "-2")
            {
                throw new Exception("获取 UserId 失败");
            }
            else if (paras[0].Value.ToString() == "-3")
            {
                throw new Exception("删除管理员失败");
            }
            return paras[0].Value.ToString() == "1";
        }

        /// <summary>
        /// 获取全部管理员信息
        /// </summary>
        /// <returns>全部管理员信息</returns>
        public DataTable GetAllAdminInfo()
        {
            string sql = "SELECT " +
                "tb_AdminInformation.UserId AS `用户编号`,  " +
                "tb_BasicInformation.UserNumber AS `学号/教工号`,  " +
                "tb_BasicInformation.UserName AS `姓名`,  " +
                "tb_AdminInformation.AdminDepartment AS `管理员科室`,  " +
                "tb_AdminInformation.AdminRole AS `管理员角色` " +
                "FROM " +
                "tb_AdminInformation " +
                "INNER JOIN " +
                "tb_BasicInformation " +
                "ON  " +
                "tb_AdminInformation.UserId = tb_BasicInformation.UserId";
            MySqlParameter[] para = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sql, para, CommandType.Text);
            return dataTable;
        }
        #endregion
    }
}
