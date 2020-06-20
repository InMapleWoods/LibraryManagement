using System.Windows.Forms;

namespace LibraryManagement.Circulation
{
    public partial class BookBorrowForm : Form
    {
        Form parentForm;
        public BookBorrowForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void BookCirculationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        private void BookBorrowForm_Load(object sender, System.EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
        }
    }
}
