using LibraryManagement.Bll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManageUnitTest.Circulation
{
    [TestClass]
    public class BookReturnUnitTest
    {
        CirculationBll circulationBll = new CirculationBll();
        [TestMethod()]
        public void ReturnBorrowedBookTest()
        {
            int maxId = circulationBll.GetMaxId("Borrow");
            if (maxId > 0)
            {
                Assert.AreEqual(true, circulationBll.ReturnBorrowedBook(maxId));
            }
            Assert.AreEqual(false, circulationBll.ReturnBorrowedBook(-1));
        }
    }
}
