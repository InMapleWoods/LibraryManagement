using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Circulation
{
    public partial class BookCirculationForm : Form
    {
        Form parentForm;
        public BookCirculationForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void BookCirculationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
