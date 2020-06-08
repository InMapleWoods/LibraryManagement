using LibraryManagement.Dal;
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
        public UserManagementForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            string userId = loginTextBox.Text;
            if (userId == "")
            {
                MessageBox.Show("请输入登陆账号");
            }
            string password = passwordTextBox.Text;
            if (password == "")
            {
                MessageBox.Show("请输入密码");
            }
            SQLHelper sql = new SQLHelper();
            string cmdtext = "select tb_Login.Password from tb_Login, tb_BasicInformation where tb_Login.UserId = tb_BasicInformation.UserId AND tb_BasicInformation.UserNumber = "+ userId;
            MySqlParameter[] paras = new MySqlParameter[] { };
            DataTable dt = sql.ExecuteQuery(cmdtext, paras, CommandType.Text);
            if ((string)dt.Rows[0][0] == password)
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

        private void UserManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
