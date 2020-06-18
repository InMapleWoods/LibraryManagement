using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Periodical
{
    public partial class PeriodicalBindingForm : Form
    {
        Form parentForm;//父窗体

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public PeriodicalBindingForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void PeriodicalBindingForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void PeriodicalBindingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }
        
        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
           
        }
    }
}
