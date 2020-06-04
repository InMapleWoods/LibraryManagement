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
    }
}
