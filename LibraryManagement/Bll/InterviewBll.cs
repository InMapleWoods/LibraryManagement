using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.Bll
{
    /// <summary>
    /// 采访子系统用户操作类
    /// </summary>
    public class InterviewBll
    {
        /// <summary>
        /// 采访数据操作对象
        /// </summary>
        InterviewDal interviewDal = new InterviewDal();

        #region 采访清单
        /// <summary>
        /// 增加一条采访清单记录
        /// </summary>
        /// <param name="list">采访清单</param>
        /// <param name="errorMsg">增加成功与否</param>
        /// <returns></returns>
        public bool AddInterviewList(InterviewList list, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!InterviewList.isNull(list))//是否有空项
                {
                    if (InterviewList.isNormative(list, ref errorMsg))//是否符合规范
                    {
                        result = interviewDal.AddInterviewList(list);
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
        /// 删除一条采访清单记录
        /// </summary>
        /// <param name="Id">采访清单</param>
        /// <returns>删除成功与否</returns>
        public bool DeleteInterviewList(int Id)
        {
            bool result = false;
            try
            {
                result = interviewDal.DeleteInterviewList(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 修改一条采访清单记录
        /// </summary>
        /// <param name="list">采访清单</param>
        /// <returns>修改成功与否</returns>
        public bool UpdateInterviewList(InterviewList list, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (list.Id == 0)
                {
                    errorMsg.Add("Id Error");
                    return false;
                }
                if (!InterviewList.isNull(list))//是否有空项
                {
                    if (InterviewList.isNormative(list, ref errorMsg))//是否符合规范
                    {
                        result = interviewDal.UpdateInterviewList(list);
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
        /// 获取全部清单
        /// </summary>
        /// <returns>全部清单</returns>
        public DataTable GetAllInterviewList()
        {
            DataTable result = null;
            try
            {
                result = interviewDal.GetAllInterviewList();
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
        public IEnumerable GetAllInterviewListArray()
        {
            List<InterviewList> result = new List<InterviewList>();
            try
            {
                DataTable datatable = interviewDal.GetAllInterviewList();
                foreach (DataRow dr in datatable.Rows)
                {
                    InterviewList interviewList = new InterviewList()
                    {
                        Id = (int)dr["清单号"],
                        Author = dr["作者"].ToString(),
                        ISBN = dr["ISBN号"].ToString(),
                        CurrencyType = dr["货币种类"].ToString(),
                        SubscriptionNum = (int)dr["征订册数"],
                        OrderStatus = dr["订购状态"].ToString(),
                        BookName = dr["书名"].ToString(),
                        Price = double.Parse(dr["价格"].ToString()),
                        PublishingHouseId = int.Parse(dr["出版社ID"].ToString()),
                        DocumentType = dr["文献类型"].ToString(),
                    };
                    result.Add(interviewList);
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

        #region 采购订单

        /// <summary>
        /// 增加一条采购订单记录
        /// </summary>
        /// <param name="order">采购订单</param>
        /// <param name="errorMsg">增加成功与否</param>
        /// <returns></returns>
        public bool AddPurchaseOrder(InterviewPurchaseOrder order, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!InterviewPurchaseOrder.isNull(order))//是否有空项
                {
                    if (InterviewPurchaseOrder.isNormative(order, ref errorMsg))//是否符合规范
                    {
                        result = interviewDal.AddPurchaseOrder(order);
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
        /// 删除一条采购订单记录
        /// </summary>
        /// <param name="orderId">采购订单</param>
        /// <returns>增加成功与否</returns>
        public bool DeletePurchaseOrder(int orderId)
        {
            bool result = false;
            try
            {
                result = interviewDal.DeletePurchaseOrder(orderId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 修改一条采购订单记录
        /// </summary>
        /// <param name="order">采购订单</param>
        /// <returns>修改成功与否</returns>
        public bool UpdatePurchaseOrder(InterviewPurchaseOrder order, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (order.Id == 0)
                {
                    errorMsg.Add("Id Error");
                    return false;
                }
                if (!InterviewPurchaseOrder.isNull(order))//是否有空项
                {
                    if (InterviewPurchaseOrder.isNormative(order, ref errorMsg))//是否符合规范
                    {
                        result = interviewDal.UpdatePurchaseOrder(order);
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
        public DataTable GetAllPurchaseOrders()
        {
            DataTable result = null;
            try
            {
                result = interviewDal.GetAllPurchaseOrders();
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
        public IEnumerable GetAllPurchaseOrdersArray()
        {
            List<InterviewPurchaseOrder> result = new List<InterviewPurchaseOrder>();
            try
            {
                DataTable datatable = interviewDal.GetAllPurchaseOrders();
                foreach (DataRow dr in datatable.Rows)
                {
                    InterviewPurchaseOrder interviewPurchaseOrder = new InterviewPurchaseOrder()
                    {
                        Id = (int)dr["订单号"],
                        SubDate = (DateTime)dr["订单日期"],
                        ISBN = dr["ISBN号"].ToString(),
                        OrdererId = int.Parse(dr["订购人ID"].ToString()),
                        BookName = dr["书名"].ToString(),
                        DocumentType = dr["文献类型"].ToString(),
                        Price = double.Parse(dr["价格"].ToString()),
                        PublishingHouseId = int.Parse(dr["出版社ID"].ToString()),
                        CurrencyType = dr["币种"].ToString(),
                    };
                    result.Add(interviewPurchaseOrder);
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

        #region 验收清单

        /// <summary>
        /// 根据订单编号获取订购人编号
        /// </summary>
        /// <param name="id">订单编号</param>
        /// <returns>订购人编号</returns>
        public int GetOrdererIdByNum(string id)
        {
            int result = -1;
            try
            {
                result = interviewDal.GetOrdererIdByNum(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 增加一条验收清单记录
        /// </summary>
        /// <param name="list">验收清单</param>
        /// <param name="errorMsg">增加成功与否</param>
        /// <returns></returns>
        public bool AddAcceptanceList(AcceptanceList list, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!AcceptanceList.isNull(list))//是否有空项
                {
                    if (AcceptanceList.isNormative(list, ref errorMsg))//是否符合规范
                    {
                        result = interviewDal.AddAcceptanceList(list);
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
        /// 删除一条验收清单记录
        /// </summary>
        /// <param name="Id">验收清单</param>
        /// <returns>删除成功与否</returns>
        public bool DeleteAcceptanceList(int Id)
        {
            bool result = false;
            try
            {
                result = interviewDal.DeleteAcceptanceList(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 修改一条验收清单记录
        /// </summary>
        /// <param name="list">验收清单</param>
        /// <returns>修改成功与否</returns>
        public bool UpdateAcceptanceList(AcceptanceList list, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (list.Id == 0)
                {
                    errorMsg.Add("Id Error");
                    return false;
                }
                if (!AcceptanceList.isNull(list))//是否有空项
                {
                    if (AcceptanceList.isNormative(list, ref errorMsg))//是否符合规范
                    {
                        result = interviewDal.UpdateAcceptanceList(list);
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
        /// 获取全部清单
        /// </summary>
        /// <returns>全部清单</returns>
        public DataTable GetAllAcceptanceList()
        {
            DataTable result = null;
            try
            {
                result = interviewDal.GetAllAcceptanceList();
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
        public IEnumerable GetAllAcceptanceListArray()
        {
            List<AcceptanceList> result = new List<AcceptanceList>();
            try
            {
                DataTable datatable = interviewDal.GetAllAcceptanceList();
                foreach (DataRow dr in datatable.Rows)
                {
                    AcceptanceList acceptanceList = new AcceptanceList()
                    {
                        Id = (int)dr["清单号"],
                        OrderId = (int)dr["订单号"],
                        AcceptorId = (int)dr["订单号"],
                        State = dr["状态"].ToString(),

                    };
                    result.Add(acceptanceList);
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

        #region 退货清单

        /// <summary>
        /// 增加一条退货清单记录
        /// </summary>
        /// <param name="list">退货清单</param>
        /// <param name="errorMsg">增加成功与否</param>
        /// <returns></returns>
        public bool AddReturnList(InterviewReturnList list, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!InterviewReturnList.isNull(list))//是否有空项
                {
                    if (InterviewReturnList.isNormative(list, ref errorMsg))//是否符合规范
                    {
                        result = interviewDal.AddReturnList(list);
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
        /// 获取全部清单
        /// </summary>
        /// <returns>全部清单</returns>
        public DataTable GetAllReturnList()
        {
            DataTable result;
            try
            {
                result = interviewDal.GetAllReturnList();
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
        public IEnumerable GetAllReturnListArray()
        {
            List<InterviewReturnList> result = new List<InterviewReturnList>();
            try
            {
                DataTable datatable = interviewDal.GetAllReturnList();
                foreach (DataRow dr in datatable.Rows)
                {
                    InterviewReturnList interviewReturnList = new InterviewReturnList()
                    {
                        Id = (int)dr["清单号"],
                        SubDate = (DateTime)dr["订单日期"],
                        ISBN = dr["ISBN号"].ToString(),
                        OrdererId = (int)dr["订购人ID"],
                        BookName = dr["书名"].ToString(),
                        Price = double.Parse(dr["价格"].ToString()),
                        PublishingHouseId = int.Parse(dr["出版社ID"].ToString()),
                        DocumentType = dr["文献类型"].ToString(),
                    };
                    result.Add(interviewReturnList);
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
    }
}
