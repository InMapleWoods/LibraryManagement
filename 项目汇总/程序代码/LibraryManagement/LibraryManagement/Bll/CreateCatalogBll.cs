using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Dal;
using LibraryManagement.Model;

namespace LibraryManagement.Bll
{
    public class CreateCatalogBll
    {
        /// <summary>
        /// 订单数据操作对象
        /// </summary>
        CatalogDal createDal= new CatalogDal();


        /// <summary>
        /// 增加一条编目记录
        /// </summary>
        /// <param name="list">编目列表</param>
        /// <param name="errorMsg">增加成功与否</param>
        /// <returns></returns>

        public bool AddCatalogList(CreateCatalogList list, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!CreateCatalogList.isNull(list))//是否有空项
                {
                    if (CreateCatalogList.isNormative(list, ref errorMsg))//是否符合规范
                    {
                        result = createDal.AddCatalogList(list );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 删除一条编目记录
        /// </summary>
        /// <param name="listId">编目清单</param>
        /// <returns>删除成功与否</returns>
        public bool DeleteCatalogList(int listId)
        {
            bool result = false;
            try
            {
                result = createDal.DeleteCatalogList(listId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        /// <summary>
        /// 修改一条采访编目记录
        /// </summary>
        /// <param name="list">编目清单</param>
        /// <returns>修改成功与否</returns>
        public bool UpdateCatalogList(CreateCatalogList list, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (list.Id == 0)
                {
                    errorMsg.Add("Id Error");
                    return false;
                }
                if (!CreateCatalogList.isNull(list))//是否有空项
                {
                    if (CreateCatalogList.isNormative(list, ref errorMsg))//是否符合规范
                    {
                        result = createDal.UpdateCatalogList(list);
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
        /// 获取全部订单
        /// </summary>
        /// <returns>全部订单</returns>
        public DataTable GetAllCatalogList()
        {
            DataTable result = null;
            try
            {
                result = createDal.GetAllCatalogList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }
    }
}
