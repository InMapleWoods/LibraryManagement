using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
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
    }
}
