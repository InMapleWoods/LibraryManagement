using System;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest
{
    public partial class MainForm : Form
    {
        public string folderSrc = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void periodicalSystemButton_Click(object sender, EventArgs e)
        {
            var form = new Periodical.PeriodicalForm(this);
            form.Show();
            Hide();
        }

        private void statisticalSystemButton_Click(object sender, EventArgs e)
        {
            var form = new Statistical.StatisticalForm(this);
            form.Show();
            Hide();
        }

        private void interviewSystemButton_Click(object sender, EventArgs e)
        {
            var form = new Interview.InterviewForm(this);
            form.Show();
            Hide();
        }

        private void maintainaceSystemButton_Click(object sender, EventArgs e)
        {
            var form = new Maintainace.MaitainanceForm(this);
            form.Show();
            Hide();
        }

        private void catalogSystemBtn_Click(object sender, EventArgs e)
        {
            var form = new Catalog.CatalogForm(this);
            form.Show();
            Hide();
        }

        private void circulationSystemButton_Click(object sender, EventArgs e)
        {
            var form = new Circulation.CirculationForm(this);
            form.Show();
            Hide();
        }

        private void userManagementSystemButton_Click(object sender, EventArgs e)
        {
            var form = new UserManagement.UserManagementAdminChoice(this);
            form.Show();
            Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            caseBrowserTextBox.Text = Application.StartupPath;
            folderSrc = Application.StartupPath;
        }

        private void caseBrowserButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowDialog();
            caseBrowserTextBox.Text = folderDlg.SelectedPath;
            folderSrc = folderDlg.SelectedPath;
        }
    }
}
