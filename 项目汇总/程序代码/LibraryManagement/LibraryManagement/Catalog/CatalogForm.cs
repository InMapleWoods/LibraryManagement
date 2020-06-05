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
    public partial class CatalogForm : Form
    {
        Form parentForm;
        public CatalogForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void createCatalogBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm(this);
            form.Show();
            Hide();
        }

        private void CatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelBookBtn_Click(object sender, EventArgs e)
        {
            var form = new CancelBookForm();
            form.Show();
            Hide();
        }
    }
}
