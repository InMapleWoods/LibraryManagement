using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Circulation
{
    public partial class BookAppointForm : Form
    {
        Form parentForm;
        public BookAppointForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void BookAppointForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        private void BookAppointForm_FormClosing(object sender, FormClosingEventArgs e)
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
