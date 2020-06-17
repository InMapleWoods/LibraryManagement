﻿using System;
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
        /// 删除一条采购订单记录
        /// </summary>
        /// <param name="orderId">采购订单</param>
        /// <returns>增加成功与否</returns>
        public bool DeletePurchaseOrder(int orderId)
        {
            string sqlStr = "Delete from tb_PurchaseOrder where Id=@id;";
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
        /// 修改一条采购订单记录
        /// </summary>
        /// <param name="order">采购订单</param>
        /// <returns>增加成功与否</returns>
        public bool UpdatePurchaseOrder(InterviewPurchaseOrder order)
        {
            string sqlStr = "UPDATE tb_PurchaseOrder SET " +
                "SubDate=@subDate, " +
                "ISBN=@iSBN, " +
                "OrdererId=@ordererId, " +
                "BookName=@bookName, " +
                "Price=@price, " +
                "PublishingHouseId=@publishingHouseId, " +
                "DocumentType=@documentType " +
                "where Id=@id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器 
            {
                new MySqlParameter("@subDate",order.SubDate),
                new MySqlParameter("@ordererId",order.OrdererId),
                new MySqlParameter("@iSBN",order.ISBN),
                new MySqlParameter("@documentType",order.DocumentType),
                new MySqlParameter("@bookName",order.BookName),
                new MySqlParameter("@price",order.Price),
                new MySqlParameter("@publishingHouseId",order.PublishingHouseId),
                new MySqlParameter("@id",order.Id),
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
                "tb_PurchaseOrder.Id as 订单号," +
                "tb_PurchaseOrder.SubDate as 订单日期," +
                "tb_PurchaseOrder.ISBN as ISBN号," +
                "tb_BasicInformation.UserName as 订购人," +
                "tb_PurchaseOrder.BookName as 书名," +
                "tb_PurchaseOrder.Price as 价格," +
                "tb_DictionaryPublishingHouse.PublishingHouse as 出版社," +
                "tb_PurchaseOrder.DocumentType as 文献类型" +
                " from " +
                "tb_PurchaseOrder inner join " +
                "tb_DictionaryPublishingHouse inner join " +
                "tb_BasicInformation " +
                "on tb_PurchaseOrder.OrdererId=tb_BasicInformation.UserId " +
                "and tb_PurchaseOrder.PublishingHouseId=tb_DictionaryPublishingHouse.Id ;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
    }
}
