using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagement.Dal
{
        /// <summary>
        /// 编目子系统数据操作类
        /// </summary>
        public class CatalogDal
        {
            /// <summary>
            /// 工具对象
            /// </summary>
            private SQLHelper helper = new SQLHelper();
            #region 采访编目
            /// <summary>
            /// 增加一条采访编目记录
            /// </summary>
            /// <param name="list">编目清单</param>
            /// <returns>增加成功与否</returns>
            public bool AddCatalogList(CreateCatalogList list)
            {
                string sqlStr = "INSERT INTO tb_CatalogForm (" +
                 "Id," +
                 "ISBN," +
                 "PositiveTitle," +
                 "FirstAuthor," +
                 "PublishingHouseId," +
                 "DocumentType," +
                 "PrimaryLiability" +
                 "CatalogerId" +
                 "CatalogingDate" +
                 ")" +
                 "VALUES(" +
                 "@id," +
                 "@iSBN," +
                 "@positiveTitel," +
                 "@firstAuther," +
                 "@publishingHouseId," +
                 "@documentType" +
                 "@primaryLiability," +
                 "@catalogerId," +
                 "@catalogingDate," +
                 ")";
                //储存Datatable
                MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
                {
                    new MySqlParameter("@id",list.Id),
                    new MySqlParameter("@iSBN",list.ISBN),
                    new MySqlParameter("@positiveTitel",list.PositiveTitle),
                    new MySqlParameter("@firstAuther",list.FirstAuthor),
                    new MySqlParameter("@publishingHouseId",list.PublishingHouseId),
                    new MySqlParameter("@documentType",list.DocumentType),
                    new MySqlParameter("@primaryLiability",list.PrimaryLiability),
                    new MySqlParameter("@catalogerId",list.CatalogerId),
                    new MySqlParameter("@catalogingDate",list.CatalogingDate),

                };
                int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        /// <summary>
        /// 删除一条采访编目记录
        /// </summary>
        /// <param name="listId">编目清单</param>
        /// <returns>删除成功与否</returns>
        public bool DeleteCatalogList(int orderId)
        {
            string sqlStr = "Delete from tb_CatalogForm where Id=@id;";
            //储存Datatable        
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@id",orderId),
            };
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 修改一条采访编目记录
        /// </summary>
        /// <param name="list">编目清单</param>
        /// <returns>修改成功与否</returns>
        public bool UpdateCatalogList(CreateCatalogList list)
        {
            string sqlStr = "UPDATE tb_CatalogForm SET " +
                "ISBN=@iSBN, " +
                "PositiveTitle=@positiveTitel, " +
                "FirstAuthor=@firstAuther, " +
                "PublishingHouseId=@publishingHouseId, " +
                "DocumentType=@documentType, " +
                "PrimaryLiability=@primaryLiability, " +
                "CatalogerId=@catalogerId, " +
                "CatalogingDate=@catalogingDate, " +
                "where Id=@id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
               
                new MySqlParameter("@iSBN",list.ISBN),
                new MySqlParameter("@documentType",list.DocumentType),
                new MySqlParameter("@positiveTitel",list.PositiveTitle),
                new MySqlParameter("@firstAuther",list.FirstAuthor),
                new MySqlParameter("@publishingHouseId",list.PublishingHouseId),
                new MySqlParameter("@primaryLiability",list.PrimaryLiability),
                new MySqlParameter("@catalogerId",list.CatalogerId),
                new MySqlParameter("@catalogingDate",list.CatalogingDate),
                new MySqlParameter("@id",list.Id),
            };
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 获取全部订单
        /// </summary>
        /// <returns>全部订单</returns>
        public DataTable GetAllCatalogList()
        {
            string sqlstr = "select " +
                "tb_CatalogForm.Id as ID," +
                "tb_CatalogForm.PositiveTitle as 正题名," +
                "tb_CatalogForm.ISBN as ISBN号," +
                "tb_CatalogForm.FirstAuther as 第一作者," +
                "tb_DictionaryPublishingHouse.PublishingHouse as 出版社," +
                "tb_CatalogForm.PrimaryLiability as 第一责任" +
                "tb_CatalogForm.CatalogerId as 编目人员," +
                "tb_CatalogForm.DocumentType as 文献类型" +
                "tb_CatalogForm.CatalogingDate as 编目日期" +
                " from " +
                "tb_CatalogForm inner join " +
                "and tb_CatalogForm.PublishingHouseId=tb_DictionaryPublishingHouse.Id ;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        #endregion


    }


}
