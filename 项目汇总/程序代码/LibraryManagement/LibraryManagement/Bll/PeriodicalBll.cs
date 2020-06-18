using LibraryManagement.Dal;
using LibraryManagement.Model;
using System;
using System.Collections;
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

        #region 期刊订单
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
        /// <returns>删除成功与否</returns>
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
        /// <returns>修改成功与否</returns>
        public bool UpdatePeriodicalOrder(PeriodicalOrder order, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (order.Id == 0)
                {
                    errorMsg.Add("Id Error");
                    return false;
                }
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

        /// <summary>
        /// 获取全部订单
        /// </summary>
        /// <returns>全部订单</returns>
        public IEnumerable GetAllPeriodOrdersArray()
        {
            List<PeriodicalOrder> result = new List<PeriodicalOrder>();
            try
            {
                DataTable datatable = periodicalDal.GetAllPeriodOrders();
                foreach (DataRow dr in datatable.Rows)
                {
                    PeriodicalOrder periodicalOrder = new PeriodicalOrder()
                    {
                        Id = (int)dr["编号"],
                        OrderDate = (DateTime)dr["订购时间"],
                        ISBN = dr["ISBN号"].ToString(),
                        DocumentType = dr["文献类型"].ToString(),
                        PublishCycle = dr["出版周期"].ToString(),
                        OfficialTitle = dr["正刊名"].ToString(),
                        SupplementTitle = dr["副刊名"].ToString(),
                        OrderPrice = double.Parse(dr["订购价"].ToString()),
                        CurrencyType = dr["币种"].ToString(),
                        Size = dr["尺寸"].ToString(),
                    };
                    result.Add(periodicalOrder);
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
        /// 获取分页后订单
        /// </summary>
        /// <returns>分页后订单</returns>
        public IEnumerable GetPeriodOrdersArray(int index, int size)
        {
            List<PeriodicalOrder> result = new List<PeriodicalOrder>();
            try
            {
                DataTable datatable = periodicalDal.GetPeriodOrders(index, size);
                foreach (DataRow dr in datatable.Rows)
                {
                    PeriodicalOrder periodicalOrder = new PeriodicalOrder()
                    {
                        Id = (int)dr["编号"],
                        OrderDate = (DateTime)dr["订购时间"],
                        ISBN = dr["ISBN号"].ToString(),
                        DocumentType = dr["文献类型"].ToString(),
                        PublishCycle = dr["出版周期"].ToString(),
                        OfficialTitle = dr["正刊名"].ToString(),
                        SupplementTitle = dr["副刊名"].ToString(),
                        OrderPrice = (double)dr["订购价"],
                        CurrencyType = dr["币种"].ToString(),
                        Size = dr["尺寸"].ToString(),
                    };
                    result.Add(periodicalOrder);
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

        #region 期刊登到
        /// <summary>
        /// 获取全部订单
        /// </summary>
        /// <returns>全部订单</returns>
        public DataTable GetAllPeriodArrivals()
        {
            DataTable result = null;
            try
            {
                result = periodicalDal.GetAllPeriodArrivals();
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
        public DataTable GetPeriodArrivals(int index, int size)
        {
            DataTable result = null;
            try
            {
                result = periodicalDal.GetPeriodArrivals(index, size);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 增加一条期刊登到记录
        /// </summary>
        /// <param name="arrival">期刊登到</param>
        /// <returns>增加成功与否</returns>
        public bool AddPeriodicalArrival(PeriodicalArrival arrival, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!PeriodicalArrival.isNull(arrival))//是否有空项
                {
                    if (PeriodicalArrival.isNormative(arrival, ref errorMsg))//是否符合规范
                    {
                        result = periodicalDal.AddPeriodicalArrival(arrival);
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
        /// 删除一条期刊登到记录
        /// </summary>
        /// <param name="arrivalId">期刊登到</param>
        /// <returns>增加成功与否</returns>
        public bool DeletePeriodicalArrival(int arrivalId)
        {
            bool result = false;
            try
            {
                result = periodicalDal.DeletePeriodicalArrival(arrivalId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 更改一条期刊登到记录
        /// </summary>
        /// <param name="arrival">期刊登到记录</param>
        /// <returns>更改成功与否</returns>
        public bool UpdatePeriodicalArrival(PeriodicalArrival arrival, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (arrival.Id == 0)
                {
                    errorMsg.Add("Id Error");
                    return false;
                }
                if (!PeriodicalArrival.isNull(arrival))//是否有空项
                {
                    if (PeriodicalArrival.isNormative(arrival, ref errorMsg))//是否符合规范
                    {
                        result = periodicalDal.UpdatePeriodicalArrival(arrival);
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
        public IEnumerable GetAllPeriodArrivalsArray()
        {
            List<PeriodicalArrival> result = new List<PeriodicalArrival>();
            try
            {
                DataTable datatable = periodicalDal.GetAllPeriodArrivals();
                foreach (DataRow dr in datatable.Rows)
                {
                    PeriodicalArrival periodicalArrival = new PeriodicalArrival()
                    {
                        Id = (int)dr["编号"],
                        OrderId = (int)dr["订单编号"],
                        State = dr["状态"].ToString(),
                    };
                    result.Add(periodicalArrival);
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
        /// 获取分页后订单
        /// </summary>
        /// <returns>分页后订单</returns>
        public IEnumerable GetPeriodArrivalsArray(int index, int size)
        {
            List<PeriodicalArrival> result = new List<PeriodicalArrival>();
            try
            {
                DataTable datatable = periodicalDal.GetPeriodOrders(index, size);
                foreach (DataRow dr in datatable.Rows)
                {
                    PeriodicalArrival periodicalArrival = new PeriodicalArrival()
                    {
                        Id = (int)dr["编号"],
                        OrderId = (int)dr["订单编号"],
                        State = dr["状态"].ToString(),
                    };
                    result.Add(periodicalArrival);
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
        /// 将完好期刊写入流通库
        /// </summary>
        /// <returns>更改成功与否</returns>
        public bool MoveArrivedPeriodicalToCirculate()
        {
            bool result = false;
            try
            {
                result = periodicalDal.MoveArrivedPeriodicalToCirculate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        #endregion
        #region 期刊合订
        /// <summary>
        /// 获取全部期刊
        /// </summary>
        /// <returns>全部期刊</returns>
        public DataTable GetAllUnbindedPeriodical()
        {
            DataTable result = null;
            try
            {
                result = periodicalDal.GetAllUnbindedPeriodical();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取全部合订
        /// </summary>
        /// <returns>全部合订</returns>
        public DataTable GetAllPeriodBindings()
        {

            DataTable result = null;
            try
            {
                result = periodicalDal.GetAllPeriodBindings();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取分页后合订
        /// </summary>
        /// <returns>分页后合订</returns>
        public DataTable GetPeriodBindings(int index, int size)
        {

            DataTable result = null;
            try
            {
                result = periodicalDal.GetPeriodBindings(index, size);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 增加一条期刊合订记录
        /// </summary>
        /// <param name="binding">期刊合订记录</param>
        /// <returns>增加成功与否</returns>
        public bool AddPeriodicalBinding(PeriodicalBinding binding, ref List<string> errorMsg)
        {
            bool result = false;
            try
            {
                if (!PeriodicalBinding.isNull(binding))//是否有空项
                {
                    if (PeriodicalBinding.isNormative(binding, ref errorMsg))//是否符合规范
                    {
                        result = periodicalDal.AddPeriodicalBinding(binding);
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
        /// 删除一条期刊合订记录
        /// </summary>
        /// <param name="bindingId">期刊合订Id</param>
        /// <returns>删除成功与否</returns>
        public bool DeletePeriodicalBinding(int bindingId)
        {
            bool result = false;
            try
            {
                result = periodicalDal.DeletePeriodicalBinding(bindingId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }

        /// <summary>
        /// 获取全部合订
        /// </summary>
        /// <returns>全部合订</returns>
        public IEnumerable GetAllPeriodBindingsArray()
        {
            List<PeriodicalBinding> result = new List<PeriodicalBinding>();
            try
            {
                DataTable datatable = periodicalDal.GetAllPeriodBindings();
                foreach (DataRow dr in datatable.Rows)
                {
                    PeriodicalBinding periodicalBinding = new PeriodicalBinding()
                    {
                        Id = (int)dr["编号"],
                        BindingIdList = dr["订单编号"].ToString(),
                        BookId = (int)dr["流通库编号"],
                        BindingName = dr["合订本名称"].ToString(),
                    };
                    result.Add(periodicalBinding);
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
