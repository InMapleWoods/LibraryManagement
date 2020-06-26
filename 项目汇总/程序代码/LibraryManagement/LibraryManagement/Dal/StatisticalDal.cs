using LibraryManagement.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LibraryManagement.Dal
{
    internal class StatisticalDal
    {
        SQLHelper helper = new SQLHelper();
        public DataTable getStatisticResult(String sqlStr)
        {
            MySqlParameter[] para = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, para, CommandType.Text);
            return dataTable;
        }
        /// <summary>
        /// 获取统计设计表信息
        /// </summary>
        /// <returns></returns>
        public DataTable getStatisticInfo()
        {
            string sqlStr = "Select " +
                " tb_StatisticalFormat.Id as 编号 ," +
                " tb_StatisticalFormat.TableName as 表名称 ," +
                " tb_StatisticalFormat.Operation as 操作 " +
                " from tb_StatisticalFormat ; ";
            MySqlParameter[] para = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, para, CommandType.Text);
            return dataTable;
        }
        public DataTable getStatisticInfoByName(StatisticalInfo statisticalInfo)
        {
            string sqlStr = "Select " +
                " tb_StatisticalFormat.Id as 编号 ," +
                " tb_StatisticalFormat.TableName as 表名称 ," +
                " tb_StatisticalFormat.Operation as 操作 " +
                " from tb_StatisticalFormat " +
                " Where TableName =@TableName ;";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@TableName",statisticalInfo.TableName),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, para, CommandType.Text);
            return dataTable;
        }
    }
}
