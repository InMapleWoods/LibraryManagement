using System;
using System.Windows.Forms;
using LibraryManagement.Tools.MyUserControl;

namespace LibraryManagement.Periodical
{
    public partial class PeriodicalOrderForm : Form
    {
        Form parentForm;
        public PeriodicalOrderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            scriptUserControl1.AddContorlClickMethod(CreateLog_Click, ScriptUserControl.ControlNames.createButton);
        }

        private void PeriodicalOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void CreateLog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("新增记录");
        }
    }
}
