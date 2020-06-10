using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.UserManagement
{
    public partial class AddReaderForm : Form
    {
        Form parentForm;
        public AddReaderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void AddReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
