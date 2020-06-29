using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Periodical
{
    public partial class PeriodicalArrivalForm : Form
    {
        Form parentForm;//父窗体

        Tools.UserCaseHandle userCaseHandle;
        int selectIndex = -1;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public PeriodicalArrivalForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((PeriodicalForm)form).parentForm).folderSrc + "\\Add_PeriodicalArrival.xls");
            comboBox_chooseType.SelectedIndex = 0;
            stateComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void PeriodicalArrivalForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void PeriodicalArrivalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }


        private void btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的登到（若有错误会被添加到错误列表中）
                var list = new PeriodicalArrival[] { GetPeriodicalArrival(ref errorList) };
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
                //获取根据当前页面内容生成的登到（若有错误会被添加到错误列表中）
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


        private void DataBind()
        {
            try
            {
                arrivalDataGridView.DataSource = userCaseHandle.GetUserCasesDataTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 获取当前窗体所表示的登到
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>期刊登到</returns>
        private PeriodicalArrival GetPeriodicalArrival(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            //根据页面内容构造登到
            PeriodicalArrival arrival = new PeriodicalArrival()
            {
                State = stateComboBox.Text,
            };
            error = errorList;//返回错误列表
            return arrival;//返回登到
        }

        private void btn_reflashCase_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void comboBox_chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_chooseType.SelectedIndex == 0)
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((PeriodicalForm)parentForm).parentForm).folderSrc + "\\Add_PeriodicalArrival.xls");
            }
            else
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((PeriodicalForm)parentForm).parentForm).folderSrc + "\\Update_PeriodicalArrival.xls");
            }
            DataBind();
        }
    }
}
