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
        /// <returns>增加成功与否</returns>
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
        /// <returns>增加成功与否</returns>
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
                "and tb_PeriodicalOrder.PublishingHouseId=tb_DictionaryPublishingHouse.Id ;";
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
                "order by tb_PeriodicalOrder.Id limit @startPos,@endPos;";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@startPos",startPos),
                new MySqlParameter("@endPos",endPos),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
    }
}
