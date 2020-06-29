using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 退货清单
    /// </summary>
    public class InterviewReturnList
    {
        /// <summary>
        /// 单号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// 订单日期
        /// </summary>
        public DateTime SubDate = DateTime.Now;

        /// <summary>
        /// ISBN号
        /// </summary>
        public string ISBN = "";

        /// <summary>
        /// 订购人ID
        /// </summary>
        public int OrdererId = 0;

        /// <summary>
        /// 书名
        /// </summary>
        public string BookName = "";

        /// <summary>
        /// 价格
        /// </summary>
        public double Price = 0;

        /// <summary>
        /// 出版社ID
        /// </summary>
        public int PublishingHouseId = 0;

        /// <summary>
        /// 文献类型
        /// </summary>
        public string DocumentType = "";

        /// <summary>
        /// 判断清单是否有空项
        /// </summary>
        /// <param name="list">待判断清单</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(InterviewReturnList list)
        {
            if (list.ISBN == "")
            {
                return true;
            }
            if (list.OrdererId == 0)
            {
                return true;
            }
            if (list.BookName == "")
            {
                return true;
            }
            if (list.Price == 0)
            {
                return true;
            }
            if (list.PublishingHouseId == 0)
            {
                return true;
            }
            if (list.DocumentType == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断清单是否规范
        /// </summary>
        /// <param name="list">待判断清单</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>
        public static bool isNormative(InterviewReturnList list, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            if (list.OrdererId <= 0)
            {
                errorList.Add("OrdererId Error");
            }
            Match matchISBN = Regex.Match(list.ISBN, @"^(\d{10})$");
            if (!matchISBN.Success)
            {
                errorList.Add("ISBN Error");
            }
            if (list.Price <= 0)
            {
                errorList.Add("Price Error");
            }
            if (list.PublishingHouseId <= 0)
            {
                errorList.Add("PublishingHouseId Error");
            }
            Match matchDocumentType = Regex.Match(list.DocumentType,  @"^(期刊|专著|论文|电子文献|专利)$");
            if (!matchDocumentType.Success)
            {
                errorList.Add("DocumentType Error");
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
