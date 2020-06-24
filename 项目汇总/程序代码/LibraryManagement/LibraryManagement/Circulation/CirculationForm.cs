using System;
using System.Windows.Forms;

namespace LibraryManagement.Circulation
{
    public partial class CirculationForm : Form
    {
        Form parentForm;
        public CirculationForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void CirculationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void bookBorrowButton_Click(object sender, EventArgs e)
        {
            var form = new BookBorrowForm(this);
            form.Show();
            Hide();
        }

        private void bookAppointButton_Click(object sender, EventArgs e)
        {
            var form = new BookAppointForm(this);
            form.Show();
            Hide();
        }

        private void bookReturnButton_Click(object sender, EventArgs e)
        {
            var form = new BookReturnForm(this);
            form.Show();
            Hide();
        }

        private void CirculationForm_Load(object sender, EventArgs e)
        {
            try
            {
                new Bll.CirculationBll().DealAllLog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bookDamageButton_Click(object sender, EventArgs e)
        {
            var form = new BookDamageForm(this);
            form.Show();
            Hide();
        }

        private void defaultHandleButton_Click(object sender, EventArgs e)
        {
            var form = new DefaultHandleForm(this);
            form.Show();
            Hide();
        }
    }
}
