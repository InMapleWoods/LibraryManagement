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

        public string ISBN = "";

        public string OfficialTitle = "";

        public string FirstAuthor = "";

        public int PublishingHouseId = 0;

        public string DocumentType = "";

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
            Match matchOfficialTitle = Regex.Match(book.OfficialTitle, @"(.*)");
            if (!matchOfficialTitle.Success)
            {
                errorList.Add("OfficialTitle Error");
            }
            if (book.PublishingHouseId <= 0)
            {
                errorList.Add("PublishingHouseId Error");
            }
            Match matchDocumentType = Regex.Match(book.DocumentType, @"\b(期刊|专著)\b");
            if (!matchDocumentType.Success)
            {
                errorList.Add("DocumentType Error");
            }
            Match matchBookStatus = Regex.Match(book.BookStatus, @"\b(可借阅|已借出|已预约|已丢失)\b");
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
