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
    /// 采访子系统数据操作类
    /// </summary>
    public class InterviewPurchaseDal
    {
        /// <summary>
        /// 工具对象
        /// </summary>
        private SQLHelper helper = new SQLHelper();

        /// <summary>
        /// 增加一条采购订单记录
        /// </summary>
        /// <param name="order">采购订单</param>
        /// <returns>增加成功与否</returns>
        public bool AddPurchaseOrder(InterviewPurchaseOrder order)
        {
            string sqlStr = "INSERT INTO tb_PurchaseOrder (" +
                "Id," +
                "SubDate," +
                "ISBN," +
                "OrdererId," +
                "BookName," +
                "Price," +
                "PublishingHouseId," +
                "DocumentType" +
                ")" +
                "VALUES(" +
                "@id," +
                "@subDate," +
                "@iSBN," +
                "@ordererId," +
                "@bookName," +
                "@price," +
                "@publishingHouseId," +
                "@documentType" +
                ")";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@id",order.Id),
                new MySqlParameter("@subDate",order.SubDate),
                new MySqlParameter("@iSBN",order.ISBN),
                new MySqlParameter("@ordererId",order.OrdererId),
                new MySqlParameter("@bookName",order.BookName),
                new MySqlParameter("@price",order.Price),
                new MySqlParameter("@publishingHouseId",order.PublishingHouseId),
                new MySqlParameter("@documentType",order.DocumentType),
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
        public DataTable GerAllPurchaseOrders()
        {
            string sqlstr = "select " +
                "tb_PurchaseOrder.Id as 订单号，" +
                "tb_PurchaseOrder.SubDate as 订单日期，" +
                "tb_PurchaseOrder.ISBN as ISBN号，" +
                "tb_PurchaseOrder.OrdererId as 订购人ID，" +
                "tb_PurchaseOrder.BookName as 书名，" +
                "tb_PurchaseOrder.Price as 价格，" +
                "tb_PurchaseOrder.PublishingHouseId as 出版社ID，" +
                "tb_PurchaseOrder.DocumentType as 文献类型" +
                " from " +
                "tb_PurchaseOrder ;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
    }
}
