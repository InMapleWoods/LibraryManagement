using LibraryManagement.Bll;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Interview
{
    public partial class ReturnListForm : Form
    {
        Form parentForm;//父窗体
        InterviewBll interviewBll = new InterviewBll();//采访订单用户操作类
        UtilBll utilBll = new UtilBll();//复用部分用户操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public ReturnListForm(Form form)
        {
            parentForm = form;
            InitializeComponent();
        }

        /// <summary>
        /// 获取当前窗体所表示的退货清单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>退货清单</returns>
        private InterviewReturnList GetReturnList(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表

            //出版社Id
            int publisherId = ((KeyValuePair<int, string>)publishingHouseComboBox.SelectedItem).Key;

            //判断订购人账号是否符合要求
            Match matchOrderer = Regex.Match(SubscriberTextBox.Text, @"(^\d{8}$)|(^\d{10}$)|(^\d{12}$)");
            if (!matchOrderer.Success)
            {
                errorList.Add("OrdererNumber Error");
            }

            //通过订购人账号获取id
            int ordererId = utilBll.GetUserIdFormNumber(SubscriberTextBox.Text);

            double price;

            //判断价格是否能被转换为整型
            if (!double.TryParse(priceTextBox.Text, out price))
            {
                errorList.Add("OrderPrice Error");
            }

            //根据页面内容构造清单
            InterviewReturnList list = new InterviewReturnList()
            {
                SubDate = subDatePicker.Value,
                ISBN = ISBNtextBox.Text,
                OrdererId = ordererId,
                BookName = bookNameTextBox.Text,
                Price = price,
                PublishingHouseId = publisherId,
                DocumentType = documentTypeComboBox.Text,
            };
            error = errorList;//返回错误列表
            return list;//返回清单
        }

        /// <summary>
        /// 获取当前窗体所表示的采购订单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>采购订单</returns>
        private InterviewPurchaseOrder GetPurchaseOrder(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表

            //出版社Id
            int publisherId = ((KeyValuePair<int, string>)publishingHouseComboBox.SelectedItem).Key;

            //判断订购人账号是否符合要求
            Match matchOrderer = Regex.Match(SubscriberTextBox.Text, @"(^\d{8}$)|(^\d{10}$)|(^\d{12}$)");
            if (!matchOrderer.Success)
            {
                errorList.Add("OrdererNumber Error");
            }

            //通过订购人账号获取id
            int ordererId = utilBll.GetUserIdFormNumber(SubscriberTextBox.Text);

            double price;

            //判断价格是否能被转换为整型
            if (!double.TryParse(priceTextBox.Text, out price))
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
                PublishingHouseId = publisherId,
                DocumentType = documentTypeComboBox.Text,
            };
            error = errorList;//返回错误列表
            return order;//返回订单
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的清单（若有错误会被添加到错误列表中）
                InterviewReturnList list = GetReturnList(ref errorList);
                //判断是否添加清单成功
                if (interviewBll.AddReturnList(list, ref errorList))
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
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">行</param>
        private void SetInformation(DataGridViewRow row)
        {
            NumTextBox.Text = row.Cells[0].Value.ToString();//订单编号
            subDatePicker.Value = (DateTime)row.Cells[1].Value;//订购时间
            ISBNtextBox.Text = row.Cells[2].Value.ToString();//ISBN
            bookNameTextBox.Text = row.Cells[4].Value.ToString();//书名
            priceTextBox.Text = row.Cells[5].Value.ToString();//价格
            publishingHouseComboBox.Text = row.Cells[6].Value.ToString();//出版社名称
            documentTypeComboBox.Text = row.Cells[7].Value.ToString();//文献类型
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            //上方窗体数据绑定
            OrderDataGridView.DataSource = interviewBll.GetAllPurchaseOrders();

            //下方窗体数据绑定
            ReturnListDataGridView.DataSource = interviewBll.GetAllReturnList();

            //出版社数据绑定
            BindingSource bs_PublishingHouse = new BindingSource();
            bs_PublishingHouse.DataSource = utilBll.GetPublishingHouseNames();
            publishingHouseComboBox.DataSource = bs_PublishingHouse;
            publishingHouseComboBox.ValueMember = "Key";
            publishingHouseComboBox.DisplayMember = "Value";
        }

        #region 关闭当前界面并返回
        private void ReturnListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            Hide();
        }
        #endregion

        #region 选择行更改
        private void OrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                SetInformation(OrderDataGridView.SelectedRows[0]);
            }
        }

        private void ReturnListDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ReturnListDataGridView.SelectedRows.Count > 0)
            {
                SetInformation(ReturnListDataGridView.SelectedRows[0]);
            }
        }
        #endregion

        #region 当前行更改
        private void OrderDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (OrderDataGridView.CurrentRow != null)
            {
                SetInformation(OrderDataGridView.CurrentRow);
            }
        }

        private void ReturnListDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (ReturnListDataGridView.CurrentRow != null)
            {
                SetInformation(ReturnListDataGridView.CurrentRow);
            }
        }
        #endregion

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void ReturnListForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 打印退货清单
        /// </summary>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.PrintService print = new Tools.PrintService((DataTable)ReturnListDataGridView.DataSource);
                if (print.PrintDataTable())//打印datagridview中的内容
                {
                    MessageBox.Show("打印成功");
                }
                else
                {
                    MessageBox.Show("打印失败");
                }
                Focus();//该窗体获取焦点
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
