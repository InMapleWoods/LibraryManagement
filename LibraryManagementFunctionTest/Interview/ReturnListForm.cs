using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Interview
{
    public partial class ReturnListForm : Form
    {
        Form parentForm;//父窗体
        Tools.UserCaseHandle userCaseHandle;
        int selectIndex = -1;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public ReturnListForm(Form form)
        {
            parentForm = form;
            InitializeComponent();
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((InterviewForm)form).parentForm).folderSrc + "\\Add_ReturnList.xls");
            comboBox_chooseType.SelectedIndex = 0;
            documentTypeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取当前窗体所表示的退货清单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>退货清单</returns>
        private InterviewReturnList GetReturnList(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表


            //通过订购人账号获取id
            int ordererId = int.Parse(SubscriberTextBox.Text);

            double price;

            //判断价格是否能被转换为整型
            if (!double.TryParse(priceTextBox.Text, out price))
            {
                errorList.Add("OrderPrice Error");
            }

            //根据页面内容构造清单
            InterviewReturnList list = new InterviewReturnList()
            {
                SubDate = subDatePicker.Value,
                ISBN = ISBNtextBox.Text,
                OrdererId = ordererId,
                BookName = bookNameTextBox.Text,
                Price = price,
                PublishingHouseId = int.Parse(PublishingHouseTextBox.Text),
                DocumentType = documentTypeComboBox.Text,
            };
            error = errorList;//返回错误列表
            return list;//返回清单
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            try
            {
                ReturnListDataGridView.DataSource = userCaseHandle.GetUserCasesDataTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #region 关闭当前界面并返回
        private void ReturnListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
        #endregion

        #region 选择行更改

        private void ReturnListDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ReturnListDataGridView.SelectedRows.Count > 0)
            {
                selectIndex = ReturnListDataGridView.SelectedRows[0].Index;
            }
        }
        #endregion

        #region 当前行更改

        private void ReturnListDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (ReturnListDataGridView.CurrentRow != null)
            {
                selectIndex = ReturnListDataGridView.CurrentRow.Index;
            }
        }
        #endregion

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void ReturnListForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        private void Btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                var list = new InterviewReturnList[] { GetReturnList(ref errorList) };
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

        private void Btn_removeCase_Click(object sender, EventArgs e)
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

        private void Btn_reflashCase_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void ComboBox_chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_chooseType.SelectedIndex == 0)
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((InterviewForm)parentForm).parentForm).folderSrc + "\\Add_ReturnList.xls");
            }
            else
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((InterviewForm)parentForm).parentForm).folderSrc + "\\Update_ReturnList.xls");
            }
            DataBind();
        }
    }
}