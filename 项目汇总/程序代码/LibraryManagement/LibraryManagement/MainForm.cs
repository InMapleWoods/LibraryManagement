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
    }
}
