using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools.MyUserControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagement.UserManagement
{
    public partial class AdminChangeReaderLevel : Form
    {
        Form parentForm;//父窗体
        UserManagementBll userManagementBll = new UserManagementBll();//用户管理操作类
        UtilBll utilBll = new UtilBll();//复用部分操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form"></param>
        public AdminChangeReaderLevel(Form form)
        {
            InitializeComponent();
            parentForm = form;
            //scriptUserControl1.AddContorlClickMethod(NewLog_Click, ScriptUserControl.ControlNames.createButton);
            //scriptUserControl1.AddContorlClickMethod(AddLog_Click, ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.AddContorlClickMethod(ChangeLog_Click, ScriptUserControl.ControlNames.changeButton);
            //scriptUserControl1.AddContorlClickMethod(DeleteLog_Click, ScriptUserControl.ControlNames.emptyButton);
            scriptUserControl1.AddContorlClickMethod(SaveLog_Click, ScriptUserControl.ControlNames.saveButton);
            scriptUserControl1.AddContorlClickMethod(NextLog_Click, ScriptUserControl.ControlNames.nextButton);
            scriptUserControl1.AddContorlClickMethod(PreviousLog_Click, ScriptUserControl.ControlNames.previousButton);
            scriptUserControl1.AddContorlClickMethod(ExitLog_Click, ScriptUserControl.ControlNames.exitButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.createButton);
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void AdminChangeReaderLevel_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗口关闭时切换到父窗体
        /// </summary>
        private void AdminChangeReaderLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        #region 用户控件相关方法（菜单控件）
        /// <summary>
        /// 修改记录
        /// </summary>
        private void ChangeLog_Click(object sender, EventArgs e)
        {
            try
            {
                string readerNum = txb_userNum.Text;//获取读者编号
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
        /// 保存记录
        /// </summary>
        private void SaveLog_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的读者信息（若有错误会被添加到错误列表中）
                //string readerLevel = cbb_readerLevel.Text;//获取修改后的值            
                UserManagementReaderLevel level = GetReaderLevel(ref errorList);
                //判断是否修改读者信息成功
                if (userManagementBll.UpdateReaderLevel(level, ref errorList))
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
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
            DataBind();//数据绑定
            ChangeControlEnableState();//改变菜单按钮启用状态
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

        private UserManagementReaderLevel GetReaderLevel(ref List<string> error)
        {
            List<string> errorList = new List<string>();

            UserManagementReaderLevel level = new UserManagementReaderLevel()
            {
                UserName = txb_userName.Text,
                UserNumber = txb_userNum.Text,
                Contact = txb_contact.Text,
                ReaderLevelName = cbb_readerLevel.Text,
                BorrowBookNumber = txb_borrowBookNum.Text,
                ReserveBookNumber = txb_reserveBookNum.Text,
                BorrowBookDays = txb_borrowDays.Text,
                RenewBookDays = txb_renewDays.Text,
                ForfeitMultiples = txb_forfeitMul.Text,
                RenewBookNumber = txb_renewNum.Text
            };
            error = errorList;//返回错误列表
            return level;//返回读者信息
        }


        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            // 下方总窗体数据绑定
            dataGridView1.DataSource = userManagementBll.GetAllReadersLevel();

            // 读者级别数据绑定
            BindingSource bs_ReaderLevel = new BindingSource();
            bs_ReaderLevel.DataSource = utilBll.GetReaderLevel();
            cbb_readerLevel.DataSource = bs_ReaderLevel;
            cbb_readerLevel.ValueMember = "Key";
            cbb_readerLevel.DisplayMember = "Value";
        }

        /// <summary>
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">选中行</param>
        private void SetReaderLevel(DataGridViewRow row)
        {
            txb_userName.Text = row.Cells[0].Value.ToString();//姓名
            txb_userNum.Text = row.Cells[1].Value.ToString();//读者编号
            txb_contact.Text = row.Cells[2].Value.ToString();//联系电话
            cbb_readerLevel.Text = row.Cells[3].Value.ToString();//读者级别
            txb_borrowBookNum.Text = row.Cells[4].Value.ToString();//可借阅图书数目
            txb_reserveBookNum.Text = row.Cells[5].Value.ToString();//可预约图书数目
            txb_borrowDays.Text = row.Cells[6].Value.ToString();//借阅天数
            txb_renewDays.Text = row.Cells[7].Value.ToString();//可续约天数
            txb_forfeitMul.Text = row.Cells[8].Value.ToString();//罚款倍数
            txb_renewNum.Text = row.Cells[9].Value.ToString();//续借册数
        }

        /// <summary>
        /// 修改用户控件中按钮的启用状态
        /// </summary>
        private void ChangeControlEnableState()
        {
            //scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.changeButton);
            //scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.emptyButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.saveButton);
        }

        /// <summary>
        /// 当前行更改
        /// </summary>
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SetReaderLevel(dataGridView1.CurrentRow);
            }
        }

        /// <summary>
        /// 选择行更改
        /// </summary>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SetReaderLevel(dataGridView1.SelectedRows[0]);
            }
        }
    }
}
