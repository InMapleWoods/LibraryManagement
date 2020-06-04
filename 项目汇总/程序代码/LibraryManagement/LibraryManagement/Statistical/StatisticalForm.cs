using System.Windows.Forms;

namespace LibraryManagement.Statistical
{
    public partial class StatisticalForm : Form
    {
        Form parentForm;
        public StatisticalForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void StatisticalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
