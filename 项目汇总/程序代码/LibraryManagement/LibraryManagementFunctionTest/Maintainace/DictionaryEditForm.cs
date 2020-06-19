using System;
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

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            this.textBox_Name.Text = "";
            this.textBox_Adress.Text = "";
            this.textBox_CorPL.Text = "";
            this.textBox_Call.Text = "";
            this.textBox_Postcodes.Text = "";
            this.textBox_Remark.Text = "";
            this.textBox_BankName.Text = "";
        }
    }
}
