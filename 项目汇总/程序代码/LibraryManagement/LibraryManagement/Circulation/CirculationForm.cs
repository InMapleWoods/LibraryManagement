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
            var form = new BookBorrowForm(this);
            form.Show();
            Hide();
        }
    }
}
