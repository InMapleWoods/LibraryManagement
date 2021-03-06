﻿using LibraryManagement.Model;
using MySql.Data.MySqlClient;
using System;
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

        #region 直接编目
        /// <summary>
        /// 增加一条直接编目记录
        /// </summary>
        /// <param name="list">编目清单</param>
        /// <returns>增加成功与否</returns>
        public bool AddCatalogList(CreateCatalogList list)
        {
            string sqlStr = "INSERT INTO tb_CatalogForm (" +
             "ISBN," +
             "PositiveTitle," +
             "FirstAuthor," +
             "PublishingHouseId," +
             "DocumentType," +
             "PrimaryLiability," +
             "CatalogerId," +
             "CatalogingDate" +
             ")" +
             "VALUES(" +
             "@iSBN," +
             "@positiveTitel," +
             "@firstAuther," +
             "@publishingHouseId," +
             "@documentType," +
             "@primaryLiability," +
             "@catalogerId," +
             "@catalogingDate" +
             ")";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
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
        /// 删除一条直接编目记录
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
        /// 修改一条直接编目记录
        /// </summary>
        /// <param name="list">编目清单</param>
        /// <returns>修改成功与否</returns>
        public bool UpdateCatalogList(CreateCatalogList list)
        {
            string sqlStr = "UPDATE tb_CatalogForm SET " +
                "ISBN=@iSBN, " +
                "PositiveTitle=@positiveTitle, " +
                "FirstAuthor=@firstAuthor, " +
                "PublishingHouseId=@publishingHouseId, " +
                "DocumentType=@documentType, " +
                "PrimaryLiability=@primaryLiability, " +
                "CatalogerId=@catalogerId, " +
                "CatalogingDate=@catalogingDate " +
                "where Id=@id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {

                new MySqlParameter("@iSBN",list.ISBN),
                new MySqlParameter("@documentType",list.DocumentType),
                new MySqlParameter("@positiveTitle",list.PositiveTitle),
                new MySqlParameter("@firstAuthor",list.FirstAuthor),
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
                "tb_CatalogForm.Id as 编号," +
                "tb_CatalogForm.FirstAuthor as 第一作者," +
                "tb_CatalogForm.ISBN as ISBN号," +
                 "tb_CatalogForm.PositiveTitle as 正题名," +
                "tb_DictionaryPublishingHouse.PublishingHouse as 出版社," +
                "tb_CatalogForm.PrimaryLiability as 第一责任," +
                "tb_CatalogForm.DocumentType as 文献类型," +
                "tb_BasicInformation.UserName as 编目人员," +
                "tb_CatalogForm.CatalogingDate as 编目日期" +
                " from " +
                "tb_CatalogForm inner join " +
                 "tb_DictionaryPublishingHouse inner join " +
                 "tb_BasicInformation " +
                "on tb_CatalogForm.PublishingHouseId=tb_DictionaryPublishingHouse.Id " +
                "and tb_CatalogForm.CatalogerId=tb_BasicInformation.UserId ";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        #endregion

        #region 采访编目
        /// <summary>
        /// 获取全部清单
        /// </summary>
        /// <returns>全部清单</returns>
        public DataTable GetAllAcceptanceList()
        {
            string sqlstr = " SELECT " +
                " tb_AcceptanceList.Id AS `编号`, " +
                " tb_BasicInformation.UserName AS `验收人`, " +
                " tb_AcceptanceList.OrderId AS `订单编号` " +
                " FROM " +
                " tb_AcceptanceList " +
                " INNER JOIN tb_BasicInformation ON tb_AcceptanceList.AcceptorId = tb_BasicInformation.UserId WHERE Not Exists (select * from tb_InterviewCatalog where tb_InterviewCatalog.InterviewId=tb_AcceptanceList.Id) AND tb_AcceptanceList.State<>'已编目';";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        /// <summary>
        /// 获取全部采访
        /// </summary>
        /// <returns>全部采访</returns>

        public DataTable GetAllInterviewCatalog()
        {
            string sqlstr = " SELECT " +
                " tb_InterviewCatalog.Id AS 编号, " +
                " tb_InterviewCatalog.InterviewId AS 采访验收编号, " +
                //" tb_DictionaryBookSeller.BookSeller AS 书商名, " +
                //" tb_DictionaryPublishingHouse.PublishingHouse AS 出版社, " +
                // " tb_AcceptanceList.OrdererId AS 订购人, " +
                //" tb_AcceptanceList.AcceptorId AS 验收人, " +
                " tb_InterviewCatalog.State AS 状态  " +
                " FROM " +
                " tb_InterviewCatalog where tb_InterviewCatalog.State<>'已入表';";//+
                                                                               //" INNER JOIN tb_AcceptanceList " +
                                                                               //" INNER JOIN tb_DictionaryPublishingHouse " +
                                                                               //" INNER JOIN tb_DictionaryBookSeller " +
                                                                               //" ON tb_InterviewCatalog.InterviewId = tb_AcceptanceList.Id;";// +
                                                                               //" AND tb_DictionaryBookSeller.Id = tb_AcceptanceList.BookSellerId" +
                                                                               //" AND tb_DictionaryPublishingHouse.Id = tb_AcceptanceList.PublishingHouse;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }

        /// <summary>
        /// 增加一条采访编目记录
        /// </summary>
        /// <param name="list">采访编目记录</param>
        /// <returns>增加成功与否</returns>
        public bool AddInterviewCatalog(InterviewCatalog list)
        {
            string sqlStr = "INSERT INTO tb_InterviewCatalog (" +
                "InterviewId," +
                "State" +
                ") " +
                "VALUES(" +
                "@interviewId," +
                "@state" +
                ");";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@interviewId",list.InterviewId),
                new MySqlParameter("@state",list.State),
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
        /// <param name="interviewCatalogId">采访编目Id</param>
        /// <returns>删除成功与否</returns>
        public bool DeleteInterviewCatalog(int interviewCatalogId)
        {
            string sqlStr = "Delete from tb_InterviewCatalog where Id=@id;";
            //储存Datatable        
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@id",interviewCatalogId),
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
        /// 更改一条采访编目记录
        /// </summary>
        /// <param name="list">采访编目记录</param>
        /// <returns>更改成功与否</returns>
        public bool UpdateInterviewCatalog(InterviewCatalog list)
        {
            string sqlStr = "UPDATE tb_InterviewCatalog SET " +
                "InterviewId=@interviewId, " +
                "State=@state " +
                "where Id=@id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@state",list.State),
                new MySqlParameter("@interviewId",list.InterviewId),
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
        /// 将完好编目写入流通库
        /// </summary>
        /// <returns>更改成功与否</returns>
        public bool MoveInterviewCatalogToCirculate(int id)
        {
            string sqlStr = "MoveAcceptToCatalog";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@returnValue",MySqlDbType.Bit,1),
                new MySqlParameter("@catalogId",id),
                new MySqlParameter("@catalogDate",DateTime.Now),
            };
            para[0].Direction = ParameterDirection.Output;//将第一个变量设为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
            return para[0].Value.ToString() == "1";
        }
        #endregion

        #region 编目移送
        /// <summary>
        /// 获取全部编目
        /// </summary>
        /// <returns>全部编目</returns>
        public DataTable GetAllQueryCatalogForm()
        {
            string sqlstr = "select " +
                "tb_CatalogForm.Id as 编号," +
                "tb_CatalogForm.ISBN as ISBN号," +
                "tb_CatalogForm.DocumentType as 文献类型," +
                "tb_CatalogForm.PositiveTitle as 正刊名," +
                "tb_DictionaryPublishingHouse.PublishingHouse as 出版社," +
                "tb_CatalogForm.PrimaryLiability as 第一责任," +
                "tb_CatalogForm.FirstAuthor as 第一作者," +
                "tb_CatalogForm.CatalogingDate as 编目日期," +
                "tb_BasicInformation.UserName as 编目人员" +
                " from " +
                "tb_CatalogForm inner join " +
                "tb_DictionaryPublishingHouse inner join " +
                "tb_BasicInformation " +
                "on tb_CatalogForm.CatalogerId=tb_BasicInformation.UserId " +
                "and tb_CatalogForm.PublishingHouseId=tb_DictionaryPublishingHouse.Id " +
                "and tb_CatalogForm.State='未处理';";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        public bool MoveCatalog(int Id)
        {
            string sqlStr = " SELECT " +
               " tb_CatalogForm.Id AS `编目编号`, " +
               " tb_CatalogForm.ISBN AS ISBN, " +
               " tb_CatalogForm.PositiveTitle AS `题目名称`, " +
               " tb_CatalogForm.FirstAuthor AS `第一作者`, " +
               " tb_CatalogForm.PublishingHouseId AS `出版社编号`, " +
               " tb_CatalogForm.DocumentType AS `文献类型`, " +
               " tb_CatalogForm.State AS `编目状态`  " +
               " FROM " +
               " tb_CatalogForm  " +
               " WHERE " +
               " tb_CatalogForm.Id = @id " +
               " AND tb_CatalogForm.State = '未处理';";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@id",Id),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, paras, CommandType.Text);
            if (dataTable.Rows.Count <= 0)
                return false;
            DataRow row = dataTable.Rows[0];
            CreateCatalogList createCatalogList = new CreateCatalogList()
            {
                Id = int.Parse(row["编目编号"].ToString()),
                ISBN = row["ISBN"].ToString(),
                PositiveTitle = row["题目名称"].ToString(),
                FirstAuthor = row["第一作者"].ToString(),
                PublishingHouseId = int.Parse(row["出版社编号"].ToString()),
                DocumentType = row["文献类型"].ToString(),

            };
            sqlStr = "UPDATE tb_CatalogForm SET tb_CatalogForm.State='已处理' where tb_CatalogForm.state='未处理' and tb_CatalogForm.Id=@id";
            paras = new MySqlParameter[]
            {
                new MySqlParameter("@id",createCatalogList.Id),
            };
            int count = helper.ExecuteNonQuery(sqlStr, paras, CommandType.Text);
            sqlStr = "INSERT INTO tb_CirculateBooks (" +
                " tb_CirculateBooks.ISBN," +
                " tb_CirculateBooks.FirstAuthor," +
                " tb_CirculateBooks.DocumentType, " +
                "tb_CirculateBooks.BookStatus, " +
                "tb_CirculateBooks.OfficialTitle, " +
                "tb_CirculateBooks.PublishingHouseId" +
                " )VALUES" +
                "(" +
                 "@iSBN," +
                 "@firstAuther," +
                 "@documentType," +
                 "@bookStatus," +
                 "@officialTitle," +
                 "@publishingHouseId" +
                 ")";
            paras = new MySqlParameter[]
            {
                new MySqlParameter("@iSBN",createCatalogList.ISBN),
                new MySqlParameter("@firstAuther",createCatalogList.FirstAuthor),
                new MySqlParameter("@documentType",createCatalogList.DocumentType),
                new MySqlParameter("@bookStatus","可借阅"),
                new MySqlParameter("@officialTitle",createCatalogList.PositiveTitle),
                new MySqlParameter("@publishingHouseId",createCatalogList.PublishingHouseId),
            };
            count = helper.ExecuteNonQuery(sqlStr, paras, CommandType.Text);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 编目查询
        /// <summary>
        /// 获取全部编目
        /// </summary>
        /// <returns>全部编目</returns>
        public DataTable GetAllQueryCatalogForm(string id)
        {
            id = "%" + id + "%";
            string sqlstr = "select " +
                "tb_CatalogForm.Id as 编号," +
                "tb_CatalogForm.ISBN as ISBN号," +
                "tb_CatalogForm.DocumentType as 文献类型," +
                "tb_CatalogForm.PositiveTitle as 正刊名," +
                "tb_DictionaryPublishingHouse.PublishingHouse as 出版社," +
                "tb_CatalogForm.PrimaryLiability as 第一责任," +
                "tb_CatalogForm.FirstAuthor as 第一作者," +
                "tb_CatalogForm.CatalogingDate as 编目日期," +
                "tb_BasicInformation.UserName as 编目人员" +
                " from " +
                "tb_CatalogForm inner join " +
                "tb_DictionaryPublishingHouse inner join " +
                "tb_BasicInformation " +
                "on tb_CatalogForm.CatalogerId=tb_BasicInformation.UserId " +
                "and tb_CatalogForm.PublishingHouseId=tb_DictionaryPublishingHouse.Id " +
                "and tb_CatalogForm.Id LIKE @id ;";
            MySqlParameter[] paras = new MySqlParameter[]
           {
                new MySqlParameter("@id",id),

           };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        #endregion
    }
}



