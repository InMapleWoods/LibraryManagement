using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 期刊合订记录
    /// </summary>
    public class PeriodicalBinding
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// 合订期刊编号
        /// </summary>
        public string BindingIdList = "";

        /// <summary>
        /// 流通库编号
        /// </summary>
        public int BookId = 0;

        /// <summary>
        /// 合订名
        /// </summary>
        public string BindingName = "";

        /// <summary>
        /// 判断合订记录是否有空项
        /// </summary>
        /// <param name="binding">待判断合订记录</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(PeriodicalBinding binding)
        {
            if (binding.BindingIdList == "")
            {
                return true;
            }
            if (binding.BindingName == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断合订记录是否规范
        /// </summary>
        /// <param name="binding">待判断合订记录</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>
        public static bool isNormative(PeriodicalBinding binding, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            Match matchBindingIdList = Regex.Match(binding.BindingIdList,                  @"^((\d+)(\|\d+)+)$");
            if (!matchBindingIdList.Success)
            {
                errorList.Add("BindingIdList Error");
            }
            Match matchBindingName = Regex.Match(binding.BindingName,  @"^(.*)$");
            if (!matchBindingName.Success)
            {
                errorList.Add("BindingName Error");
            }
            errorMsg = errorList;
            if (errorList.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static string GetBindingListString(IEnumerable list)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var i in list)
            {
                builder.Append(i);
                builder.Append("|");
            }
            string result = builder.ToString();
            return result.Substring(0, result.Length - 1);
        }
    }
}
