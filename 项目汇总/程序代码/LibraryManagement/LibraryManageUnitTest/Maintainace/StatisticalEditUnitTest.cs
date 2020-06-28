using System;
using System.Collections;
using System.Collections.Generic;
using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManageUnitTest.Maintainace
{
    [TestClass]
    public class StatisticalEditUnitTest
    {
        MaintainaceBll maintainaceBll = new MaintainaceBll();
        [TestMethod]
        public void TestAddStatisticalInfo()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\73473\Desktop\软件工程\用例\Add_StatisticalInfo.xls");
            IEnumerable addStatisticalInfo = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in addStatisticalInfo)
            {
                Assert.AreEqual(false, maintainaceBll.AddStatisticalInfo((StatisticalInfo)i, ref errorList));
            }
            //int maxId = -1;
            //foreach (DictionaryBookSeller i in maintainaceBll.getAllDicBookSellerArry())
            //{
            //    if (i.Id > maxId)
            //    {
            //        maxId = i.Id;
            //    }
            //}
            StatisticalInfo statisticalInfo = new StatisticalInfo()
            {
                Id = -1,
                TableName = "PeriodicalOrder",
                Operation = "select * from tb_PeriodicalOrder;",
                

            };
            Assert.AreEqual(true, maintainaceBll.AddStatisticalInfo(statisticalInfo,ref errorList));
        }
        [TestMethod]
        public void TestUpdateStatisticalInfo()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\73473\Desktop\软件工程\用例\Update_StatisticalInfo.xls");
            IEnumerable updateStatisticalInfo = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in updateStatisticalInfo)
            {
                Assert.AreEqual(false, maintainaceBll.UpdateStatisticalInfo((StatisticalInfo)i, ref errorList));
            }
            int maxId = -1;
            foreach (StatisticalInfo i in maintainaceBll.getAllStatisticalInfoArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            StatisticalInfo statisticalInfo = new StatisticalInfo()
            {
                Id = maxId,
                TableName = "PeriodicalOrder",
                Operation = "select * from tb_PeriodicalOrder;",


            };
            Assert.AreEqual(true, maintainaceBll.UpdateStatisticalInfo(statisticalInfo,ref errorList));
        }
        [TestMethod]
        public void TestDeleteStatisticalInfo()
        {
            int maxId = -1;
            foreach (StatisticalInfo i in maintainaceBll.getAllStatisticalInfoArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, maintainaceBll.DeleteStatisticalInfo(maxId));
            }
            Assert.AreEqual(false, maintainaceBll.DeleteDicBookSeller(-1));
        }
    }
}
