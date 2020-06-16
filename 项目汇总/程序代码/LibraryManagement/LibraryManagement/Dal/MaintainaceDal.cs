using LibraryManagement.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Dal
{
    class MaintainaceDal
    {
        /// <summary>
        /// 工具对象
        /// </summary>
        private SQLHelper helper = new SQLHelper();
        /*
        /// <summary>
        /// 增加书商数据操作
        /// </summary>
        /// <param name="bookseller">书商字典项</param>
        /// <returns>返回成功与否</returns>
        public bool AddDicBookSeller(DictionaryBookSeller bookseller)
        {
            string sqlStr = "INSERT INTO tb_DictionaryBookSeller ( " +
            "BookSeller," +
            "Location," +
            " Contact," +
            " `CallNumber`," +
            " Postcodes," +
            " BankName," +
            " Remark " +
            ")" +
            "VALUES(" +
            "@BookSeller," +
            "@Location," +
            " @Contact," +
            " @CallNumber," +
            " @Postcodes," +
            " @BankName," +
            " @Remark " +
            ");";
            //储存DB
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@BookSeller",bookseller.BookSeller),
                new MySqlParameter("@Location",bookseller.Location),
                new MySqlParameter("@Contact",bookseller.Contact),
                new MySqlParameter("@CallNumber",bookseller.CallNumber),
                new MySqlParameter("@Postcodes",bookseller.PostCodes),
                new MySqlParameter("@BankName",bookseller.BankName),
                new MySqlParameter("@Remark",bookseller.Remark),
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
        }*/
        public bool AddDicBookSeller(DictionaryBookSeller bookseller)
        {
            string sqlStr = "AddBooksellerDictionary";
            //储存DB
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@returnValue",MySqlDbType.Int32,4),
                new MySqlParameter("@name",bookseller.BookSeller),
                new MySqlParameter("@location",bookseller.Location),
                new MySqlParameter("@contact",bookseller.Contact),
                new MySqlParameter("@callNum",bookseller.CallNumber),
                new MySqlParameter("@postcodes",bookseller.PostCodes),
                new MySqlParameter("@bankName",bookseller.BankName),
                new MySqlParameter("@remark",bookseller.Remark),
            };
            para[0].Direction = ParameterDirection.Output;//将第一个变量设为输出变量
            int count = helper.ExecuteNonQuery(sqlStr, para, CommandType.StoredProcedure);
            int result = (int)para[0].Value;//获取返回值
            if (result == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 增添出版社数据操作
        /// </summary>
        /// <param name="publishingHouse">出版社项</param>
        /// <returns>返回成功与否</returns>
        public bool AddDicPublishingHouse(DictionaryPublishingHouse publishingHouse)
        {
            string sqlStr = "INSERT INTO tb_DictionaryPublishingHouse ( " +
            "PublishingHouse," +
            "Location," +
            " PublishingLocation," +
            " CallNumber," +
            " Postcodes," +
            " BankName," +
            " Remark " +
            ")" +
            "VALUES(" +
            "@PublishingHouse," +
            "@Location," +
            "@PublishingLocation," +
            "@CallNumber," +
            "@Postcodes," +
            "@BankName," +
            "@Remark " +
            ");";
            //储存DB
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@PublishingHouse",publishingHouse.PublishingHouse),
                new MySqlParameter("@Location",publishingHouse.Location),
                new MySqlParameter("@PublishingLocation",publishingHouse.PublishingLocation),
                new MySqlParameter("@CallNumber",publishingHouse.CallNumber),
                new MySqlParameter("@Postcodes",publishingHouse.PostCodes),
                new MySqlParameter("@BankName",publishingHouse.BankName),
                new MySqlParameter("@Remark",publishingHouse.Remark),
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
        /// 修改书商字典
        /// </summary>
        /// <param name="bookSeller"></param>
        /// <returns></returns>
        public bool UpdateBookSeller(DictionaryBookSeller bookSeller)
        {
            string sqlStr = "UPDATE tb_DictionaryBookSeller SET " +
                " BookSeller=@BookSeller, " +
                " Location=@Location, " +
                " Contact=@Contact, " +
                " CallNumber=@CallNumber, " +
                " Postcodes=@Postcodes, " +
                " BankName=@BankName, " +
                " Remark=@Remark " +
                " where Id=@Id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                
                new MySqlParameter("@BookSeller",bookSeller.BookSeller),
                new MySqlParameter("@Location",bookSeller.Location),
                new MySqlParameter("@Contact",bookSeller.Contact),
                new MySqlParameter("@CallNumber",bookSeller.CallNumber),
                new MySqlParameter("@Postcodes",bookSeller.PostCodes),
                new MySqlParameter("@BankName",bookSeller.BankName),
                new MySqlParameter("@Remark",bookSeller.Remark),
                new MySqlParameter("@Id",bookSeller.Id),
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
        /// 修改出版社字典
        /// </summary>
        /// <param name="publishingHouse"></param>
        /// <returns></returns>
        public bool UpdatePublishingHouse(DictionaryPublishingHouse publishingHouse)
        {
            string sqlStr = "UPDATE tb_DictionaryPublishingHouse SET " +
                " PublishingHouse=@PublishingHouse, " +
                " Location=@Location, " +
                " PublishingLocation=@PublishingLocation, " +
                " CallNumber=@CallNumber, " +
                " Postcodes=@Postcodes, " +
                " BankName=@BankName, " +
                " Remark=@Remark " +
                " where Id=@Id;";
            //储存Datatable
            MySqlParameter[] para = new MySqlParameter[]//存储相应参数的容器
            {
                new MySqlParameter("@Id",publishingHouse.Id),
                new MySqlParameter("@PublishingHouse",publishingHouse.PublishingHouse),
                new MySqlParameter("@Location",publishingHouse.Location),
                new MySqlParameter("@PublishingLocation",publishingHouse.PublishingLocation),
                new MySqlParameter("@CallNumber",publishingHouse.CallNumber),
                new MySqlParameter("@Postcodes",publishingHouse.PostCodes),
                new MySqlParameter("@BankName",publishingHouse.BankName),
                new MySqlParameter("@Remark",publishingHouse.Remark),
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
        /// 通过ID删除书商信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DeleteBookSellerById(int Id)
        {
            string sqrStr = " DELETE FROM tb_DictionaryBookSeller " +
                " WHERE Id = @Id ;";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@Id", Id)
            };
            int count = helper.ExecuteNonQuery(sqrStr, paras, CommandType.Text);
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
        /// 通过ID删除出版社信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DeletePublishingHouseById(int Id)
        {
            string sqrStr = " DELETE FROM tb_DictionaryPublishingHouse " +
                " WHERE Id = @Id ;";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@Id", Id)
            };
            int count = helper.ExecuteNonQuery(sqrStr, paras, CommandType.Text);
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
        /// 获取全部书商字典
        /// </summary>
        /// <returns>库中全部数据</returns>
        public DataTable getAllDicBookSeller()
        {
            string sqlstr = "Select " +
            " tb_DictionaryBookSeller.Id as 编号," +
            " tb_DictionaryBookSeller.BookSeller as 书商名字," +
            " tb_DictionaryBookSeller.Location as 地址," +
            " tb_DictionaryBookSeller.Contact as 联系人," +
            " tb_DictionaryBookSeller.CallNumber as 电话," +
            " tb_DictionaryBookSeller.Postcodes as 邮编," +
            " tb_DictionaryBookSeller.BankName as 开户行," +
            " tb_DictionaryBookSeller.Remark as 备注" +
            " from tb_DictionaryBookSeller;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        /// <summary>
        /// 获取全部出版社字典
        /// </summary>
        /// <returns>库中全部数据</returns>
        public DataTable getAllDicPublishingHouse()
        {
            string sqlstr = "Select " +
            " tb_DictionaryPublishingHouse.Id as 编号," +
            " tb_DictionaryPublishingHouse.PublishingHouse as 出版社名字," +
            " tb_DictionaryPublishingHouse.Location as 地址," +
            " tb_DictionaryPublishingHouse.PublishingLocation as 出版地," +
            " tb_DictionaryPublishingHouse.CallNumber as 电话," +
            " tb_DictionaryPublishingHouse.Postcodes as 邮编," +
            " tb_DictionaryPublishingHouse.BankName as 开户行," +
            " tb_DictionaryPublishingHouse.Remark as 备注 " +
            " from tb_DictionaryPublishingHouse;";
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, paras, CommandType.Text);
            return dataTable;
        }
        /// <summary>
        /// 分页获取书商信息
        /// </summary>
        /// <param name="index">索引页</param>
        /// <param name="size">每页容量</param>
        /// <returns></returns>
        public DataTable getDicBookSeller(int index, int size)
        {
            int startPos = (index - 1) * size;
            int endPos = size;
            string sqlstr = "Select " +
            " tb_DictionaryBookSeller.Id as 编号," +
            " tb_DictionaryBookSeller.BookSeller as 书商名字," +
            " tb_DictionaryBookSeller.Location as 地址," +
            " tb_DictionaryBookSeller.Contact as 联系人," +
            " tb_DictionaryBookSeller.CallNumber as 电话," +
            " tb_DictionaryBookSeller.Postcodes as 邮编," +
            " tb_DictionaryBookSeller.BankName as 开户行," +
            " tb_DictionaryBookSeller.Remark as 备注 " +
            " from tb_DictionaryBookSeller limit @startPos,@endPos;";

            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@startPos",startPos),
                new MySqlParameter("@endPos", endPos),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, para, CommandType.Text);
            return dataTable;
        }
        /// <summary>
        /// 分页获取出版社字典
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public DataTable getDicPublishingHouse(int index, int size)
        {
            int startPos = (index - 1) * size;
            int endPos = size;
            string sqlstr = "Select " +
            "tb_DictionaryPublishingHouse.Id as 编号," +
            "tb_DictionaryPublishingHouse.PublishingHouse as 出版社名字," +
            "tb_DictionaryPublishingHouse.Location as 地址," +
            "tb_DictionaryPublishingHouse.PublishingLocation as 出版地," +
            "tb_DictionaryPublishingHouse.CallNumber as 电话," +
            "tb_DictionaryPublishingHouse.Postcodes as 邮编," +
            "tb_DictionaryPublishingHouse.BankName as 开户行," +
            "tb_DictionaryPublishingHouse.Remark as 备注" +
            "from tb_DictionaryPublishingHouse limit @startPos,@endPos;";

            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@startPos",startPos),
                new MySqlParameter("@endPos", endPos),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlstr, para, CommandType.Text);
            return dataTable;
        }
        /// <summary>
        /// 通过ID获取书商信息
        /// </summary>
        /// <param name="bookSeller"></param>
        /// <returns></returns>
        public DataTable getBookSellerByName(DictionaryBookSeller bookSeller)
        {
            string sqlStr = "Select " +
            " tb_DictionaryBookSeller.Id as 编号," +
            " tb_DictionaryBookSeller.BookSeller as 书商名字," +
            " tb_DictionaryBookSeller.Location as 地址," +
            " tb_DictionaryBookSeller.Contact as 联系人," +
            " tb_DictionaryBookSeller.CallNumber as 电话," +
            " tb_DictionaryBookSeller.Postcodes as 邮编," +
            " tb_DictionaryBookSeller.BankName as 开户行," +
            " tb_DictionaryBookSeller.Remark as 备注" +
            " from tb_DictionaryBookSeller" +
            " Where BookSeller =@BookSeller ;";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@BookSeller",bookSeller.BookSeller),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, para, CommandType.Text);
            return dataTable;
        }
        public DataTable getPublishingHouserByName(DictionaryPublishingHouse publishingHouse)
        {
            string sqlStr = "Select " +
            " tb_DictionaryPublishingHouse.Id as 编号," +
            " tb_DictionaryPublishingHouse.PublishingHouse as 出版社名字," +
            " tb_DictionaryPublishingHouse.Location as 地址," +
            " tb_DictionaryPublishingHouse.PublishingLocation as 出版地," +
            " tb_DictionaryPublishingHouse.CallNumber as 电话," +
            " tb_DictionaryPublishingHouse.Postcodes as 邮编," +
            " tb_DictionaryPublishingHouse.BankName as 开户行," +
            " tb_DictionaryPublishingHouse.Remark as 备注 " +
            " from tb_DictionaryPublishingHouse" +
            " Where PublishingHouse =@PublishingHouse ;";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@PublishingHouse",publishingHouse.PublishingHouse),
            };
            DataTable dataTable = helper.ExecuteQuery(sqlStr, para, CommandType.Text);
            return dataTable;
        }

    }
}
