using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 书商字典
    /// </summary>
    class DictionaryBookSeller
    {
        /// <summary>
        /// 书商编号
        /// </summary>
        public int Id;
        /// <summary>
        /// 书商名字
        /// </summary>
        public string BookSeller;
        /// <summary>
        /// 地址
        /// </summary>
        public string Location;
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact;
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
        public static bool isNull(DictionaryBookSeller bookseller)
        {
            if (bookseller.Id == 0)
            {
                return true;
            }
            if (bookseller.BookSeller == "")
            {
                return true;
            }
            if (bookseller.Location == "")
            {
                return true;
            }
            if (bookseller.Contact == "")
            {
                return true;
            }
            if (bookseller.Call == "")
            {
                return true;
            }
            if (bookseller.PostCodes == 0)
            {
                return true;
            }
            if (bookseller.BankName == "")
            {
                return true;
            }
            return false;
        }
        public static bool isNormative(DictionaryBookSeller bookseller, ref List<string> errorMsg)
        {
            return true;//待做
        }
    }
}
