﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 书商字典
    /// </summary>
    public class DictionaryBookSeller
    {
        /// <summary>
        /// 书商编号
        /// </summary>
        public int Id;
        /// <summary>
        /// 书商名字
        /// </summary>
        public string BookSeller;
        /// <summary>
        /// 地址
        /// </summary>
        public string Location;
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact;
        /// <summary>
        /// 电话
        /// </summary>
        public string CallNumber;
        /// <summary>
        /// 邮编
        /// </summary>
        public int PostCodes;
        /// <summary>
        /// 开户行
        /// </summary>
        public string BankName;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark;
        /// <summary>
        /// 判断是否有空值
        /// </summary>
        /// <param name="bookseller">书商字典项</param>
        /// <returns></returns>
        public static bool isNull(DictionaryBookSeller bookseller)
        {

            if (bookseller.BookSeller == "")
            {
                return true;
            }
            if (bookseller.Location == "")
            {
                return true;
            }
            if (bookseller.Contact == "")
            {
                return true;
            }
            if (bookseller.CallNumber == "")
            {
                return true;
            }
            if (bookseller.PostCodes == 0)
            {
                return true;
            }
            if (bookseller.BankName == "")
            {
                return true;
            }
            return false;
        }
        public static bool isNormative(DictionaryBookSeller bookseller, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            if (bookseller.Id <= 0)
            {
                errorList.Add("BookSellerId Error");
            }
            Match matchCallNumber = Regex.Match(bookseller.CallNumber, @"^(\d{1,11})$");
            if (!matchCallNumber.Success)
            {
                errorList.Add("CallNumber Error");
            }
            Match matchPostCodes = Regex.Match(bookseller.PostCodes.ToString(), @"^(\d{5,6})$");
            if (!matchPostCodes.Success)
            {
                errorList.Add("CallNumber Error");
            }
            if (errorList.Count > 0)
            {
                return true;
            }
            errorMsg = errorList;
            return false;
        }
    }
}
