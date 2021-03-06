﻿using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryManageUnitTest.Periodical
{
    [TestClass]
    public class PeriodicalOrderUnitTest
    {
        PeriodicalBll periodicalBll = new PeriodicalBll();

        [TestMethod]
        public void TestAddPeriodicalOrder()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\96464\Desktop\软件工程\测试用例\Add_PeriodicalOrder.xls");
            IEnumerable periodicalOrders = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in periodicalOrders)
            {
                Assert.AreEqual(false, periodicalBll.AddPeriodicalOrder((PeriodicalOrder)i, ref errorList));
            }
            PeriodicalOrder order = new PeriodicalOrder()
            {
                OrdererId = 1,
                ISBN = "1234567890",
                OfficialTitle = "单元测试" + DateTime.Now.Date.ToString("yy-MM-dd"),
                SupplementTitle = "单元测试" + DateTime.Now.Date.ToString("yy-MM-dd"),
                OrderPrice = 10,
                BookSellerId = 1,
                OrderDate = DateTime.Now,
                DocumentType = "期刊",
                PublishCycle = "月刊",
                PublishingHouseId = 1,
                CurrencyType = "美元(USD)",
                Size = "A4",
            };
            Assert.AreEqual(true, periodicalBll.AddPeriodicalOrder(order, ref errorList));
        }

        [TestMethod]
        public void TestUpdatePeriodicalOrder()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\96464\Desktop\软件工程\测试用例\Update_PeriodicalOrder.xls");
            IEnumerable periodicalOrders = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in periodicalOrders)
            {
                Assert.AreEqual(false, periodicalBll.UpdatePeriodicalOrder((PeriodicalOrder)i, ref errorList));
            }
            int maxId = -1;
            foreach (PeriodicalOrder i in periodicalBll.GetAllPeriodOrdersArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                PeriodicalOrder order = new PeriodicalOrder()
                {
                    Id = maxId,
                    OrdererId = 1,
                    ISBN = "1234567890",
                    OfficialTitle = "单元测试" + DateTime.Now.Date.ToString("yy-MM-dd"),
                    SupplementTitle = "单元测试" + DateTime.Now.Date.ToString("yy-MM-dd"),
                    OrderPrice = 10,
                    BookSellerId = 1,
                    OrderDate = DateTime.Now,
                    DocumentType = "期刊",
                    PublishCycle = "月刊",
                    PublishingHouseId = 1,
                    CurrencyType = "美元(USD)",
                    Size = "A4",
                };
                Assert.AreEqual(true, periodicalBll.UpdatePeriodicalOrder(order, ref errorList));
            }
        }

        [TestMethod]
        public void TestDeletePeriodicalOrder()
        {
            int maxId = -1;
            foreach (PeriodicalOrder i in periodicalBll.GetAllPeriodOrdersArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, periodicalBll.DeletePeriodicalOrder(maxId));
            }
            Assert.AreEqual(false, periodicalBll.DeletePeriodicalOrder(-1));
        }

    }
}
