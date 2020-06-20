using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools.MyUserControl;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagement.Periodical
{
    /// <summary>
    /// 期刊订单窗体
    /// </summary>
    public partial class PeriodicalOrderForm : Form
    {
        Form parentForm;//父窗体
        PeriodicalBll periodicalBll = new PeriodicalBll();//期刊用户操作类
        UtilBll utilBll = new UtilBll();//复用部分用户操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public PeriodicalOrderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            scriptUserControl1.AddContorlClickMethod(NewLog_Click, ScriptUserControl.ControlNames.createButton);
            scriptUserControl1.AddContorlClickMethod(AddLog_Click, ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.AddContorlClickMethod(ChangeLog_Click, ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.AddContorlClickMethod(DeleteLog_Click, ScriptUserControl.ControlNames.emptyButton);
            scriptUserControl1.AddContorlClickMethod(SaveLog_Click, ScriptUserControl.ControlNames.saveButton);
            scriptUserControl1.AddContorlClickMethod(NextLog_Click, ScriptUserControl.ControlNames.nextButton);
            scriptUserControl1.AddContorlClickMethod(PreviousLog_Click, ScriptUserControl.ControlNames.previousButton);
            scriptUserControl1.AddContorlClickMethod(ExitLog_Click, ScriptUserControl.ControlNames.exitButton);
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void PeriodicalOrderForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void PeriodicalOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        #region 用户控件相关方法（菜单控件）
        /// <summary>
        /// 新增记录
        /// </summary>
        private void NewLog_Click(object sender, EventArgs e)
        {
            try
            {
                DataBind();//数据绑定
                EmptyPeriodicalOrder();//将输入框置为空白
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 增加记录
        /// </summary>
        private void AddLog_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                PeriodicalOrder order = GetPeriodicalOrder(ref errorList);
                //判断是否添加订单成功
                if (periodicalBll.AddPeriodicalOrder(order, ref errorList))
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
        /// 修改记录
        /// </summary>
        private void ChangeLog_Click(object sender, EventArgs e)
        {
            try
            {
                string orderNum = orderNumTextBox.Text;//获取订单编号
                if (string.IsNullOrEmpty(orderNum))
                {
                    return;
                }
                ChangeControlEnableState();//更改菜单按钮启用状态
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        private void DeleteLog_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否删除该条记录", "删除确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    string orderNum = orderNumTextBox.Text;//获取订单编号
                    int id;
                    if (!int.TryParse(orderNum, out id))//将其转换为数字失败
                    {
                        MessageBox.Show("订单编号错误");
                        return;
                    }
                    if (periodicalBll.DeletePeriodicalOrder(id))//调用订单删除方法
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
        /// 保存记录
        /// </summary>
        private void SaveLog_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                string orderNum = orderNumTextBox.Text;//获取订单编号
                int id;
                if (!int.TryParse(orderNum, out id))//将其转换为数字失败
                {
                    MessageBox.Show("订单编号错误");
                    return;
                }
                PeriodicalOrder order = GetPeriodicalOrder(ref errorList);
                order.Id = id;//设置订单ID
                //判断是否添加订单成功
                if (periodicalBll.UpdatePeriodicalOrder(order, ref errorList))
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
            ChangeControlEnableState();//改变菜单按钮启用状态
        }

        /// <summary>
        /// 下一条记录
        /// </summary>
        private void NextLog_Click(object sender, EventArgs e)
        {
            try
            {
                //若不选择整行，selectRows是没有元素的，所以需要进行判断
                int index;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    index = dataGridView1.SelectedRows[0].Index;
                }
                else
                {
                    index = dataGridView1.CurrentRow.Index;
                }
                dataGridView1.Rows[index].Selected = false;//放弃选择当前行
                index = index + 1 >= dataGridView1.RowCount ? dataGridView1.RowCount - 1 : index + 1;
                dataGridView1.Rows[index].Selected = true;//选择下一行
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///上一条记录
        /// </summary>
        private void PreviousLog_Click(object sender, EventArgs e)
        {
            try
            {
                //若不选择整行，selectRows是没有元素的，所以需要进行判断
                int index;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    index = dataGridView1.SelectedRows[0].Index;
                }
                else
                {
                    index = dataGridView1.CurrentRow.Index;
                }
                dataGridView1.Rows[index].Selected = false;//放弃选择当前行
                index = index - 1 <= 0 ? 0 : index - 1;
                dataGridView1.Rows[index].Selected = true;//选择上一行
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        private void ExitLog_Click(object sender, EventArgs e)
        {
            try
            {
                parentForm.Show();//显示父窗体
                Hide();//隐藏本窗体
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        /// <summary>
        /// 获取当前窗体所表示的订单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>期刊订单</returns>
        private PeriodicalOrder GetPeriodicalOrder(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            //书商Id
            int booksellerId = ((KeyValuePair<int, string>)booksellerComboBox.SelectedItem).Key;
            //出版社Id
            int publishingHouseId = ((KeyValuePair<int, string>)publishingHouseComboBox.SelectedItem).Key;
            //判断订购人账号是否符合要求
            Match matchOrderer = Regex.Match(ordererTextBox.Text, @"(^\d{8}$)|(^\d{10}$)|(^\d{12}$)");
            if (!matchOrderer.Success)
            {
                errorList.Add("OrdererNumber Error");
            }
            //通过订购人账号获取id
            int ordererId = utilBll.GetUserIdFormNumber(ordererTextBox.Text);
            double price;
            //判断价格是否能被转换为浮点型
            if (!double.TryParse(orderPriceTextBox.Text, out price))
            {
                errorList.Add("OrderPrice Error");
            }
            //根据页面内容构造订单
            PeriodicalOrder order = new PeriodicalOrder()
            {
                BookSellerId = booksellerId,
                OrderDate = orderDatePicker.Value,
                OrdererId = ordererId,
                ISBN = IsbnTextBox.Text,
                DocumentType = documentTypeComboBox.Text,
                PublishCycle = cycleComboBox.Text,
                OfficialTitle = officialTitleTextBox.Text,
                SupplementTitle = supplementTitleTextBox.Text,
                PublishingHouseId = publishingHouseId,
                OrderPrice = price,
                CurrencyType = currencyTypeComboBox.Text,
                Size = sizeComboBox.Text,
            };
            error = errorList;//返回错误列表
            return order;//返回订单
        }

        /// <summary>
        /// 将当前窗体输入文本部分置空
        /// </summary>
        private void EmptyPeriodicalOrder()
        {
            orderNumTextBox.Text = "";
            booksellerComboBox.Text = "";
            orderDatePicker.Value = DateTime.Now;
            IsbnTextBox.Text = "";
            documentTypeComboBox.Text = "";
            cycleComboBox.Text = "";
            officialTitleTextBox.Text = "";
            supplementTitleTextBox.Text = "";
            publishingHouseComboBox.Text = "";
            orderPriceTextBox.Text = "";
            currencyTypeComboBox.Text = "";
            sizeComboBox.Text = "";
        }

        /// <summary>
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">行</param>
        private void SetPeriodicalOrder(DataGridViewRow row)
        {
            orderNumTextBox.Text = row.Cells[0].Value.ToString();//订单编号
            booksellerComboBox.Text = row.Cells[1].Value.ToString();//书商名称
            orderDatePicker.Value = (DateTime)row.Cells[2].Value;//订购时间
            IsbnTextBox.Text = row.Cells[4].Value.ToString();//ISBN
            documentTypeComboBox.Text = row.Cells[5].Value.ToString();//文献类型
            cycleComboBox.Text = row.Cells[6].Value.ToString();//出版周期
            officialTitleTextBox.Text = row.Cells[7].Value.ToString();//正刊名
            supplementTitleTextBox.Text = row.Cells[8].Value.ToString();//副刊名
            publishingHouseComboBox.Text = row.Cells[9].Value.ToString();//出版社名称
            orderPriceTextBox.Text = row.Cells[10].Value.ToString();//订购价
            currencyTypeComboBox.Text = row.Cells[11].Value.ToString();//币种
            sizeComboBox.Text = row.Cells[12].Value.ToString();//尺寸
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            //下方总窗体数据绑定
            dataGridView1.DataSource = periodicalBll.GetAllPeriodOrders();

            //书商数据绑定
            BindingSource bs_BookSeller = new BindingSource();
            bs_BookSeller.DataSource = utilBll.GetBookSellerNames();
            booksellerComboBox.DataSource = bs_BookSeller;
            booksellerComboBox.ValueMember = "Key";
            booksellerComboBox.DisplayMember = "Value";

            //出版社数据绑定
            BindingSource bs_PublishingHouse = new BindingSource();
            bs_PublishingHouse.DataSource = utilBll.GetPublishingHouseNames();
            publishingHouseComboBox.DataSource = bs_PublishingHouse;
            publishingHouseComboBox.ValueMember = "Key";
            publishingHouseComboBox.DisplayMember = "Value";

            currencyTypeComboBox.SelectedIndex = 0;//币种
            documentTypeComboBox.SelectedIndex = 0;//文献类型
            cycleComboBox.SelectedIndex = 0;//出版周期
            sizeComboBox.SelectedIndex = 0;//尺寸
        }

        /// <summary>
        /// 修改用户控件中按钮的启用状态
        /// </summary>
        private void ChangeControlEnableState()
        {
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.emptyButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.saveButton);
        }

        /// <summary>
        /// 选择行更改
        /// </summary>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SetPeriodicalOrder(dataGridView1.SelectedRows[0]);
            }
        }

        /// <summary>
        /// 当前行更改
        /// </summary>
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SetPeriodicalOrder(dataGridView1.CurrentRow);
            }
        }

    }
}
