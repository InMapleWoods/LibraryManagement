using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools.MyUserControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagement.UserManagement
{
    public partial class AdminOperationForm : Form
    {
        Form parentForm;//父窗体
        UserManagementBll userManagementBll = new UserManagementBll();//用户管理操作类
        UtilBll utilBll = new UtilBll();//复用部分操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public AdminOperationForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            scriptUserControl1.AddContorlClickMethod(NewLog_Click, ScriptUserControl.ControlNames.createButton);
            scriptUserControl1.AddContorlClickMethod(AddLog_Click, ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.AddContorlClickMethod(ChangeLog_Click, ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.AddContorlClickMethod(DeleteLog_Click, ScriptUserControl.ControlNames.emptyButton);
            //scriptUserControl1.AddContorlClickMethod(SaveLog_Click, ScriptUserControl.ControlNames.saveButton);
            //scriptUserControl1.AddContorlClickMethod(NextLog_Click, ScriptUserControl.ControlNames.nextButton);
            //scriptUserControl1.AddContorlClickMethod(PreviousLog_Click, ScriptUserControl.ControlNames.previousButton);
            //scriptUserControl1.AddContorlClickMethod(ExitLog_Click, ScriptUserControl.ControlNames.exitButton);
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminOperationForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminOperationForm_FormClosing(object sender, FormClosingEventArgs e)
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

                //获取根据当前页面内容生成的读者信息（若有错误会被添加到错误列表中）
                UserManagementReaderInfo info = GetReaderInfo(ref errorList);

                //判断是否添加读者成功
                if (userManagementBll.addANewReader(info, ref errorList))
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
        }

        /// <summary>
        /// 修改记录
        /// </summary>
        private void ChangeLog_Click(object sender, EventArgs e)
        {
            try
            {
                string readerNum = txb_UserNumber.Text;//获取读者编号
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
                    string userNumber = txb_UserNumber.Text;//获取读者编号
                    if (userManagementBll.deleteAReader(userNumber))//调用订单删除方法
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
        #endregion

        /// <summary>
        /// 将当前窗体的输入文本部分置空
        /// </summary>
        private void EmptyReaderInfo()
        {
            txb_LibraryCardNum.Text = "";
            txb_UserNumber.Text = "";
            txb_UserName.Text = "";
            cbb_Gender.Text = "";
            dtp_Birthday.Value = DateTime.Now;
            cbb_BuildingNo.Text = "";
            txb_DormitoryNo.Text = "";
            txb_Contact.Text = "";
            cbb_Department.Text = "";
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            // 下方总窗体数据绑定
            dataGridView1.DataSource = userManagementBll.GetAllReadersInfo();

            // 所在院系数据绑定
            BindingSource bs_DepartmentName = new BindingSource();
            bs_DepartmentName.DataSource = utilBll.GetReaderDepartmentName();
            cbb_Department.DataSource = bs_DepartmentName;
            cbb_Department.ValueMember = "Key";
            cbb_Department.DisplayMember = "Value";

            cbb_Gender.SelectedIndex = 0;// 性别
            cbb_BuildingNo.SelectedIndex = 0;// 楼号
        }

        /// <summary>
        /// 获取当前窗体表示的读者信息
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>读者信息</returns>
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

        /// <summary>
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row"></param>
        private void SetReaderInfo(DataGridViewRow row)
        {
            txb_LibraryCardNum.Text = row.Cells[1].Value.ToString();//借书证号
            dtp_Birthday.Value = (DateTime)row.Cells[6].Value;//出生日期
            txb_UserNumber.Text = row.Cells[3].Value.ToString();//读者编号
            cbb_BuildingNo.Text = row.Cells[7].Value.ToString().Substring(0, 2);//楼号
            txb_DormitoryNo.Text = row.Cells[7].Value.ToString().Substring(3, 3);//宿舍号
            txb_UserName.Text = row.Cells[2].Value.ToString();//姓名
            txb_Contact.Text = row.Cells[8].Value.ToString();//联系电话
            cbb_Gender.Text = row.Cells[5].Value.ToString() == "1" ? "男" : "女";//性别
            cbb_Department.Text = row.Cells[4].Value.ToString();//院系名字
        }

        /// <summary>
        /// 修改用户控件中按钮的启用状态
        /// </summary>
        private void ChangeControlEnableState()
        {
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.emptyButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.saveButton);
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
