using System;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.UserManagement
{
    public partial class UserManagementAdminChoice : Form
    {
        public Form parentForm;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public UserManagementAdminChoice(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        /// <summary>
        /// 添加读者或修改读者信息窗体
        /// </summary>
        private void btn_AddReader_Click(object sender, EventArgs e)
        {
            var form = new AdminOperationForm(this);
            form.Show();
            Hide();
        }

        /// <summary>
        /// 修改读者权限窗体
        /// </summary>
        private void btn_ChangeReaderLevel_Click(object sender, EventArgs e)
        {
            //var form = new AdminChangeReaderLevel(this);
            //form.Show();
            //Hide();
        }

        /// <summary>
        /// 添加管理员窗体
        /// </summary>
        private void button_addAdmin_Click(object sender, EventArgs e)
        {
            var form = new AdminAddNewAdmin(this);
            form.Show();
            Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var form = new UserManagementForm(this);
            form.Show();
            Hide();
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void UserManagementAdminChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
