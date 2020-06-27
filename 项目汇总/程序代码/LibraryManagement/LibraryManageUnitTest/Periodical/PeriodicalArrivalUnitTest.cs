using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace LibraryManageUnitTest.Periodical
{
    [TestClass]
    public class PeriodicalArrivalUnitTest
    {
        PeriodicalBll periodicalBll = new PeriodicalBll();

        [TestMethod]
        public void TestAddPeriodicalArrival()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\96464\Desktop\软件工程\测试用例\Add_PeriodicalArrival.xls");
            IEnumerable periodicalArrivals = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in periodicalArrivals)
            {
                Assert.AreEqual(false, periodicalBll.AddPeriodicalArrival((PeriodicalArrival)i, ref errorList));
            }
            int maxId = -1;
            foreach (PeriodicalOrder i in periodicalBll.GetAllPeriodOrdersArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            PeriodicalArrival arrival = new PeriodicalArrival()
            {
                Id = 1,
                OrderId = maxId,
                State = "完好",
            };
            Assert.AreEqual(true, periodicalBll.AddPeriodicalArrival(arrival, ref errorList));
        }

        [TestMethod]
        public void TestUpdatePeriodicalArrival()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\96464\Desktop\软件工程\Update_PeriodicalArrival.xls");
            IEnumerable periodicalArrivals = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in periodicalArrivals)
            {
                Assert.AreEqual(false, periodicalBll.UpdatePeriodicalArrival((PeriodicalArrival)i, ref errorList));
            }
            int maxId = -1;
            foreach (PeriodicalArrival i in periodicalBll.GetAllPeriodArrivalsArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            int maxOrderId = -1;
            foreach (PeriodicalOrder i in periodicalBll.GetAllPeriodOrdersArray())
            {
                if (i.Id > maxOrderId)
                {
                    maxOrderId = i.Id;
                }
            }
            if (maxId != -1)
            {
                PeriodicalArrival arrival = new PeriodicalArrival()
                {
                    Id = maxId,
                    OrderId = maxOrderId,
                    State = "待退",
                };
                Assert.AreEqual(true, periodicalBll.UpdatePeriodicalArrival(arrival, ref errorList));
            }
        }

        [TestMethod]
        public void TestDeletePeriodicalArrival()
        {
            int maxId = -1;
            foreach (PeriodicalArrival i in periodicalBll.GetAllPeriodArrivalsArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, periodicalBll.DeletePeriodicalArrival(maxId));
            }
            Assert.AreEqual(false, periodicalBll.DeletePeriodicalArrival(-1));
        }

        [TestMethod]
        public void TestMoveArrivedPeriodicalToCirculate()
        {
            Assert.AreEqual(true, periodicalBll.MoveArrivedPeriodicalToCirculate());
        }
    }
}
