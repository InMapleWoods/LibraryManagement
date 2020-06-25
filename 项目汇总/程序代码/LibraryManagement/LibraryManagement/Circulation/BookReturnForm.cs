using LibraryManagement.Bll;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Circulation
{
    public partial class BookReturnForm : Form
    {
        Form parentForm;
        CirculationBll circulationBll = new CirculationBll();
        string logId = string.Empty;
        public BookReturnForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void BookReturnForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        private void BookReturnForm_FormClosing(object sender, FormClosingEventArgs e)
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
                dataGridView1.DataSource = circulationBll.GetBorrowLogByReader(readerId, bookId);
                GetReader(readerId);
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
            Book book = circulationBll.GetBookById(int.Parse(bookId), false);
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

        private void borrowCardNumTextBox_TextChanged(object sender, System.EventArgs e)
        {
            DataBind();
        }

        private void bookCodeTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string bookId = bookCodeTextBox.Text;
            if (string.IsNullOrEmpty(bookId))
                return;
            GetBook(bookId);
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                SetBookReturnLog(row);
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = dataGridView1.CurrentRow;
                SetBookReturnLog(row);
            }
        }

        private void SetBookReturnLog(DataGridViewRow row)
        {
            logId = row.Cells[0].Value.ToString();
            bookCodeTextBox.Text = circulationBll.GetBorrowLogBookNum(int.Parse(logId)).ToString();
            string date = ((DateTime)row.Cells[3].Value).ToString("yyyy-MM-dd");
            borrowDateTextBox.Text = date;
        }

        private void bookCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)//如果按下回车键
            {
                DataBind();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否通过该条记录还书", "还书确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    int id;
                    if (!int.TryParse(logId, out id))//将其转换为数字失败
                    {
                        MessageBox.Show("书籍编号格式错误");
                        return;
                    }
                    if (circulationBll.ReturnBorrowedBook(id))//调用还书方法
                    {
                        MessageBox.Show("还书成功");
                    }
                    else
                    {
                        MessageBox.Show("还书失败");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();//数据绑定
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(logId, out id))//将其转换为数字失败
                {
                    MessageBox.Show("书籍编号格式错误");
                    return;
                }
                if (circulationBll.ReturnBorrowedBook(id))//调用还书方法
                {
                    MessageBox.Show("还书成功");
                }
                else
                {
                    MessageBox.Show("还书失败");
                }
                List<string> errorList = new List<string>();//创建一个错误列表
                BookDamageLog log = new BookDamageLog();
                var form = new AddDamageForm(this, log);
                form.StartPosition = FormStartPosition.CenterParent;
                DialogResult dialogResult = form.ShowDialog();
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    int bookid;
                    if (!int.TryParse(bookCodeTextBox.Text, out bookid))//将其转换为数字失败
                    {
                        MessageBox.Show("书籍编号格式错误");
                        return;
                    }
                    log.BookId = bookid;
                    log.RepairState = "待修复";
                    if (circulationBll.AddDamageLog(log, ref errorList))//添加破损记录
                    {
                        MessageBox.Show("增加破损成功");
                    }
                    else
                    {
                        MessageBox.Show("增加破损失败");
                    }
                }
                if (errorList.Count > 0)
                {
                    foreach (var i in errorList)
                    {
                        MessageBox.Show(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
