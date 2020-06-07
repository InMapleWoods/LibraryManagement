using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Interview
{
    public partial class BookOrderForm : Form
    {
        Form parentForm;
        public BookOrderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void BookOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
