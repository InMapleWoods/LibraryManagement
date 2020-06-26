using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibraryManagementFunctionTest.Model
{
    /// <summary>
    /// 采购订单
    /// </summary>
    public class InterviewPurchaseOrder
    {
        /// <summary>
        /// 订单号
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
        /// 货币种类
        /// </summary>
        public string CurrencyType = "";

        /// <summary>
        /// 出版社ID
        /// </summary>
        public int PublishingHouseId = 0;

        /// <summary>
        /// 文献类型
        /// </summary>
        public string DocumentType = "";

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark = "";

        /// <summary>
        /// 判断订单是否有空项
        /// </summary>
        /// <param name="order">待判断订单</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(InterviewPurchaseOrder order)
        {
            if(order.ISBN == "")
            {
                return true;
            }
            if(order.OrdererId == 0)
            {
                return true;
            }
            if(order.BookName == "")
            {
                return true;
            }
            if(order.Price == 0)
            {
                return true;
            }
            if (order.CurrencyType == "")
            {
                return true;
            }
            if (order.PublishingHouseId == 0)
            {
                return true;
            }
            if(order.DocumentType == "")
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
        public static bool isNormative(InterviewPurchaseOrder order , ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            if (order.OrdererId <= 0)
            {
                errorList.Add("OrdererId Error");
            }
            Match matchISBN = Regex.Match(order.ISBN, @"^(\d{10})$");
            if (!matchISBN.Success)
            {
                errorList.Add("ISBN Error");
            }
            if(order.Price <= 0)
            {
                errorList.Add("Price Error");
            }
            if (order.PublishingHouseId <= 0)
            {
                errorList.Add("PublishingHouseId Error");
            }
            Match matchDocumentType = Regex.Match(order.DocumentType, @"\b(期刊|专著|论文|电子文献|专利)\b");
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
