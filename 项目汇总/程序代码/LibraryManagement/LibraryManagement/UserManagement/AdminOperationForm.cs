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
            //scriptUserControl1.AddContorlClickMethod(ChangeLog_Click, ScriptUserControl.ControlNames.changeButton);
            //scriptUserControl1.AddContorlClickMethod(DeleteLog_Click, ScriptUserControl.ControlNames.emptyButton);
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLog_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表

                ////获取根据当前页面内容生成的读者信息（若有错误会被添加到错误列表中）
                //UserManagementReaderInfo info = GetReaderInfo(ref errorList);

                ////判断是否添加读者成功
                //if (userManagementBll.addANewReader(info, ref errorList))
                //{
                //    MessageBox.Show("添加成功");
                //}
                //else
                //{
                //    MessageBox.Show("添加失败");
                //    foreach (var i in errorList)
                //    {
                //        MessageBox.Show(i);//逐条显示错误信息
                //    }
                //}
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

        }

        ///// <summary>
        ///// 获取当前窗体表示的读者信息
        ///// </summary>
        ///// <param name="error">错误列表</param>
        ///// <returns>读者信息</returns>
        //private UserManagementReaderInfo GetReaderInfo(ref List<string> error)
        //{
        //    List<string> errorList = new List<string>();

        //    UserManagementReaderInfo info = new UserManagementReaderInfo()
        //    {
        //        LibraryCardNum = txb_LibraryCardNum.Text,
        //        UserNumber = txb_UserNumber.Text,
        //        UserName = txb_UserName.Text,
        //        Gender = cbb_Gender.Text,
        //        Birthday = dtp_Birthday.Value,
        //        Address = cbb_BuildingNo + "#" + txb_DormitoryNo,
        //        Contact = txb_Contact.Text,
        //        DepartmentNum = cbb_Department.Text
        //    };
        //    error = errorList;
        //    return info;
        //}
    }
}
