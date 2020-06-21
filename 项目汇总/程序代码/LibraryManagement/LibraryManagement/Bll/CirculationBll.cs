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
        /// 期刊数据操作对象
        /// </summary>
        CirculationDal circulationDal = new CirculationDal();

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
        /// <returns>图书</returns>
        public Book GetBookById(int id)
        {
            Book result = null;
            try
            {
                result = circulationDal.GetBookById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }
    }
}
