using System;
using System.Windows.Forms;

namespace LibraryManagement.Maintainace
{
    public partial class MaitainanceForm : Form
    {
        Form parentForm;
        public MaitainanceForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void Btn_statisticalEditor_Click(object sender, EventArgs e)
        {

        }

        private void Btn_dictionaryEdit_Click(object sender, EventArgs e)
        {
            var form = new DictionaryEditForm(this);
            form.Show();
            Hide();
        }

        private void MaitainanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
