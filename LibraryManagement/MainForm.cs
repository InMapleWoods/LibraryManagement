using LibraryManagement.Circulation;
using System;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void getAllBookButton_Click(object sender, EventArgs e)
        {
            var form = new GetAllCirculateBooks(this);
            form.Show();
            Hide();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            var form = new UserManagement.UserManagementForm(this);
            form.Show();
            Hide();
        }
    }
}
