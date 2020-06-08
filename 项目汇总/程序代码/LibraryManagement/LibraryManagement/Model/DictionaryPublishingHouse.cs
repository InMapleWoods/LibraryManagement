using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    class DictionaryPublishingHouse
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
        public string Call;
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
            if (publishingHouse.Call == "")
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
            return false;//待做
        }
    }
}
