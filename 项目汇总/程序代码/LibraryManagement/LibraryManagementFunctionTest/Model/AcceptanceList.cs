using System.Collections.Generic;

namespace LibraryManagementFunctionTest.Model
{
    /// <summary>
    /// 验收清单
    /// </summary>
    public class AcceptanceList
    {
        /// <summary>
        /// 验收单号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// 书商编号
        /// </summary>
        public int BookSellerId = 0;

        /// <summary>
        /// 出版社编号
        /// </summary>
        public int PublishingHouseId = 0;

        /// <summary>
        /// 订购人编号
        /// </summary>
        public int OrdererId = 0;

        /// <summary>
        /// 验收人编号
        /// </summary>
        public int AcceptorId = 0;

        /// <summary>
        /// 文献类型
        /// </summary>
        public string DocumentType = "";

        /// <summary>
        /// 判断清单是否有空项
        /// </summary>
        /// <param name="list">待判断清单</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(AcceptanceList list)
        {
            if (list.BookSellerId == 0)
            {
                return true;
            }
            if (list.PublishingHouseId == 0)
            {
                return true;
            }
            if (list.OrdererId == 0)
            {
                return true;
            }
            if (list.AcceptorId == 0)
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
        public static bool isNormative(AcceptanceList list, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            if (list.Id < 0)
            {
                errorList.Add("Id Error");
            }
            if (list.BookSellerId < 0)
            {
                errorList.Add("BookSellerId Error");
            }
            if (list.PublishingHouseId < 0)
            {
                errorList.Add("PublishingHouseId Error");
            }
            if (list.OrdererId < 0)
            {
                errorList.Add("OrdererId Error");
            }
            if (list.AcceptorId < 0)
            {
                errorList.Add("AcceptorId Error");
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
