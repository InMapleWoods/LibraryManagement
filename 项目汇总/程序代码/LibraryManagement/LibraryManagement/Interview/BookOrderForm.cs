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

namespace LibraryManagement.Interview
{
    public partial class BookOrderForm : Form
    {
        Form parentForm;
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
                PurchaseOrder order = Get

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitLog_Click(object sender,EventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void BookOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
