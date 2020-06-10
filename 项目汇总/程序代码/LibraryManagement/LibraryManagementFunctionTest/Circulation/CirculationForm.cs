﻿using System;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Circulation
{
    public partial class CirculationForm : Form
    {
        Form parentForm;
        public CirculationForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void CirculationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void bookBorrowButton_Click(object sender, EventArgs e)
        {
            var form = new BookCirculationForm(this);
            form.Show();
            Hide();
        }
    }
}
