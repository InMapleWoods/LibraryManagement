using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.UserManagement
{
    public partial class UserManagementForm : Form
    {
        Form parentForm;
        public UserManagementForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void UserManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
