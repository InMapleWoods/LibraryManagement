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
            scriptUserControl1.AddContorlClickMethod(ExitLog_Click,
                ScriptUserControl.ControlNames.exitButton);
            scriptUserControl1.AddContorlClickMethod(AddLog_Click,
                ScriptUserControl.ControlNames.addButton);
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

        private InterviewPurchaseOrder GetPurchaseOrder(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
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

            int publisherId;
            //判断出版社ID是否能被转换为整型
            if (!int.TryParse(publisherTextBox.Text, out publisherId))
            {
                errorList.Add("PublisherId Error");
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

        private void ExitLog_Click(object sender,EventArgs e)
        {
            parentForm.Show();
            Hide();
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

        }
    }
}
