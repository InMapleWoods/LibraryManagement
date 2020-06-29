using System;
using System.Windows.Forms;

namespace LibraryManagement
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminForm(new Form(),new Model.UserManagementAdmin() { Number="201709001013"}));
        }
    }
}
