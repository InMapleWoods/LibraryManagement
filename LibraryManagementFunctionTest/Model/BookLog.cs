using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryManagementFunctionTest.Model
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
        /// 判断记录是否有空项
        /// </summary>
        /// <param name="log">待判断记录</param>
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
        /// 判断记录是否规范
        /// </summary>
        /// <param name="log">待判断记录</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>
        public static bool isNormative(BookBorrowLog log, ref List<string> errorMsg)
        {
            List<string> errorlog = new List<string>();
            if (log.ReaderId <= 0)
            {
                errorlog.Add("ReaderId Error");
            }
            if (log.BookId <= 0)
            {
                errorlog.Add("BookId Error");
            }
            Match matchState = Regex.Match(log.State, @"^(有效|失效)$");
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

    /// <summary>
    /// 预约记录
    /// </summary>
    public class BookAppointLog
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
        /// 预约时间
        /// </summary>
        public DateTime AppointmentTime = DateTime.Now;

        /// <summary>
        /// 到期时间
        /// </summary>
        public DateTime ExpireDate = DateTime.Now;

        /// <summary>
        /// 预约状态
        /// </summary>
        public string State = "";

        /// <summary>
        /// 判断记录是否有空项
        /// </summary>
        /// <param name="log">待判断记录</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(BookAppointLog log)
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
        /// 判断记录是否规范
        /// </summary>
        /// <param name="log">待判断记录</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>
        public static bool isNormative(BookAppointLog log, ref List<string> errorMsg)
        {
            List<string> errorlog = new List<string>();
            if (log.ReaderId <= 0)
            {
                errorlog.Add("ReaderId Error");
            }
            if (log.BookId <= 0)
            {
                errorlog.Add("BookId Error");
            }
            Match matchState = Regex.Match(log.State, @"^(有效|失效)$");
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

    public class BookDamageLog
    {
        /// <summary>
        /// 损坏记录编号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// 书籍编号
        /// </summary>
        public int BookId = 0;

        /// <summary>
        /// 检查人员编号
        /// </summary>
        public int CheckerId = 0;

        /// <summary>
        /// 检查时间
        /// </summary>
        public DateTime CheckTime = DateTime.Now;

        /// <summary>
        /// 损坏详情
        /// </summary>
        public string DamageDetail = string.Empty;

        /// <summary>
        /// 处理状态
        /// </summary>
        public string RepairState = string.Empty;

        /// <summary>
        /// 判断记录是否有空项
        /// </summary>
        /// <param name="log">待判断记录</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(BookDamageLog log)
        {
            if (log.BookId == 0)
            {
                return true;
            }
            if (log.CheckerId == 0)
            {
                return true;
            }
            if (string.IsNullOrEmpty(log.DamageDetail))
            {
                return true;
            }
            if (string.IsNullOrEmpty(log.RepairState))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断记录是否规范
        /// </summary>
        /// <param name="log">待判断记录</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>
        public static bool isNormative(BookDamageLog log, ref List<string> errorMsg)
        {
            List<string> errorlog = new List<string>();
            if (log.BookId == 0)
            {
                errorlog.Add("BookId Error");
            }
            if (log.CheckerId == 0)
            {
                errorlog.Add("CheckerId Error");
            }
            Match matchDamageDetail = Regex.Match(log.DamageDetail, @"^(.*)$");
            if (!matchDamageDetail.Success)
            {
                errorlog.Add("DamageDetail Error");
            }
            Match matchRepairState = Regex.Match(log.RepairState, @"^(已修复|待修复|修复失败)$");
            if (!matchRepairState.Success)
            {
                errorlog.Add("RepairState Error");
            }
            errorMsg = errorlog;
            if (errorlog.Count > 0)
            {
                return false;
            }
            return true;
        }
    }

    public class DisHonestyLog
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// 读者Id
        /// </summary>
        public int ReaderId = 0;

        /// <summary>
        /// 书籍Id
        /// </summary>
        public int BookId = 0;

        /// <summary>
        /// 违约时间
        /// </summary>
        public DateTime DishonestyTime = DateTime.Now;

        /// <summary>
        /// 罚金倍数
        /// </summary>
        public double PenaltyMultiple = 1;

        /// <summary>
        /// 处理状态
        /// </summary>
        public string State = "";

        /// <summary>
        /// 判断记录是否有空项
        /// </summary>
        /// <param name="log">待判断记录</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(DisHonestyLog log)
        {
            if (log.BookId == 0)
            {
                return true;
            }
            if (log.ReaderId == 0)
            {
                return true;
            }
            if (log.PenaltyMultiple == 1)
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
        /// 判断记录是否规范
        /// </summary>
        /// <param name="log">待判断记录</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>
        public static bool isNormative(DisHonestyLog log, ref List<string> errorMsg)
        {
            List<string> errorlog = new List<string>();
            if (log.BookId <= 0)
            {
                errorlog.Add("BookId Error");
            }
            if (log.ReaderId <= 0)
            {
                errorlog.Add("ReaderId Error");
            }
            if (log.PenaltyMultiple <= 0)
            {
                errorlog.Add("PenaltyMultiple Error");
            }
            Match matchState = Regex.Match(log.State, @"^(待处理|未交书|未缴费|已处理)$");
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
