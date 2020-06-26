using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 读者级别
    /// </summary>
    class UserManagementReaderLevel
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName = "";

        /// <summary>
        /// 读者编号
        /// </summary>
        public string UserNumber = "";

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Contact = "";

        /// <summary>
        /// 读者级别
        /// </summary>
        public string ReaderLevelName = "";

        /// <summary>
        /// 可借阅图书数目
        /// </summary>
        public string BorrowBookNumber = "";

        /// <summary>
        /// 可预约图书数目
        /// </summary>
        public string ReserveBookNumber = "";

        /// <summary>
        /// 借阅天数
        /// </summary>
        public string BorrowBookDays = "";

        /// <summary>
        /// 可续借天数
        /// </summary>
        public string RenewBookDays = "";

        /// <summary>
        /// 罚款倍数
        /// </summary>
        public string ForfeitMultiples = "";

        /// <summary>
        /// 续借册数
        /// </summary>
        public string RenewBookNumber = "";

        /// <summary>
        /// 判断读者级别信息是否符合规范
        /// </summary>
        /// <param name="level">待判定读者级别</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(UserManagementReaderLevel level)
        {
            if (level.UserName == "")
            {
                return true;
            }
            if (level.UserNumber == "")
            {
                return true;
            }
            if (level.Contact == "")
            {
                return true;
            }
            if (level.ReaderLevelName == "")
            {
                return true;
            }
            if (level.BorrowBookNumber == "")
            {
                return true;
            }
            if (level.ReserveBookNumber == "")
            {
                return true;
            }
            if (level.BorrowBookDays == "")
            {
                return true;
            }
            if (level.RenewBookDays == "")
            {
                return true;
            }
            if (level.ForfeitMultiples == "")
            {
                return true;
            }
            if (level.RenewBookNumber == "")
            {
                return true;
            }
            return false;
        }

        public static bool isNormative(UserManagementReaderLevel level, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            Match matchUserName = Regex.Match(level.UserName, @"\S{2,20}");
            if (!matchUserName.Success)
            {
                errorList.Add("UserName Error");
            }
            Match matchUserNumber = Regex.Match(level.UserNumber, @"(\d{12}|\d{10}|\d{8})");
            if (!matchUserNumber.Success)
            {
                errorList.Add("UserNumber Error");
            }
            Match matchContact = Regex.Match(level.Contact, @"\d{11}");
            if (!matchContact.Success)
            {
                errorList.Add("Contact Error");
            }
            Match matchReaderLevelName = Regex.Match(level.ReaderLevelName, @"\d{1}");
            if (!matchReaderLevelName.Success)
            {
                errorList.Add("ReaderLevelName Error");
            }
            Match matchBorrowBookNumber = Regex.Match(level.BorrowBookNumber, @"\d{1}");
            if (!matchBorrowBookNumber.Success)
            {
                errorList.Add("BorrowBookNumber Error");
            }
            Match matchReserveBookNumber = Regex.Match(level.ReserveBookNumber, @"\d{1}");
            if (!matchReserveBookNumber.Success)
            {
                errorList.Add("ReserveBookNumber Error");
            }
            Match matchBorrowBookDays = Regex.Match(level.BorrowBookDays, @"\d{2}");
            if (!matchBorrowBookDays.Success)
            {
                errorList.Add("BorrowBookDays Error");
            }
            Match matchRenewBookDays = Regex.Match(level.RenewBookDays, @"\d{2}");
            if (!matchRenewBookDays.Success)
            {
                errorList.Add("RenewBookDays Error");
            }
            Match matchForfeitMultiples = Regex.Match(level.ForfeitMultiples, @"\d{1}");
            if (!matchForfeitMultiples.Success)
            {
                errorList.Add("ForfeitMultiples Error");
            }
            Match matchRenewBookNumber = Regex.Match(level.RenewBookNumber, @"\d{1}");
            if (!matchRenewBookNumber.Success)
            {
                errorList.Add("RenewBookNumber Error");
            }
            return true;
        }
    }
}
