using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 期刊登到记录
    /// </summary>
    public class PeriodicalArrival
    {
        /// <summary>
        /// 登到记录编号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// 订单编号
        /// </summary>
        public int OrderId = 0;

        /// <summary>
        /// 登到状态
        /// </summary>
        public string State = "";


        /// <summary>
        /// 判断订单是否有空项
        /// </summary>
        /// <param name="arrival">待判断订单</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(PeriodicalArrival arrival)
        {
            if (arrival.OrderId == 0)
            {
                return true;
            }
            if (arrival.State == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断订单是否规范
        /// </summary>
        /// <param name="arrival">待判断订单</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>
        public static bool isNormative(PeriodicalArrival arrival, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            if (arrival.OrderId <= 0)
            {
                errorList.Add("OrderId Error");
            }
            Match matchState = Regex.Match(arrival.State, @"(完好|退回|待退)");
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
