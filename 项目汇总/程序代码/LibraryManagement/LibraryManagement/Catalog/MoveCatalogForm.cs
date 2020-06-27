using LibraryManagement.Bll;
using System;
using System.Windows.Forms;
using System.Data;

namespace LibraryManagement.Catalog
{
    public partial class MoveCatalogForm : Form
    {
        Form parentForm;//父窗体
        CatalogBll createCatalogBll = new CatalogBll();//编目子系统操作类
        public MoveCatalogForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void MoveCatalogForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            // 下方窗体数据绑定
            dataGridView1.DataSource = createCatalogBll.GetAllCatalogList();
        }


        private void MoveCatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }
        /// <summary>
        /// 当前行变化
        /// </summary>
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }

        /// <summary>
        /// 选择行变化
        /// </summary>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }


        /// <summary>
        /// 获取Id
        /// </summary>
        /// <returns></returns>
        private int getMoveCatalogId()
        {
            int id = int.Parse(textBox1.Text);

            return id;
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dialogResult = MessageBox.Show("是否入库", "入库确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    if (createCatalogBll.MoveCatalog(getMoveCatalogId()))//调用全部入库方法
                    {
                        MessageBox.Show("入库成功");
                    }
                    else
                    {
                        MessageBox.Show("入库失败");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();//数据绑定
        }

        /// <summary>
        /// 打印按钮点击事件
        /// </summary>
        private void printBtn_Click(object sender, EventArgs e)
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
        private void previewBtn_Click(object sender, EventArgs e)
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
    }
}

