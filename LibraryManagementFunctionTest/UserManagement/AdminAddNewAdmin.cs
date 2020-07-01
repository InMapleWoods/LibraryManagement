using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.UserManagement
{
    public partial class AdminAddNewAdmin : Form
    {
        Form parentForm;//父窗体
        Tools.UserCaseHandle userCaseHandle;
        int selectIndex = -1;

        public AdminAddNewAdmin(Form form)
        {
            InitializeComponent();
            parentForm = form;
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((UserManagementAdminChoice)form).parentForm).folderSrc + "\\Add_UserManagementAdminInfo.xls");
        }

        private void AdminAddNewAdmin_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void AdminAddNewAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        private void DataBind()
        {
            try
            {
                dataGridView1.DataSource = userCaseHandle.GetUserCasesDataTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 获取当前窗体表示的读者信息
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>读者信息</returns>
        private UserManagementAdminInfo GetAdminInfo(ref List<string> error)
        {
            List<string> errorList = new List<string>();

            UserManagementAdminInfo info = new UserManagementAdminInfo()
            {
                UserNumber = txb_userNumber.Text,
                UserName = txb_userName.Text,
                AdminDepartment = txb_adminDepartment.Text,
                AdminRole = txb_adminRole.Text

            };
            error = errorList;//返回错误列表
            return info;//返回读者信息
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                selectIndex = dataGridView1.CurrentRow.Index;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectIndex = dataGridView1.SelectedRows[0].Index;
            }
        }

        private void btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                var list = new UserManagementAdminInfo[] { GetAdminInfo(ref errorList) };
                if (errorList.Count == 0)
                {
                    if (userCaseHandle.AddUserCases(list.ToList()))
                    {
                        MessageBox.Show("添加成功");
                    }
                }
                else
                {
                    MessageBox.Show("添加失败");
                    foreach (var i in errorList)
                    {
                        MessageBox.Show(i);//逐条显示错误信息
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();
        }

        private void btn_removeCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                if (selectIndex == -1)
                    return;
                if (errorList.Count == 0)
                {
                    if (userCaseHandle.DeleteUserCase(selectIndex))
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                else
                {
                    MessageBox.Show("删除失败");
                    foreach (var i in errorList)
                    {
                        MessageBox.Show(i);//逐条显示错误信息
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();
        }

        private void btn_reflashCase_Click(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
