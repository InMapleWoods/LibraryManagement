using LibraryManagement.Bll;
using LibraryManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace LibraryManageUnitTest.UserManagement
{
    [TestClass]
    public class AdminAddNewAdmin
    {
        UserManagementBll userManagementBll = new UserManagementBll();

        [TestMethod]
        public void TestAddANewAdmin()
        {
            Tools.UserCaseHandle userCaseHandle = new Tools.UserCaseHandle(@"C:\Users\96464\Desktop\软件工程\测试用例\Add_UserManagementAdminInfo.xls");
            IEnumerable userManagementAdminInfo = userCaseHandle.GetUserCases();
            List<string> errorList = new List<string>();
            foreach (var i in userManagementAdminInfo)
            {
                Assert.AreEqual(false, userManagementBll.addANewAdmin((UserManagementAdminInfo)i, ref errorList));
            }
            UserManagementAdminInfo info = new UserManagementAdminInfo()
            {
                UserNumber = "201709001031",
                UserName = "赵琪",
                AdminDepartment = "统计处",
                AdminRole = "统计科"
            };
            Assert.AreEqual(true, userManagementBll.addANewAdmin(info, ref errorList));
        }
    }
}
