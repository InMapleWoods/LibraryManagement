using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.UserManagement
{
    public partial class AdminOperationForm : Form
    {
        Form parentForm;
        Tools.UserCaseHandle userCaseHandle;
        int selectIndex = -1;
        public AdminOperationForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((UserManagementAdminChoice)form).parentForm).folderSrc + "\\Add_UserManagementReaderInfo.xls");
            comboBox_chooseType.SelectedIndex = 0;
        }

        private void AdminOperationForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        private void AdminOperationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            try
            {
                dataGridView1.DataSource = userCaseHandle.GetUserCasesDataTable();
                cbb_BuildingNo.SelectedIndex = 0;
                cbb_Department.SelectedIndex = 0;
                cbb_Gender.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void comboBox_chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_chooseType.SelectedIndex == 0)
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((UserManagementAdminChoice)parentForm).parentForm).folderSrc + "\\Add_UserManagementReaderInfo.xls");
            }
            else
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((UserManagementAdminChoice)parentForm).parentForm).folderSrc + "\\Update_UserManagementReaderInfo.xls");
            }
            DataBind();
        }

        private UserManagementReaderInfo GetReaderInfo(ref List<string> error)
        {
            List<string> errorList = new List<string>();

            UserManagementReaderInfo info = new UserManagementReaderInfo()
            {
                LibraryCardNum = txb_LibraryCardNum.Text,
                UserNumber = txb_UserNumber.Text,
                UserName = txb_UserName.Text,
                BitGender = cbb_Gender.Text,
                Birthday = dtp_Birthday.Value,
                Address = cbb_BuildingNo.Text + "#" + txb_DormitoryNo.Text,
                Contact = txb_Contact.Text,
                DepartmentName = cbb_Department.Text
            };
            error = errorList;//返回错误列表
            return info;//返回读者信息
        }

        private void btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                var list = new UserManagementReaderInfo[] { GetReaderInfo(ref errorList) };
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
