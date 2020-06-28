using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryManageUnitTest.Circulation
{
    [TestClass]
    public class BookAppointUnitTest
    {
        CirculationBll circulationBll = new CirculationBll();
        UtilBll utilBll = new UtilBll();
        [TestMethod()]
        public void AddAppointLogTest()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\96464\Desktop\软件工程\测试用例\Add_BookAppointLog.xls");
            IEnumerable bookAppointLogs = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in bookAppointLogs)
            {
                Assert.AreEqual(false, circulationBll.AddAppointLog((BookAppointLog)i, ref errorList));
            }
            int maxId = -1;
            foreach (Book i in circulationBll.GetAllBooksArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            BookAppointLog log = new BookAppointLog()
            {
                Id = 1,
                BookId = maxId,
                AppointmentTime = DateTime.Now,
                ExpireDate = DateTime.Now,
                ReaderId = utilBll.GetUserIdFormNumber("201709001013"),
                State = "有效"
            };
            Assert.AreEqual(true, circulationBll.AddAppointLog(log, ref errorList));
            maxId = -1;
            foreach (Book i in circulationBll.GetAllBooksArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            log = new BookAppointLog()
            {
                Id = 1,
                BookId = maxId,
                AppointmentTime = DateTime.Now,
                ExpireDate = DateTime.Now,
                ReaderId = utilBll.GetUserIdFormNumber("201709001013"),
                State = "有效"
            };
            Assert.AreEqual(true, circulationBll.AddAppointLog(log, ref errorList));
        }

        [TestMethod()]
        public void RemoveAppointLogTest()
        {
            int maxId = circulationBll.GetMaxId("Appoint");
            if (maxId != -1)
            {
                Assert.AreEqual(true, circulationBll.RemoveAppointLog(maxId));
            }
            Assert.AreEqual(false, circulationBll.RemoveAppointLog(-1));
        }
    }
}
