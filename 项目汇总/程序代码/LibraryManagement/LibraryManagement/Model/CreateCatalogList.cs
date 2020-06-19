using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 采访编目
    /// </summary>
    public class CreateCatalogList
    {

        /// <summary>
        /// 编号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// ISBN号
        /// </summary>
        public string ISBN = "";

        /// <summary>
        /// 编目日期
        /// </summary>
        public DateTime CatalogingDate = DateTime.Now;

        /// <summary>
        /// 编目人员
        /// </summary>
        public int CatalogerId = 0;

        /// <summary>
        /// 正题名
        /// </summary>
        public string PositiveTitle = "";

        /// <summary>
        /// 第一作者
        /// </summary>
        public string FirstAuthor = "";

        /// <summary>
        /// 出版社ID
        /// </summary>
        public int PublishingHouseId = 0;


        /// <summary>
        /// 文献类型
        /// </summary>
        public string DocumentType = "";

        /// <summary>
        /// 第一责任
        /// </summary>
        public string PrimaryLiability = "";

        /// <summary>
        /// 判断列表是否有空项
        /// </summary>
        /// <param name="list">待判断列表</param>
        /// <returns>是否有空项</returns>
        public static bool isNull(CreateCatalogList  list)
        {
            if (list.ISBN == "")
            {
                return true;
            }
            if (list.CatalogerId == 0)
            {
                return true;
            }
            if (list.PositiveTitle  == "")
            {
                return true;
            }
            if (list.FirstAuthor == "")
            {
                return true;
            }
            if (list.PublishingHouseId == 0)
            {
                return true;
            }
            if (list.DocumentType == "")
            {
                return true;
            }
            if (list.PrimaryLiability == "")
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 判断编目是否规范
        /// </summary>
        /// <param name="list">待判断订单</param>
        /// <param name="errorMsg">错误信息</param>
        /// <returns>是否规范</returns>

        public static bool isNormative(CreateCatalogList list , ref List<string> errorMsg)
        {
            List<string> errorList = new List<string>();
            if (list.CatalogerId <= 0)
            {
                errorList.Add("CatalogerId Error");
            }
            Match matchISBN = Regex.Match(list.ISBN, @"^(\d{10})$");
            if (!matchISBN.Success)
            {
                errorList.Add("ISBN Error");
            }
            if (list.PublishingHouseId <= 0)
            {
                errorList.Add("PublishingHouseId Error");
            }
            Match matchDocumentType = Regex.Match(list.DocumentType, @"\b(期刊|专著)\b");
            if (!matchDocumentType.Success)
            {
                errorList.Add("DocumentType Error");
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
