using System;
using System.Collections;
using System.Collections.Generic;
using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManageUnitTest.Interview
{
    [TestClass]
    public class AcceptanceListUnitTest
    {
        InterviewBll interviewBll = new InterviewBll();

        [TestMethod]
        public void TestAddAcceptanceList()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\96464\Desktop\软件工程\测试用例\Add_AcceptanceList.xls");
            IEnumerable acceptanceList = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in acceptanceList)
            {
                Assert.AreEqual(false, interviewBll.AddAcceptanceList((AcceptanceList)i, ref errorList));
            }
            AcceptanceList list = new AcceptanceList()
            {
                Id = 1,
                OrderId = 1,
                AcceptorId = 1,
                State = "已编目",
            };
            Assert.AreEqual(true, interviewBll.AddAcceptanceList(list, ref errorList));
        }

        [TestMethod]
        public void TestUpdateAcceptanceList()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\Mr.Feng\Desktop\软工\测试用例\Update_AcceptanceList.xls");
            IEnumerable acceptanceList = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in acceptanceList)
            {
                Assert.AreEqual(false, interviewBll.UpdateAcceptanceList((AcceptanceList)i, ref errorList));
            }
            int maxId = -1;
            foreach (AcceptanceList i in interviewBll.GetAllAcceptanceListArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                AcceptanceList list = new AcceptanceList()
                {
                    Id = maxId,
                    OrderId = 10,
                    AcceptorId = 200,
                    State = "已编目",
                };
                Assert.AreEqual(true, interviewBll.UpdateAcceptanceList(list, ref errorList));
            }
        }

        [TestMethod]
        public void TestDeleteAcceptanceList()
        {
            int maxId = -1;
            foreach (AcceptanceList i in interviewBll.GetAllAcceptanceListArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, interviewBll.DeleteAcceptanceList(maxId));
            }
            Assert.AreEqual(false, interviewBll.DeleteAcceptanceList(-1));
        }
    }
}
