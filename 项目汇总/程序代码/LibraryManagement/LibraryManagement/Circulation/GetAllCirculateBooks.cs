using LibraryManagement.Bll;
using System;
using System.Windows.Forms;

namespace LibraryManagement.Circulation
{
    public partial class GetAllCirculateBooks : Form
    {
        Form parentForm;
        CirculationBll circulationBll = new CirculationBll();
        public GetAllCirculateBooks(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }
        private void GetAllCirculateBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        private void GetAllCirculateBooks_Load(object sender, System.EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            try
            {
                string isbn = IsbnTextBox.Text;
                string title = officialTitleTextBox.Text;
                string author = textBox_author.Text;
                string documentType = textBox_documentType.Text;
                dataGridView1.DataSource = circulationBll.GetAllBooks(isbn, title, author, documentType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void IsbnTextBox_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }

        private void officialTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }

        private void textBox_author_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }

        private void textBox_documentType_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
