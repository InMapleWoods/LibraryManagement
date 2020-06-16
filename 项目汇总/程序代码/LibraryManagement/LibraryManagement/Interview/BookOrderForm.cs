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
        Form parentForm;
        InterviewPurchaseBll interviewPurchaseBll = new InterviewPurchaseBll();
        UtilBll utilBll = new UtilBll();
        public BookOrderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            scriptUserControl1.AddContorlClickMethod(ExitLog_Click, ScriptUserControl.ControlNames.exitButton);
            scriptUserControl1.AddContorlClickMethod(AddLog_Click, ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.AddContorlClickMethod(ChangeLog_Click, ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.AddContorlClickMethod(DeleteLog_Click, ScriptUserControl.ControlNames.emptyButton);
        }

        private void AddLog_Click(object sender,EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                InterviewPurchaseOrder order = GetPurchaseOrder(ref errorList);
                //判断是否添加订单成功
                if(interviewPurchaseBll.AddPurchaseOrder(order, ref errorList))
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
                    if (interviewPurchaseBll.DeletePurchaseOrder(id))//调用订单删除方法
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
        /// 返回上一级
        /// </summary>
        private void ExitLog_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            Hide();
        }

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

        private void BookOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
        private void DataBind()
        {
            //下方总窗体数据绑定
            dataGridView1.DataSource = interviewPurchaseBll.GetAllPurchaseOrders();

            //出版社数据绑定
            BindingSource bs_PublishingHouse = new BindingSource();
            bs_PublishingHouse.DataSource = utilBll.GetPublishingHouseNames();
            publishingHouseComboBox.DataSource = bs_PublishingHouse;
            publishingHouseComboBox.ValueMember = "Key";
            publishingHouseComboBox.DisplayMember = "Value";
        }
    }
}
