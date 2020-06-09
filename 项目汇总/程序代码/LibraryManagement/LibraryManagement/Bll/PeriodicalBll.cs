using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.Bll
{
    /// <summary>
    /// 期刊用户操作类
    /// </summary>
    public class PeriodicalBll
    {
        /// <summary>
        /// 期刊数据操作对象
        /// </summary>
        PeriodicalDal periodicalDal = new PeriodicalDal();

        /// <summary>
        /// 增加一条期刊订单记录
        /// </summary>
        /// <param name="order">期刊订单</param>
        /// <returns>增加成功与否</returns>
        public bool AddPeriodicalOrder(PeriodicalOrder order, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!PeriodicalOrder.isNull(order))//是否有空项
                {
                    if (PeriodicalOrder.isNormative(order, ref errorMsg))//是否符合规范
                    {
                        result = periodicalDal.AddPeriodicalOrder(order);
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
        /// 删除一条期刊订单记录
        /// </summary>
        /// <param name="orderId">期刊订单</param>
        /// <returns>增加成功与否</returns>
        public bool DeletePeriodicalOrder(int orderId)
        {
            bool result = false;
            try
            {
                result = periodicalDal.DeletePeriodicalOrder(orderId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 修改一条期刊订单记录
        /// </summary>
        /// <param name="order">期刊订单</param>
        /// <returns>增加成功与否</returns>
        public bool UpdatePeriodicalOrder(PeriodicalOrder order, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!PeriodicalOrder.isNull(order))//是否有空项
                {
                    if (PeriodicalOrder.isNormative(order, ref errorMsg))//是否符合规范
                    {
                        result = periodicalDal.UpdatePeriodicalOrder(order);
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
        public DataTable GetAllPeriodOrders()
        {
            DataTable result = null;
            try
            {
                result = periodicalDal.GetAllPeriodOrders();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取分页后订单
        /// </summary>
        /// <returns>分页后订单</returns>
        public DataTable GetPeriodOrders(int index, int size)
        {
            DataTable result = null;
            try
            {
                result = periodicalDal.GetPeriodOrders(index, size);
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
