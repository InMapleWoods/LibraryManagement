using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Periodical
{
    public partial class PeriodicalOrderForm : Form
    {
        Form parentForm;//父窗体
        Tools.UserCaseHandle userCaseHandle;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public PeriodicalOrderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((PeriodicalForm)form).parentForm).folderSrc + "\\PeriodicalOrder.xls");
            sizeComboBox.SelectedIndex = 0;
            booksellerComboBox.SelectedIndex = 0;
            currencyTypeComboBox.SelectedIndex = 0;
            publishingHouseComboBox.SelectedIndex = 0;
            cycleComboBox.SelectedIndex = 0;
            documentTypeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void PeriodicalOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        private void btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                var list = new PeriodicalOrder[] { GetPeriodicalOrder(ref errorList) };
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
                int id = int.Parse(orderNumTextBox.Text);
                if (errorList.Count == 0)
                {
                    if (userCaseHandle.DeleteUserCase(id))
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

        private void PeriodicalOrderForm_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            try
            {
                dataGridView1.DataSource = userCaseHandle.GetUserCasesDataTable();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 获取当前窗体所表示的订单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>期刊订单</returns>
        private PeriodicalOrder GetPeriodicalOrder(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            //通过订购人账号获取id
            int ordererId = int.Parse(ordererTextBox.Text);
            double price;
            //判断价格是否能被转换为浮点型
            if (!double.TryParse(orderPriceTextBox.Text, out price))
            {
                errorList.Add("OrderPrice Error");
            }
            //根据页面内容构造订单
            PeriodicalOrder order = new PeriodicalOrder()
            {
                Id = int.Parse(orderNumTextBox.Text),
                BookSellerId = booksellerComboBox.SelectedIndex,
                OrderDate = orderDatePicker.Value,
                OrdererId = ordererId,
                ISBN = IsbnTextBox.Text,
                DocumentType = documentTypeComboBox.Text,
                PublishCycle = cycleComboBox.Text,
                OfficialTitle = officialTitleTextBox.Text,
                SupplementTitle = supplementTitleTextBox.Text,
                PublishingHouseId = publishingHouseComboBox.SelectedIndex,
                OrderPrice = price,
                CurrencyType = currencyTypeComboBox.Text,
                Size = sizeComboBox.Text,
            };
            error = errorList;//返回错误列表
            return order;//返回订单
        }

        private void btn_reflashCase_Click(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
