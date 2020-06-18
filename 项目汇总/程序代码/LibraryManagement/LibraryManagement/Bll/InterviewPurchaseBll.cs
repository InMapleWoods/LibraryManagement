﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Dal;
using LibraryManagement.Model;

namespace LibraryManagement.Bll
{
    /// <summary>
    /// 采购订单用户操作类
    /// </summary>
    public class InterviewPurchaseBll
    {
        /// <summary>
        /// 订单数据操作对象
        /// </summary>
        InterviewDal purchaseDal = new InterviewDal();

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
                if(!InterviewPurchaseOrder.isNull(order))//是否有空项
                {
                    if(InterviewPurchaseOrder.isNormative(order, ref errorMsg))//是否符合规范
                    {
                        result = purchaseDal.AddPurchaseOrder(order);
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
                result = purchaseDal.DeletePurchaseOrder(orderId);
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
                        result = purchaseDal.UpdatePurchaseOrder(order);
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
                result = purchaseDal.GerAllPurchaseOrders();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex; 
            }
            return result;
        }


    }
}
