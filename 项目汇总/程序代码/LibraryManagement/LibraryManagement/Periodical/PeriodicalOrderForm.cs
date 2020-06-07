using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools.MyUserControl;

namespace LibraryManagement.Periodical
{
    public partial class PeriodicalOrderForm : Form
    {
        Form parentForm;
        PeriodicalBll periodicalBll = new PeriodicalBll();
        UtilBll utilBll = new UtilBll();
        public PeriodicalOrderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            scriptUserControl1.AddContorlClickMethod(AddLog_Click, ScriptUserControl.ControlNames.addButton);
        }

        private void PeriodicalOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

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

        private void PeriodicalOrderForm_Load(object sender, EventArgs e)
        {
            DataBind();
        }

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

    }
}
