using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryManagementFunctionTest.Model
{
    /// <summary>
    /// 期刊订单
    /// </summary>
    public class PeriodicalOrder
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// 书商编号
        /// </summary>
        public int BookSellerId = 0;

        /// <summary>
        /// 订购日期
        /// </summary>
        public DateTime OrderDate = DateTime.Now;

        /// <summary>
        /// 订购人编号
        /// </summary>
        public int OrdererId = 0;

        /// <summary>
        /// ISBN号
        /// </summary>
        public string ISBN = "";

        /// <summary>
        /// 文献类型
        /// </summary>
        public string DocumentType = "";

        /// <summary>
        /// 出版周期
        /// </summary>
        public string PublishCycle = "";

        /// <summary>
        /// 正刊名
        /// </summary>
        public string OfficialTitle = "";

        /// <summary>
        /// 副刊名
        /// </summary>
        public string SupplementTitle = "";

        /// <summary>
        /// 出版社编号
        /// </summary>
        public int PublishingHouseId = 0;

        /// <summary>
        /// 订购价
        /// </summary>
        public double OrderPrice = 0.0;

        /// <summary>
        /// 币种
        /// </summary>
        public string CurrencyType = "";

        /// <summary>
        /// 尺寸
        /// </summary>
        public string Size = "";

        /// <summary>
        /// 判断订单是否有空项
        /// </summary>
        /// <param name="order">待判断订单</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(PeriodicalOrder order)
        {
            if (order.BookSellerId == 0)
            {
                return true;
            }
            if (order.OrdererId == 0)
            {
                return true;
            }
            if (order.ISBN == "")
            {
                return true;
            }
            if (order.DocumentType == "")
            {
                return true;
            }
            if (order.PublishCycle == "")
            {
                return true;
            }
            if (order.OfficialTitle == "")
            {
                return true;
            }
            if (order.SupplementTitle == "")
            {
                return true;
            }
            if (order.PublishingHouseId == 0)
            {
                return true;
            }
            if (order.OrderPrice == 0.0)
            {
                return true;
            }
            if (order.CurrencyType == "")
            {
                return true;
            }
            if (order.Size == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断订单是否规范
        /// </summary>
        /// <param name="order">待判断订单</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>
        public static bool isNormative(PeriodicalOrder order, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            if (order.BookSellerId <= 0)
            {
                errorList.Add("BookSellerId Error");
            }
            if (order.OrdererId <= 0)
            {
                errorList.Add("OrdererId Error");
            }
            Match matchISBN = Regex.Match(order.ISBN, @"^(\d{10})$");
            if (!matchISBN.Success)
            {
                errorList.Add("ISBN Error");
            }
            Match matchDocumentType = Regex.Match(order.DocumentType, @"\b(期刊|专著)\b");
            if (!matchDocumentType.Success)
            {
                errorList.Add("DocumentType Error");
            }
            Match matchPublishCycle = Regex.Match(order.PublishCycle, @"\b(周刊|半月刊|月刊|季刊|年刊)\b");
            if (!matchPublishCycle.Success)
            {
                errorList.Add("PublishCycle Error");
            }
            Match matchOfficialTitle = Regex.Match(order.OfficialTitle, @"(.*)");
            if (!matchOfficialTitle.Success)
            {
                errorList.Add("OfficialTitle Error");
            }
            Match matchSupplementTitle = Regex.Match(order.SupplementTitle, @"(.*)");
            if (!matchSupplementTitle.Success)
            {
                errorList.Add("SupplementTitle Error");
            }
            if (order.PublishingHouseId <= 0)
            {
                errorList.Add("PublishingHouseId Error");
            }
            if (Math.Sign(order.OrderPrice) != 1)
            {
                errorList.Add("OrderPrice Error");
            }
            Match matchCurrencyType = Regex.Match(order.CurrencyType, @"(人民币\(RMB\))|(美元\(USD\))");
            if (!matchCurrencyType.Success)
            {
                errorList.Add("CurrencyType Error");
            }
            Match matchSize = Regex.Match(order.Size, @"\b(A4|A3|16开)\b");
            if (!matchSize.Success)
            {
                errorList.Add("Size Error");
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
