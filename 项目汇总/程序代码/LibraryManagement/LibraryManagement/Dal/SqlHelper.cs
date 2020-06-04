using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Dal
{
    public class SQLHelper
    {
        private readonly MySqlConnection conn = null;
        private MySqlCommand cmd = null;
        private readonly MySqlDataReader sdr = null;

        public SQLHelper(string sqlConnect)
        {
            conn = new MySqlConnection(sqlConnect);
        }
        
        public SQLHelper()
        {
            conn = new MySqlConnection("server=152.136.73.240;port=1733;database=db_LibraryManagement;user id=Lsa;password=llfllf;Charset=utf8;");
        }

        private string protectsql(string text)
        {/*
            text = text.Replace(";", "");
            text = text.Replace("-", "");*/
            return text;
        }

        /// <summary>
        /// 打开数据库
        /// </summary>
        /// <returns>返回SqlConnection</returns>
        private MySqlConnection getconn()
        {
            try
            {
                //打开链接            
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception) { throw; }
            return conn;
        }


        /// <summary>
        /// 查询表中数据条数
        /// </summary>
        /// <param name="cmdtext">要查询的表</param>
        /// <returns>表中数据条数</returns>
        public int sqlNum(string cmdtext)
        {
            cmdtext = protectsql(cmdtext);
            string sqltext = "SELECT COUNT(*) from " + cmdtext;
            getconn();
            int res = 0;
            try
            {
                using (cmd = new MySqlCommand(sqltext, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    res = (int)(long)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                res = -1;
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return res;
        }

        /// <summary>
        /// 查询表中数据最大值
        /// </summary>
        /// <param name="cmdCol">要查询的列名称</param>
        /// <param name="cmdtext">要查询的表</param>
        /// <returns>表中数据最大值</returns>
        public int sqlMaxColValue(string cmdCol, string cmdtext)
        {
            cmdtext = protectsql(cmdtext);
            string sqltext = "SELECT Max(" + cmdCol + ") from " + cmdtext;
            getconn();
            int res = 0;
            try
            {
                using (cmd = new MySqlCommand(sqltext, conn))
                {

                    cmd.CommandType = CommandType.Text;
                    res = (int)(long)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                res = -1;
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return res;
        }

        /// <summary>
        /// 查询表中数据条数
        /// </summary>
        /// <param name="cmdID">要查询的ID列名称</param>
        /// <param name="cmdtext">要查询的表</param>
        /// <returns>表中数据最大值</returns>
        public int sqlMaxID(string cmdID, string cmdtext)
        {
            cmdtext = protectsql(cmdtext);
            string sqltext = "SELECT Max(" + cmdID + ")+1 from " + cmdtext;
            getconn();
            int res = 0;
            try
            {
                using (cmd = new MySqlCommand(sqltext, conn))
                {

                    cmd.CommandType = CommandType.Text;
                    res = (int)(long)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                res = -1;
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return res;
        }

        /// <summary>
        /// 执行SQL查询语句
        /// </summary>
        /// <param name="cmdtext">SQL查询语句</param>
        /// <returns>返回DataTable数据表</returns>
        public DataTable reDt(string cmdtext)
        {
            cmdtext = protectsql(cmdtext);
            getconn();
            MySqlDataAdapter da;
            DataSet ds;
            try
            {
                using (da = new MySqlDataAdapter(cmdtext, conn))
                {
                    using (ds = new DataSet())
                    {
                        da.Fill(ds);
                        return (ds.Tables[0]);
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        ///  执行带参数的增删改SQL语句或存储过程
        /// </summary>
        /// <param name="cmdtext">增删改SQL语句或存储过程</param>
        /// <param name="paras">参数集合</param>
        /// <param name="ct">命令类型（SQL语句或存储过程）</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string cmdtext, MySqlParameter[] paras, CommandType ct)
        {//该方法执行传入的SQL语句
            cmdtext = protectsql(cmdtext);
            int res = 0;
            try
            {
                using (cmd = new MySqlCommand(cmdtext, getconn()))
                {
                    cmd.CommandType = ct;
                    cmd.Parameters.AddRange(paras);
                    res = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return res;
        }

        /// <summary>
        /// 执行带参数查询SQL语句或存储过程
        /// </summary>
        /// <param name="cmdtext">查询SQL语句或存储过程</param>
        /// <param name="paras">参数集合</param>
        /// <param name="ct">命令类型（SQL语句或存储过程）</param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string cmdtext, MySqlParameter[] paras, CommandType ct)
        {//执行查询
            cmdtext = protectsql(cmdtext);
            DataTable dt = new DataTable();
            try
            {
                using (cmd = new MySqlCommand(cmdtext, getconn()))
                {
                    cmd.CommandType = ct;
                    cmd.Parameters.AddRange(paras);
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        dt.Load(sdr);
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }

        /// <summary>
        ///  MD5加密
        /// </summary>
        /// <param name="strPwd">要加密的字符串</param>
        /// <returns>返回加密后的字符串</returns>
        public string GetMD5(string strPwd)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(strPwd);
            byte[] MD5data = md5.ComputeHash(data);
            md5.Clear();
            string str = "";
            for (int i = 0; i < MD5data.Length - 1; i++)
            {
                str += MD5data[i].ToString("X").PadLeft('1', '0');
            }
            md5.Dispose();
            return str;
        }
    }
}
