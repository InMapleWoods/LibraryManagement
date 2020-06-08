using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 采购订单
    /// </summary>
    public class PurchaseOrder
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
        public int Price = 0;

        /// <summary>
        /// 出版社ID
        /// </summary>
        public int PublishingHouseId = 0;

        /// <summary>
        /// 文献类型
        /// </summary>
        public string DocumentType = "";

        /// <summary>
        /// 判断订单是否有空项
        /// </summary>
        /// <param name="order">待判断订单</param>
        /// <returns>是否有空项</returns>
        
        public static bool isNull(PurchaseOrder order)
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
            if(order.PublishingHouseId == 0)
            {
                return true;
            }
            if(order.DocumentType == "")
            {
                return true;
            }
            return false;
        }
    }
}
