using System;
using System.Collections.Generic;
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
            PeriodicalOrder order = GetPeriodicalOrder();
            if (periodicalBll.AddPeriodicalOrder(order))
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            DataBind();
        }

        private PeriodicalOrder GetPeriodicalOrder()
        {
            int booksellerId = ((KeyValuePair<int, string>)booksellerComboBox.SelectedItem).Key;
            int publishingHouseId = ((KeyValuePair<int, string>)publishingHouseComboBox.SelectedItem).Key;
            int ordererId = utilBll.GetUserIdFormNumber(ordererTextBox.Text);
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
                OrderPrice = double.Parse(orderPriceTextBox.Text),
                CurrencyType = currencyTypeComboBox.Text,
                Size = sizeComboBox.Text,
            };
            return order;
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
