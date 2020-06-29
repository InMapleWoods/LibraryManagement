using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools.MyUserControl;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagement.Circulation
{
    public partial class BookAppointForm : Form
    {
        Form parentForm;
        CirculationBll circulationBll = new CirculationBll();
        public BookAppointForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            scriptUserControl1.AddContorlClickMethod(NewLog_Click, ScriptUserControl.ControlNames.createButton);
            scriptUserControl1.AddContorlClickMethod(AddLog_Click, ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.AddContorlClickMethod(ChangeLog_Click, ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.AddContorlClickMethod(DeleteLog_Click, ScriptUserControl.ControlNames.emptyButton);
            scriptUserControl1.AddContorlClickMethod(NextLog_Click, ScriptUserControl.ControlNames.nextButton);
            scriptUserControl1.AddContorlClickMethod(PreviousLog_Click, ScriptUserControl.ControlNames.previousButton);
            scriptUserControl1.AddContorlClickMethod(ExitLog_Click, ScriptUserControl.ControlNames.exitButton);
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

        private void borrowCardNumTextBox_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }

        private void bookCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                idTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        #region 用户控件相关方法（菜单控件）
        /// <summary>
        /// 新增记录
        /// </summary>
        private void NewLog_Click(object sender, EventArgs e)
        {
            try
            {
                DataBind();//数据绑定
                EmptyBookAppoint();//将输入框置为空白
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 增加记录
        /// </summary>
        private void AddLog_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                BookAppointLog log = GetBookAppointLog(ref errorList);
                //判断是否添加订单成功
                if (circulationBll.AddAppointLog(log, ref errorList))
                {
                    MessageBox.Show("添加成功");
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

        /// <summary>
        /// 修改记录
        /// </summary>
        private void ChangeLog_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeControlEnableState();//更改菜单按钮启用状态
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        private void DeleteLog_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeControlEnableState();
                if (string.IsNullOrEmpty(idTextBox.Text))
                {
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("是否删除该条记录", "删除确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    if (circulationBll.RemoveAppointLog(int.Parse(idTextBox.Text)))//调用订单删除方法
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();//数据绑定
        }

        /// <summary>
        /// 下一条记录
        /// </summary>
        private void NextLog_Click(object sender, EventArgs e)
        {
            try
            {
                //若不选择整行，selectRows是没有元素的，所以需要进行判断
                int index;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    index = dataGridView1.SelectedRows[0].Index;
                }
                else
                {
                    index = dataGridView1.CurrentRow.Index;
                }
                dataGridView1.Rows[index].Selected = false;//放弃选择当前行
                index = index + 1 >= dataGridView1.RowCount ? dataGridView1.RowCount - 1 : index + 1;
                dataGridView1.Rows[index].Selected = true;//选择下一行
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///上一条记录
        /// </summary>
        private void PreviousLog_Click(object sender, EventArgs e)
        {
            try
            {
                //若不选择整行，selectRows是没有元素的，所以需要进行判断
                int index;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    index = dataGridView1.SelectedRows[0].Index;
                }
                else
                {
                    index = dataGridView1.CurrentRow.Index;
                }
                dataGridView1.Rows[index].Selected = false;//放弃选择当前行
                index = index - 1 <= 0 ? 0 : index - 1;
                dataGridView1.Rows[index].Selected = true;//选择上一行
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        private void ExitLog_Click(object sender, EventArgs e)
        {
            try
            {
                parentForm.Show();//显示父窗体
                Hide();//隐藏本窗体
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 修改用户控件中按钮的启用状态
        /// </summary>
        private void ChangeControlEnableState()
        {
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.emptyButton);
            idTextBox.Visible = !idTextBox.Visible;
            idLabel.Visible = !idLabel.Visible;
        }
        #endregion

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            try
            {
                List<string> errorList = new List<string>();//错误列表
                Match matchBorrowCardNum = Regex.Match(borrowCardNumTextBox.Text, @"(^\d{11}$)");
                if (!matchBorrowCardNum.Success)
                {
                    errorList.Add("BorrowCardNum Error");
                }
                if (errorList.Count > 0)
                    return;
                //通过借书证号获取id
                int readerId = circulationBll.GetReaderIdByNum(borrowCardNumTextBox.Text);
                if (readerId == -1)
                    return;
                string bookId = bookCodeTextBox.Text;
                dataGridView1.DataSource = circulationBll.GetAppointLogByReader(readerId, bookId);
                GetReader(readerId);
                if (string.IsNullOrEmpty(bookId))
                    return;
                GetBook(bookId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 设置窗体输入框数据
        /// </summary>
        /// <param name="bookId">图书Id</param>
        private void GetBook(string bookId)
        {
            Book book = circulationBll.GetBookById(int.Parse(bookId));
            IsbnTextBox.Text = book.ISBN;
            authorTextBox.Text = book.FirstAuthor;
            officialTitleTextBox.Text = book.OfficialTitle;
        }

        /// <summary>
        /// 设置窗体输入框数据
        /// </summary>
        /// <param name="readerId">读者Id</param>
        private void GetReader(int readerId)
        {
            Reader reader = circulationBll.GetReaderById(readerId);
            nameTextBox.Text = reader.Name;
            genderTextBox.Text = reader.Sex;
            workplaceTextBox.Text = reader.Department;
            borrowNumTextBox.Text = reader.BorrowNum.ToString();
            appointmentNumTextBox.Text = reader.AppointNum.ToString();
            penaltyMultipleTextBox.Text = reader.ForfeitMultiples.ToString();
            fineAmountTextBox.Text = reader.ExtendedForfeit.ToString();
        }

        /// <summary>
        /// 清空记录
        /// </summary>
        private void EmptyBookAppoint()
        {
            borrowCardNumTextBox.Text = "";
            bookCodeTextBox.Text = "";
            IsbnTextBox.Text = "";
            authorTextBox.Text = "";
            officialTitleTextBox.Text = "";
            nameTextBox.Text = "";
            genderTextBox.Text = "";
            workplaceTextBox.Text = "";
            borrowNumTextBox.Text = "";
            appointmentNumTextBox.Text = "";
            penaltyMultipleTextBox.Text = "";
            fineAmountTextBox.Text = "";
            validityTermTextBox.Text = "";
        }

        private BookAppointLog GetBookAppointLog(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            Match matchAppointCardNum = Regex.Match(borrowCardNumTextBox.Text, @"(^\d{11}$)");
            if (!matchAppointCardNum.Success)
            {
                errorList.Add("AppointCardNum Error");
            }
            //通过借书证号获取id
            int readerId = circulationBll.GetReaderIdByNum(borrowCardNumTextBox.Text);
            if (readerId == -1)
            {
                errorList.Add("ReaderId Error");
            }
            string bookId = bookCodeTextBox.Text;
            if (string.IsNullOrEmpty(bookId))
            {
                errorList.Add("BookId Error");
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
                ReaderId = readerId,
                AppointmentTime = appointDatePicker.Value,
                ExpireDate = expireDateTime,
                State = "有效"
            };
            error = errorList;
            return bookAppointLog;
        }
    }
}
