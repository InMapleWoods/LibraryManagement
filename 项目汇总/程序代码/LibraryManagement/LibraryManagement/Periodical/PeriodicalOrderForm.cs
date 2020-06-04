﻿using System.Windows.Forms;

namespace LibraryManagement.Periodical
{
    public partial class PeriodicalOrderForm : Form
    {
        Form parentForm;
        public PeriodicalOrderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void PeriodicalOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
