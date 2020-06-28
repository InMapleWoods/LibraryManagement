using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManageUnitTest.Catalog
{
    [TestClass()]
    public class CatalogMoveUnitTest
    {

        CatalogBll createCatalogBll = new CatalogBll();

        [TestMethod()]
        public void MoveCatalogTest()
        {
            int maxId = -1;
            foreach (CreateCatalogList i in createCatalogBll.GetMoveCatalog())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, createCatalogBll.MoveCatalog(maxId));
            }
            Assert.AreEqual(false, createCatalogBll.MoveCatalog(-1));
        }
    }
}
