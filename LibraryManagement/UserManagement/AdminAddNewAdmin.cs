using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools.MyUserControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagement.UserManagement
{
    public partial class AdminAddNewAdmin : Form
    {
        Form parentForm;//父窗体
        UserManagementBll userManagementBll = new UserManagementBll();//用户管理操作类
        UtilBll utilBll = new UtilBll();//复用部分操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        public AdminAddNewAdmin(Form form)
        {
            InitializeComponent();
            parentForm = form;
            scriptUserControl1.AddContorlClickMethod(NewLog_Click, ScriptUserControl.ControlNames.createButton);
            scriptUserControl1.AddContorlClickMethod(AddLog_Click, ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.AddContorlClickMethod(ChangeLog_Click, ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.AddContorlClickMethod(DeleteLog_Click, ScriptUserControl.ControlNames.emptyButton);
            //scriptUserControl1.AddContorlClickMethod(SaveLog_Click, ScriptUserControl.ControlNames.saveButton);
            scriptUserControl1.AddContorlClickMethod(NextLog_Click, ScriptUserControl.ControlNames.nextButton);
            scriptUserControl1.AddContorlClickMethod(PreviousLog_Click, ScriptUserControl.ControlNames.previousButton);
            scriptUserControl1.AddContorlClickMethod(ExitLog_Click, ScriptUserControl.ControlNames.exitButton);
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void AdminAddNewAdmin_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void AdminAddNewAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        #region 用户控件相关方法（菜单控件）
        /// <summary>
        /// 新增记录
        /// </summary>
        private void NewLog_Click(object sender, EventArgs e)
        {
            try
            {
                DataBind();//数据绑定
                EmptyReaderInfo();//将输入框置为空白
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 增加记录
        /// </summary>
        private void AddLog_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表

                //获取根据当前页面内容生成的管理员信息（若有错误会被添加到错误列表中）
                UserManagementAdminInfo info = GetAdminInfo(ref errorList);

                //判断是否添加管理员成功
                if (userManagementBll.addANewAdmin(info, ref errorList))
                {
                    MessageBox.Show("添加成功");
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

        /// <summary>
        /// 修改记录
        /// </summary>
        private void ChangeLog_Click(object sender, EventArgs e)
        {
            try
            {
                string readerNum = txb_userNumber.Text;//获取管理员编号
                if (string.IsNullOrEmpty(readerNum))
                {
                    return;
                }
                ChangeControlEnableState();//更改菜单按钮启用状态
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        private void DeleteLog_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否删除该条记录", "删除确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    List<string> errorList = new List<string>();//创建一个错误列表
                    //获取根据当前页面内容生成的读者信息（若有错误会被添加到错误列表中）
                    UserManagementAdminInfo info = GetAdminInfo(ref errorList);
                    if (userManagementBll.deleteAAdmin(info))//调用管理员删除方法
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();//数据绑定
            ChangeControlEnableState();
        }

        /// <summary>
        /// 下一条记录
        /// </summary>
        private void NextLog_Click(object sender, EventArgs e)
        {
            try
            {
                //若不选择整行，selectRows是没有元素的，所以需要进行判断
                int index;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    index = dataGridView1.SelectedRows[0].Index;
                }
                else
                {
                    index = dataGridView1.CurrentRow.Index;
                }
                dataGridView1.Rows[index].Selected = false;//放弃选择当前行
                index = index + 1 >= dataGridView1.RowCount ? dataGridView1.RowCount - 1 : index + 1;
                dataGridView1.Rows[index].Selected = true;//选择下一行
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 上一条记录
        /// </summary>
        private void PreviousLog_Click(object sender, EventArgs e)
        {
            try
            {
                //若不选择整行，selectRows是没有元素的，所以需要进行判断
                int index;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    index = dataGridView1.SelectedRows[0].Index;
                }
                else
                {
                    index = dataGridView1.CurrentRow.Index;
                }
                dataGridView1.Rows[index].Selected = false;//放弃选择当前行
                index = index - 1 <= 0 ? 0 : index - 1;
                dataGridView1.Rows[index].Selected = true;//选择上一行
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        private void ExitLog_Click(object sender, EventArgs e)
        {
            try
            {
                parentForm.Show();//显示父窗体
                Hide();//隐藏本窗体
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        /// <summary>
        /// 将当前窗体的输入文本部分置空
        /// </summary>
        private void EmptyReaderInfo()
        {
            txb_userName.Text = "";
            txb_userNumber.Text = "";
            txb_adminDepartment.Text = "";
            txb_adminRole.Text = "";
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

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            // 下方总窗体数据绑定
            dataGridView1.DataSource = userManagementBll.GetAllAdminInfo();
        }

        /// <summary>
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">选中行</param>
        private void SetReaderInfo(DataGridViewRow row)
        {
            txb_userNumber.Text = row.Cells[1].Value.ToString();//读者编号
            txb_userName.Text = row.Cells[2].Value.ToString();//读者姓名
            txb_adminDepartment.Text = row.Cells[3].Value.ToString();//管理员科室
            txb_adminRole.Text = row.Cells[4].Value.ToString();//管理员角色
        }

        /// <summary>
        /// 修改用户控件中按钮的启用状态
        /// </summary>
        private void ChangeControlEnableState()
        {
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.emptyButton);
            //scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.saveButton);
        }

        /// <summary>
        /// 选择行更改
        /// </summary>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SetReaderInfo(dataGridView1.SelectedRows[0]);
            }
        }

        /// <summary>
        /// 当前行更改
        /// </summary>
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SetReaderInfo(dataGridView1.CurrentRow);
            }
        }
    }
}
