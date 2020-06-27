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
            DocumentTypeComboBox.SelectedIndex = 0;//文献类型
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

        }

        private void btn_removeCase_Click(object sender, EventArgs e)
        {

        }

        private void btn_reflashCase_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
