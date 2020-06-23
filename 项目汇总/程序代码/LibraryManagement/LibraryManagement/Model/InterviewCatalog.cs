using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 采访编目记录
    /// </summary>
    public class InterviewCatalog
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// 采访编号
        /// </summary>
        public int InterviewId = 0;

        /// <summary>
        /// 编目状态
        /// </summary>
        public string State = "";

        /// <summary>
        /// 判断编目记录是否有空项
        /// </summary>
        /// <param name="list">待判断登到记录</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(InterviewCatalog list)
        {
            if (list.InterviewId == 0)
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
        /// 判断采访记录是否规范
        /// </summary>
        /// <param name="list">待判断采访记录</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>
        public static bool isNormative(InterviewCatalog list, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            if (list.InterviewId <= 0)
            {
                errorList.Add("InterviewId Error");
            }
            Match matchState = Regex.Match(list.State, @"(可编目|退回|待退)");
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
