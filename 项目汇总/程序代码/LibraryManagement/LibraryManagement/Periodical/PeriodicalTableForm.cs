using LibraryManagement.Bll;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement.Periodical
{
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

        private void checkBox_arrived_CheckedChanged(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.PrintService print = new Tools.PrintService((DataTable)dataGridView1.DataSource);
                if (print.PrintDataTable())
                {
                    MessageBox.Show("打印成功");
                }
                else
                {
                    MessageBox.Show("打印失败");
                }
                Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_preview_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.PrintService print = new Tools.PrintService((DataTable)dataGridView1.DataSource);
                print.PrintPreview();
                Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _TextBox_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
