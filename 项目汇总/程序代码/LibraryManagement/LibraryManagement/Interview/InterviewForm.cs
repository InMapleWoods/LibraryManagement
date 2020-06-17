﻿using System.Windows.Forms;

namespace LibraryManagement.Interview
{
    public partial class InterviewForm : Form
    {
        Form parentForm;
        public InterviewForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void InterviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void OrderButton_Click(object sender, System.EventArgs e)
        {
            var form = new BookOrderForm(this);
            form.Show();
            Hide();
        }

        private void InterviewListButton_Click(object sender, System.EventArgs e)
        {
            var form = new InterviewListForm(this);
            form.Show();
            Hide();
        }
    }
}
