using LibraryManagement.Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Circulation
{
    public partial class DefaultHandleForm : Form
    {
        Form parentForm;
        CirculationBll circulationBll = new CirculationBll();
        public DefaultHandleForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void defaultHandleForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        private void defaultHandleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            try
            {
                //通过借书证号获取id
                int readerId = circulationBll.GetReaderIdByNum(borrowCardNumTextBox.Text);
                if (readerId == -1)
                    return;
                dataGridView1.DataSource = circulationBll.GetDisHonestyLog(readerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void borrowCardNumTextBox_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = dataGridView1.CurrentRow;
                SetDishonestyLog(row);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                SetDishonestyLog(row);
            }
        }
        private void SetDishonestyLog(DataGridViewRow row)
        {
            if (row == null)
            {
                return;
            }
            int id = int.Parse(row.Cells[0].Value.ToString());
            int bookId = circulationBll.GetDisHonestyLogBookId(id);
            bookCodeTextBox.Text = bookId.ToString();
        }

        private void button_lost_Click(object sender, EventArgs e)
        {
            getMoney();
        }

        private bool getMoney()
        {
            DialogResult result;
            do
            {
                result = MessageBox.Show("是否收费成功", "收费成功", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    return true;
                }
                else if (result == DialogResult.Cancel)
                {
                    return false;
                }
            } while (result == DialogResult.No);
            return false;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {

        }
    }
}
