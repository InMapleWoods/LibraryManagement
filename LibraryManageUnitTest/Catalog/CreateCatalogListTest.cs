using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagement.Bll;
using LibraryManagement.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageUnitTest.Catalog
{

    [TestClass()]
    public class CreateCatalogListTests
    {
        CatalogBll createCatalogBll = new CatalogBll();

        [TestMethod()]
        public void AddCatalogListTest()
        {

            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"E:\大三课程文档汇总\软件工程\FunctionTest\Add_CreateCatalogList.xls");
            IEnumerable createCatalog = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in createCatalog)
            {
                Assert.AreEqual(false, createCatalogBll.AddCatalogList((CreateCatalogList)i, ref errorList));
            }
            CreateCatalogList list = new CreateCatalogList()
            {
                Id = 1,
                ISBN = "1234567890",
                PositiveTitle = "阿衰正传" + DateTime.Now.Date.ToString("yy-MM-dd"),
                FirstAuthor = "小七" + DateTime.Now.Date.ToString("yy-MM-dd"),
                PrimaryLiability = "笑哈哈出版社" + DateTime.Now.Date.ToString("yy-MM-dd"),
                CatalogerId = 1,
                CatalogingDate = DateTime.Now,
                DocumentType = "专著",                
                PublishingHouseId = 1,
                
            };
            Assert.AreEqual(true, createCatalogBll.AddCatalogList(list, ref errorList));
        } 

        [TestMethod()]
        public void DeleteCatalogListTest()
        {

            int maxId = -1;
            foreach (CreateCatalogList i in createCatalogBll.GetAllCreateCatalogArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, createCatalogBll.DeleteCatalogList(maxId));
            }
            Assert.AreEqual(false, createCatalogBll.DeleteCatalogList(-1));
        }

        [TestMethod()]
        public void UpdateCatalogListTest()
        {

            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"E:\大三课程文档汇总\软件工程\FunctionTest\Update_CreateCatalogList.xls");
            IEnumerable createCatalog = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in createCatalog)
            {
                Assert.AreEqual(false, createCatalogBll.UpdateCatalogList((CreateCatalogList)i, ref errorList));
            }
            int maxId = -1;
            foreach (CreateCatalogList i in createCatalogBll.GetAllCreateCatalogArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                CreateCatalogList list = new CreateCatalogList()
                {
                    Id = maxId,
                    ISBN = "1234567890",
                    PositiveTitle = "阿衰正传" + DateTime.Now.Date.ToString("yy-MM-dd"),
                    FirstAuthor = "小七" + DateTime.Now.Date.ToString("yy-MM-dd"),
                    PrimaryLiability = "笑哈哈出版社" + DateTime.Now.Date.ToString("yy-MM-dd"),
                    CatalogerId = 1,
                    CatalogingDate = DateTime.Now,
                    DocumentType = "专著",
                    PublishingHouseId = 1,
                };
                Assert.AreEqual(true, createCatalogBll.UpdateCatalogList(list, ref errorList));
            }
        }
    }
}