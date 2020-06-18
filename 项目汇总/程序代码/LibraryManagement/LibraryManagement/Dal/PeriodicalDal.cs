using LibraryManagement.Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagement.Dal
{
    /// <summary>
    /// 期刊子系统数据操作类
    /// </summary>
    public class PeriodicalDal
    {
        /// <summary>
        /// 工具对象
        /// </summary>
        private SQLHelper helper = new SQLHelper();

        #region 期刊订单
        /// <summary>
        /// 增加一条期刊订单记录
        /// </summary>
        /// <param name="order">期刊订单</param>
        /// <returns>增加成功与否</returns>
        public bool AddPeriodicalOrder(PeriodicalOrder order)
        {
            string sqlStr = "INSERT INTO tb_PeriodicalOrder (" +
                "BookSellerId," +
                "OrderTime," +
                "OrdererId," +
                "ISBN," +
                "DocumentType," +
                "PublishCycle," +
                "OfficialTitle," +
                "SupplementTitle," +
                "PublishingHouseId," +
                "OrderPrice," +
                "CurrencyType," +
                "Size" +
                ") " +
                "VALUES(" +
                "@bookSellerId," +
                "@orderTime," +
                "@ordererId," +
                "@iSBN," +
                "@documentType," +
                "@publishCycle," +
                "@officialTitle," +
                "@supplementTitle," +
                "@publishingHouseId," +
                "@orderPrice," +
                "@currencyType," +
                "@size" +
                ");";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@bookSellerId",order.BookSellerId),
                new MySqlParameter("@orderTime",order.OrderDate),
                new MySqlParameter("@ordererId",order.OrdererId),
                new MySqlParameter("@iSBN",order.ISBN),
                new MySqlParameter("@documentType",order.DocumentType),
                new MySqlParameter("@publishCycle",order.PublishCycle),
                new MySqlParameter("@officialTitle",order.OfficialTitle),
                new MySqlParameter("@supplementTitle",order.SupplementTitle),
                new MySqlParameter("@publishingHouseId",order.PublishingHouseId),
                new MySqlParameter("@orderPrice",order.OrderPrice),
                new MySqlParameter("@currencyType",order.CurrencyType),
                new MySqlParameter("@size",order.Size),
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
        /// 删除一条期刊订单记录
        /// </summary>
        /// <param name="orderId">期刊订单</param>
        /// <returns>删除成功与否</returns>
        public bool DeletePeriodicalOrder(int orderId)
        {
            string sqlStr = "Delete from tb_PeriodicalOrder where Id=@id;";
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
        /// 修改一条期刊订单记录
        /// </summary>
        /// <param name="order">期刊订单</param>
        /// <returns>修改成功与否</returns>
        public bool UpdatePeriodicalOrder(PeriodicalOrder order)
        {
            string sqlStr = "UPDATE tb_PeriodicalOrder SET " +
                "BookSellerId=@bookSellerId, " +
                "OrderTime=@orderTime, " +
                "OrdererId=@ordererId, " +
                "ISBN=@iSBN, " +
                "DocumentType=@documentType, " +
                "PublishCycle=@publishCycle, " +
                "OfficialTitle=@officialTitle, " +
                "SupplementTitle=@supplementTitle, " +
                "PublishingHouseId=@publishingHouseId, " +
                "OrderPrice=@orderPrice, " +
                "CurrencyType=@currencyType, " +
                "Size=@size " +
                "where Id=@id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@bookSellerId",order.BookSellerId),
                new MySqlParameter("@orderTime",order.OrderDate),
                new MySqlParameter("@ordererId",order.OrdererId),
                new MySqlParameter("@iSBN",order.ISBN),
                new MySqlParameter("@documentType",order.DocumentType),
                new MySqlParameter("@publishCycle",order.PublishCycle),
                new MySqlParameter("@officialTitle",order.OfficialTitle),
                new MySqlParameter("@supplementTitle",order.SupplementTitle),
                new MySqlParameter("@publishingHouseId",order.PublishingHouseId),
                new MySqlParameter("@orderPrice",order.OrderPrice),
                new MySqlParameter("@currencyType",order.CurrencyType),
                new MySqlParameter("@size",order.Size),
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
        public DataTable GetAllPeriodOrders()
        {
            string sqlstr = "select " +
                "tb_PeriodicalOrder.Id as 编号," +
                "tb_DictionaryBookSeller.BookSeller as 书商," +
                "tb_PeriodicalOrder.OrderTime as 订购时间," +
                "tb_BasicInformation.UserName as 订购人," +
                "tb_PeriodicalOrder.ISBN as ISBN号," +
                "tb_PeriodicalOrder.DocumentType as 文献类型," +
                "tb_PeriodicalOrder.PublishCycle as 出版周期," +
                "tb_PeriodicalOrder.OfficialTitle as 正刊名," +
                "tb_PeriodicalOrder.SupplementTitle as 副刊名," +
                "tb_DictionaryPublishingHouse.PublishingHouse as 出版社," +
                "tb_PeriodicalOrder.OrderPrice as 订购价," +
                "tb_PeriodicalOrder.CurrencyType as 币种," +
                "tb_PeriodicalOrder.Size as 尺寸" +
                " from " +
                "tb_PeriodicalOrder inner join " +
                "tb_DictionaryBookSeller inner join " +
                "tb_DictionaryPublishingHouse inner join " +
                "tb_BasicInformation " +
                "on tb_PeriodicalOrder.BookSellerId=tb_DictionaryBookSeller.Id " +
                "and tb_PeriodicalOrder.OrdererId=tb_BasicInformation.UserId " +
                "and tb_PeriodicalOrder.PublishingHouseId=tb_DictionaryPublishingHouse.Id " +
                "AND NOT EXISTS ( SELECT * FROM tb_PeriodicalArrival WHERE tb_PeriodicalArrival.OrderId = tb_PeriodicalOrder.Id ) ;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 获取分页后订单
        /// </summary>
        /// <returns>分页后订单</returns>
        public DataTable GetPeriodOrders(int index, int size)
        {
            int startPos = (index - 1) * size;
            int endPos = size;
            string sqlstr = "select " +
                "tb_PeriodicalOrder.Id as 编号," +
                "tb_DictionaryBookSeller.BookSeller as 书商," +
                "tb_PeriodicalOrder.OrderTime as 订购时间," +
                "tb_BasicInformation.UserName as 订购人," +
                "tb_PeriodicalOrder.ISBN as ISBN号," +
                "tb_PeriodicalOrder.DocumentType as 文献类型," +
                "tb_PeriodicalOrder.PublishCycle as 出版周期," +
                "tb_PeriodicalOrder.OfficialTitle as 正刊名," +
                "tb_PeriodicalOrder.SupplementTitle as 副刊名," +
                "tb_DictionaryPublishingHouse.PublishingHouse as 出版社," +
                "tb_PeriodicalOrder.OrderPrice as 订购价," +
                "tb_PeriodicalOrder.CurrencyType as 币种," +
                "tb_PeriodicalOrder.Size as 尺寸" +
                " from " +
                "tb_PeriodicalOrder inner join " +
                "tb_DictionaryBookSeller inner join " +
                "tb_DictionaryPublishingHouse inner join " +
                "tb_BasicInformation " +
                "on tb_PeriodicalOrder.BookSellerId=tb_DictionaryBookSeller.Id " +
                "and tb_PeriodicalOrder.OrdererId=tb_BasicInformation.UserId " +
                "and tb_PeriodicalOrder.PublishingHouseId=tb_DictionaryPublishingHouse.Id " +
                "AND NOT EXISTS ( SELECT * FROM tb_PeriodicalArrival WHERE tb_PeriodicalArrival.OrderId = tb_PeriodicalOrder.Id ) " +
                "order by tb_PeriodicalOrder.Id limit @startPos,@endPos;";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@startPos",startPos),
                new MySqlParameter("@endPos",endPos),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        #endregion

        #region 期刊登到

        /// <summary>
        /// 获取全部登到
        /// </summary>
        /// <returns>全部登到</returns>
        public DataTable GetAllPeriodArrivals()
        {
            string sqlstr = " SELECT " +
                " tb_PeriodicalArrival.Id AS 编号, " +
                " tb_PeriodicalArrival.OrderId AS 订单编号, " +
                " tb_PeriodicalOrder.ISBN AS ISBN号, " +
                " tb_PeriodicalOrder.OfficialTitle AS 正刊名, " +
                " tb_PeriodicalOrder.OrderPrice AS 订购价, " +
                " tb_PeriodicalOrder.CurrencyType AS 币种, " +
                " tb_PeriodicalArrival.State AS 状态  " +
                " FROM " +
                " tb_PeriodicalArrival " +
                " INNER JOIN tb_PeriodicalOrder " +
                " ON tb_PeriodicalArrival.OrderId = tb_PeriodicalOrder.Id;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 获取分页后登到
        /// </summary>
        /// <returns>分页后登到</returns>
        public DataTable GetPeriodArrivals(int index, int size)
        {
            int startPos = (index - 1) * size;
            int endPos = size;
            string sqlstr = " SELECT " +
                " tb_PeriodicalArrival.Id AS 编号, " +
                " tb_PeriodicalArrival.OrderId AS 订单编号, " +
                " tb_PeriodicalOrder.ISBN AS ISBN号, " +
                " tb_PeriodicalOrder.OfficialTitle AS 正刊名, " +
                " tb_PeriodicalOrder.OrderPrice AS 订购价, " +
                " tb_PeriodicalOrder.CurrencyType AS 币种, " +
                " tb_PeriodicalArrival.State AS 状态  " +
                " FROM " +
                " tb_PeriodicalArrival " +
                " INNER JOIN tb_PeriodicalOrder " +
                " ON tb_PeriodicalArrival.OrderId = tb_PeriodicalOrder.Id " +
                " order by tb_PeriodicalArrival.Id limit @startPos,@endPos;";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@startPos",startPos),
                new MySqlParameter("@endPos",endPos),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 增加一条期刊登到记录
        /// </summary>
        /// <param name="arrival">期刊登到记录</param>
        /// <returns>增加成功与否</returns>
        public bool AddPeriodicalArrival(PeriodicalArrival arrival)
        {
            string sqlStr = "INSERT INTO tb_PeriodicalArrival (" +
                "OrderId," +
                "State" +
                ") " +
                "VALUES(" +
                "@orderId," +
                "@state" +
                ");";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@orderId",arrival.OrderId),
                new MySqlParameter("@state",arrival.State),
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
        /// 删除一条期刊登到记录
        /// </summary>
        /// <param name="arrivalId">期刊登到Id</param>
        /// <returns>删除成功与否</returns>
        public bool DeletePeriodicalArrival(int arrivalId)
        {
            string sqlStr = "Delete from tb_PeriodicalArrival where Id=@id;";
            //储存Datatable        
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@id",arrivalId),
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
        /// 更改一条期刊登到记录
        /// </summary>
        /// <param name="arrival">期刊登到记录</param>
        /// <returns>更改成功与否</returns>
        public bool UpdatePeriodicalArrival(PeriodicalArrival arrival)
        {
            string sqlStr = "UPDATE tb_PeriodicalArrival SET " +
                "OrderId=@orderId, " +
                "State=@state " +
                "where Id=@id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@state",arrival.State),
                new MySqlParameter("@orderId",arrival.OrderId),
                new MySqlParameter("@id",arrival.Id),
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
        /// 将完好期刊写入流通库
        /// </summary>
        /// <returns>更改成功与否</returns>
        public bool MoveArrivedPeriodicalToCirculate()
        {
            string sqlStr = "MoveArrivedPeriodicalToCirculate";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@result",MySqlDbType.Bit,1),
            };
            para[0].Direction = ParameterDirection.Output;//将第一个变量设为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
            return para[0].Value.ToString() == "1";
        }
        #endregion

        #region 期刊合订
        /// <summary>
        /// 获取全部期刊
        /// </summary>
        /// <returns>全部期刊</returns>
        public DataTable GetAllUnbindedPeriodical()
        {
            string sqlstr = " SELECT " +
                " tb_CirculateBooks.Id AS 编号, " +
                " tb_CirculateBooks.ISBN AS ISBN, " +
                " tb_CirculateBooks.OfficialTitle AS 标题, " +
                " tb_DictionaryPublishingHouse.PublishingLocation AS 出版社  " +
                " FROM " +
                " tb_CirculateBooks " +
                " INNER JOIN tb_DictionaryPublishingHouse " +
                " ON tb_CirculateBooks.PublishingHouseId = tb_DictionaryPublishingHouse.id  " +
                " AND tb_CirculateBooks.DocumentType = '期刊'  " +
                " AND BookStatus <> '已合订'; ";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 获取全部合订
        /// </summary>
        /// <returns>全部合订</returns>
        public DataTable GetAllPeriodBindings()
        {
            string sqlstr = " SELECT " +
                " tb_PeriodicalBindingList.Id AS 编号, " +
                " tb_PeriodicalBindingList.BindingIdList AS 合订编号, " +
                " tb_PeriodicalBindingList.BookId AS 流通库编号, " +
                " tb_PeriodicalBindingList.BindingName AS 合订本名称  " +
                " FROM " +
                " tb_PeriodicalBindingList ;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 获取分页后合订
        /// </summary>
        /// <returns>分页后合订</returns>
        public DataTable GetPeriodBindings(int index, int size)
        {
            int startPos = (index - 1) * size;
            int endPos = size;
            string sqlstr = " SELECT " +
                " tb_PeriodicalBindingList.Id AS 编号, " +
                " tb_PeriodicalBindingList.BindingIdList AS 合订编号, " +
                " tb_PeriodicalBindingList.BookId AS 流通库编号, " +
                " tb_PeriodicalBindingList.BindingName AS 合订本名称  " +
                " FROM " +
                " tb_PeriodicalBindingList " +
                " order by tb_PeriodicalBindingList.Id limit @startPos,@endPos;";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@startPos",startPos),
                new MySqlParameter("@endPos",endPos),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 增加一条期刊合订记录
        /// </summary>
        /// <param name="binding">期刊合订记录</param>
        /// <returns>增加成功与否</returns>
        //public bool AddPeriodicalBinding(PeriodicalBinding binding)
        //{
        //    string sqlStr = "INSERT INTO tb_PeriodicalArrival (" +
        //        "OrderId," +
        //        "State" +
        //        ") " +
        //        "VALUES(" +
        //        "@orderId," +
        //        "@state" +
        //        ");";
        //    //储存Datatable
        //    MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
        //    {
        //        new MySqlParameter("@orderId",binding.OrderId),
        //        new MySqlParameter("@state",binding.State),
        //    };
        //    int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
        //    if (count > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        /// <summary>
        /// 删除一条期刊合订记录
        /// </summary>
        /// <param name="bindingId">期刊合订Id</param>
        /// <returns>删除成功与否</returns>
        public bool DeletePeriodicalBinding(int bindingId)
        {
            string sqlStr = "Delete from tb_PeriodicalArrival where Id=@id;";
            //储存Datatable        
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@id",bindingId),
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

        ///// <summary>
        ///// 更改一条期刊合订记录
        ///// </summary>
        ///// <param name="binding">期刊合订记录</param>
        ///// <returns>更改成功与否</returns>
        //public bool UpdatePeriodicalBinding(PeriodicalBinding binding)
        //{
        //    string sqlStr = "UPDATE tb_PeriodicalArrival SET " +
        //        "OrderId=@orderId, " +
        //        "State=@state " +
        //        "where Id=@id;";
        //    //储存Datatable
        //    MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
        //    {
        //        new MySqlParameter("@state",binding.State),
        //        new MySqlParameter("@orderId",binding.OrderId),
        //        new MySqlParameter("@id",binding.Id),
        //    };
        //    int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.Text);
        //    if (count > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        #endregion
    }
}
