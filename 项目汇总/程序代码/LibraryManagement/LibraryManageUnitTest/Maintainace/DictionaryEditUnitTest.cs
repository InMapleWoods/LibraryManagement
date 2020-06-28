using System;
using System.Collections;
using System.Collections.Generic;
using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManageUnitTest.Maintainace
{
    [TestClass]
    public class DictionaryEditUnitTest
    {
        MaintainaceBll maintainaceBll = new MaintainaceBll();
        [TestMethod]
        public void TestAddBookSeller()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\73473\Desktop\软件工程\用例\Add_DictionaryBookSeller.xls");
            IEnumerable addBookSeller = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in addBookSeller)
            {
                Assert.AreEqual(false, maintainaceBll.AddDicBookSeller((DictionaryBookSeller)i, ref errorList));
            }
            //int maxId = -1;
            //foreach (DictionaryBookSeller i in maintainaceBll.getAllDicBookSellerArry())
            //{
            //    if (i.Id > maxId)
            //    {
            //        maxId = i.Id;
            //    }
            //}
            DictionaryBookSeller bookSeller = new DictionaryBookSeller()
            {
                Id = -1,
                BookSeller = "新华书店",
                Location = "华电路",
                Contact = "小黄",
                CallNumber = "1234567890",
                PostCodes = 12345,
                BankName = "建设银行",
                Remark = ""

            };
            Assert.AreEqual(true,maintainaceBll.AddDicBookSeller(bookSeller,ref errorList));
        }
        [TestMethod]
        public void TestUpdateBookSeller()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\73473\Desktop\软件工程\用例\Update_DictionaryBookSeller.xls");
            IEnumerable updateBookSeller = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in updateBookSeller)
            {
                Assert.AreEqual(false, maintainaceBll.UpdateDicBookSeller((DictionaryBookSeller)i, ref errorList));
            }
            int maxId = -1;
            foreach (DictionaryBookSeller i in maintainaceBll.getAllDicBookSellerArry())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            DictionaryBookSeller bookSeller = new DictionaryBookSeller()
            {
                Id = maxId,
                BookSeller = "新华书店",
                Location = "华电路",
                Contact = "小黄",
                CallNumber = "1234567890",
                PostCodes = 12345,
                BankName = "建设银行",
                Remark = ""

            };
            Assert.AreEqual(true, maintainaceBll.UpdateDicBookSeller(bookSeller, ref errorList));
        }
        [TestMethod]
        public void TestDeleteBookSeller()
        {
            int maxId = -1;
            foreach (DictionaryBookSeller i in maintainaceBll.getAllDicBookSellerArry())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, maintainaceBll.DeleteDicBookSeller(maxId));
            }
            Assert.AreEqual(false, maintainaceBll.DeleteDicBookSeller(-1));
        }
        [TestMethod]
        public void TestAddPublishingHouse()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\73473\Desktop\软件工程\用例\Add_DictionaryPublishingHouse.xls");
            IEnumerable addPublishingHouse = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in addPublishingHouse)
            {
                Assert.AreEqual(false, maintainaceBll.AddDicPublishingHouse((DictionaryPublishingHouse)i, ref errorList));
            }
            //int maxId = -1;
            //foreach (DictionaryBookSeller i in maintainaceBll.getAllDicBookSellerArry())
            //{
            //    if (i.Id > maxId)
            //    {
            //        maxId = i.Id;
            //    }
            //}
            DictionaryPublishingHouse publishingHouse = new DictionaryPublishingHouse()
            {
                Id = -1,
                PublishingHouse = "华电出版社",
                Location = "华电路",
                PublishingLocation = "华北电力大学",
                CallNumber = "1234567890",
                PostCodes = 12345,
                BankName = "建设银行",
                Remark = ""

            };
            Assert.AreEqual(true, maintainaceBll.AddDicPublishingHouse(publishingHouse,ref errorList));
        }
        [TestMethod]
        public void TestUpdatePublishingHouse()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\73473\Desktop\软件工程\用例\Update_DictionaryPublishingHouse.xls");
            IEnumerable updatePublishingHouse = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in updatePublishingHouse)
            {
                Assert.AreEqual(false,maintainaceBll.UpdateDicPublishingHouse((DictionaryPublishingHouse)i, ref errorList));
            }
            int maxId = -1;
            foreach (DictionaryPublishingHouse i in maintainaceBll.getAllDicPublishingHouseArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            DictionaryPublishingHouse publishingHouse = new DictionaryPublishingHouse()
            {
                Id = maxId,
                PublishingHouse = "华电出版社",
                Location = "华电路",
                PublishingLocation = "华北电力大学",
                CallNumber = "1234567890",
                PostCodes = 12345,
                BankName = "建设银行",
                Remark = ""

            };
            Assert.AreEqual(true, maintainaceBll.UpdateDicPublishingHouse(publishingHouse,ref errorList));
        }
        [TestMethod]
        public void TestDeletePublishingHouse()
        {
            int maxId = -1;
            foreach (DictionaryPublishingHouse i in maintainaceBll.getAllDicPublishingHouseArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, maintainaceBll.DeleteDicBookSeller(maxId));
            }
            Assert.AreEqual(false, maintainaceBll.DeleteDicBookSeller(-1));
        }
    }

}
