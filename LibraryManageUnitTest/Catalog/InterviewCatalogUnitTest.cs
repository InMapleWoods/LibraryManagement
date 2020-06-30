using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LibraryManageUnitTest.Catalog
{
    [TestClass()]
    public class InterviewCatalogUnitTest
    {
        CatalogBll createCatalogBll = new CatalogBll();
        InterviewBll interviewBll = new InterviewBll();

        [TestMethod()]
        public void AddInterviewCatalogTest()
        {
            //Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"E:\大三课程文档汇总\软件工程\FunctionTest\Add_CatalogFormList.xls");
            //IEnumerable interviewCatalog = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            InterviewCatalog interview1 = new InterviewCatalog()
            {
                Id = 1,
                InterviewId = 1,
                State = "",

            };

            Assert.AreEqual(false, createCatalogBll.AddInterviewCatalog(interview1, ref errorList));

            int maxId = -1;
            foreach (AcceptanceList i in interviewBll.GetAllAcceptanceListArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            InterviewCatalog list = new InterviewCatalog()
            {
                Id = 1,
                InterviewId = maxId,
                State = "可编目",
            };
            Assert.AreEqual(true, createCatalogBll.AddInterviewCatalog(list, ref errorList));

        }

        [TestMethod()]
        public void DeleteInterviewCatalogTest()
        {
            int maxId = -1;
            foreach (InterviewCatalog i in createCatalogBll.GetAllInterviewCatalogArray())
            {
                if (i.Id > maxId)
                {
                    maxId = i.Id;
                }
            }
            if (maxId != -1)
            {
                Assert.AreEqual(true, createCatalogBll.DeleteInterviewCatalog(maxId));
            }
            Assert.AreEqual(false, createCatalogBll.DeleteInterviewCatalog(-1));
        }

        //[TestMethod()]
        //public void UpdateInterviewCatalogTest()
        //{
        //    Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"E:\大三课程文档汇总\软件工程\FunctionTest\Update_CatalogFormList.xls");
        //    IEnumerable  interviewCatalog = userCaseHandle.GetUserCases();

        //    List<string> errorList = new List<string>();
        //    foreach (var i in interviewCatalog)
        //    {
        //        Assert.AreEqual(false, createCatalogBll.UpdateInterviewCatalog((InterviewCatalog)i, ref errorList));
        //    }
        //    int maxId = -1;
        //    foreach (CreateCatalogList i in createCatalogBll.GetAllCreateCatalogArray())
        //    {
        //        if (i.Id > maxId)
        //        {
        //            maxId = i.Id;
        //        }
        //    }
        //    int maxInterviewId = -1;
        //    foreach (CreateCatalogList i in createCatalogBll.GetAllInterviewCatalogArray())
        //    {
        //        if (i.Id > maxInterviewId)
        //        {
        //            maxInterviewId = i.Id;
        //        }
        //    }
        //    if (maxId != -1)
        //    {
        //        InterviewCatalog list = new InterviewCatalog()
        //        {
        //            Id = maxId,
        //            InterviewId = maxInterviewId,
        //            State = "待退",
        //        };
        //        Assert.AreEqual(true, createCatalogBll.UpdateInterviewCatalog(list, ref errorList));
        //    }
        //}



    }
}
