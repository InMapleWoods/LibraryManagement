using LibraryManagement.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Dal
{
    /// <summary>
    /// 流通子系统数据操作类
    /// </summary>
    public class CirculationDal
    {
        /// <summary>
        /// 工具对象
        /// </summary>
        private SQLHelper helper = new SQLHelper();

        #region 图书借阅
        /// <summary>
        /// 获取全部借阅记录
        /// </summary>
        /// <returns>全部借阅记录</returns>
        public DataTable GetBorrowLog()
        {
            string sqlstr = " SELECT " +
                " tb_BookBorrowLog.Id AS 编号, " +
                " tb_BasicInformation.UserName AS 借书人, " +
                " tb_CirculateBooks.OfficialTitle AS 书名, " +
                " tb_BookBorrowLog.BorrowTime AS 借阅时间  " +
                " FROM " +
                " tb_BookBorrowLog " +
                " INNER JOIN tb_BasicInformation " +
                " INNER JOIN tb_CirculateBooks ON tb_BookBorrowLog.BookId = tb_CirculateBooks.Id  " +
                " AND tb_BookBorrowLog.ReaderId = tb_BasicInformation.UserId; ";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 获取某人全部借阅记录
        /// </summary>
        /// <param name="readerId">读者编号</param>
        /// <param name="bookId">书籍编号</param>
        /// <returns>某人全部借阅记录</returns>
        public DataTable GetBorrowLogByReader(int readerId, string bookId)
        {
            bookId = "%" + bookId + "%";
            string sqlstr = " SELECT " +
                " tb_BookBorrowLog.Id AS 编号, " +
                " tb_BasicInformation.UserName AS 借书人, " +
                " tb_CirculateBooks.OfficialTitle AS 书名, " +
                " tb_BookBorrowLog.BorrowTime AS 借阅时间  " +
                " FROM " +
                " tb_BookBorrowLog " +
                " INNER JOIN tb_BasicInformation " +
                " INNER JOIN tb_CirculateBooks ON tb_BookBorrowLog.BookId = tb_CirculateBooks.Id  " +
                " AND tb_BookBorrowLog.ReaderId = tb_BasicInformation.UserId " +
                " AND tb_BookBorrowLog.State = '有效' " +
                " AND tb_CirculateBooks.Id LIKE @bookName " +
                " AND tb_BookBorrowLog.ReaderId = @readerId; ";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                 new MySqlParameter("@bookName", bookId),
                 new MySqlParameter("@readerId", readerId),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 借阅图书
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public bool AddBorrowLog(BookBorrowLog log)
        {
            string sqlStr = "AddBookBorrowLog";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@returnValue",MySqlDbType.Int32,1),
                new MySqlParameter("@readerId",log.ReaderId),
                new MySqlParameter("@bookId",log.BookId),
                new MySqlParameter("@borrowTime",log.BorrowTime),
            };
            para[0].Direction = ParameterDirection.Output;//将第一个变量设为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
            if (para[0].Value.ToString() == "-2")
            {
                throw new Exception("存在未处理违约");
            }
            if (para[0].Value.ToString() == "-3")
            {
                throw new Exception("用户可借阅数量不足");
            }
            return para[0].Value.ToString() == "1";
        }

        /// <summary>
        /// 删除借阅图书记录
        /// </summary>
        /// <param name="id">记录id</param>
        /// <returns></returns>
        public bool RemoveBorrowLog(int id)
        {
            string sqlStr = "DeleteBookBorrowLog";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@returnValue",MySqlDbType.Int32,1),
                new MySqlParameter("@Id",id),
            };
            para[0].Direction = ParameterDirection.Output;//将第一个变量设为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
            return para[0].Value.ToString() == "1";
        }
        #endregion

        #region 图书预约
        /// <summary>
        /// 获取某人全部预约记录
        /// </summary>
        /// <param name="readerId">读者编号</param>
        /// <param name="bookId">书籍编号</param>
        /// <returns>某人全部预约记录</returns>
        public DataTable GetAppointLogByReader(int readerId, string bookId)
        {
            bookId = "%" + bookId + "%";
            string sqlstr = " SELECT " +
                " tb_BookAppointLog.Id AS `编号`,  " +
                " tb_BasicInformation.UserName AS `借书人`,  " +
                " tb_CirculateBooks.OfficialTitle AS `书名`,  " +
                " tb_BookAppointLog.AppointmentTime AS `预约时间`,  " +
                " tb_BookAppointLog.ExpireDate AS `到期时间` " +
                " FROM " +
                " tb_BookAppointLog " +
                " INNER JOIN tb_BasicInformation " +
                " INNER JOIN tb_CirculateBooks ON " +
                " tb_BookAppointLog.BookId = tb_CirculateBooks.Id AND " +
                " tb_BookAppointLog.ReaderId = tb_BasicInformation.UserId AND " +
                " tb_BookAppointLog.State = '有效' " +
                " AND tb_CirculateBooks.Id LIKE @bookName " +
                " AND tb_BookAppointLog.ReaderId = @readerId; ";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                 new MySqlParameter("@bookName", bookId),
                 new MySqlParameter("@readerId", readerId),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 预约图书
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public bool AddAppointLog(BookAppointLog log)
        {
            string sqlStr = "AddBookAppointLog";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@returnValue",MySqlDbType.Int32,1),
                new MySqlParameter("@readerId",log.ReaderId),
                new MySqlParameter("@bookId",log.BookId),
                new MySqlParameter("@appointTime",log.AppointmentTime),
                new MySqlParameter("@expireDate",log.ExpireDate),
            };
            para[0].Direction = ParameterDirection.Output;//将第一个变量设为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
            if (para[0].Value.ToString() == "-2")
            {
                throw new Exception("存在未处理违约");
            }
            if (para[0].Value.ToString() == "-3")
            {
                throw new Exception("用户可预约数量不足");
            }
            return para[0].Value.ToString() == "1";
        }

        /// <summary>
        /// 删除预约图书记录
        /// </summary>
        /// <param name="id">记录id</param>
        /// <returns></returns>
        public bool RemoveAppointLog(int id)
        {
            string sqlStr = "DeleteBookAppointLog";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@returnValue",MySqlDbType.Int32,1),
                new MySqlParameter("@Id",id),
            };
            para[0].Direction = ParameterDirection.Output;//将第一个变量设为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
            return para[0].Value.ToString() == "1";
        }
        #endregion

        #region 图书归还
        /// <summary>
        /// 获取借阅记录编号中的书籍编号
        /// </summary>
        /// <param name="Id">借阅记录编号</param>
        /// <returns>书籍编号</returns>
        public int GetBorrowLogBookNum(int Id)
        {
            string sqlstr = " SELECT " +
                " tb_BookBorrowLog.BookId AS 编号 " +
                " FROM " +
                " tb_BookBorrowLog " +
                " WHERE tb_BookBorrowLog.Id = @Id ;";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                 new MySqlParameter("@Id", Id),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            if (dataTable.Rows.Count <= 0)
            {
                return -1;
            }
            DataRow row = dataTable.Rows[0];
            return (int)row["编号"];
        }

        /// <summary>
        /// 归还借阅记录所对应的图书
        /// </summary>
        /// <param name="Id">借阅记录编号</param>
        /// <returns>借阅成功与否</returns>
        public bool ReturnBorrowedBook(int Id)
        {
            string sqlStr = "ReturnBorrowedBook";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@returnValue",MySqlDbType.Int32,1),
                new MySqlParameter("@Id",Id),
            };
            para[0].Direction = ParameterDirection.Output;//将第一个变量设为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
            return para[0].Value.ToString() == "1";
        }

        #endregion

        #region 图书损坏
        /// <summary>
        /// 获取全部未处理图书损坏记录
        /// </summary>
        /// <returns>图书损坏记录</returns>
        public DataTable GetDamageLog()
        {
            string sqlstr = " SELECT " +
                " tb_BookDamageLog.Id AS `编号`, " +
                " tb_CirculateBooks.OfficialTitle AS `书名`, " +
                " tb_BasicInformation.UserName AS `检查人 `, " +
                " tb_BookDamageLog.CheckTime AS `检查时间`, " +
                " tb_BookDamageLog.DamageDetail AS `损坏详细信息`  " +
                " FROM " +
                " tb_BookDamageLog " +
                " INNER JOIN tb_BasicInformation ON tb_BookDamageLog.CheckerId = tb_BasicInformation.UserId " +
                " INNER JOIN tb_CirculateBooks ON tb_BookDamageLog.BookId = tb_CirculateBooks.Id ;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 更改损坏状态
        /// </summary>
        /// <param name="log">图书损坏记录</param>
        /// <returns>更改成功与否</returns>
        public bool UpdateDamageLog(BookDamageLog log)
        {
            string sqlStr = "UPDATE tb_BookDamageLog SET " +
                "RepairState=@state " +
                "where Id=@id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@state",log.RepairState),
                new MySqlParameter("@id",log.Id),
            };
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 增加书籍损坏记录
        /// </summary>
        /// <param name="log">损坏记录</param>
        /// <returns>损坏记录</returns>
        public bool AddDamageLog(BookDamageLog log)
        {
            string sqlStr = "INSERT INTO tb_BookDamageLog (" +
                "BookId," +
                "CheckerId," +
                "CheckTime," +
                "DamageDetail," +
                "RepairState" +
                ") " +
                "VALUES(" +
                "@bookId," +
                "@checkerId," +
                "@checkTime," +
                "@damageDetail," +
                "@repairState" +
                ");";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@bookId",log.BookId),
                new MySqlParameter("@checkerId",log.CheckerId),
                new MySqlParameter("@checkTime",log.CheckTime),
                new MySqlParameter("@damageDetail",log.DamageDetail),
                new MySqlParameter("@repairState",log.RepairState),
            };
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 违约处理

        /// <summary>
        /// 获取违约记录
        /// </summary>
        /// <param name="readerId">读者编号</param>
        /// <returns>违约记录</returns>
        public DataTable GetDisHonestyLog(int readerId)
        {
            string strSql = " SELECT " +
                " tb_DishonestyLog.Id AS `编号`, " +
                " tb_BasicInformation.UserName AS `读者姓名`, " +
                " tb_CirculateBooks.OfficialTitle AS `书名`, " +
                " tb_DishonestyLog.DishonestyTime AS `违约时间`, " +
                " tb_DishonestyLog.PenaltyMultiple AS `罚金倍数`, " +
                " tb_DishonestyLog.State AS `状态`  " +
                " FROM " +
                " tb_DishonestyLog " +
                " INNER JOIN tb_BasicInformation ON tb_DishonestyLog.ReaderId = tb_BasicInformation.UserId " +
                " INNER JOIN tb_CirculateBooks ON tb_DishonestyLog.BookId = tb_CirculateBooks.Id " +
                "WHERE tb_DishonestyLog.ReaderId = @readerId;"; 
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@readerId", readerId),
            };
            DataTable dataTable = helper.ExecuteQuery(strSql, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 获取违约记录书籍编号
        /// </summary>
        /// <param name="Id">编号</param>
        /// <returns>书籍编号</returns>
        public int GetDisHonestyLogBookId(int Id)
        {
            string strSql = " SELECT " +
                " tb_DishonestyLog.BookId AS `编号`"+
                " FROM " +
                " tb_DishonestyLog "+
                "WHERE tb_DishonestyLog.Id = @Id;"; 
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@Id", Id),
            };
            DataTable dataTable = helper.ExecuteQuery(strSql, paras, CommandType.Text);
            if (dataTable.Rows.Count <= 0)
            {
                return -1;
            }
            return (int)dataTable.Rows[0]["编号"];
        }
        #endregion
        /// <summary>
        /// 根据读者借书证号获取读者编号
        /// </summary>
        /// <param name="num">借书证号</param>
        /// <returns>读者编号</returns>
        public int GetReaderIdByNum(string num)
        {
            string sqlStr = "select UserId from tb_ReaderInformation where LibraryCardNum=@number";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                 new MySqlParameter("@number", num),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, paras, CommandType.Text);
            if (dataTable.Rows.Count <= 0)
            {
                return -1;
            }
            return (int)dataTable.Rows[0]["UserId"];
        }

        /// <summary>
        /// 获取读者
        /// </summary>
        /// <param name="id">读者Id</param>
        /// <returns>读者</returns>
        public Reader GetReaderById(int id)
        {
            string sqlStr = "GetReaderInfo";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@readerId",id),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, paras, CommandType.StoredProcedure);
            if (dataTable.Rows.Count <= 0)
                return new Reader();
            DataRow row = dataTable.Rows[0];
            Reader reader = new Reader()
            {
                Id = int.Parse(row["编号"].ToString()),
                Name = row["姓名"].ToString(),
                BitSex = int.Parse(row["性别"].ToString()),
                Department = row["单位"].ToString(),
                BorrowNum = int.Parse(row["可借数目"].ToString()),
                AppointNum = int.Parse(row["可预约数"].ToString()),
                ValidityTerm = int.Parse(row["有效期"].ToString()),
                ForfeitMultiples = double.Parse(row["罚金倍数"].ToString()),
                ExtendedForfeit = double.Parse(row["待缴罚金"].ToString()),
            };
            return reader;
        }

        /// <summary>
        /// 获取图书
        /// </summary>
        /// <param name="id">图书Id</param>
        /// <param name="isBorrowOrReturn">是否为借书部分</param>
        /// <returns>图书</returns>
        public Book GetBookById(int id, bool isBorrowOrReturn = true)
        {
            string sqlStr = " SELECT " +
                " tb_CirculateBooks.Id AS `图书编号`, " +
                " tb_CirculateBooks.ISBN AS ISBN, " +
                " tb_CirculateBooks.OfficialTitle AS `题目名称`, " +
                " tb_CirculateBooks.FirstAuthor AS `第一作者`, " +
                " tb_CirculateBooks.PublishingHouseId AS `出版社编号`, " +
                " tb_CirculateBooks.DocumentType AS `文献类型`, " +
                " tb_CirculateBooks.BookStatus AS `图书状态`  " +
                " FROM " +
                " tb_CirculateBooks  " +
                " WHERE " +
                " tb_CirculateBooks.Id = @bookId ";
            if (isBorrowOrReturn)
            {
                sqlStr = sqlStr + " AND tb_CirculateBooks.BookStatus = '可借阅' ;";
            }
            else
            {
                sqlStr = sqlStr + ";";
            }
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@bookId",id),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, paras, CommandType.Text);
            if (dataTable.Rows.Count <= 0)
                return new Book();
            DataRow row = dataTable.Rows[0];
            Book book = new Book()
            {
                Id = int.Parse(row["图书编号"].ToString()),
                ISBN = row["ISBN"].ToString(),
                OfficialTitle = row["题目名称"].ToString(),
                FirstAuthor = row["第一作者"].ToString(),
                PublishingHouseId = int.Parse(row["出版社编号"].ToString()),
                DocumentType = row["文献类型"].ToString(),
                BookStatus = row["图书状态"].ToString(),
            };
            return book;
        }

        /// <summary>
        /// 自动处理超期预约和借阅
        /// </summary>
        public void DealAllLog()
        {
            string sqlStr = "DealAllBookLog";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[] { };
            helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
        }
    }
}
