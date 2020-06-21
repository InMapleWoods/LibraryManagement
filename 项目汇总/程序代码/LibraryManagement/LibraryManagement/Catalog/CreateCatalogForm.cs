using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools.MyUserControl;

namespace LibraryManagement.Catalog
{
    public partial class CreateCatalogForm : Form
    {
        Form parentForm;//父窗体
        CreateCatalogBll createCatalogBll = new CreateCatalogBll();//编目用户操作类
        UtilBll utilBll = new UtilBll();//复用部分用户操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public CreateCatalogForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            scriptUserControl1.AddContorlClickMethod(NewLog_Click, ScriptUserControl.ControlNames.createButton);
            scriptUserControl1.AddContorlClickMethod(AddLog_Click, ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.AddContorlClickMethod(ChangeLog_Click, ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.AddContorlClickMethod(DeleteLog_Click, ScriptUserControl.ControlNames.emptyButton);
            scriptUserControl1.AddContorlClickMethod(SaveLog_Click, ScriptUserControl.ControlNames.saveButton);
            scriptUserControl1.AddContorlClickMethod(NextLog_Click, ScriptUserControl.ControlNames.nextButton);
            scriptUserControl1.AddContorlClickMethod(PreviousLog_Click, ScriptUserControl.ControlNames.previousButton);
            scriptUserControl1.AddContorlClickMethod(ExitLog_Click, ScriptUserControl.ControlNames.exitButton);
        }

       

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void CreateCatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
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
                EmptyCreateCatalogList();//将输入框置为空白
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
                CreateCatalogList list = GetCatalogList(ref errorList);
                //判断是否添加订单成功
                if (createCatalogBll.AddCatalogList(list, ref errorList))
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
                string id = idTextBox.Text;//获取清单号
                if (string.IsNullOrEmpty(id))
                {
                    return;
                }
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
                DialogResult dialogResult = MessageBox.Show("是否删除该条记录", "删除确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    string listNum = idTextBox.Text;//获取编目号
                    int id;
                    if (!int.TryParse(listNum, out id))//将其转换为数字失败
                    {
                        MessageBox.Show("订单编号错误");
                        return;
                    }
                    if (createCatalogBll.DeleteCatalogList(id))//调用订单删除方法
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
        /// 保存记录
        /// </summary>
        private void SaveLog_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的清单（若有错误会被添加到错误列表中）
                string createId = idTextBox.Text;//获取清单号
                int id;
                if (!int.TryParse(createId, out id))//将其转换为数字失败
                {
                    MessageBox.Show("清单号错误");
                    return;
                }
                CreateCatalogList list = GetCatalogList(ref errorList);
                list.Id = id;//设置清单号
                //判断是否添加清单成功
                if (createCatalogBll.UpdateCatalogList(list, ref errorList))
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
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
            DataBind();//数据绑定
            ChangeControlEnableState();//改变菜单按钮启用状态
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
        /// 返回上一级
        /// </summary>
        private void ExitLog_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        #endregion

        /// <summary>
        /// 获取当前窗体所表示的清单
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>编目清单</returns>
        private CreateCatalogList GetCatalogList(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表

            //出版社Id
            int publisherId = ((KeyValuePair<int, string>)PublishingHouseComboBox.SelectedItem ).Key;
            //编目人员ID
            int catalogerId = utilBll.GetUserIdFormNumber(CatalogerIdTextBox.Text);


            //根据页面内容构造清单
            CreateCatalogList list = new CreateCatalogList()
            {
                ISBN = ISBNTextBox.Text,
                FirstAuthor = AuthorTextBox.Text,
                PositiveTitle = BookNameTextBox.Text,
                CatalogingDate = CatalogDateTimePicker.Value ,
                PublishingHouseId = publisherId,
                DocumentType = DocumentTypeComboBox.Text,
                CatalogerId = catalogerId,
                PrimaryLiability= PrimaryLiabilityLabelTextBox.Text 
            };
            error = errorList;//返回错误列表
            return list;//返回清单
        }

        /// <summary>
        /// 修改用户控件中按钮的启用状态
        /// </summary>
        private void ChangeControlEnableState()
        {
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.emptyButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.saveButton);
        }

        /// <summary>
        /// 将当前窗体输入文本部分置空
        /// </summary>
        private void EmptyCreateCatalogList()
        {
            ISBNTextBox.Text = "";
            AuthorTextBox.Text = "";
            DocumentTypeComboBox.Text = "";
            BookNameTextBox.Text = "";
            PrimaryLiabilityLabelTextBox.Text = "";
            CatalogerIdTextBox.Text = "";
            CatalogDateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// 设置某行的数据为当前窗体输入框内容
        /// </summary>
        /// <param name="row">行</param>
        private void SetInterviewList(DataGridViewRow row)
        {
            idTextBox.Text = row.Cells[0].Value.ToString();//ID号
            AuthorTextBox.Text = row.Cells[1].Value.ToString();//作者
            ISBNTextBox.Text = row.Cells[2].Value.ToString();//ISBN
            BookNameTextBox.Text = row.Cells[3].Value.ToString();//书名
            //PriceTextBox.Text = row.Cells[4].Value.ToString();//价格
            PublishingHouseComboBox.Text = row.Cells[5].Value.ToString();//出版社名称
            DocumentTypeComboBox.Text = row.Cells[6].Value.ToString();//文献类型
            CatalogerIdTextBox.Text = row.Cells[7].Value.ToString();//编目人员
            CatalogDateTimePicker.Value = (DateTime)row.Cells[8].Value;//编目日期
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            //下方总窗体数据绑定
            dataGridView1.DataSource = createCatalogBll.GetAllCatalogList();

            //出版社数据绑定
            BindingSource bs_PublishingHouse = new BindingSource();
            bs_PublishingHouse.DataSource = utilBll.GetPublishingHouseNames();
            PublishingHouseComboBox.DataSource = bs_PublishingHouse;
            PublishingHouseComboBox.ValueMember = "Key";
            PublishingHouseComboBox.DisplayMember = "Value";
        }

        /// <summary>
        /// 选择行更改
        /// </summary>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SetInterviewList(dataGridView1.SelectedRows[0]);
            }
        }

        /// <summary>
        /// 当前行更改
        /// </summary>
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SetInterviewList(dataGridView1.CurrentRow);
            }
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void CreateCatalogListForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }
        private void serialNumberBtn_Click(object sender, EventArgs e)
        {
            var form = new SerialNumberForm(this);
            form.Show();
            Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm(this);
            form.Show();
            Hide();
        }

        private void pringBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm(this);
            form.Show();
            Hide();
        }

        private void catalogQueryBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateCatalogForm(this);
            form.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void catalogingDatLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstAuthorLabel_Click(object sender, EventArgs e)
        {

        }

        private void documentTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void scriptUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }
    }
}
