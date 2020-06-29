using System;
using System.Collections;
using System.Collections.Generic;
using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManageUnitTest.Interview
{
    [TestClass]
    public class PurchaseOrderUnitTest
    {
        InterviewBll interviewBll = new InterviewBll();

        [TestMethod]
        public void TestAddPurchaseOrder()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\Mr.Feng\Desktop\软工\测试用例\Add_InterviewPurchaseOrder.xls");
            IEnumerable purchaseOrders = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in purchaseOrders)
            {
                Assert.AreEqual(false, interviewBll.AddPurchaseOrder((InterviewPurchaseOrder)i, ref errorList));
            }
            InterviewPurchaseOrder order = new InterviewPurchaseOrder()
            {
                Id = 1,
                ISBN = "1234567890",
                OrdererId = 1,
                BookName = "采访单元测试",
                Price = 1,
                CurrencyType = "美元＄",
                PublishingHouseId = 1,
                DocumentType = "专著",
            };
            Assert.AreEqual(true, interviewBll.AddPurchaseOrder(order, ref errorList));
        }

        [TestMethod]
        public void TestUpdatePurchaseOrder()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\Mr.Feng\Desktop\软工\测试用例\Update_InterviewPurchaseOrder.xls");
            IEnumerable purchaseOrders = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in purchaseOrders)
            {
                Assert.AreEqual(false, interviewBll.UpdatePurchaseOrder((InterviewPurchaseOrder)i, ref errorList));
            }
            int maxId = -1;
            foreach (InterviewPurchaseOrder i in interviewBll.GetAllPurchaseOrdersArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                InterviewPurchaseOrder order = new InterviewPurchaseOrder()
                {
                    Id = maxId,
                    OrdererId = 1,
                    ISBN = "1234567890",
                    BookName = "采访单元测试",
                    Price = 10,
                    SubDate = DateTime.Now,
                    DocumentType = "期刊",
                    PublishingHouseId = 1,
                    CurrencyType = "美元＄",
                };
                Assert.AreEqual(true, interviewBll.UpdatePurchaseOrder(order, ref errorList));
            }
        }

        [TestMethod]
        public void TestDeletePurchaseOrder()
        {
            int maxId = -1;
            foreach (InterviewPurchaseOrder i in interviewBll.GetAllPurchaseOrdersArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, interviewBll.DeletePurchaseOrder(maxId));
            }
            Assert.AreEqual(false, interviewBll.DeletePurchaseOrder(-1));
        }
    }
}
