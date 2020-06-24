using LibraryManagement.Bll;
using LibraryManagement.Dal;
using LibraryManagement.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.UserManagement
{
    public partial class UserManagementForm : Form
    {
        Form parentForm;
        UserManagementBll userManagementBll = new UserManagementBll();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form"></param>
        public UserManagementForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        /// <summary>
        /// 登录按钮执行操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();
                UserManagementLogin login = GetAllLoginInformation();
                int responseCode = userManagementBll.adminLogin(login, ref errorList);
                if (responseCode == 200)
                {
                    MessageBox.Show("登陆成功");
                    var form = new AdminOperationForm(this);
                    form.Show();
                    Hide();
                }
                else if(responseCode == 401)
                {
                    MessageBox.Show("密码不正确，请重新输入");
                }
                else if(responseCode == 403)
                {
                    MessageBox.Show("权限不足，禁止登陆");
                }
                else
                {
                    MessageBox.Show("输入格式有误，请重新输入");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 获取登录页面用户输入的信息
        /// </summary>
        /// <returns>登录信息</returns>
        private UserManagementLogin GetAllLoginInformation()
        {
            UserManagementLogin login = new UserManagementLogin()
            {
                UserNumber = txb_Login.Text,
                Password = txb_Password.Text
            };
            return login;
        }

        /// <summary>
        /// 窗口关闭时执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
