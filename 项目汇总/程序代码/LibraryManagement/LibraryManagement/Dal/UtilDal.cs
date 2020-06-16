﻿using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.Dal
{
    /// <summary>
    /// 复用部分数据操作类
    /// </summary>
    public class UtilDal
    {
        /// <summary>
        /// 工具对象
        /// </summary>
        private SQLHelper helper = new SQLHelper();

        /// <summary>
        /// 由用户账号获取用户Id
        /// </summary>
        /// <param name="number"></param>
        /// <returns>用户ID</returns>
        public int GetUserIdFormNumber(string number)
        {
            string sqlStr = "select UserId from tb_BasicInformation where UserNumber=@number;";//SQL执行字符串
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@number",number.Trim()),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, paras, CommandType.Text);
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                return -1;
            }
            int idResult = (int)dataTable.Rows[0]["UserId"];
            return idResult;
        }

        /// <summary>
        /// 获取书商名称
        /// </summary>
        /// <returns>书商名称</returns>
        public Dictionary<int, string> GetBookSellerNames()
        {
            string sqlStr = "select Id,BookSeller from tb_DictionaryBookSeller";//SQL执行字符串
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, paras, CommandType.Text);
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                return null;
            }
            Dictionary<int, string> result = new Dictionary<int, string>();
            foreach (DataRow i in dataTable.Rows)
            {
                int idResult = (int)i["Id"];
                string nameResult = (string)i["BookSeller"];
                result.Add(idResult, nameResult);
            }
            return result;
        }

        /// <summary>
        /// 获取出版社名称
        /// </summary>
        /// <returns>出版社名称</returns>
        public Dictionary<int, string> GetPublishingHouseNames()
        {
            string sqlStr = "select Id,PublishingHouse from tb_DictionaryPublishingHouse";//SQL执行字符串
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, paras, CommandType.Text);
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                return null;
            }
            Dictionary<int, string> result = new Dictionary<int, string>();
            foreach (DataRow i in dataTable.Rows)
            {
                int idResult = (int)i["Id"];
                string nameResult = (string)i["PublishingHouse"];
                result.Add(idResult, nameResult);
            }
            return result;
        }
    }
}
