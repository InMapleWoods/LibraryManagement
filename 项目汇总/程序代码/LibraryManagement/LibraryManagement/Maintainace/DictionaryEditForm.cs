using System.Windows.Forms;

namespace LibraryManagement.Maintainace
{
    public partial class DictionaryEditForm : Form
    {
        public int dicType;//0为书商字典，1为出版社字典
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
            if (comboBox_Dictionary.Text.ToString().Equals("书商字典"))
            {
                lab_CorPL.Text = "联系人";
                dicType = 0;
            }
            if (comboBox_Dictionary.Text.ToString().Equals("出版社字典"))
            {
                lab_CorPL.Text = "出版地";
                dicType = 1;
            }

        }

        private void lab_Location_Click(object sender, System.EventArgs e)
        {

        }
    }
}
