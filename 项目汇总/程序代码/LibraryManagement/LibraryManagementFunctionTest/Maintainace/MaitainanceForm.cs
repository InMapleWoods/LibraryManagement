using System;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Maintainace
{
    public partial class MaitainanceForm : Form
    {
        public Form parentForm;
        public MaitainanceForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void Btn_statisticalEditor_Click(object sender, EventArgs e)
        {
            var form = new DictionaryPublishingHouseEdit(this);
            form.Show();
            Hide();
        }

        private void Btn_dictionaryEdit_Click(object sender, EventArgs e)
        {
            var form = new DictionaryBookSellerEdit(this);
            form.Show();
            Hide();
        }

        private void MaitainanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void MaitainanceForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_backups_Click(object sender, EventArgs e)
        {

        }
    }
}
