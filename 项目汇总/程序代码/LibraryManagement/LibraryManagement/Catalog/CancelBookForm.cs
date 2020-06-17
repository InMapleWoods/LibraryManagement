using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Catalog
{
    public partial class CancelBookForm : Form
    {
        Form parentForm;
        public CancelBookForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void CancelBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void cancelApplyBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelAuditBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
