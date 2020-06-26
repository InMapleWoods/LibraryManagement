using LibraryManagement.Dal;
using System;
using System.Collections.Generic;

namespace LibraryManagement.Bll
{
    public class UtilBll
    {
        UtilDal utilDal = new UtilDal();

        /// <summary>
        /// 由用户账号获取用户Id
        /// </summary>
        /// <param name="number"></param>
        /// <returns>用户ID</returns>
        public int GetUserIdFormNumber(string number)
        {
            int result = -1;
            try
            {
                result = utilDal.GetUserIdFormNumber(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取书商名称
        /// </summary>
        /// <returns>书商名称</returns>
        public Dictionary<int, string> GetBookSellerNames()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            try
            {
                result = utilDal.GetBookSellerNames();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取出版社名称
        /// </summary>
        /// <returns>出版社名称</returns>
        public Dictionary<int, string> GetPublishingHouseNames()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            try
            {
                result = utilDal.GetPublishingHouseNames();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取院系名称
        /// </summary>
        /// <returns>院系名称</returns>
        public Dictionary<int, string> GetReaderDepartmentName()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            try
            {
                result = utilDal.GetReaderDepartmentName();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取读者级别
        /// </summary>
        /// <returns>读者级别</returns>
        public Dictionary<int, string> GetReaderLevel()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            try
            {
                result = utilDal.GetReaderLevel();
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
