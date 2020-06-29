using System;
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



        private void newBookBtn_Click(object sender, EventArgs e)
        {
            var form = new MoveCatalogForm(this);
            form.Show();
            Hide();
        }

        private void catalogQueryBtn_Click_1(object sender, EventArgs e)
        {
            var form = new CatalogQueryForm(this);
            form.Show();
            Hide();
        }
        private void interviewCatalogBtn_Click(object sender, EventArgs e)
        {
            var form = new InterviewCatalogForm(this);
            form.Show();
            Hide();
        }
    }
}
