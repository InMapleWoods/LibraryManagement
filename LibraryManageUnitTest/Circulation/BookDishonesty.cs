using LibraryManagement.Bll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManageUnitTest.Circulation
{
    [TestClass]
    public class BookDishonesty
    {
        CirculationBll circulationBll = new CirculationBll();
        [TestMethod()]
        public void MoneyReceivedTest()
        {
            int maxId = circulationBll.GetMaxId("Dishonesty");
            if (maxId > 0)
            {
                Assert.AreEqual(true, circulationBll.MoneyReceived(maxId));
            }
            Assert.AreEqual(false, circulationBll.MoneyReceived(-1));
        }

        [TestMethod()]
        public void BookReceivedTest()
        {
            int maxId = circulationBll.GetMaxId("Dishonesty");
            if (maxId > 0)
            {
                Assert.AreEqual(true, circulationBll.BookReceived(maxId));
            }
            Assert.AreEqual(false, circulationBll.BookReceived(-1));
        }

        [TestMethod()]
        public void BookLostTest()
        {
            int maxId = circulationBll.GetMaxId("Book");
            if (maxId > 0)
            {
                Assert.AreEqual(true, circulationBll.BookLost(maxId));
            }
            Assert.AreEqual(false, circulationBll.BookLost(-1));
        }
    }
}
