using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryManagement.Model
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
        /// 订单编号
        /// </summary>
        public int OrderId = 0;

        /// <summary>
        /// 验收人编号
        /// </summary>
        public int AcceptorId = 0;

        /// <summary>
        /// 状态
        /// </summary>
        public string State = "";

        /// <summary>
        /// 判断清单是否有空项
        /// </summary>
        /// <param name="list">待判断清单</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(AcceptanceList list)
        {
            if (list.OrderId == 0)
            {
                return true;
            }
            if (list.AcceptorId == 0)
            {
                return true;
            }
            if (list.State == "")
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
            if (list.OrderId < 0)
            {
                errorList.Add("OrderId Error");
            }
            if (list.AcceptorId < 0)
            {
                errorList.Add("AcceptorId Error");
            }
            Match matchState = Regex.Match(list.State,  @"^(已编目|未处理)$");
            if (!matchState.Success)
            {
                errorList.Add("State Error");
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
