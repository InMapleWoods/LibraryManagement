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
    }
}
