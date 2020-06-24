using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 采访清单
    /// </summary>
    public class InterviewList
    {
        /// <summary>
        /// 清单号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// ISBN号
        /// </summary>
        public string ISBN = "";

        /// <summary>
        /// 作者
        /// </summary>
        public string Author = "";

        /// <summary>
        /// 书名
        /// </summary>
        public string BookName = "";

        /// <summary>
        /// 价格
        /// </summary>
        public double Price = 0;

        /// <summary>
        /// 货币种类
        /// </summary>
        public string CurrencyType = "";

        /// <summary>
        /// 征订册数
        /// </summary>
        public int SubscriptionNum = 0;

        /// <summary>
        /// 出版社ID
        /// </summary>
        public int PublishingHouseId = 0;

        /// <summary>
        /// 文献类型
        /// </summary>
        public string DocumentType = "";

        /// <summary>
        /// 订购状态
        /// </summary>
        public string OrderStatus = "";

        /// <summary>
        /// 判断清单是否有空项
        /// </summary>
        /// <param name="list">待判断清单</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(InterviewList list)
        {
            if (list.ISBN == "")
            {
                return true;
            }
            if (list.Author == "")
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
            if (list.CurrencyType == "")
            {
                return true;
            }
            if (list.SubscriptionNum == 0)
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
            if (list.OrderStatus == "")
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
        public static bool isNormative(InterviewList list, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            if (list.Id < 0)
            {
                errorList.Add("Id Error");
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
            Match matchCurrentType = Regex.Match(list.CurrencyType, @"\b(人民币￥|美元＄)\b");
            if (!matchCurrentType.Success)
            {
                errorList.Add("CurrentType Error");
            }
            if (list.SubscriptionNum <= 0)
            {
                errorList.Add("SubscriptionNum Error");
            }
            if (list.PublishingHouseId <= 0)
            {
                errorList.Add("PublishingHouseId Error");
            }
            Match matchDocumentType = Regex.Match(list.DocumentType, @"\b(期刊|专著|论文|电子文献|专利)\b");
            if (!matchDocumentType.Success)
            {
                errorList.Add("DocumentType Error");
            }
            Match matchOrderStatus = Regex.Match(list.OrderStatus, @"\b(采访|验收)\b");
            if (!matchOrderStatus.Success)
            {
                errorList.Add("OrderStatus Error");
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
