using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Circulation
{
    public partial class BookBorrowForm : Form
    {
        Form parentForm;
        public BookBorrowForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void BookBorrowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
