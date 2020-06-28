using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryManagement.Model
{
    public class DictionaryPublishingHouse
    {
        /// <summary>
        /// 出版社编号
        /// </summary>
        public int Id;
        /// <summary>
        /// 出版社名字
        /// </summary>
        public string PublishingHouse;
        /// <summary>
        /// 地址
        /// </summary>
        public string Location;
        /// <summary>
        /// 出版地址
        /// </summary>
        public string PublishingLocation;
        /// <summary>
        /// 电话
        /// </summary>
        public string CallNumber;
        /// <summary>
        /// 邮编
        /// </summary>
        public int PostCodes;
        /// <summary>
        /// 开户行
        /// </summary>
        public string BankName;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark;
        /// <summary>
        /// 判断是否有空值
        /// </summary>
        /// <param name="bookseller">书商字典项</param>
        /// <returns></returns>
        public static bool isNull(DictionaryPublishingHouse publishingHouse)
        {

            if (publishingHouse.PublishingHouse == "")
            {
                return true;
            }
            if (publishingHouse.Location == "")
            {
                return true;
            }
            if (publishingHouse.PublishingLocation == "")
            {
                return true;
            }
            if (publishingHouse.CallNumber == "")
            {
                return true;
            }
            if (publishingHouse.PostCodes == 0)
            {
                return true;
            }
            if (publishingHouse.BankName == "")
            {
                return true;
            }
            return false;
        }
        public static bool isNormative(DictionaryPublishingHouse publishingHouse, ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            if (publishingHouse.Id <= 0)
            {
                errorList.Add("BookSellerId Error");
            }
            Match matchCallNumber = Regex.Match(publishingHouse.CallNumber, @"^(\d{1,11})$");
            if (!matchCallNumber.Success)
            {
                errorList.Add("CallNumber Error");
            }
            Match matchPostCodes = Regex.Match(publishingHouse.PostCodes.ToString(), @"^(\d{5,6})$");
            if (!matchPostCodes.Success)
            {
                errorList.Add("PostCodes Error");
            }
            if (errorList.Count > 0)
            {
                return true;
            }
            errorMsg = errorList;
            return false;
        }
    }
}
