using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Circulation
{
    public partial class BookAppointForm : Form
    {
        Form parentForm;
        Tools.UserCaseHandle userCaseHandle;
        int selectIndex = -1;
        public BookAppointForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((CirculationForm)form).parentForm).folderSrc + "\\Add_BookAppointLog.xls");
        }

        private void BookAppointForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        private void BookAppointForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
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

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            try
            {
                dataGridView1.DataSource = userCaseHandle.GetUserCasesDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private BookAppointLog GetBookAppointLog(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            string bookId = bookCodeTextBox.Text;
            if (string.IsNullOrEmpty(bookId))
            {
                errorList.Add("BookId Error");
            }
            string readerId = readerIdTextBox.Text;
            if (string.IsNullOrEmpty(readerId))
            {
                errorList.Add("ReaderId Error");
            }
            string expireDate = validityTermTextBox.Text;
            if (string.IsNullOrEmpty(expireDate))
            {
                errorList.Add("ExpireDate Error");
            }
            DateTime date = appointDatePicker.Value;
            DateTime expireDateTime = date.AddDays(double.Parse(expireDate));
            BookAppointLog bookAppointLog = new BookAppointLog()
            {
                BookId = int.Parse(bookId),
                ReaderId = int.Parse(readerId),
                AppointmentTime = appointDatePicker.Value,
                ExpireDate = expireDateTime,
                State = "有效"
            };
            error = errorList;
            return bookAppointLog;
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

        private void btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                var list = new BookAppointLog[] { GetBookAppointLog(ref errorList) };
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
    }
}
