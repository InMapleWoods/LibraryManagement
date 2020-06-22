using System;
using System.Windows.Forms;

namespace LibraryManagement.Periodical
{
    /// <summary>
    /// 期刊子系统窗体
    /// </summary>
    public partial class PeriodicalForm : Form
    {
        Form parentForm;//父窗体

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public PeriodicalForm(Form form)
        {
            InitializeComponent();
            parentForm = form;//父窗体
        }

        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        private void PeriodicalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        /// <summary>
        /// 期刊订单按钮点击事件
        /// </summary>
        private void orderButton_Click(object sender, EventArgs e)
        {
            var form = new PeriodicalOrderForm(this);
            form.Show();
            Hide();
        }

        /// <summary>
        /// 期刊登到按钮点击事件
        /// </summary>
        private void arriveButton_Click(object sender, EventArgs e)
        {
            var form = new PeriodicalArrivalForm(this);
            form.Show();
            Hide();
        }

        /// <summary>
        /// 期刊合订按钮点击事件
        /// </summary>
        private void bindiButton_Click(object sender, EventArgs e)
        {
            var form = new PeriodicalBindingForm(this);
            form.Show();
            Hide();
        }

        /// <summary>
        /// 报表打印按钮点击事件
        /// </summary>
        private void reportFormButton_Click(object sender, EventArgs e)
        {
            var form = new PeriodicalTableForm(this);
            form.Show();
            Hide();
        }
    }
}
