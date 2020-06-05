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
    public partial class AdminOperationForm : Form
    {
        Form parentForm;
        public AdminOperationForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void addNewReaderButton_Click(object sender, EventArgs e)
        {
            var form = new AddReaderForm(this);
            form.Show();
            Hide();
        }

        private void AdminOperationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
