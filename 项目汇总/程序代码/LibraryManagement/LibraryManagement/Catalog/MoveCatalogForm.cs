//using LibraryManagement.Bll;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace LibraryManagement.Catalog
//{
//    public partial class MoveCatalogForm : Form
//    {
//        Form parentForm;//父窗体
//        CreateCatalogBll createCatalogBll = new CreateCatalogBll();//编目子系统操作类
//        public MoveCatalogForm(Form form)
//        {
//            InitializeComponent();
//            parentForm = form;
//        }

//        /// <summary>
//        /// 窗体加载函数
//        /// </summary>
//        private void MoveCatalogForm_Load(object sender, EventArgs e)
//        {
//            DataBind();//数据绑定
//        }
//        /// <summary>
//        /// 数据绑定
//        /// </summary>
//        private void DataBind()
//        {
//            // 下方窗体数据绑定
//            dataGridView1.DataSource = createCatalogBll.GetAllCatalogList();
//        }


//        private void MoveCatalogForm_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            parentForm.Show();//显示上层窗体
//            Hide();//隐藏当前窗体
//        }
//        /// <summary>
//        /// 当前行变化
//        /// </summary>
//        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
//        {
//            if (dataGridView1.CurrentRow != null)
//            {
//                textBox1.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
//            }
//        }

//        /// <summary>
//        /// 选择行变化
//        /// </summary>
//        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
//        {
//            if (dataGridView1.SelectedRows.Count > 0)
//            {
//                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
//            }
//        }
//        /// <summary>
//        /// 入库按钮点击
//        /// </summary>
//        private void circulationButton_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                DialogResult dialogResult = MessageBox.Show("是否入库", "入库确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
//                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
//                {
//                    if (CreateCatalogBll.MoveCatalog())//调用全部入库方法
//                    {
//                        MessageBox.Show("全部入库成功");
//                    }
//                    else
//                    {
//                        MessageBox.Show("全部入库失败");
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//            DataBind();//数据绑定
//        }
       


//    }
//}

