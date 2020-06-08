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
                        result = maintainaceDal.AddDicBookSeller(bookSeller);
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
                        result = maintainaceDal.AddDicPublishingHouse(publishingHouse);
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
    }
}
