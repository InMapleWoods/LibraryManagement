using System;
using System.Windows.Forms;

namespace LibraryManagement.Periodical
{
    public partial class PeriodicalForm : Form
    {
        Form parentForm;
        public PeriodicalForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            var form = new PeriodicalOrderForm(this);
            form.Show();
            Hide();
        }

        private void PeriodicalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
