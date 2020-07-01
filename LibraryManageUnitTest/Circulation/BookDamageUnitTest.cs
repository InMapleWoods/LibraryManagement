using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryManageUnitTest.Circulation
{
    [TestClass]
    public class BookDamageUnitTest
    {
        CirculationBll circulationBll = new CirculationBll();
        UtilBll utilBll = new UtilBll();
        [TestMethod()]
        public void UpdateDamageLogTest()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\96464\Desktop\软件工程\测试用例\Update_BookDamageLog.xls");
            IEnumerable bookDamageLogs = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in bookDamageLogs)
            {
                Assert.AreEqual(false, circulationBll.UpdateDamageLog((BookDamageLog)i));
            }
            int maxId = -1;
            foreach (Book i in circulationBll.GetAllBooksArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            BookDamageLog log = new BookDamageLog()
            {
                Id = circulationBll.GetMaxId("Damage"),
                BookId = maxId,
                RepairState = "已修复",
                CheckerId = utilBll.GetUserIdFormNumber("201709001013"),
                CheckTime = DateTime.Now,
                DamageDetail = "update单元测试损坏详情" + DateTime.Now.ToString("yy-MM-dd")
            };
            Assert.AreEqual(true, circulationBll.UpdateDamageLog(log));
        }

        [TestMethod()]
        public void AddDamageLogTest()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\96464\Desktop\软件工程\测试用例\Add_BookDamageLog.xls");
            IEnumerable bookDamageLogs = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in bookDamageLogs)
            {
                Assert.AreEqual(false, circulationBll.AddDamageLog((BookDamageLog)i, ref errorList));
            }
            int maxId = -1;
            foreach (Book i in circulationBll.GetAllBooksArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            BookDamageLog log = new BookDamageLog()
            {
                Id = 1,
                BookId = maxId,
                RepairState = "已修复",
                CheckerId = utilBll.GetUserIdFormNumber("201709001013"),
                CheckTime = DateTime.Now,
                DamageDetail = "add单元测试损坏详情" + DateTime.Now.ToString("yy-MM-dd")
            };
            Assert.AreEqual(true, circulationBll.AddDamageLog((BookDamageLog)log, ref errorList));
        }
    }
}
