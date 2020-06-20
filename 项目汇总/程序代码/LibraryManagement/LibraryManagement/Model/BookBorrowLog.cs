﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 借阅记录
    /// </summary>
    public class BookBorrowLog
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// 读者编号
        /// </summary>
        public int ReaderId = 0;

        /// <summary>
        /// 书籍编号
        /// </summary>
        public int BookId = 0;

        /// <summary>
        /// 借阅时间
        /// </summary>
        public DateTime BorrowTime = DateTime.Now;

        /// <summary>
        /// 借阅记录状态
        /// </summary>
        public string State = "";

        /// <summary>
        /// 判断列表是否有空项
        /// </summary>
        /// <param name="log">待判断列表</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(BookBorrowLog log)
        {
            if (log.ReaderId == 0)
            {
                return true;
            }
            if (log.BookId == 0)
            {
                return true;
            }
            if (string.IsNullOrEmpty(log.State))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 判断编目是否规范
        /// </summary>
        /// <param name="log">待判断订单</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>

        public static bool isNormative(BookBorrowLog log, ref List<string> errorMsg)
        {
            List<string> errorlog = new List<string>();
            if (log.ReaderId == 0)
            {
                errorlog.Add("ReaderId Error");
            }
            if (log.BookId == 0)
            {
                errorlog.Add("BookId Error");
            }
            Match matchState = Regex.Match(log.State, @"(有效|无效)");
            if (!matchState.Success)
            {
                errorlog.Add("State Error");
            }
            errorMsg = errorlog;
            if (errorlog.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
