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
    /// <summary>
    /// 采访清单用户操作类
    /// </summary>
    public class InterviewListBll
    {

        /// <summary>
        /// 清单数据操作对象
        /// </summary>
        InterviewDal interviewDal = new InterviewDal();

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
                if(!InterviewList.isNull(list))//是否有空项
                {
                    if(InterviewList.isNormative(list, ref errorMsg))//是否符合规范
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex; 
            }
            return result;
        }
    }
}
