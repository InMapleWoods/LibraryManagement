using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LibraryManageUnitTest.Periodical
{
    [TestClass]
    public class PeriodicalUnitTest
    {
        PeriodicalBll periodicalBll = new PeriodicalBll();
        [TestMethod]
        public void TestAddPeriodicalOrder()
        {
            List<PeriodicalOrder> periodicalOrders = new List<PeriodicalOrder>(
                new PeriodicalOrder[] { 
                    new PeriodicalOrder() 
                    { 
                        OrdererId = 1, 
                        ISBN = "1234567890",
                        OfficialTitle = "正", 
                        SupplementTitle = "副", 
                        OrderPrice = 10 
                    }, 
                    new PeriodicalOrder() 
                    { 
                        OrdererId = -1, 
                        ISBN = "1234567890", 
                        OfficialTitle = "正",
                        SupplementTitle = "副",
                        OrderPrice = 10
                    }, 
                    new PeriodicalOrder()
                    {
                        OrdererId = 1,
                        ISBN = string.Empty, 
                        OfficialTitle = "正",
                        SupplementTitle = "副",
                        OrderPrice = 10 
                    },
                    new PeriodicalOrder() 
                    { 
                        OrdererId = 1,
                        ISBN = "1234567890",
                        OfficialTitle = string.Empty,
                        SupplementTitle = "副",
                        OrderPrice = 10
                    }, 
                    new PeriodicalOrder() 
                    { 
                        OrdererId = 1,
                        ISBN = "1234567890",
                        OfficialTitle = "正",
                        SupplementTitle = string.Empty, 
                        OrderPrice = 10 
                    },
                    new PeriodicalOrder()
                    { 
                        OrdererId = 1, 
                        ISBN = "1234567890", 
                        OfficialTitle = "正",
                        SupplementTitle = "副", 
                        OrderPrice = -10 
                    }, 
                    new PeriodicalOrder()
                    { 
                        OrdererId = 1, 
                        ISBN = "123456789",
                        OfficialTitle = "正", 
                        SupplementTitle = "副", 
                        OrderPrice = 10 
                    },
                    new PeriodicalOrder() 
                    { 
                        OrdererId = 1,
                        ISBN = "12345678900", 
                        OfficialTitle = "正", 
                        SupplementTitle = "副", 
                        OrderPrice = 10 
                    },
                    new PeriodicalOrder()
                    { 
                        OrdererId = 1, 
                        ISBN = "ABC", 
                        OfficialTitle = "正", 
                        SupplementTitle = "副", 
                        OrderPrice = 10 
                    }, 
                    new PeriodicalOrder() 
                    { 
                        OrdererId = 1, 
                        ISBN = "1234567890", 
                        OfficialTitle = "正", 
                        SupplementTitle = "副", 
                        OrderPrice = 0 
                    } 
                });
            List<string> errorList = new List<string>();
            foreach (var i in periodicalOrders)
            {
                Assert.AreEqual(false, periodicalBll.AddPeriodicalOrder(i, ref errorList));
            }
            PeriodicalOrder order = new PeriodicalOrder()
            {
                OrdererId = 1,
                ISBN = "1234567890",
                OfficialTitle = "单元测试"+DateTime.Now.Date.ToString("yy-MM-dd"),
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
    }
}
