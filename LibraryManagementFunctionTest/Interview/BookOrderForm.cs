using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Interview
{
    public partial class BookOrderForm : Form
    {
        Form parentForm;//父窗体
        Tools.UserCaseHandle userCaseHandle;
        int selectIndex = -1;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public BookOrderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((InterviewForm)form).parentForm).folderSrc + "\\Add_InterviewPurchaseOrder.xls");
            comboBox_chooseType.SelectedIndex = 0;
            currencyTypeComboBox.SelectedIndex = 0;
            documentTypeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取当前窗体所表示的订单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>采购订单</returns>
        private InterviewPurchaseOrder GetPurchaseOrder(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表

            //判断订购人账号是否符合要求
            Match matchOrderer = Regex.Match(SubscriberTextBox.Text, @"(^\d{8}$)|(^\d{10}$)|(^\d{12}$)");
            if (!matchOrderer.Success)
            {
                errorList.Add("OrdererNumber Error");
            }

            //通过订购人账号获取id
            int ordererId = int.Parse(orderNumTextBox.Text);

            double price;

            //判断价格是否能被转换为整型
            if (!double.TryParse(pricetextBox.Text, out price))
            {
                errorList.Add("OrderPrice Error");
            }

            //根据页面内容构造订单
            InterviewPurchaseOrder order = new InterviewPurchaseOrder()
            {
                SubDate = subDatePicker.Value,
                ISBN = ISBNtextBox.Text,
                OrdererId = ordererId,
                BookName = bookNameTextBox.Text,
                Price = price,
                CurrencyType = currencyTypeComboBox.Text,
                PublishingHouseId = int.Parse(PublishingHouseTextBox.Text),
                DocumentType = documentTypeComboBox.Text,
                Remark = RemarkTextBox.Text,
            };
            error = errorList;//返回错误列表
            return order;//返回订单
        }

        /// <summary>
        /// 关闭当前界面并返回
        /// </summary>
        private void BookOrderForm_FormClosing(object sender, FormClosingEventArgs e)
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
                OrderDataGridView.DataSource = userCaseHandle.GetUserCasesDataTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 选择行更改
        /// </summary>
        private void OrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                selectIndex = OrderDataGridView.SelectedRows[0].Index;
            }
        }

        /// <summary>
        /// 当前行更改
        /// </summary>
        private void OrderDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (OrderDataGridView.CurrentRow != null)
            {
                selectIndex = OrderDataGridView.CurrentRow.Index;
            }
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void BookOrderForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        private void Btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                var list = new InterviewPurchaseOrder[] { GetPurchaseOrder(ref errorList) };
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
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((InterviewForm)parentForm).parentForm).folderSrc + "\\Add_InterviewPurchaseOrder.xls");
            }
            else
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((InterviewForm)parentForm).parentForm).folderSrc + "\\Update_InterviewPurchaseOrder.xls");
            }
            DataBind();
        }
    }
}
