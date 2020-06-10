using System;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.UserManagement
{
    public partial class AdminOperationForm : Form
    {
        Form parentForm;
        public AdminOperationForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void addNewReaderButton_Click(object sender, EventArgs e)
        {
            var form = new AddReaderForm(this);
            form.Show();
            Hide();
        }

        private void AdminOperationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
