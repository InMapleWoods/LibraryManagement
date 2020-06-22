using LibraryManagement.Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Interview
{
    public partial class ReturnListForm : Form
    {
        Form parentForm;//父窗体
        InterviewPurchaseBll interviewPurchaseBll = new InterviewPurchaseBll();//采访订单用户操作类
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
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">行</param>
        private void SetPurchaseOrder(DataGridViewRow row)
        {
            orderNumTextBox.Text = row.Cells[0].Value.ToString();//订单编号
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
            OrderDataGridView.DataSource = interviewPurchaseBll.GetAllPurchaseOrders();
        }

        /// <summary>
        /// 选择行更改
        /// </summary>
        private void OrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                SetPurchaseOrder(OrderDataGridView.SelectedRows[0]);
            }
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void ReturnListForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }
    }
}
