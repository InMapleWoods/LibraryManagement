using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Tools.MyUserControl;
using LibraryManagement.Model;
using LibraryManagement.Bll;
using System.Text.RegularExpressions;

namespace LibraryManagement.Interview
{
    public partial class BookOrderForm : Form
    {
        Form parentForm;//父窗体
        InterviewBll interviewBll = new InterviewBll();//采访子系统用户操作类
        UtilBll utilBll = new UtilBll();//复用部分用户操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public BookOrderForm(Form form)
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

        #region 用户控件相关方法（菜单控件）
        /// <summary>
        /// 新增记录
        /// </summary>
        private void NewLog_Click(object sender, EventArgs e)
        {
            try
            {
                DataBind();//数据绑定
                EmptyPurchaseOrder();//将输入框置为空白
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        private void AddLog_Click(object sender,EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                InterviewPurchaseOrder order = GetPurchaseOrder(ref errorList);
                //判断是否添加订单成功
                if(interviewBll.AddPurchaseOrder(order, ref errorList))
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
                    if (interviewBll.DeletePurchaseOrder(id))//调用订单删除方法
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
                InterviewPurchaseOrder order = GetPurchaseOrder(ref errorList);
                order.Id = id;//设置订单ID
                //判断是否添加订单成功
                if (interviewBll.UpdatePurchaseOrder(order, ref errorList))
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
                if (OrderDataGridView.SelectedRows.Count > 0)
                {
                    index = OrderDataGridView.SelectedRows[0].Index;
                }
                else
                {
                    index = OrderDataGridView.CurrentRow.Index;
                }
                OrderDataGridView.Rows[index].Selected = false;//放弃选择当前行
                index = index + 1 >= OrderDataGridView.RowCount ? OrderDataGridView.RowCount - 1 : index + 1;
                OrderDataGridView.Rows[index].Selected = true;//选择下一行
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
                if (OrderDataGridView.SelectedRows.Count > 0)
                {
                    index = OrderDataGridView.SelectedRows[0].Index;
                }
                else
                {
                    index = OrderDataGridView.CurrentRow.Index;
                }
                OrderDataGridView.Rows[index].Selected = false;//放弃选择当前行
                index = index - 1 <= 0 ? 0 : index - 1;
                OrderDataGridView.Rows[index].Selected = true;//选择上一行
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 返回上一级
        /// </summary>
        private void ExitLog_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        #endregion

        /// <summary>
        /// 获取当前窗体所表示的订单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>采购订单</returns>
        private InterviewPurchaseOrder GetPurchaseOrder(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表

            //出版社Id
            int publisherId = ((KeyValuePair<int, string>)publishingHouseComboBox.SelectedItem).Key;
            
            //判断订购人账号是否符合要求
            Match matchOrderer = Regex.Match(SubscriberTextBox.Text, @"(^\d{8}$)|(^\d{10}$)|(^\d{12}$)");
            if (!matchOrderer.Success)
            {
                errorList.Add("OrdererNumber Error");
            }

            //通过订购人账号获取id
            int ordererId = utilBll.GetUserIdFormNumber(SubscriberTextBox.Text);

            double price;

            //判断价格是否能被转换为整型
            if (!double.TryParse(pricetextBox.Text, out price))
            {
                errorList.Add("OrderPrice Error");
            }

            //根据页面内容构造订单
            InterviewPurchaseOrder order = new InterviewPurchaseOrder()
            {
                SubDate = subDatePicker.Value,
                ISBN = ISBNtextBox.Text,
                OrdererId = ordererId,
                BookName = bookNameTextBox.Text,
                Price = price,
                PublishingHouseId = publisherId,
                DocumentType = documentTypeComboBox.Text,
            };
            error = errorList;//返回错误列表
            return order;//返回订单
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
        /// 关闭当前界面并返回
        /// </summary>
        private void BookOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        /// <summary>
        /// 将当前窗体输入文本部分置空
        /// </summary>
        private void EmptyPurchaseOrder()
        {
            orderNumTextBox.Text = "";
            subDatePicker.Value = DateTime.Now;
            ISBNtextBox.Text = "";
            documentTypeComboBox.Text = "";
            SubscriberTextBox.Text = "";
            bookNameTextBox.Text = "";
            pricetextBox.Text = "";
        }

        /// <summary>
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">行</param>
        private void SetInformation(DataGridViewRow row)
        {
            orderNumTextBox.Text = row.Cells[0].Value.ToString();//订单编号
            subDatePicker.Value = (DateTime)row.Cells[1].Value;//订购时间
            ISBNtextBox.Text = row.Cells[2].Value.ToString();//ISBN
            bookNameTextBox.Text = row.Cells[4].Value.ToString();//书名
            pricetextBox.Text = row.Cells[5].Value.ToString();//价格
            publishingHouseComboBox.Text = row.Cells[6].Value.ToString();//出版社名称
            documentTypeComboBox.Text = row.Cells[7].Value.ToString();//文献类型
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            //上方总窗体数据绑定
            InterviewDataGridView.DataSource = interviewBll.GetAllInterviewList();
            //下方总窗体数据绑定
            OrderDataGridView.DataSource = interviewBll.GetAllPurchaseOrders();

            //出版社数据绑定
            BindingSource bs_PublishingHouse = new BindingSource();
            bs_PublishingHouse.DataSource = utilBll.GetPublishingHouseNames();
            publishingHouseComboBox.DataSource = bs_PublishingHouse;
            publishingHouseComboBox.ValueMember = "Key";
            publishingHouseComboBox.DisplayMember = "Value";
        }

        /// <summary>
        /// 选择行更改
        /// </summary>
        private void OrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                SetInformation(OrderDataGridView.SelectedRows[0]);
            }
        }

        /// <summary>
        /// 当前行更改
        /// </summary>
        private void OrderDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (OrderDataGridView.CurrentRow != null)
            {
                SetInformation(OrderDataGridView.CurrentRow);
            }
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void BookOrderForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }
    }
}
