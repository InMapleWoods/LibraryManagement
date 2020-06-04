using System.Windows.Forms;

namespace LibraryManagement.Maintainace
{
    public partial class DictionaryEditForm : Form
    {
        Form parentForm;
        public DictionaryEditForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void DictionaryEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
