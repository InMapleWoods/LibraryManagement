using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Catalog
{
    public partial class CreateCatalogForm : Form
    {
        Form parentForm;//父窗体
        Tools.UserCaseHandle userCaseHandle;
        int selectIndex = -1;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public CreateCatalogForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((CatalogForm)form).parentForm).folderSrc + "\\Add_CatalogFormList.xls");
            comboBox_chooseType.SelectedIndex = 0;
        }



        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void CreateCatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        /// <summary>
        /// 获取当前窗体所表示的清单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>编目清单</returns>
        private CreateCatalogList GetCatalogList(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
          

            //根据页面内容构造清单
            CreateCatalogList list = new CreateCatalogList()
            {
                ISBN = ISBNTextBox.Text,
                FirstAuthor = AuthorTextBox.Text,
                PositiveTitle = BookNameTextBox.Text,
                CatalogingDate = CatalogDateTimePicker.Value,
                DocumentType = DocumentTypeComboBox.Text,
                PrimaryLiability = PrimaryLiabilityLabelTextBox.Text
            };
            error = errorList;//返回错误列表
            return list;//返回清单
        }


        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            // DocumentTypeComboBox.SelectedIndex = 0;//文献类型
            try
            {
                dataGridView1.DataSource = userCaseHandle.GetUserCasesDataTable();
               PublishingHouseComboBox.SelectedIndex = 0;
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

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void CreateCatalogListForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        private void btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                var list = new CreateCatalogList[] { GetCatalogList(ref errorList) };
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

        private void btn_reflashCase_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void comboBox_chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_chooseType.SelectedIndex == 0)
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((CatalogForm)parentForm).parentForm).folderSrc + "\\Add_CatalogFormList.xls");
            }
            else
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((CatalogForm)parentForm).parentForm).folderSrc + "\\Update_CatalogFormList.xls");
            }
            DataBind();
        }
    }
}
