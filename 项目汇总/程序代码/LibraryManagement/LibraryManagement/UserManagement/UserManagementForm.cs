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
        public UserManagementForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private UserManagementLogin GetAllLoginInformation()
        {
            UserManagementLogin login = new UserManagementLogin()
            {
                UserNumber = txb_Login.Text,
                Password = txb_Password.Text
            };
            return login;
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();
                UserManagementLogin login = GetAllLoginInformation();
                if (userManagementBll.adminLogin(login, ref errorList))
                {
                    MessageBox.Show("登陆成功");
                    var form = new AdminOperationForm(this);
                    form.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("密码不正确，请重新输入");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
