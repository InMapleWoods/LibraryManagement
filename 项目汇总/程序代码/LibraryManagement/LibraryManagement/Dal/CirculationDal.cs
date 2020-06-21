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
    /// 流通子系统数据操作类
    /// </summary>
    public class CirculationDal
    {
        /// <summary>
        /// 工具对象
        /// </summary>
        private SQLHelper helper = new SQLHelper();

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
                new MySqlParameter("@returnValue",MySqlDbType.Bit,1),
                new MySqlParameter("@readerId",log.ReaderId),
                new MySqlParameter("@bookId",log.BookId),
                new MySqlParameter("@borrowTime",log.BorrowTime),
            };
            para[0].Direction = ParameterDirection.Output;//将第一个变量设为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
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
                new MySqlParameter("@returnValue",MySqlDbType.Bit,1),
                new MySqlParameter("@Id",id),
            };
            para[0].Direction = ParameterDirection.Output;//将第一个变量设为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
            return para[0].Value.ToString() == "1";
        }

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
            string sqlStr = " SELECT " +
                " tb_ReaderInformation.UserId AS `编号`, " +
                " tb_BasicInformation.UserName AS `姓名`, " +
                " tb_BasicInformation.Gender AS `性别`, " +
                " tb_ReaderDepartment.DepartmentName AS `单位`, " +
                " tb_ReaderLevel.BorrowBookNumber - Count( tb_BookBorrowLog.ReaderId ) AS `可借数目`, " +
                " tb_ReaderLevel.ReserveBookNumber - Count( tb_BookAppointLog.ReaderId ) AS `可预约数`, " +
                " tb_ReaderLevel.BorrowBookDays AS `有效期`, " +
                " tb_ReaderLevel.ForfeitMultiples AS `罚金倍数`, " +
                " tb_ReaderInformation.ExtendedForfeit AS `待缴罚金`  " +
                " FROM " +
                " tb_BasicInformation " +
                " INNER JOIN tb_ReaderInformation ON tb_BasicInformation.UserId = tb_ReaderInformation.UserId " +
                " INNER JOIN tb_ReaderLevel ON tb_ReaderInformation.ReaderLevelId = tb_ReaderLevel.Id " +
                " INNER JOIN tb_ReaderDepartment ON tb_ReaderInformation.DepartmentId = tb_ReaderDepartment.Id " +
                " LEFT JOIN tb_BookBorrowLog ON tb_ReaderInformation.Id = tb_BookBorrowLog.ReaderId " +
                " LEFT JOIN tb_BookAppointLog ON tb_ReaderInformation.Id = tb_BookAppointLog.ReaderId  " +
                " WHERE " +
                " tb_ReaderInformation.UserId = @readerId  " +
                " GROUP BY " +
                " tb_ReaderInformation.Id; ";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@readerId",id),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, paras, CommandType.Text);
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
                AppointNum = int.Parse(row["可借数目"].ToString()),
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
        /// <returns>图书</returns>
        public Book GetBookById(int id)
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
                " tb_CirculateBooks.Id = @bookId "+
                " AND tb_CirculateBooks.BookStatus = '可借阅' ;";
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


    }
}
