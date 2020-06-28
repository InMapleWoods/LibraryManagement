using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Interview
{
    public partial class InterviewForm : Form
    {
        public Form parentForm;
        public InterviewForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void InterviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void OrderButton_Click(object sender, System.EventArgs e)
        {
            var form = new BookOrderForm(this);
            form.Show();
            Hide();
        }

        private void InterviewListButton_Click(object sender, System.EventArgs e)
        {
            var form = new InterviewListForm(this);
            form.Show();
            Hide();
        }

        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void AcceptanceListButton_Click(object sender, System.EventArgs e)
        {
            var form = new AcceptanceListForm(this);
            form.Show();
            Hide();
        }

        private void ReturnInformationButton_Click(object sender, System.EventArgs e)
        {
            var form = new ReturnListForm(this);
            form.Show();
            Hide();
        }
    }
}
