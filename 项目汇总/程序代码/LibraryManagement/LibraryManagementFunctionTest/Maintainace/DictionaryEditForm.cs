using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Maintainace
{
    public partial class DictionaryEditForm : Form
    {
        Form parentForm;
        public DictionaryEditForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void DictionaryEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void comboBox_Dictionary_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox_Dictionary.SelectedIndex == 0)
            {
                lab_CorPL.Text = "联系人";
            }
            if (comboBox_Dictionary.SelectedIndex == 1)
            {
                lab_CorPL.Text = "出版地";
            }
        }
    }
}
