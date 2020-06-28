using LibraryManagement.Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagement.Dal
{
    /// <summary>
    /// 采访子系统数据操作类
    /// </summary>
    public class InterviewDal
    {
        /// <summary>
        /// 工具对象
        /// </summary>
        private SQLHelper helper = new SQLHelper();

        #region 采访清单

        /// <summary>
        /// 增加一条采访清单记录
        /// </summary>
        /// <param name="list">采访清单</param>
        /// <returns>增加成功与否</returns>
        public bool AddInterviewList(InterviewList list)
        {
            string sqlStr = "INSERT INTO tb_InterviewList (" +
                "Id," +
                "Author," +
                "ISBN," +
                "OrderStatus," +
                "BookName," +
                "Price," +
                "CurrencyType," +
                "SubscriptionNum," +
                "PublishingHouseId," +
                "DocumentType" +
                ")" +
                "VALUES(" +
                "@id," +
                "@author," +
                "@iSBN," +
                "@orderStatus," +
                "@bookName," +
                "@price," +
                "@currencyType," +
                "@subscriptionNum," +
                "@publishingHouseId," +
                "@documentType" +
                ")";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@id",list.Id),
                new MySqlParameter("@author",list.Author),
                new MySqlParameter("@iSBN",list.ISBN),
                new MySqlParameter("@bookName",list.BookName),
                new MySqlParameter("@price",list.Price),
                new MySqlParameter("@currencyType",list.CurrencyType),
                new MySqlParameter("@subscriptionNum",list.SubscriptionNum),
                new MySqlParameter("@publishingHouseId",list.PublishingHouseId),
                new MySqlParameter("@orderStatus",list.OrderStatus),
                new MySqlParameter("@documentType",list.DocumentType),
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
        /// 删除一条采访清单记录
        /// </summary>
        /// <param name="Id">采访清单</param>
        /// <returns>删除成功与否</returns>
        public bool DeleteInterviewList(int Id)
        {
            string sqlStr = "Delete from tb_InterviewList where Id=@id;";
            //储存Datatable        
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@id",Id),
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
        /// 修改一条采访清单记录
        /// </summary>
        /// <param name="list">采访清单</param>
        /// <returns>修改成功与否</returns>
        public bool UpdateInterviewList(InterviewList list)
        {
            string sqlStr = "UPDATE tb_InterviewList SET " +
                "ISBN=@iSBN, " +
                "Author=@author, " +
                "BookName=@bookName, " +
                "Price=@price, " +
                "CurrencyType=@currencyType, " +
                "SubscriptionNum=@subscriptionNum, " +
                "PublishingHouseId=@publishingHouseId, " +
                "DocumentType=@documentType, " +
                "OrderStatus=@orderStatus " +
                "where Id=@id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器 
            {
                new MySqlParameter("@author",list.Author),
                new MySqlParameter("@iSBN",list.ISBN),
                new MySqlParameter("@documentType",list.DocumentType),
                new MySqlParameter("@bookName",list.BookName),
                new MySqlParameter("@price",list.Price),
                new MySqlParameter("@currencyType",list.CurrencyType),
                new MySqlParameter("@subscriptionNum",list.SubscriptionNum),
                new MySqlParameter("@publishingHouseId",list.PublishingHouseId),
                new MySqlParameter("@id",list.Id),
                new MySqlParameter("@orderStatus",list.OrderStatus),
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
        /// 获取全部清单
        /// </summary>
        /// <returns>全部清单</returns>
        public DataTable GetAllInterviewList()
        {
            string sqlstr = "select " +
                "tb_InterviewList.Id as 清单号," +
                "tb_InterviewList.Author as 作者," +
                "tb_InterviewList.ISBN as ISBN号," +
                "tb_InterviewList.BookName as 书名," +
                "tb_InterviewList.Price as 价格," +
                "tb_InterviewList.currencyType as 货币种类," +
                "tb_InterviewList.subscriptionNum as 征订册数," +
                "tb_DictionaryPublishingHouse.PublishingHouse as 出版社," +
                "tb_InterviewList.DocumentType as 文献类型," +
                "tb_InterviewList.OrderStatus as 订购状态 " +
                " from " +
                "tb_InterviewList inner join " +
                "tb_DictionaryPublishingHouse " +
                "on tb_InterviewList.PublishingHouseId=tb_DictionaryPublishingHouse.Id ;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        #endregion

        #region 采购订单

        /// <summary>
        /// 增加一条采购订单记录
        /// </summary>
        /// <param name="order">采购订单</param>
        /// <returns>增加成功与否</returns>
        public bool AddPurchaseOrder(InterviewPurchaseOrder order)
        {
            string sqlStr = "INSERT INTO tb_InterviewPurchaseOrder (" +
                "Id," +
                "SubDate," +
                "ISBN," +
                "OrdererId," +
                "BookName," +
                "Price," +
                "CurrencyType," +
                "PublishingHouseId," +
                "DocumentType," +
                "Remark " +
                ")" +
                "VALUES(" +
                "@id," +
                "@subDate," +
                "@iSBN," +
                "@ordererId," +
                "@bookName," +
                "@price," +
                "@currencyType," +
                "@publishingHouseId," +
                "@documentType," +
                "@remark " +
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
                new MySqlParameter("@currencyType",order.CurrencyType),
                new MySqlParameter("@publishingHouseId",order.PublishingHouseId),
                new MySqlParameter("@documentType",order.DocumentType),
                new MySqlParameter("@remark",order.Remark),
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
        /// <returns>删除成功与否</returns>
        public bool DeletePurchaseOrder(int orderId)
        {
            string sqlStr = "Delete from tb_InterviewPurchaseOrder where Id=@id;";
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
        /// <returns>修改成功与否</returns>
        public bool UpdatePurchaseOrder(InterviewPurchaseOrder order)
        {
            string sqlStr = "UPDATE tb_InterviewPurchaseOrder SET " +
                "SubDate=@subDate, " +
                "ISBN=@iSBN, " +
                "OrdererId=@ordererId, " +
                "BookName=@bookName, " +
                "Price=@price, " +
                "CurrencyType=@currencyType, " +
                "PublishingHouseId=@publishingHouseId," +
                "DocumentType=@documentType, " +
                "Remark=@remark " +
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
                new MySqlParameter("@currencyType",order.CurrencyType),
                new MySqlParameter("@publishingHouseId",order.PublishingHouseId),
                new MySqlParameter("@id",order.Id),
                new MySqlParameter("@remark",order.Remark),
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
                "tb_InterviewPurchaseOrder.Id as 订单号," +
                "tb_InterviewPurchaseOrder.SubDate as 订单日期," +
                "tb_InterviewPurchaseOrder.ISBN as ISBN号," +
                "tb_BasicInformation.UserName as 订购人," +
                "tb_InterviewPurchaseOrder.BookName as 书名," +
                "tb_InterviewPurchaseOrder.Price as 价格," +
                "tb_InterviewPurchaseOrder.CurrencyType as 货币类型," +
                "tb_DictionaryPublishingHouse.PublishingHouse as 出版社," +
                "tb_InterviewPurchaseOrder.DocumentType as 文献类型, " +
                "tb_InterviewPurchaseOrder.Remark as 备注" +
                " from " +
                "tb_InterviewPurchaseOrder inner join " +
                "tb_DictionaryPublishingHouse inner join " +
                "tb_BasicInformation " +
                "on tb_InterviewPurchaseOrder.OrdererId=tb_BasicInformation.UserId " +
                "and tb_InterviewPurchaseOrder.PublishingHouseId=tb_DictionaryPublishingHouse.Id ;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        #endregion

        #region 验收清单

        /// <summary>
        /// 根据订单编号获取订购人编号
        /// </summary>
        /// <param name="id">订单编号</param>
        /// <returns>订购人编号</returns>
        public int GetOrdererIdByNum(string id)
        {
            string sqlStr = "select tb_InterviewPurchaseOrder.OrdererId as 订购人 from tb_InterviewPurchaseOrder where tb_InterviewPurchaseOrder.Id = @id;";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                 new MySqlParameter("@id", id),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, paras, CommandType.Text);
            if (dataTable.Rows.Count <= 0)
            {
                return -1;
            }
            return (int)dataTable.Rows[0]["订购人"];
        }
        /// <summary>
        /// 增加一条验收清单记录
        /// </summary>
        /// <param name="list">验收清单</param>
        /// <returns>增加成功与否</returns>
        public bool AddAcceptanceList(AcceptanceList list)
        {
            string sqlStr = "INSERT INTO tb_AcceptanceList (" +
                "Id," +
                "BookSellerId," +
                "PublishingHouseId," +
                "OrdererId," +
                "AcceptorId," +
                "DocumentType" +
                ")" +
                "VALUES(" +
                "@id," +
                "@bookSellerId," +
                "@publishingHouseId," +
                "@ordererId," +
                "@acceptorId," +
                "@documentType" +
                ")";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@id",list.Id),
                new MySqlParameter("@bookSellerId",list.BookSellerId),
                new MySqlParameter("@publishingHouseId",list.PublishingHouseId),
                new MySqlParameter("@ordererId",list.OrdererId),
                new MySqlParameter("@acceptorId",list.AcceptorId),
                new MySqlParameter("@documentType",list.DocumentType),
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
        /// 删除一条验收清单记录
        /// </summary>
        /// <param name="Id">验收清单</param>
        /// <returns>删除成功与否</returns>
        public bool DeleteAcceptanceList(int Id)
        {
            string sqlStr = "Delete from tb_AcceptanceList where Id=@id;";
            //储存Datatable        
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@id",Id),
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
        /// 修改一条验收记录
        /// </summary>
        /// <param name="list">验收清单</param>
        /// <returns>修改成功与否</returns>
        public bool UpdateAcceptanceList(AcceptanceList list)
        {
            string sqlStr = "UPDATE tb_AcceptanceList SET " +
                "BookSellerId=@bookSellerId, " +
                "PublishingHouseId=@publishingHouseId, " +
                "OrdererId=@ordererId, " +
                "AcceptorId=@acceptorId, " +
                "DocumentType=@documentType " +
                "where Id=@id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器 
            {
                new MySqlParameter("@id",list.Id),
                new MySqlParameter("@bookSellerId",list.BookSellerId),
                new MySqlParameter("@publishingHouseId",list.PublishingHouseId),
                new MySqlParameter("@ordererId",list.OrdererId),
                new MySqlParameter("@acceptorId",list.AcceptorId),
                new MySqlParameter("@documentType",list.DocumentType),
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
        /// 获取全部清单
        /// </summary>
        /// <returns>全部清单</returns>
        public DataTable GetAllAcceptanceList()
        {
            string sqlstr = " SELECT " +
                " tb_AcceptanceList.Id AS `清单号`, " +
                " tb_DictionaryBookSeller.BookSeller AS `书商`, " +
                " tb_DictionaryPublishingHouse.PublishingHouse AS `出版社`, " +
                " t2.UserName AS 订购人, " +
                " t1.UserName AS 验收人, " +
                " tb_AcceptanceList.DocumentType AS `文献类型`  " +
                " FROM " +
                " tb_AcceptanceList " +
                " INNER JOIN tb_DictionaryBookSeller ON tb_AcceptanceList.BookSellerId = tb_DictionaryBookSeller.Id " +
                " INNER JOIN tb_DictionaryPublishingHouse ON tb_AcceptanceList.PublishingHouseId = tb_DictionaryPublishingHouse.Id " +
                " INNER JOIN tb_BasicInformation AS t1 ON t1.UserId = tb_AcceptanceList.AcceptorId " +
                " INNER JOIN tb_BasicInformation AS t2 ON t2.UserId = tb_AcceptanceList.OrdererId ;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        #endregion

        #region 退货清单

        /// <summary>
        /// 增加一条退货清单记录
        /// </summary>
        /// <param name="list">退货清单</param>
        /// <returns>增加成功与否</returns>
        public bool AddReturnList(InterviewReturnList list)
        {
            string sqlStr = "INSERT INTO tb_InterviewReturnList (" +
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
                new MySqlParameter("@id",list.Id),
                new MySqlParameter("@subDate",list.SubDate),
                new MySqlParameter("@iSBN",list.ISBN),
                new MySqlParameter("@ordererId",list.OrdererId),
                new MySqlParameter("@bookName",list.BookName),
                new MySqlParameter("@price",list.Price),
                new MySqlParameter("@publishingHouseId",list.PublishingHouseId),
                new MySqlParameter("@documentType",list.DocumentType),
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
        /// 获取全部清单
        /// </summary>
        /// <returns>全部清单</returns>
        public DataTable GetAllReturnList()
        {
            string sqlstr = "select " +
                "tb_InterviewReturnList.Id as 订单号," +
                "tb_InterviewReturnList.SubDate as 订单日期," +
                "tb_InterviewReturnList.ISBN as ISBN号," +
                "tb_BasicInformation.UserName as 订购人," +
                "tb_InterviewReturnList.BookName as 书名," +
                "tb_InterviewReturnList.Price as 价格," +
                "tb_DictionaryPublishingHouse.PublishingHouse as 出版社," +
                "tb_InterviewReturnList.DocumentType as 文献类型" +
                " from " +
                "tb_InterviewReturnList inner join " +
                "tb_DictionaryPublishingHouse inner join " +
                "tb_BasicInformation " +
                "on tb_InterviewReturnList.OrdererId=tb_BasicInformation.UserId " +
                "and tb_InterviewReturnList.PublishingHouseId=tb_DictionaryPublishingHouse.Id ;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        #endregion
    }
}
