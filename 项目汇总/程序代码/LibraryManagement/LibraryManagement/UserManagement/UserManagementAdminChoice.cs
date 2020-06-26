using System;
using System.Windows.Forms;

namespace LibraryManagement.UserManagement
{
    public partial class UserManagementAdminChoice : Form
    {
        Form parentForm;

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
            var form = new AdminChangeReaderLevel(this);
            form.Show();
            Hide();
        }

        private void UserManagementAdminChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void button_addAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("待完善");
        }
    }
}
