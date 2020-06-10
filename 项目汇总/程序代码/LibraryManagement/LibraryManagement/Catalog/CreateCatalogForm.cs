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
    public partial class CreateCatalogForm : Form
    {
        Form parentForm;
        public CreateCatalogForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void CreateCatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void serialNumberBtn_Click(object sender, EventArgs e)
        {
            var form = new SerialNumberForm(this);
            form.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm(this);
            form.Show();
            Hide();
        }

        private void pringBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm(this);
            form.Show();
            Hide();
        }

        private void catalogQueryBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm(this);
            form.Show();
            Hide();
        }
    }
}
