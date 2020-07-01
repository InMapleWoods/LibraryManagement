using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace LibraryManagementFunctionTest.Circulation
{
    public partial class BookDamageForm : Form
    {
        Form parentForm;
        Tools.UserCaseHandle userCaseHandle;
        int selectIndex = -1;
        public BookDamageForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((CirculationForm)form).parentForm).folderSrc + "\\Add_BookDamageLog.xls");
            comboBox_chooseType.SelectedIndex = 0;
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
                dataGridView1.DataSource = userCaseHandle.GetUserCasesDataTable();
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
                selectIndex = dataGridView1.CurrentRow.Index;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectIndex = dataGridView1.SelectedRows[0].Index;
            }
        }

        private void comboBox_chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_chooseType.SelectedIndex == 0)
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((CirculationForm)parentForm).parentForm).folderSrc + "\\Add_BookDamageLog.xls");
            }
            else
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((CirculationForm)parentForm).parentForm).folderSrc + "\\Update_BookDamageLog.xls");
            }
            DataBind();
        }

        private BookDamageLog GetBookDamageLog(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            string bookId = textBox_bookId.Text;
            if (string.IsNullOrEmpty(bookId))
            {
                errorList.Add("BookId Error");
            }
            string checkerId = textBox_checkerId.Text;
            if (string.IsNullOrEmpty(checkerId))
            {
                errorList.Add("ReaderId Error");
            }
            string detail = textBox_detail.Text;
            if (string.IsNullOrEmpty(detail))
            {
                errorList.Add("Detail Error");
            }
            BookDamageLog bookBorrowLog = new BookDamageLog()
            {
                BookId = int.Parse(bookId),
                CheckerId = int.Parse(checkerId),
                DamageDetail = detail,
                CheckTime = DateTime.Now,
                RepairState = comboBox_chooseType.Text,
            };
            error = errorList;
            return bookBorrowLog;
        }

        private void btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                var list = new BookDamageLog[] { GetBookDamageLog(ref errorList) };
                if (errorList.Count == 0)
                {
                    if (userCaseHandle.AddUserCases(list.ToList()))
                    {
                        MessageBox.Show("添加成功");
                    }
                }
                else
                {
                    MessageBox.Show("添加失败");
                    foreach (var i in errorList)
                    {
                        MessageBox.Show(i);//逐条显示错误信息
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();
        }
        private void btn_reflashCase_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btn_removeCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                if (selectIndex == -1)
                    return;
                if (errorList.Count == 0)
                {
                    if (userCaseHandle.DeleteUserCase(selectIndex))
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                else
                {
                    MessageBox.Show("删除失败");
                    foreach (var i in errorList)
                    {
                        MessageBox.Show(i);//逐条显示错误信息
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();
        }
    }
}
