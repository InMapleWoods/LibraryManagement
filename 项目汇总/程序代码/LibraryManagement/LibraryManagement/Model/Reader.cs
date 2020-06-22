using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryManagement.Model
{
    /// <summary>
    /// 流通读者
    /// </summary>
    public class Reader
    {
        /// <summary>
        /// 读者编号
        /// </summary>
        public int Id = 0;

        /// <summary>
        /// 读者姓名
        /// </summary>
        public string Name = "";

        /// <summary>
        /// 读者性别
        /// </summary>
        public string Sex;

        /// <summary>
        /// 读者性别
        /// </summary>
        public int BitSex
        {
            set
            {
                Sex = value == 1 ? "男" : "女";
            }
        }

        /// <summary>
        /// 读者单位
        /// </summary>
        public string Department="";

        /// <summary>
        /// 可借数目
        /// </summary>
        public int BorrowNum = 0;

        /// <summary>
        /// 可预约数
        /// </summary>
        public int AppointNum = 0;

        /// <summary>
        /// 有效期
        /// </summary>
        public int ValidityTerm = 0;

        /// <summary>
        /// 罚金倍数
        /// </summary>
        public double ForfeitMultiples = 0;

        /// <summary>
        /// 待缴罚金
        /// </summary>
        public double ExtendedForfeit = 0;
    }
}
