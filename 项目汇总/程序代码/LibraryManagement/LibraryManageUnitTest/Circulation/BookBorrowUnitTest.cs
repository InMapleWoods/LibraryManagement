using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryManageUnitTest.Circulation
{
    [TestClass]
    public class BookBorrowUnitTest
    {
        CirculationBll circulationBll = new CirculationBll();
        UtilBll utilBll = new UtilBll();
        [TestMethod()]
        public void AddBorrowLogTest()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\96464\Desktop\软件工程\测试用例\Add_BookBorrowLog.xls");
            IEnumerable bookBorrowLogs = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in bookBorrowLogs)
            {
                Assert.AreEqual(false, circulationBll.AddBorrowLog((BookBorrowLog)i, ref errorList));
            }
            int maxId = -1;
            foreach (Book i in circulationBll.GetAllBooksArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            BookBorrowLog log = new BookBorrowLog()
            {
                Id = 1,
                BookId = maxId,
                ReaderId = utilBll.GetUserIdFormNumber("201709001013"),
                State = "有效",
                BorrowTime = DateTime.Now,
            };
            Assert.AreEqual(true, circulationBll.AddBorrowLog(log, ref errorList));
            maxId = -1;
            foreach (Book i in circulationBll.GetAllBooksArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            log = new BookBorrowLog()
            {
                Id = 1,
                BookId = maxId,
                ReaderId = utilBll.GetUserIdFormNumber("201709001013"),
                State = "有效",
                BorrowTime = DateTime.Now,
            };
            Assert.AreEqual(true, circulationBll.AddBorrowLog(log, ref errorList));
        }

        [TestMethod()]
        public void RemoveBorrowLogTest()
        {
            int maxId = circulationBll.GetMaxId("Borrow");
            if (maxId != -1)
            {
                Assert.AreEqual(true, circulationBll.RemoveBorrowLog(maxId));
            }
            Assert.AreEqual(false, circulationBll.RemoveBorrowLog(-1));
        }
    }
}
