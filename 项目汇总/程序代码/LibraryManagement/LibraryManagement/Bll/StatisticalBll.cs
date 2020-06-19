using LibraryManagement.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Bll
{
    class StatisticalBll
    {
        StatisticalDal statisticalDal = new StatisticalDal();
        public DataTable getStatisticalInfo()
        {
            DataTable result = null;
            try
            {
                result = statisticalDal.getStatisticInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return result;
        }
        public DataTable getStatisticalResult(string sqlStr)
        {
            DataTable result = null;
            try
            {
                result = statisticalDal.getStatisticResult(sqlStr);
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
