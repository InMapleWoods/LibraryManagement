using LibraryManagementFunctionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementFunctionTest.Maintainace
{
    public partial class DictionaryBookSellerEdit : Form
    {
        Form parentForm;
        Tools.UserCaseHandle userCaseHandle;
        int selectIndex = -1;
        //记录当前id
        int currentID = -1;
        public DictionaryBookSellerEdit(Form form)
        {
            InitializeComponent();
            parentForm = form;
            userCaseHandle = new Tools.UserCaseHandle(((MainForm)((MaitainanceForm)form).parentForm).folderSrc + "\\Add_DictionaryBookSeller.xls");
            comboBox_chooseType.SelectedIndex = 0;
        }

        private void DictionaryEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void comboBox_Dictionary_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox_Dictionary.SelectedIndex == 0)
            {
                lab_CorPL.Text = "联系人";
                DataBind();
            }
            if (comboBox_Dictionary.SelectedIndex == 1)
            {
                lab_CorPL.Text = "联系人";
                DataBind();
            }


        }
        /// <summary>
        /// 获取书商
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        private DictionaryBookSeller GetDictionaryBookSeller(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            //规则判断
            //生成对象
            DictionaryBookSeller bookSeller = new DictionaryBookSeller()
            {
                //书商编号
                Id = currentID,
                //书商名称
                BookSeller = textBox_Name.Text.Trim(),
                //地址
                Location = textBox_Adress.Text.Trim(),
                //联系人
                Contact = textBox_CorPL.Text.Trim(),
                //电话
                CallNumber = textBox_Call.Text.Trim(),
                //邮编
                PostCodes = int.Parse(textBox_Postcodes.Text.Trim()),
                //开户行
                BankName = textBox_BankName.Text.Trim(),
                //备注
                Remark = textBox_Remark.Text.Trim(),
            };
            error = errorList;
            return bookSeller;
        }
        /// <summary>
        /// 获取出版社
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        private DictionaryPublishingHouse GetDictionaryPublishingHouse(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            //规则判断
            //生成对象
            DictionaryPublishingHouse publishingHouse = new DictionaryPublishingHouse()
            {
                //出版社编号
                Id = currentID,
                //出版社名称
                PublishingHouse = textBox_Name.Text.Trim(),
                //地址
                Location = textBox_Adress.Text.Trim(),
                //出版地
                PublishingLocation = textBox_CorPL.Text.Trim(),
                //电话
                CallNumber = textBox_Call.Text.Trim(),
                //邮编
                PostCodes = int.Parse(textBox_Postcodes.Text.Trim()),
                //开户行
                BankName = textBox_BankName.Text.Trim(),
                //备注
                Remark = textBox_Remark.Text.Trim(),
            };
            error = errorList;
            return publishingHouse;
        }

        private void DataBind()
        {
            if (comboBox_Dictionary.SelectedIndex == 0)
            {
                dataGV_DictionaryShow.DataSource = userCaseHandle.GetUserCasesDataTable();
            }
            if (comboBox_Dictionary.SelectedIndex == 1)
            {
                dataGV_DictionaryShow.DataSource = userCaseHandle.GetUserCasesDataTable();
            }
        }

        private void DictionaryEditForm_Load(object sender, EventArgs e)
        {
            comboBox_Dictionary.SelectedIndex = 0;
            DataBind();
        }

        private void dataGV_DictionaryShow_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGV_DictionaryShow.SelectedRows.Count > 0)
            {
                selectIndex = dataGV_DictionaryShow.SelectedRows[0].Index;
            }

        }
        /// <summary>
        /// 解除text数据绑定
        /// </summary>
        private void textBindclear()
        {
            textBox_Name.Text = null;
            textBox_Adress.Text = null;
            textBox_CorPL.Text = null;
            textBox_Call.Text = null;
            textBox_BankName.Text = null;
            textBox_Postcodes.Text = null;
            textBox_Remark.Text = null;
        }

        private void textWritableChange()
        {
            if (textBox_Name.ReadOnly)
            {
                textBox_Name.ReadOnly = false;
                /*               textBox_Adress.ReadOnly=false;
                               textBox_CorPL.ReadOnly=false;
                               textBox_Call.ReadOnly=false;
                               textBox_BankName.ReadOnly=false;
                               textBox_Postcodes.ReadOnly=false;
                               textBox_Remark.ReadOnly=false; */
            }
            else
            {
                textBox_Name.ReadOnly = true;
                /*               textBox_Adress.ReadOnly = true;
                               textBox_CorPL.ReadOnly = true;
                               textBox_Call.ReadOnly = true;
                               textBox_BankName.ReadOnly = true;
                               textBox_Postcodes.ReadOnly = true;
                               textBox_Remark.ReadOnly = true; */
            }
        }
        /// <summary>
        /// 显示选择数据
        /// </summary>
        private void showSelect(DataGridViewRow row)
        {
            if (dataGV_DictionaryShow.Rows.Count <= 0)
                return;
            //           if (comboBox_Dictionary.SelectedIndex == 0)
            //           {
            currentID = int.Parse(row.Cells[0].Value.ToString());
            textBox_Name.Text = row.Cells[1].Value.ToString();//书商or出版社名字
            textBox_Adress.Text = row.Cells[2].Value.ToString();//地址
            textBox_CorPL.Text = row.Cells[3].Value.ToString();//联系人or出版地
            textBox_Call.Text = row.Cells[4].Value.ToString();//电话
            textBox_BankName.Text = row.Cells[6].Value.ToString();//开户行
            textBox_Postcodes.Text = row.Cells[5].Value.ToString();//邮编
            textBox_Remark.Text = row.Cells[7].Value.ToString();
            //textBox_Name.ReadOnly = true;
            //           }
            /*           else if (comboBox_Dictionary.SelectedIndex == 1)
                       {
                           textBox_Name.Text = this.dataGV_DictionaryShow.CurrentRow.Cells["出版社名字"].Value.ToString();
                           textBox_Adress.Text = this.dataGV_DictionaryShow.CurrentRow.Cells["地址"].Value.ToString();
                           textBox_CorPL.Text = this.dataGV_DictionaryShow.CurrentRow.Cells["出版地"].Value.ToString();
                           textBox_Call.Text = this.dataGV_DictionaryShow.CurrentRow.Cells["电话"].Value.ToString();
                           textBox_BankName.Text = this.dataGV_DictionaryShow.CurrentRow.Cells["开户行"].Value.ToString();
                           textBox_Postcodes.Text = this.dataGV_DictionaryShow.CurrentRow.Cells["邮编"].Value.ToString();
                           textBox_Remark.Text = this.dataGV_DictionaryShow.CurrentRow.Cells["备注"].Value.ToString();
                       }
                       */
        }
        /// <summary>
        /// 按钮状态改变
        /// </summary>

        private void textBox_Remark_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGV_DictionaryShow_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGV_DictionaryShow.CurrentRow != null)
            {
                selectIndex = dataGV_DictionaryShow.CurrentRow.Index;
            }
        }

        private void btn_addCase_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                var list = new DictionaryBookSeller[] { GetDictionaryBookSeller(ref errorList) };
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
            DataBind();
        }

        private void btn_reflashCase_Click(object sender, EventArgs e)
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

        private void comboBox_chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_chooseType.SelectedIndex == 0)
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((MaitainanceForm)parentForm).parentForm).folderSrc + "\\Add_DictionaryBookSeller.xls");
            }
            else
            {
                userCaseHandle = new Tools.UserCaseHandle(((MainForm)((MaitainanceForm)parentForm).parentForm).folderSrc + "\\Update_DictionaryBookSeller.xls");
            }
            DataBind();
        }
    }
}
