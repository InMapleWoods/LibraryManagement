using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LibraryManageUnitTest.Periodical
{
    [TestClass]
    public class PeriodicalBindingUnitTest
    {

        PeriodicalBll periodicalBll = new PeriodicalBll();

        [TestMethod]
        public void TestAddPeriodicalBinding()
        {
            List<string> errorList = new List<string>();
            PeriodicalBinding binding1 = new PeriodicalBinding()
            {
                Id = 1,
                BookId = 1,
                BindingIdList = "",
                BindingName = "单元测试Add",
            };
            PeriodicalBinding binding2 = new PeriodicalBinding()
            {
                Id = 1,
                BookId = 1,
                BindingIdList = "2|3",
                BindingName = "",
            };
            Assert.AreEqual(false, periodicalBll.AddPeriodicalBinding(binding1, ref errorList));
            Assert.AreEqual(false, periodicalBll.AddPeriodicalBinding(binding2, ref errorList));
            int max1Id = -1;
            int max2Id = -1;
            Book[] books = ((List<Book>)periodicalBll.GetAllUnbindedPeriodicalArray()).ToArray();
            if (books.Length < 2)
            {
                return;
            }
            else
            {
                max1Id = books[books.Length - 1].Id;
                max2Id = books[books.Length - 2].Id;
            }
            PeriodicalBinding binding = new PeriodicalBinding()
            {
                Id = 1,
                BookId = 1,
                BindingIdList = max1Id + "|" + max2Id,
                BindingName = "单元测试Add",
            };
            Assert.AreEqual(true, periodicalBll.AddPeriodicalBinding(binding, ref errorList));
        }

        [TestMethod]
        public void TestDeletePeriodicalBinding()
        {
            int maxId = -1;
            foreach (PeriodicalBinding i in periodicalBll.GetAllPeriodBindingsArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, periodicalBll.DeletePeriodicalBinding(maxId));
            }
            Assert.AreEqual(false, periodicalBll.DeletePeriodicalBinding(-1));
        }
    }
}
