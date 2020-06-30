using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Interview
{
    public partial class InterviewListForm : Form
    {

        Form parentForm;//父窗体
        Tools.UserCaseHandle userCaseHandle;
        int selectIndex = -1;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public InterviewListForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((InterviewForm)form).parentForm).folderSrc + "\\Add_InterviewList.xls");
            currencyTypeComboBox.SelectedIndex = 0;
            DocumentTypeComboBox.SelectedIndex = 0;
            OrderStatusComboBox.SelectedIndex = 0;
            comboBox_chooseType.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取当前窗体所表示的清单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>采访清单</returns>
        private InterviewList GetInterviewList(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表

            //出版社Id
            int publisherId = int.Parse(PublishingHouseTextBox.Text);

            double price;

            //判断价格是否能被转换为浮点型
            if (!double.TryParse(PriceTextBox.Text, out price))
            {
                errorList.Add("Price Error");
            }

            int subscriptionNum;

            //判断征订册数是否能被转换为整型
            if (!int.TryParse(subscriptionNumTextBox.Text, out subscriptionNum))
            {
                errorList.Add("Price Error");
            }

            //根据页面内容构造清单
            InterviewList list = new InterviewList()
            {
                ISBN = ISBNTextBox.Text,
                Author = AuthorTextBox.Text,
                BookName = BookNameTextBox.Text,
                Price = price,
                CurrencyType = currencyTypeComboBox.Text,
                SubscriptionNum = subscriptionNum,
                PublishingHouseId = publisherId,
                DocumentType = DocumentTypeComboBox.Text,
                OrderStatus = OrderStatusComboBox.Text
            };
            error = errorList;//返回错误列表
            return list;//返回订单
        }

        /// <summary>
        /// 关闭当前界面并返回
        /// </summary>
        private void InterviewListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            try
            {
                InterviewDataGridView.DataSource = userCaseHandle.GetUserCasesDataTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// 选择行更改
        /// </summary>
        private void InterviewDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (InterviewDataGridView.SelectedRows.Count > 0)
            {
                selectIndex = InterviewDataGridView.SelectedRows[0].Index;
            }
        }

        /// <summary>
        /// 当前行更改
        /// </summary>
        private void InterviewDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (InterviewDataGridView.CurrentRow != null)
            {
                selectIndex = InterviewDataGridView.CurrentRow.Index;
            }
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void InterviewListForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        private void Btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                var list = new InterviewList[] { GetInterviewList(ref errorList) };
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

        private void Btn_removeCase_Click(object sender, EventArgs e)
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

        private void Btn_reflashCase_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void ComboBox_chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_chooseType.SelectedIndex == 0)
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((InterviewForm)parentForm).parentForm).folderSrc + "\\Add_InterviewList.xls");
            }
            else
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((InterviewForm)parentForm).parentForm).folderSrc + "\\Update_InterviewList.xls");
            }
            DataBind();
        }
    }
}
