using LibraryManagement.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AdminForm : Form
    {
        Form parentForm;
        UserManagementAdmin admin;
        public AdminForm(Form form, UserManagementAdmin user)
        {
            InitializeComponent();
            parentForm = form;
            admin = user;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            SetVisible();
        }

        private void SetVisible()
        {
            string[] roles = UserManagementAdmin.GetRoles(admin.Roles);
            if (roles.Contains("读者信息管理员"))
            {
                userManagementSystemButton.Visible = true;
            }
            if (roles.Contains("流通管理员"))
            {
                circulationSystemButton.Visible = true;
            }
            if (roles.Contains("编目员"))
            {
                catalogSystemBtn.Visible = true;
            }
            if (roles.Contains("采访员"))
            {
                interviewSystemButton.Visible = true;
            }
            if (roles.Contains("系统维护员"))
            {
                maintainaceSystemButton.Visible = true;
            }
            if (roles.Contains("统计员"))
            {
                statisticalSystemButton.Visible = true;
            }
            if (roles.Contains("期刊管理员"))
            {
                periodicalSystemButton.Visible = true;
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }


        private void periodicalSystemButton_Click(object sender, EventArgs e)
        {
            var form = new Periodical.PeriodicalForm(this);
            form.Show();
            Hide();
        }

        private void statisticalSystemButton_Click(object sender, EventArgs e)
        {
            var form = new Statistical.StatisticalForm(this);
            form.Show();
            Hide();
        }

        private void interviewSystemButton_Click(object sender, EventArgs e)
        {
            var form = new Interview.InterviewForm(this);
            form.Show();
            Hide();
        }

        private void maintainaceSystemButton_Click(object sender, EventArgs e)
        {
            var form = new Maintainace.MaitainanceForm(this);
            form.Show();
            Hide();
        }

        private void catalogSystemBtn_Click(object sender, EventArgs e)
        {
            var form = new Catalog.CatalogForm(this);
            form.Show();
            Hide();
        }

        private void circulationSystemButton_Click(object sender, EventArgs e)
        {
            var form = new Circulation.CirculationForm(this);
            form.Show();
            Hide();
        }

        private void userManagementSystemButton_Click(object sender, EventArgs e)
        {
            var form = new UserManagement.UserManagementAdminChoice(this);
            form.Show();
            Hide();
        }
    }
}
