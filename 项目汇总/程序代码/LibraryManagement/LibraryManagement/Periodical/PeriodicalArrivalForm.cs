using LibraryManagement.Bll;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagement.Periodical
{
    /// <summary>
    /// 期刊登到窗体
    /// </summary>
    public partial class PeriodicalArrivalForm : Form
    {
        Form parentForm;//父窗体
        PeriodicalBll periodicalBll = new PeriodicalBll();//期刊用户操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public PeriodicalArrivalForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void PeriodicalArrivalForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void PeriodicalArrivalForm_FormClosing(object sender, FormClosingEventArgs e)
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
            orderDataGridView.DataSource = periodicalBll.GetAllPeriodOrders();
            // 下方窗体数据绑定
            arrivalDataGridView.DataSource = periodicalBll.GetAllPeriodArrivals();
            stateComboBox.SelectedIndex = 0;//状态
            SetEnable();
        }

        /// <summary>
        /// 登到按钮点击
        /// </summary>
        private void arrivalButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                PeriodicalArrival arrival = GetPeriodicalArrival(ref errorList);
                //判断是否添加订单成功
                if (periodicalBll.AddPeriodicalArrival(arrival, ref errorList))
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
        /// 修改登到按钮点击
        /// </summary>
        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）                
                int id;
                if (!int.TryParse(idTextBox.Text, out id))//将其转换为数字失败
                {
                    MessageBox.Show("登到编号错误");
                    return;
                }
                PeriodicalArrival arrival = GetPeriodicalArrival(ref errorList);
                arrival.Id = id;//设置登到ID
                //判断是否修改登到成功
                if (periodicalBll.UpdatePeriodicalArrival(arrival, ref errorList))
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
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
        /// 删除登到记录按钮点击
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否删除该条记录", "删除确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    int id;
                    if (!int.TryParse(idTextBox.Text, out id))//将其转换为数字失败
                    {
                        MessageBox.Show("登到编号错误");
                        return;
                    }
                    if (periodicalBll.DeletePeriodicalArrival(id))//调用登到删除方法
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
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
        /// 获取当前窗体所表示的登到记录
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>期刊登到记录</returns>
        private PeriodicalArrival GetPeriodicalArrival(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            int orderId;
            //判断登到编号是否能被转换为浮点型
            if (!int.TryParse(orderIdTextBox.Text, out orderId))
            {
                errorList.Add("OrderId Error");
            }
            //根据页面内容构造登到记录
            PeriodicalArrival arrival = new PeriodicalArrival()
            {
                OrderId = orderId,
                State = stateComboBox.Text,
            };
            error = errorList;//返回错误列表
            return arrival;//返回登到
        }

        /// <summary>
        /// 当前行变化
        /// </summary>
        private void orderDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (orderDataGridView.CurrentRow != null)
            {
                idTextBox.Text = "";//编号
                orderIdTextBox.Text = orderDataGridView.CurrentRow.Cells["编号"].Value.ToString();//订单编号
                stateComboBox.SelectedIndex = 0;//登到状态
            }
            SetEnable();//按钮启用
        }

        /// <summary>
        /// 选择行变化
        /// </summary>
        private void orderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (orderDataGridView.SelectedRows.Count > 0)
            {
                idTextBox.Text = "";//编号
                orderIdTextBox.Text = orderDataGridView.SelectedRows[0].Cells["编号"].Value.ToString();//订单编号
                stateComboBox.SelectedIndex = 0;//登到状态
            }
            SetEnable();//按钮启用
        }

        /// <summary>
        /// 当前行变化
        /// </summary>
        private void arrivalDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (arrivalDataGridView.CurrentRow != null)
            {
                SetPeriodicalArrival(arrivalDataGridView.CurrentRow);
            }
            SetEnable();//按钮启用
        }

        /// <summary>
        /// 选择行变化
        /// </summary>
        private void arrivalDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (arrivalDataGridView.SelectedRows.Count > 0)
            {
                SetPeriodicalArrival(arrivalDataGridView.SelectedRows[0]);
            }
            SetEnable();//按钮启用
        }

        /// <summary>
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">行</param>
        private void SetPeriodicalArrival(DataGridViewRow row)
        {
            idTextBox.Text = row.Cells["编号"].Value.ToString();//编号
            orderIdTextBox.Text = row.Cells["订单编号"].Value.ToString();//订单编号
            stateComboBox.Text = row.Cells["状态"].Value.ToString();//登到状态
        }

        /// <summary>
        /// 根据点击上下窗体的不同启用不同按钮
        /// </summary>
        private void SetEnable()
        {
            if (arrivalDataGridView.Rows.Count == 0)
            {
                changeButton.Enabled = false;
                deleteButton.Enabled = false;
                arrivalButton.Enabled = true;
            }
            DataGridViewRow row = arrivalDataGridView.SelectedRows.Count <= 0 ? arrivalDataGridView.CurrentRow : arrivalDataGridView.SelectedRows[0];
            if (row == null)
            {
                return;
            }
            if ((idTextBox.Text == row.Cells["编号"].Value.ToString()) && (orderIdTextBox.Text == row.Cells["订单编号"].Value.ToString()) && (stateComboBox.Text == row.Cells["状态"].Value.ToString()))
            {
                changeButton.Enabled = true;
                deleteButton.Enabled = true;
                arrivalButton.Enabled = false;
            }
            else
            {
                changeButton.Enabled = false;
                deleteButton.Enabled = false;
                arrivalButton.Enabled = true;
            }
        }

        /// <summary>
        /// 全部入库按钮点击
        /// </summary>
        private void circulationButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否全部入库", "入库确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    if (periodicalBll.MoveArrivedPeriodicalToCirculate())//调用全部入库方法
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
