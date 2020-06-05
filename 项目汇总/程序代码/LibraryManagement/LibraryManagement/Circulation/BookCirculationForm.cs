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
    public partial class BookCirculationForm : Form
    {
        Form parentForm;
        public BookCirculationForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void BookCirculationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
