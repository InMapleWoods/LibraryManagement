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
    /// 验收清单用户操作类
    /// </summary>
    public class AcceptanceListBll
    {
        /// <summary>
        /// 清单数据操作对象
        /// </summary>
        InterviewDal interviewDal = new InterviewDal();

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
    }
}
