using LibraryManagement.Bll;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement.Catalog
{
    public partial class CatalogQueryForm : Form
    {
        Form parentForm;
        CatalogBll createCatalogBll = new CatalogBll();//编目用户操作类
        public CatalogQueryForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void CatalogQueryForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void CatalogQueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }


        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            string id = iDTextBox.Text;
            queryDataGridView.DataSource = createCatalogBll.GetAllQueryPeriodOrders(id);

        }

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        private void queryBtn_Click(object sender, EventArgs e)
        {
            DataBind();
        }
        /// <summary>
        /// 打印按钮点击事件
        /// </summary>
        private void printBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.PrintService print = new Tools.PrintService((DataTable)queryDataGridView.DataSource);
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
        private void previewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.PrintService print = new Tools.PrintService((DataTable)queryDataGridView.DataSource);
                print.PrintPreview();//显示打印预览
                Focus();//该窗体获取焦点
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void scriptUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
