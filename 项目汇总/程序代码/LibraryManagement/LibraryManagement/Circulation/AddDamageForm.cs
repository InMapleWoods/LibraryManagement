using LibraryManagement.Bll;
using LibraryManagement.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagement.Circulation
{
    public partial class AddDamageForm : Form
    {
        BookDamageLog damageLog;
        Form parentForm;
        CirculationBll circulationBll = new CirculationBll();
        UtilBll utilBll = new UtilBll();
        public AddDamageForm(Form form, BookDamageLog log)
        {
            InitializeComponent();
            parentForm = form;
            damageLog = log;
        }

        private void AddDamageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            damageLog.DamageDetail = richTextBox_detail.Text;
            Match matchChecker = Regex.Match(textBox_checkerNum.Text, @"(^\d{8}$)|(^\d{10}$)|(^\d{12}$)");
            if (!matchChecker.Success)
            {
                MessageBox.Show("AcceptorId Error");
                return;
            }
            damageLog.CheckerId = utilBll.GetUserIdFormNumber(textBox_checkerNum.Text);
            damageLog.CheckTime = DateTime.Now;
            DialogResult = DialogResult.Yes;
        }
    }
}
