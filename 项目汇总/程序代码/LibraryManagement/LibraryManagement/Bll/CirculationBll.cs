using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.Bll
{
    /// <summary>
    /// 流通用户操作类
    /// </summary>
    public class CirculationBll
    {
        /// <summary>
        /// 流通用户操作对象
        /// </summary>
        CirculationDal circulationDal = new CirculationDal();

        #region 图书借阅
        /// <summary>
        /// 获取全部借阅记录
        /// </summary>
        /// <returns>全部借阅记录</returns>
        public DataTable GetBorrowLog()
        {
            DataTable result = null;
            try
            {
                result = circulationDal.GetBorrowLog();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取某人全部借阅记录
        /// </summary>
        /// <param name="readerId">读者编号</param>
        /// <param name="bookId">书籍编号</param>
        /// <returns>某人全部借阅记录</returns>
        public DataTable GetBorrowLogByReader(int readerId, string bookId)
        {
            DataTable result = null;
            try
            {
                result = circulationDal.GetBorrowLogByReader(readerId, bookId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取某人全部借阅记录列表
        /// </summary>
        /// <param name="readerId">读者编号</param>
        /// <param name="bookId">书籍编号</param>
        /// <returns>某人全部借阅记录列表</returns>
        public IEnumerable GetBorrowLogByReaderArray(int readerId, string bookId)
        {
            List<BookBorrowLog> result = new List<BookBorrowLog>();
            try
            {
                DataTable datatable = circulationDal.GetBorrowLogByReader(readerId, bookId);
                foreach (DataRow dr in datatable.Rows)
                {
                    BookBorrowLog log = new BookBorrowLog()
                    {
                        Id = (int)dr["编号"],
                        BorrowTime = (DateTime)dr["借阅时间"],                        
                    };
                    result.Add(log);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        /// <summary>
        /// 借阅图书
        /// </summary>
        /// <param name="log"></param>        
        /// <param name="errorMsg">错误</param>
        /// <returns>增加成功与否</returns>
        public bool AddBorrowLog(BookBorrowLog log, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!BookBorrowLog.isNull(log))//是否有空项
                {
                    if (BookBorrowLog.isNormative(log, ref errorMsg))//是否符合规范
                    {
                        result = circulationDal.AddBorrowLog(log);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 删除借阅图书记录
        /// </summary>
        /// <param name="id">记录id</param>
        /// <returns>增加成功与否</returns>
        public bool RemoveBorrowLog(int id)
        {
            bool result = false;
            try
            {
                result = circulationDal.RemoveBorrowLog(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
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
            DataTable result = null;
            try
            {
                result = circulationDal.GetAppointLogByReader(readerId, bookId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }


        /// <summary>
        /// 预约图书
        /// </summary>
        /// <param name="log"></param>        
        /// <param name="errorMsg">错误</param>
        /// <returns>增加成功与否</returns>
        public bool AddAppointLog(BookAppointLog log, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!BookAppointLog.isNull(log))//是否有空项
                {
                    if (BookAppointLog.isNormative(log, ref errorMsg))//是否符合规范
                    {
                        result = circulationDal.AddAppointLog(log);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 删除预约图书记录
        /// </summary>
        /// <param name="id">记录id</param>
        /// <returns>增加成功与否</returns>
        public bool RemoveAppointLog(int id)
        {
            bool result = false;
            try
            {
                result = circulationDal.RemoveAppointLog(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
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
            int result = -1;
            try
            {
                result = circulationDal.GetBorrowLogBookNum(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 归还借阅记录所对应的图书
        /// </summary>
        /// <param name="Id">借阅记录编号</param>
        /// <returns>借阅成功与否</returns>
        public bool ReturnBorrowedBook(int Id)
        {
            bool result = false;
            try
            {
                result = circulationDal.ReturnBorrowedBook(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }
        #endregion

        #region 图书损坏
        /// <summary>
        /// 获取全部未处理图书损坏记录
        /// </summary>
        /// <returns>图书损坏记录</returns>
        public DataTable GetDamageLog()
        {
            DataTable result = null;
            try
            {
                result = circulationDal.GetDamageLog();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 更改损坏状态
        /// </summary>
        /// <param name="log">图书损坏记录</param>
        /// <returns>更改成功与否</returns>
        public bool UpdateDamageLog(BookDamageLog log)
        {
            bool result;
            try
            {
                result = circulationDal.UpdateDamageLog(log);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 增加书籍损坏记录
        /// </summary>
        /// <param name="log">损坏记录</param>
        /// <returns>损坏记录</returns>
        public bool AddDamageLog(BookDamageLog log, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!BookDamageLog.isNull(log))//是否有空项
                {
                    if (BookDamageLog.isNormative(log, ref errorMsg))//是否符合规范
                    {
                        result = circulationDal.AddDamageLog(log);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
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
            DataTable result = null;
            try
            {
                result = circulationDal.GetDisHonestyLog(readerId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        
        /// <summary>
        /// 获取违约记录书籍编号
        /// </summary>
        /// <param name="Id">编号</param>
        /// <returns>书籍编号</returns>
        public int GetDisHonestyLogBookId(int Id)
        {
            int result = -1;
            try
            {
                result = circulationDal.GetDisHonestyLogBookId(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// 罚金已收到
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool MoneyReceived(int Id)
        {
            bool result = false;
            try
            {
                result = circulationDal.MoneyReceived(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 书本已收到
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool BookReceived(int Id)
        {
            bool result = false;
            try
            {
                result = circulationDal.BookReceived(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// 书籍丢失
        /// </summary>
        /// <param name="Id">书籍丢失</param>
        /// <returns></returns>
        public bool BookLost(int Id)
        {
            bool result = false;
            try
            {
                result = circulationDal.BookLost(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }
        #endregion

        /// <summary>
        /// 根据读者借书证号获取读者编号
        /// </summary>
        /// <param name="num">借书证号</param>
        /// <returns>读者编号</returns>
        public int GetReaderIdByNum(string num)
        {
            int result = -1;
            try
            {
                result = circulationDal.GetReaderIdByNum(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 获取读者
        /// </summary>
        /// <param name="id">读者Id</param>
        /// <returns>读者</returns>
        public Reader GetReaderById(int id)
        {
            Reader result = null;
            try
            {
                result = circulationDal.GetReaderById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 获取图书
        /// </summary>
        /// <param name="id">图书Id</param>
        /// <param name="isBorrowOrReturn">是否为借书部分</param>
        /// <returns>图书</returns>
        public Book GetBookById(int id, bool isBorrowOrReturn = true)
        {
            Book result = null;
            try
            {
                result = circulationDal.GetBookById(id, isBorrowOrReturn);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 自动处理超期预约和借阅
        /// </summary>
        public void DealAllLog()
        {
            try
            {
                circulationDal.DealAllLog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
