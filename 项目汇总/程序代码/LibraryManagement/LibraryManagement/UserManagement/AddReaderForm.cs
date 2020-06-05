using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.UserManagement
{
    public partial class AddReaderForm : Form
    {
        Form parentForm;
        public AddReaderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void AddReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
