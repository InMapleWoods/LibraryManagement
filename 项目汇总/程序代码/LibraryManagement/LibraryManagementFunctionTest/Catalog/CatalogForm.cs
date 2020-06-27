using System;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Catalog
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
    }
}
