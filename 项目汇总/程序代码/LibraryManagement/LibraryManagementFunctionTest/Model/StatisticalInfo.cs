using System.Collections.Generic;

namespace LibraryManagementFunctionTest.Model
{
    class StatisticalInfo
    {
        //编号
        public int Id;
        //表名
        public string TableName;
        //操作
        public string Operation;

        public static bool isNull(StatisticalInfo statisticalInfo)
        {

            if (statisticalInfo.TableName == "")
            {
                return true;
            }
            if (statisticalInfo.Operation == "")
            {
                return true;
            }
            return false;
        }
        public static bool isNormative(StatisticalInfo statisticalInfo, ref List<string> errorMsg)
        {
            return false;//待做
        }
    }

}
