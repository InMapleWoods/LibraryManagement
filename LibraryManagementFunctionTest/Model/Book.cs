using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryManagementFunctionTest.Model
{
    /// <summary>
    /// 流通图书
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 图书编号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// ISBN
        /// </summary>
        public string ISBN = "";

        /// <summary>
        /// 题目名称
        /// </summary>
        public string OfficialTitle = "";

        /// <summary>
        /// 第一作者
        /// </summary>
        public string FirstAuthor = "";

        /// <summary>
        /// 出版社编号
        /// </summary>
        public int PublishingHouseId = 0;

        /// <summary>
        /// 文献类型
        /// </summary>
        public string DocumentType = "";

        /// <summary>
        /// 图书状态
        /// </summary>
        public string BookStatus;

        /// <summary>
        /// 判断流通图书是否有空项
        /// </summary>
        /// <param name="book">待判断流通图书</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(Book book)
        {
            if (book.Id == 0)
            {
                return true;
            }
            if (book.ISBN == "")
            {
                return true;
            }
            if (book.OfficialTitle == "")
            {
                return true;
            }
            if (book.FirstAuthor == "")
            {
                return true;
            }
            if (book.PublishingHouseId == 0)
            {
                return true;
            }
            if (book.DocumentType == "")
            {
                return true;
            }
            if (book.BookStatus == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断流通图书是否规范
        /// </summary>
        /// <param name="book">待判断流通图书</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>
        public static bool isNormative(Book book, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            Match matchISBN = Regex.Match(book.ISBN, @"^(\d{10})$");
            if (!matchISBN.Success)
            {
                errorList.Add("ISBN Error");
            }
            Match matchOfficialTitle = Regex.Match(book.OfficialTitle, @"^(.*)$");
            if (!matchOfficialTitle.Success)
            {
                errorList.Add("OfficialTitle Error");
            }
            if (book.PublishingHouseId <= 0)
            {
                errorList.Add("PublishingHouseId Error");
            }
            Match matchDocumentType = Regex.Match(book.DocumentType, @"^(期刊|专著)$");
            if (!matchDocumentType.Success)
            {
                errorList.Add("DocumentType Error");
            }
            Match matchBookStatus = Regex.Match(book.BookStatus, @"^(可借阅|已借出|已预约|已缺失|已合订)$");
            if (!matchBookStatus.Success)
            {
                errorList.Add("BookStatus Error");
            }
            errorMsg = errorList;
            if (errorList.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
