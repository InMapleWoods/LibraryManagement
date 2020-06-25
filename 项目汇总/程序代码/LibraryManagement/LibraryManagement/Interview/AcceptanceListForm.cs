using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools.MyUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Interview
{
    public partial class AcceptanceListForm : Form
    {
        Form parentForm;//父窗体
        InterviewBll interviewBll = new InterviewBll();//采访子系统用户操作类
        UtilBll utilBll = new UtilBll();//复用部分用户操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public AcceptanceListForm(Form form)
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
                EmptyAcceptanceList();//将输入框置为空白
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        private void AddLog_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的清单（若有错误会被添加到错误列表中）
                AcceptanceList list = GetAcceptanceList(ref errorList);
                //判断是否添加清单成功
                if (interviewBll.AddAcceptanceList(list, ref errorList))
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
                string Id = IdTextBox.Text;//获取清单编号
                if (string.IsNullOrEmpty(Id))
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
                    string idNum = IdTextBox.Text;//获取清单编号
                    int id;
                    if (!int.TryParse(idNum, out id))//将其转换为数字失败
                    {
                        MessageBox.Show("清单编号错误");
                        return;
                    }
                    if (interviewBll.DeleteAcceptanceList(id))//调用清单删除方法
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
                //获取根据当前页面内容生成的清单（若有错误会被添加到错误列表中）
                string idNum = IdTextBox.Text;//获取订单编号
                int id;
                if (!int.TryParse(idNum, out id))//将其转换为数字失败
                {
                    MessageBox.Show("订单编号错误");
                    return;
                }
                AcceptanceList list = GetAcceptanceList(ref errorList);
                list.Id = id;//设置清单ID
                //判断是否添加清单成功
                if (interviewBll.UpdateAcceptanceList(list, ref errorList))
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
                if (AcceptanceDataGridView.SelectedRows.Count > 0)
                {
                    index = AcceptanceDataGridView.SelectedRows[0].Index;
                }
                else
                {
                    index = AcceptanceDataGridView.CurrentRow.Index;
                }
                AcceptanceDataGridView.Rows[index].Selected = false;//放弃选择当前行
                index = index + 1 >= AcceptanceDataGridView.RowCount ? AcceptanceDataGridView.RowCount - 1 : index + 1;
                AcceptanceDataGridView.Rows[index].Selected = true;//选择下一行
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
                if (AcceptanceDataGridView.SelectedRows.Count > 0)
                {
                    index = AcceptanceDataGridView.SelectedRows[0].Index;
                }
                else
                {
                    index = AcceptanceDataGridView.CurrentRow.Index;
                }
                AcceptanceDataGridView.Rows[index].Selected = false;//放弃选择当前行
                index = index - 1 <= 0 ? 0 : index - 1;
                AcceptanceDataGridView.Rows[index].Selected = true;//选择上一行
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
        /// 将当前窗体输入文本部分置空
        /// </summary>
        private void EmptyAcceptanceList()
        {
            IdTextBox.Text = "";
            BookSellerComboBox.Text = "";
            PublishingHouseComboBox.Text = "";
            OrdererTextBox.Text = "";
            AcceptorTextBox.Text = "";
            DocumentTypeComboBox.Text = "";
        }

        /// <summary>
        /// 获取当前窗体所表示的清单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>验收清单</returns>
        private AcceptanceList GetAcceptanceList(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表

            //书商Id
            int bookSellerId = ((KeyValuePair<int, string>)BookSellerComboBox.SelectedItem).Key;

            //出版社Id
            int publisherId = ((KeyValuePair<int, string>)PublishingHouseComboBox.SelectedItem).Key;

            //判断订购人账号是否符合要求
            Match matchOrderer = Regex.Match(OrdererTextBox.Text, @"(^\d{8}$)|(^\d{10}$)|(^\d{12}$)");
            if (!matchOrderer.Success)
            {
                errorList.Add("OrdererId Error");
            }

            //通过订购人账号获取id
            int ordererId = utilBll.GetUserIdFormNumber(OrdererTextBox.Text);

            //判断验收人账号是否符合要求
            Match matchAcceptor = Regex.Match(AcceptorTextBox.Text, @"(^\d{8}$)|(^\d{10}$)|(^\d{12}$)");
            if (!matchAcceptor.Success)
            {
                errorList.Add("AcceptorId Error");
            }

            //通过订购人账号获取id
            int acceptorId = utilBll.GetUserIdFormNumber(AcceptorTextBox.Text);

            //根据页面内容构造清单
            AcceptanceList list = new AcceptanceList()
            {
                BookSellerId = bookSellerId,
                PublishingHouseId = publisherId,
                OrdererId = ordererId,
                AcceptorId = acceptorId,
                DocumentType = DocumentTypeComboBox.Text,
            };
            error = errorList;//返回错误列表
            return list;//返回订单
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
        private void AcceptanceListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        /// <summary>
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">行</param>
        private void SetAcceptanceList(DataGridViewRow row)
        {
            IdTextBox.Text = row.Cells[0].Value.ToString();//清单号
            BookSellerComboBox.Text = row.Cells[1].Value.ToString();//书商
            PublishingHouseComboBox.Text = row.Cells[2].Value.ToString();//出版社
            DocumentTypeComboBox.Text = row.Cells[5].Value.ToString();//文献类型
        }

        /// <summary>
        /// 选择行更改
        /// </summary>
        private void AcceptanceDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (AcceptanceDataGridView.SelectedRows.Count > 0)
            {
                SetAcceptanceList(AcceptanceDataGridView.SelectedRows[0]);
            }
        }

        /// <summary>
        /// 当前行更改
        /// </summary>
        private void AcceptanceDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (AcceptanceDataGridView.CurrentRow != null)
            {
                SetAcceptanceList(AcceptanceDataGridView.CurrentRow);
            }
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void AcceptanceListForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            //上方窗体数据绑定
            PurchaseDataGridView.DataSource = interviewBll.GetAllPurchaseOrders();

            //下方窗体数据绑定
            AcceptanceDataGridView.DataSource = interviewBll.GetAllAcceptanceList();

            //书商数据绑定
            BindingSource bs_BookSeller = new BindingSource();
            bs_BookSeller.DataSource = utilBll.GetBookSellerNames();
            BookSellerComboBox.DataSource = bs_BookSeller;
            BookSellerComboBox.ValueMember = "Key";
            BookSellerComboBox.DisplayMember = "Value";

            //出版社数据绑定
            BindingSource bs_PublishingHouse = new BindingSource();
            bs_PublishingHouse.DataSource = utilBll.GetPublishingHouseNames();
            PublishingHouseComboBox.DataSource = bs_PublishingHouse;
            PublishingHouseComboBox.ValueMember = "Key";
            PublishingHouseComboBox.DisplayMember = "Value";
        }
    }
}
