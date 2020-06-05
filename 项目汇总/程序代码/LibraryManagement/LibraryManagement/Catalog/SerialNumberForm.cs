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
    public partial class SerialNumberForm : Form
    {
        public SerialNumberForm()
        {
            InitializeComponent();
        }

        private void getInterviewBookBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm();
            form.Show();
            Hide();
        }

        private void cnkiBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm();
            form.Show();
            Hide();
        }

        private void classificationoBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm();
            form.Show();
            Hide();
        }
    }
}
