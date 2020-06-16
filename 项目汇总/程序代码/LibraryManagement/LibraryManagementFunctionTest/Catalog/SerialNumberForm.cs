using System;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Catalog
{
    public partial class SerialNumberForm : Form
    {
        Form parentForm;
        public SerialNumberForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void getInterviewBookBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm(this);
            form.Show();
            Hide();
        }

        private void cnkiBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm(this);
            form.Show();
            Hide();
        }

        private void classificationoBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm(this);
            form.Show();
            Hide();
        }
    }
}
