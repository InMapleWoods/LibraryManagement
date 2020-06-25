using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                result = interviewDal.GerAllPurchaseOrders();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return result;
        }
        #endregion

        #region 验收清单
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
        #endregion
    }
}
