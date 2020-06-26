using LibraryManagement.Bll;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace LibraryManagement.Catalog
{
    /// <summary>
    /// 采访编目窗体
    /// </summary>
    public partial class InterviewCatalogForm : Form
    {
        Form parentForm;//父窗体
        CreateCatalogBll createCatalogBll = new CreateCatalogBll();//编目子系统操作类
        InterviewBll interviewBll = new InterviewBll();//采访子系统操作类
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public InterviewCatalogForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void InterviewCatalogForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void InterviewCatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            // 上方窗体数据绑定
            interviewDataGridView.DataSource = interviewBll.GetAllInterviewList();
            // 下方窗体数据绑定
            catalogDataGridView.DataSource = createCatalogBll.GetAllInterviewCatalog();
            stateComboBox.SelectedIndex = 0;//状态
            SetEnable();
        }

        /// <summary>
        /// 编目按钮点击
        /// </summary>
        private void catalogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                InterviewCatalog list = GetAllCatalogList(ref errorList);
                //判断是否添加订单成功
                if (createCatalogBll.AddInterviewCatalog(list, ref errorList))
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
            DataBind();//数据绑定
        }

        /// <summary>
        /// 修改状态按钮点击
        /// </summary>
        private void changeStateBtn_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 删除编目记录按钮点击
        /// </summary>
        private void cancelCatalogBtn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 获取当前窗体所表示的编目记录
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>采访编目记录</returns>
        private InterviewCatalog GetAllCatalogList(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            int interviewId;
            //判断采访编号是否能被转换为浮点型
            if (!int.TryParse(interviewIdTextBox.Text, out interviewId))
            {
                errorList.Add("InterviewId Error");
            }
            //根据页面内容构造登到记录
            InterviewCatalog list = new InterviewCatalog()
            {
                InterviewId = interviewId,
                State = stateComboBox.Text,
            };
            error = errorList;//返回错误列表
            return list;//返回编目
        }

        /// <summary>
        /// 当前行变化
        /// </summary>
        private void interviewDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (interviewDataGridView.CurrentRow != null)
            {
                idTextBox.Text = "";//编号
                interviewIdTextBox.Text = interviewDataGridView.CurrentRow.Cells[0].Value.ToString();//采访编号
                stateComboBox.SelectedIndex = 0;//编目状态
            }
            SetEnable();//按钮启用
        }

        /// <summary>
        /// 选择行变化
        /// </summary>
        private void interviewDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (interviewDataGridView.SelectedRows.Count > 0)
            {
                idTextBox.Text = "";//编号
                interviewIdTextBox.Text = interviewDataGridView.SelectedRows[0].Cells[0].Value.ToString();//采访编号
                stateComboBox.SelectedIndex = 0;//编目状态
            }
            SetEnable();//按钮启用
        }

        /// <summary>
        /// 当前行变化
        /// </summary>
        private void catalogDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (catalogDataGridView.CurrentRow != null)
            {
                SetInterviewCatalog(catalogDataGridView.CurrentRow);
            }
            SetEnable();//按钮启用
        }

        /// <summary>
        /// 选择行变化
        /// </summary>
        private void catalogDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (catalogDataGridView.SelectedRows.Count > 0)
            {
                SetInterviewCatalog(catalogDataGridView.SelectedRows[0]);
            }
            SetEnable();//按钮启用
        }


        /// <summary>
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">行</param>
        private void SetInterviewCatalog(DataGridViewRow row)
        {
            idTextBox.Text = row.Cells["编号"].Value.ToString();//编号
            interviewIdTextBox.Text = row.Cells["采访编号"].Value.ToString();//采访编号
            stateComboBox.Text = row.Cells["状态"].Value.ToString();//采访状态
        }

        /// <summary>
        /// 根据点击上下窗体的不同启用不同按钮
        /// </summary>
        private void SetEnable()
        {
            if (catalogDataGridView.Rows.Count == 0)
            {
                changeStateBtn.Enabled = false;
                cancelCatalogBtn.Enabled = false;
                catalogBtn.Enabled = true;
            }
            DataGridViewRow row = catalogDataGridView.SelectedRows.Count <= 0 ? catalogDataGridView.CurrentRow : catalogDataGridView.SelectedRows[0];
            if (row == null)
            {
                return;
            }
            if ((idTextBox.Text == row.Cells["编号"].Value.ToString()) && (interviewIdTextBox.Text == row.Cells["订单编号"].Value.ToString()) && (stateComboBox.Text == row.Cells["状态"].Value.ToString()))
            {
                changeStateBtn.Enabled = true;
                cancelCatalogBtn.Enabled = true;
                catalogBtn.Enabled = false;
            }
            else
            {
                changeStateBtn.Enabled = false;
                cancelCatalogBtn.Enabled = false;
                catalogBtn.Enabled = true;
            }

        }

        /// <summary>
        /// 全部入库按钮点击
        /// </summary>
        private void allCatalogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否全部入库", "入库确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    if (createCatalogBll.MoveInterviewCatalogToCirculate())//调用全部入库方法
                    {
                        MessageBox.Show("全部入库成功");
                    }
                    else
                    {
                        MessageBox.Show("全部入库失败");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();//数据绑定
        }
    }
}
