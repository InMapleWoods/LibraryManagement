using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.Bll
{
    public class CatalogBll
    {
        /// <summary>
        /// 订单数据操作对象
        /// </summary>
        CatalogDal createDal = new CatalogDal();

        #region 直接编目
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
                        result = createDal.AddCatalogList(list);
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
        public bool DeleteCatalogList(int Id)
        {
            bool result = false;
            try
            {
                result = createDal.DeleteCatalogList(Id);
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

        /// <summary>
        /// 获取全部订单
        /// </summary>
        /// <returns>全部订单</returns>
        public IEnumerable GetAllCreateCatalogArray()
        {
            List<CreateCatalogList> result = new List<CreateCatalogList>();
            try
            {
                DataTable datatable = createDal.GetAllCatalogList();
                foreach (DataRow dr in datatable.Rows)
                {
                    CreateCatalogList createCatalogList = new CreateCatalogList()
                    {
                        Id = (int)dr["编号"],
                        FirstAuthor = dr["第一作者"].ToString(),
                        ISBN = dr["ISBN号"].ToString(),
                        PositiveTitle = dr["正题名"].ToString(),
                        PrimaryLiability = dr["第一责任"].ToString(),
                        DocumentType = dr["文献类型"].ToString(),
                        CatalogingDate = (DateTime)dr["编目日期"],
                        
                    };
                    result.Add(createCatalogList);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        #endregion

        #region 采访编目
        /// <summary>
        /// 获取全部采访清单
        /// </summary>
        /// <returns>全部采访清单</returns>
        public DataTable GetAllInterviewCatalog()
        {
            DataTable result = null;
            try
            {
                result = createDal.GetAllInterviewCatalog();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }


        /// <summary>
        /// 增加一条采访编目记录
        /// </summary>
        /// <param name="list">采访编目</param>
        /// <returns>增加成功与否</returns>
        public bool AddInterviewCatalog(InterviewCatalog list, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!InterviewCatalog.isNull(list))//是否有空项
                {
                    if (InterviewCatalog.isNormative(list, ref errorMsg))//是否符合规范
                    {
                        result = createDal.AddInterviewCatalog(list);
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
        /// 删除一条采访编目记录
        /// </summary>
        /// <param name="arrivalId">采访编目</param>
        /// <returns>增加成功与否</returns>
        public bool DeleteInterviewCatalog(int interviewId)
        {
            bool result = false;
            try
            {
                result = createDal.DeleteInterviewCatalog(interviewId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 更改一条编目记录
        /// </summary>
        /// <param name="list">编目记录</param>
        /// <returns>更改成功与否</returns>
        public bool UpdateInterviewCatalog(InterviewCatalog list, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (list.Id == 0)
                {
                    errorMsg.Add("Id Error");
                    return false;
                }
                if (!InterviewCatalog.isNull(list))//是否有空项
                {
                    if (InterviewCatalog.isNormative(list, ref errorMsg))//是否符合规范
                    {
                        result = createDal.UpdateInterviewCatalog(list);
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
        public IEnumerable GetAllInterviewCatalogArray()
        {
            List<InterviewCatalog> result = new List<InterviewCatalog>();
            try
            {
                DataTable datatable = createDal.GetAllInterviewCatalog();
                foreach (DataRow dr in datatable.Rows)
                {
                    InterviewCatalog interviewCatalog = new InterviewCatalog()
                    {
                        Id = (int)dr["编号"],
                        InterviewId = (int)dr["订单编号"],
                        State = dr["状态"].ToString(),
                    };
                    result.Add(interviewCatalog);
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
        /// 将完好书籍写入流通库
        /// </summary>
        /// <returns>更改成功与否</returns>
        public bool MoveInterviewCatalogToCirculate(int id)
        {
            bool result = false;
            try
            {
                result = createDal.MoveInterviewCatalogToCirculate(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        #endregion

        #region 编目移送

        /// <summary>
        /// 移送一条编目清单
        /// </summary>
        /// <param name="list">编目清单</param>
        /// <returns>增加成功与否</returns>
        public bool MoveCatalog(int Id)
        {
            bool result = false;
            try
            {
                result = createDal.MoveCatalog(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        public IEnumerable GetMoveCatalog()
        {
            List<CreateCatalogList> result = new List<CreateCatalogList>();
            try
            {
                DataTable datatable = createDal.GetAllQueryCatalogForm("");
                foreach (DataRow dr in datatable.Rows)
                {
                    CreateCatalogList createCatalogList = new CreateCatalogList()
                    {
                        Id = (int)dr["编号"]                        
                    };
                    result.Add(createCatalogList);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        #endregion

        #region 编目查询

        /// <summary>
        /// 获取全部订单
        /// </summary>
        /// <returns>全部订单</returns>
        public DataTable GetAllQueryPeriodOrders(string id)
        {
            DataTable result = null;
            try
            {
                result = createDal.GetAllQueryCatalogForm(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        #endregion

    }
}
