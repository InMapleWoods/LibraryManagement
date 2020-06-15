using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Interview
{
    public partial class BookOrderForm : Form
    {
        Form parentForm;        
        public BookOrderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void BookOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
