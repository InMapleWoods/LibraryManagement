using LibraryManagement.Bll;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement.Periodical
{
    /// <summary>
    /// 报表打印窗体
    /// </summary>
    public partial class PeriodicalTableForm : Form
    {
        Form parentForm;//父窗体
        PeriodicalBll periodicalBll = new PeriodicalBll();//期刊用户操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public PeriodicalTableForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void PeriodicalTableForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void PeriodicalTableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            string id = orderNumTextBox.Text;
            string isbn = IsbnTextBox.Text;
            string price = orderPriceTextBox.Text;
            string officialTitle = officialTitleTextBox.Text;
            if (checkBox_arrived.Checked)
            {
                dataGridView1.DataSource = periodicalBll.GetAllPeriodical(id, isbn, price, officialTitle);
            }
            else
            {
                dataGridView1.DataSource = periodicalBll.GetAllPeriodOrders(id, isbn, price, officialTitle);
            }
        }

        /// <summary>
        /// 已验收勾选状态变化
        /// </summary>
        private void checkBox_arrived_CheckedChanged(object sender, EventArgs e)
        {
            DataBind();
        }

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        private void button_search_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        /// <summary>
        /// 打印按钮点击事件
        /// </summary>
        private void button_print_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.PrintService print = new Tools.PrintService((DataTable)dataGridView1.DataSource);
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

        /// <summary>
        /// 打印预览按钮事件
        /// </summary>
        private void button_preview_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.PrintService print = new Tools.PrintService((DataTable)dataGridView1.DataSource);
                print.PrintPreview();//显示打印预览
                Focus();//该窗体获取焦点
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 文本变化事件
        /// </summary>
        private void _TextBox_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
