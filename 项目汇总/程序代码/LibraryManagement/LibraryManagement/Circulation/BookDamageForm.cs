using System;
using LibraryManagement.Bll;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using LibraryManagement.Model;

namespace LibraryManagement.Circulation
{
    public partial class BookDamageForm : Form
    {
        Form parentForm;
        CirculationBll circulationBll = new CirculationBll();
        public BookDamageForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }
        private void BookDamageForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        private void BookDamageForm_FormClosing(object sender, FormClosingEventArgs e)
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
                dataGridView1.DataSource = circulationBll.GetDamageLog();
                comboBox_State.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = dataGridView1.CurrentRow;
                SetBookDamageLog(row);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                SetBookDamageLog(row);
            }
        }
        private void SetBookDamageLog(DataGridViewRow row)
        {
            if (row == null)
            {
                return;
            }
            idTextBox.Text = row.Cells[0].Value.ToString();
            comboBox_State.Text = row.Cells[4].Value.ToString();
        }

        private void button_stateChange_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否确定修改", "修改确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
            if (dialogResult == DialogResult.Yes)//如果选择确认按钮
            {
                int id;
                if (!int.TryParse(idTextBox.Text, out id))//将其转换为数字失败
                {
                    MessageBox.Show("编号格式错误");
                    return;
                }
                BookDamageLog log = new BookDamageLog()
                {
                    Id = id,
                    RepairState = comboBox_State.Text
                };
                if (circulationBll.UpdateDamageLog(log))//调用修改方法
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }

    }
}
