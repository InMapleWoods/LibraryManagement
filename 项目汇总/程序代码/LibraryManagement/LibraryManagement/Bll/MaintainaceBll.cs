using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.Bll
{
    /// <summary>
    /// 系统维护操作类
    /// </summary>
    class MaintainaceBll
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
            catch(Exception e)
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
            catch(Exception e)
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            if(result.Rows.Count == 0)
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
            if (result.Rows.Count <=1)
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
            catch(Exception e)
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
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
        public bool DeleteStatisticalInfo(StatisticalInfo statisticalInfo)
        {
            bool result = false;
            try
            {
                result = maintainaceDal.DeleteStatisticalInfo(statisticalInfo);
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
