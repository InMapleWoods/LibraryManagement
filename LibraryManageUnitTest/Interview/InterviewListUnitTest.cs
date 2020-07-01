using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace LibraryManageUnitTest.Interview
{
    [TestClass]
    public class InterviewListUnitTest
    {
        InterviewBll interviewBll = new InterviewBll();

        [TestMethod]
        public void TestAddInterviewList()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\Mr.Feng\Desktop\软工\测试用例\Add_InterviewList.xls");
            IEnumerable interviewList = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in interviewList)
            {
                Assert.AreEqual(false, interviewBll.AddInterviewList((InterviewList)i, ref errorList));
            }
            InterviewList list = new InterviewList()
            {
                Id = 1,
                Author = "测试师",
                ISBN = "1234567890",
                PublishingHouseId = 1,
                Price = 50,
                CurrencyType = "美元＄",
                SubscriptionNum = 1,
                DocumentType = "期刊",
                OrderStatus = "采访",
                BookName = "单元测试"
            };
            Assert.AreEqual(true, interviewBll.AddInterviewList(list, ref errorList));
        }

        [TestMethod]
        public void TestUpdateInterviewList()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\Mr.Feng\Desktop\软工\测试用例\Update_InterviewList.xls");
            IEnumerable InterviewList = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in InterviewList)
            {
                Assert.AreEqual(false, interviewBll.UpdateInterviewList((InterviewList)i, ref errorList));
            }
            int maxId = -1;
            foreach (AcceptanceList i in interviewBll.GetAllInterviewListArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                InterviewList list = new InterviewList()
                {
                    Id = 1,
                    Author = "测试师",
                    ISBN = "1234567890",
                    PublishingHouseId = 1,
                    Price = 50,
                    CurrencyType = "美元＄",
                    SubscriptionNum = 1,
                    DocumentType = "期刊",
                    OrderStatus = "采访",
                    BookName = "单元测试"
                };
                Assert.AreEqual(true, interviewBll.UpdateInterviewList(list, ref errorList));
            }
        }

        [TestMethod]
        public void TestDeleteInterviewList()
        {
            int maxId = -1;
            foreach (InterviewList i in interviewBll.GetAllInterviewListArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, interviewBll.DeleteInterviewList(maxId));
            }
            Assert.AreEqual(false, interviewBll.DeleteInterviewList(-1));
        }
    }
}
