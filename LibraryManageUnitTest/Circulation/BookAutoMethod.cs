using LibraryManagement.Bll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManageUnitTest.Circulation
{
    [TestClass]
    public class BookAutoMethod
    {
        CirculationBll circulationBll = new CirculationBll();
        [TestMethod()]
        public void DealAllLogTest()
        {
            circulationBll.DealAllLog();
        }
    }
}
