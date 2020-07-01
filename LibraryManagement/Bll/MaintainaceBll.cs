using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.Bll
{
    /// <summary>
    /// 系统维护操作类
    /// </summary>
    public class MaintainaceBll
    {
        MaintainaceDal maintainaceDal = new MaintainaceDal();
        /// <summary>
        /// 新增书商字典用户操作
        /// </summary>
        /// <param name="bookSeller">书商项</param>
        /// <param name="errorMsg">错误集</param>
        /// <returns>是否增添成功</returns>
        public bool AddDicBookSeller(DictionaryBookSeller bookSeller, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!DictionaryBookSeller.isNull(bookSeller))
                {
                    if (!DictionaryBookSeller.isNormative(bookSeller, ref errorMsg))
                    {
                        if (this.AddCaseNameCheckBS(bookSeller))
                        {
                            result = maintainaceDal.AddDicBookSeller(bookSeller);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        /// <summary>
        /// 获取全部书商数据用户操作
        /// </summary>
        /// <returns>书商数据</returns>
        public DataTable getAllDicBookSeller()
        {
            DataTable result = null;
            try
            {
                result = maintainaceDal.getAllDicBookSeller();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        /// <summary>
        /// 分页获取书商字典数据用户操作
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="size">分页容量</param>
        /// <returns>一页书商数据</returns>
        public DataTable getDicBookSeller(int index, int size)
        {
            DataTable result = null;
            try
            {
                result = maintainaceDal.getDicBookSeller(index, size);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        public IEnumerable getAllDicBookSellerArry()
        {
            List<DictionaryBookSeller> result = new List<DictionaryBookSeller>();
            try
            {
                DataTable datatable = maintainaceDal.getAllDicBookSeller();
                foreach (DataRow dr in datatable.Rows)
                {
                    DictionaryBookSeller bookSeller = new DictionaryBookSeller()
                    {
                        Id = (int)dr["编号"],
                        BookSeller = dr["书商名字"].ToString(),
                        Location = dr["地址"].ToString(),
                        Contact = dr["联系人"].ToString(),
                        CallNumber = dr["电话"].ToString(),
                        PostCodes = (int)dr["邮编"],
                        BankName = dr["开户行"].ToString(),
                        Remark = dr["备注"].ToString()
                    };
                    result.Add(bookSeller);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        public IEnumerable getDicBookSellerArry(int index, int size)
        {
            List<DictionaryBookSeller> result = new List<DictionaryBookSeller>();
            try
            {
                DataTable datatable = maintainaceDal.getDicBookSeller(index, size);
                foreach (DataRow dr in datatable.Rows)
                {
                    DictionaryBookSeller bookSeller = new DictionaryBookSeller()
                    {
                        Id = (int)dr["编号"],
                        BookSeller = dr["书商名字"].ToString(),
                        Location = dr["地址"].ToString(),
                        Contact = dr["联系人"].ToString(),
                        CallNumber = dr["电话"].ToString(),
                        PostCodes = (int)dr["邮编"],
                        BankName = dr["开户行"].ToString(),
                        Remark = dr["备注"].ToString()
                    };
                    result.Add(bookSeller);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 新增出版社用户操作
        /// </summary>
        /// <param name="publishingHouse">出版社对象</param>
        /// <param name="errorMsg">错误列表</param>
        /// <returns>返回成功与否</returns>
        public bool AddDicPublishingHouse(DictionaryPublishingHouse publishingHouse, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!DictionaryPublishingHouse.isNull(publishingHouse))
                {
                    if (!DictionaryPublishingHouse.isNormative(publishingHouse, ref errorMsg))
                    {
                        if (this.AddCaseNameCheckPH(publishingHouse))
                        {
                            result = maintainaceDal.AddDicPublishingHouse(publishingHouse);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        /// <summary>
        /// 更新书商信息
        /// </summary>
        /// <param name="bookSeller"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public bool UpdateDicBookSeller(DictionaryBookSeller bookSeller, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!DictionaryBookSeller.isNull(bookSeller))
                {
                    if (!DictionaryBookSeller.isNormative(bookSeller, ref errorMsg))
                    {
                        if (this.UpdateCaseNameCheckBS(bookSeller))
                        {
                            result = maintainaceDal.UpdateBookSeller(bookSeller);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        /// <summary>
        /// 更新出版社信息
        /// </summary>
        /// <param name="bookSeller"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public bool UpdateDicPublishingHouse(DictionaryPublishingHouse publishingHouse, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!DictionaryPublishingHouse.isNull(publishingHouse))
                {
                    if (!DictionaryPublishingHouse.isNormative(publishingHouse, ref errorMsg))
                    {
                        if (this.UpdateCaseNameCheckPH(publishingHouse))
                        {
                            result = maintainaceDal.UpdatePublishingHouse(publishingHouse);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        public bool DeleteDicBookSeller(int Id)
        {
            bool result = false;
            try
            {
                result = maintainaceDal.DeleteBookSellerById(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        public bool DeleteDicPublishingHouse(int Id)
        {
            bool result = false;
            try
            {
                result = maintainaceDal.DeletePublishingHouseById(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        /// <summary>
        /// 获取全部出版社信息用户操作
        /// </summary>
        /// <returns>返回全部出版社信息</returns>
        public DataTable getAllDicPublishingHouse()
        {
            DataTable result = null;
            try
            {
                result = maintainaceDal.getAllDicPublishingHouse();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        /// <summary>
        /// 分页获取出版社信息
        /// </summary>
        /// <param name="index">索引页</param>
        /// <param name="size">页面容量</param>
        /// <returns>返回一页出版社信息</returns>
        public DataTable getDicPublishingHouse(int index, int size)
        {
            DataTable result = null;
            try
            {
                result = maintainaceDal.getDicPublishingHouse(index, size);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        public IEnumerable getAllDicPublishingHouseArray()
        {
            List<DictionaryPublishingHouse> result = new List<DictionaryPublishingHouse>();
            try
            {
                DataTable datatable = maintainaceDal.getAllDicPublishingHouse();
                foreach (DataRow dr in datatable.Rows)
                {
                    DictionaryPublishingHouse publishingHouse = new DictionaryPublishingHouse()
                    {
                        Id = (int)dr["编号"],
                        PublishingHouse = dr["出版社名字"].ToString(),
                        Location = dr["地址"].ToString(),
                        PublishingLocation = dr["出版地"].ToString(),
                        CallNumber = dr["电话"].ToString(),
                        PostCodes = (int)dr["邮编"],
                        BankName = dr["开户行"].ToString(),
                        Remark = dr["备注"].ToString()
                    };
                    result.Add(publishingHouse);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        public IEnumerable getDicPublishingHouseArray(int index, int size)
        {
            List<DictionaryPublishingHouse> result = new List<DictionaryPublishingHouse>();
            try
            {
                DataTable datatable = maintainaceDal.getDicPublishingHouse(index, size);
                foreach (DataRow dr in datatable.Rows)
                {
                    DictionaryPublishingHouse publishingHouse = new DictionaryPublishingHouse()
                    {
                        Id = (int)dr["编号"],
                        PublishingHouse = dr["出版社名字"].ToString(),
                        Location = dr["地址"].ToString(),
                        PublishingLocation = dr["出版地"].ToString(),
                        CallNumber = dr["电话"].ToString(),
                        PostCodes = (int)dr["邮编"],
                        BankName = dr["开户行"].ToString(),
                        Remark = dr["备注"].ToString()
                    };
                    result.Add(publishingHouse);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 增加时的名称查重
        /// </summary>
        /// <param name="dictionaryBookSeller"></param>
        /// <returns>为T则无重复，F则有重复</returns>
        public bool AddCaseNameCheckBS(DictionaryBookSeller dictionaryBookSeller)
        {
            DataTable result = null;

            try
            {
                result = maintainaceDal.getBookSellerByName(dictionaryBookSeller);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            if (result.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 增加时的名称查重
        /// </summary>
        /// <param name="publishingHouse"></param>
        /// <returns>为T则无重复，F则有重复</returns>
        public bool AddCaseNameCheckPH(DictionaryPublishingHouse publishingHouse)
        {
            DataTable result = null;

            try
            {
                result = maintainaceDal.getPublishingHouserByName(publishingHouse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            if (result.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新书商信息名字查重
        /// </summary>
        /// <param name="dictionaryBookSeller"></param>
        /// <returns></returns>
        public bool UpdateCaseNameCheckBS(DictionaryBookSeller dictionaryBookSeller)
        {
            DataTable result = null;

            try
            {
                result = maintainaceDal.getBookSellerByName(dictionaryBookSeller);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            if (result.Rows.Count <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新出版社信息名字查重
        /// </summary>
        /// <param name="publishingHouse"></param>
        /// <returns></returns>
        public bool UpdateCaseNameCheckPH(DictionaryPublishingHouse publishingHouse)
        {
            DataTable result = null;

            try
            {
                result = maintainaceDal.getPublishingHouserByName(publishingHouse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            if (result.Rows.Count <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //**************************************统计报表设计*********************************
        /// <summary>
        /// 获取预览结果
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public DataTable getPreviewResult(string sqlStr)
        {
            DataTable result = null;
            try
            {
                result = maintainaceDal.getStatisticResult(sqlStr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        /// <summary>
        /// 获取详细信息
        /// </summary>
        /// <returns></returns>
        public DataTable getStatisticalInfo()
        {
            DataTable result = null;
            try
            {
                result = maintainaceDal.getStatisticInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        public IEnumerable getAllStatisticalInfoArray()
        {
            List<StatisticalInfo> result = new List<StatisticalInfo>();
            try
            {
                DataTable datatable = maintainaceDal.getStatisticInfo();
                foreach (DataRow dr in datatable.Rows)
                {
                    StatisticalInfo statisticalInfo = new StatisticalInfo()
                    {
                        Id = (int)dr["编号"],
                        TableName = dr["表名称"].ToString(),
                        Operation = dr["操作"].ToString()

                    };
                    result.Add(statisticalInfo);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        public bool AddStatisticalInfo(StatisticalInfo statisticalInfo, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!StatisticalInfo.isNull(statisticalInfo))
                {
                    if (!StatisticalInfo.isNormative(statisticalInfo, ref errorMsg))
                    {
                        if (this.AddCaseNameCheckSI(statisticalInfo))
                        {
                            result = maintainaceDal.AddStatisticalInfo(statisticalInfo);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        public bool UpdateStatisticalInfo(StatisticalInfo statisticalInfo, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!StatisticalInfo.isNull(statisticalInfo))
                {
                    if (!StatisticalInfo.isNormative(statisticalInfo, ref errorMsg))
                    {
                        if (this.UpdateCaseNameCheckSI(statisticalInfo))
                        {
                            result = maintainaceDal.UpdateStatisticalInfo(statisticalInfo);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        public bool AddCaseNameCheckSI(StatisticalInfo statisticalInfo)
        {
            DataTable result = null;

            try
            {
                result = maintainaceDal.getStatisticInfoByName(statisticalInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            if (result.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateCaseNameCheckSI(StatisticalInfo statisticalInfo)
        {
            DataTable result = null;

            try
            {
                result = maintainaceDal.getStatisticInfoByName(statisticalInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            if (result.Rows.Count <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteStatisticalInfo(int id)
        {
            bool result = false;
            try
            {
                result = maintainaceDal.DeleteStatisticalInfo(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        public bool BackupDb(BackupInfo backupInfo)
        {
            bool result = false;
            try
            {
                result = maintainaceDal.BackUpDB(backupInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
    }
}
