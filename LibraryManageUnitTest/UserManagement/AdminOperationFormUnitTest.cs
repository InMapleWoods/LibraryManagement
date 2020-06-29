using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryManageUnitTest.UserManagement
{
    [TestClass]
    public class AdminOperationFormUnitTest
    {
        UserManagementBll userManagementBll = new UserManagementBll();


        [TestMethod]
        public void TestAddANewReader()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\pineapple126\Desktop\作业\软件工程\课程设计\测试用例\Add_UserManagementReaderInfo.xls");
            IEnumerable userManagementReaderInfo = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in userManagementReaderInfo)
            {
                Assert.AreEqual(false, userManagementBll.addANewReader((UserManagementReaderInfo)i, ref errorList));
            }
            UserManagementReaderInfo info = new UserManagementReaderInfo()
            {
                LibraryCardNum = "10100621120",
                UserNumber = "201709001039",
                UserName = "张三",
                BitGender = "男",
                Birthday = DateTime.Now,
                Address = "14#324",
                Contact = "15319991111",
                DepartmentName = "计算机系"
            };
            Assert.AreEqual(true, userManagementBll.addANewReader(info, ref errorList));
        }
    }
}
