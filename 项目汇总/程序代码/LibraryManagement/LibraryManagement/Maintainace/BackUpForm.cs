using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Maintainace
{
    public partial class BackUpForm : Form
    {
        Form parentForm;
        public BackUpForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btn_selectpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                textBox_Path.Text = dilog.SelectedPath;
            }
        }

        private void BackUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
