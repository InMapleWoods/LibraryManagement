using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools.MyUserControl;
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
    public partial class AcceptanceListForm : Form
    {
        Form parentForm;//父窗体

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public AcceptanceListForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
           
        }

        /// <summary>
        /// 将当前窗体输入文本部分置空
        /// </summary>
        private void EmptyAcceptanceList()
        {
            IdTextBox.Text = "";
            BookSellerComboBox.Text = "";
            PublishingHouseComboBox.Text = "";
            OrdererTextBox.Text = "";
            AcceptorTextBox.Text = "";
            DocumentTypeComboBox.Text = "";
        }

        /// <summary>
        /// 获取当前窗体所表示的清单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>验收清单</returns>
        private AcceptanceList GetAcceptanceList(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表

            //书商Id
            int bookSellerId = ((KeyValuePair<int, string>)BookSellerComboBox.SelectedItem).Key;

            //出版社Id
            int publisherId = ((KeyValuePair<int, string>)PublishingHouseComboBox.SelectedItem).Key;

            //判断订购人账号是否符合要求
            Match matchOrderer = Regex.Match(OrdererTextBox.Text, @"(^\d{8}$)|(^\d{10}$)|(^\d{12}$)");
            if (!matchOrderer.Success)
            {
                errorList.Add("OrdererId Error");
            }

            //通过订购人账号获取id
            int ordererId = utilBll.GetUserIdFormNumber(OrdererTextBox.Text);

            //判断验收人账号是否符合要求
            Match matchAcceptor = Regex.Match(AcceptorTextBox.Text, @"(^\d{8}$)|(^\d{10}$)|(^\d{12}$)");
            if (!matchAcceptor.Success)
            {
                errorList.Add("AcceptorId Error");
            }

            //通过订购人账号获取id
            int acceptorId = utilBll.GetUserIdFormNumber(AcceptorTextBox.Text);

            //根据页面内容构造清单
            AcceptanceList list = new AcceptanceList()
            {
                BookSellerId = bookSellerId,
                PublishingHouseId = publisherId,
                OrdererId = ordererId,
                AcceptorId = acceptorId,
                DocumentType = DocumentTypeComboBox.Text,
            };
            error = errorList;//返回错误列表
            return list;//返回订单
        }

        /// <summary>
        /// 关闭当前界面并返回
        /// </summary>
        private void AcceptanceListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        /// <summary>
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">行</param>
        private void SetAcceptanceList(DataGridViewRow row)
        {
            IdTextBox.Text = row.Cells[0].Value.ToString();//清单号
            BookSellerComboBox.Text = row.Cells[1].Value.ToString();//书商
            PublishingHouseComboBox.Text = row.Cells[2].Value.ToString();//出版社
            DocumentTypeComboBox.Text = row.Cells[5].Value.ToString();//文献类型
        }

        /// <summary>
        /// 选择行更改
        /// </summary>
        private void AcceptanceDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (AcceptanceDataGridView.SelectedRows.Count > 0)
            {
                SetAcceptanceList(AcceptanceDataGridView.SelectedRows[0]);
            }
        }

        /// <summary>
        /// 当前行更改
        /// </summary>
        private void AcceptanceDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (AcceptanceDataGridView.CurrentRow != null)
            {
                SetAcceptanceList(AcceptanceDataGridView.CurrentRow);
            }
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void AcceptanceListForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            //上方窗体数据绑定
            PurchaseDataGridView.DataSource = interviewBll.GetAllPurchaseOrders();

            //下方窗体数据绑定
            AcceptanceDataGridView.DataSource = interviewBll.GetAllAcceptanceList();

            //书商数据绑定
            BindingSource bs_BookSeller = new BindingSource();
            bs_BookSeller.DataSource = utilBll.GetBookSellerNames();
            BookSellerComboBox.DataSource = bs_BookSeller;
            BookSellerComboBox.ValueMember = "Key";
            BookSellerComboBox.DisplayMember = "Value";

            //出版社数据绑定
            BindingSource bs_PublishingHouse = new BindingSource();
            bs_PublishingHouse.DataSource = utilBll.GetPublishingHouseNames();
            PublishingHouseComboBox.DataSource = bs_PublishingHouse;
            PublishingHouseComboBox.ValueMember = "Key";
            PublishingHouseComboBox.DisplayMember = "Value";
        }
    }
}
