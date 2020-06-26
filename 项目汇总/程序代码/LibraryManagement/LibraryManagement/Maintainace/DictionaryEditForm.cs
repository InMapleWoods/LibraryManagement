using LibraryManagement.Bll;
using LibraryManagement.Model;
using LibraryManagement.Tools.MyUserControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagement.Maintainace
{
    public partial class DictionaryEditForm : Form
    {
        MaintainaceBll maintainaceBll = new MaintainaceBll();
        Form parentForm;
        //记录当前id
        int currentID = -1;
        public DictionaryEditForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            scriptUserControl1.AddContorlClickMethod(Addlog_click, ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.AddContorlClickMethod(Createlog_click, ScriptUserControl.ControlNames.createButton);
            scriptUserControl1.AddContorlClickMethod(ExitLog_Click, ScriptUserControl.ControlNames.exitButton);
            scriptUserControl1.AddContorlClickMethod(UpdateLog_Click, ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.AddContorlClickMethod(DeleteLog_Click, ScriptUserControl.ControlNames.emptyButton);
            scriptUserControl1.AddContorlClickMethod(SaveLog_Click, ScriptUserControl.ControlNames.saveButton);
            scriptUserControl1.AddContorlClickMethod(PreviousLog_Click, ScriptUserControl.ControlNames.previousButton);
            scriptUserControl1.AddContorlClickMethod(NextLog_Click, ScriptUserControl.ControlNames.nextButton);
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
                lab_CorPL.Text = "出版地";
                DataBind();
            }


        }
        #region 窗体点击事件
        private void Addlog_click(object sender, System.EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                if (comboBox_Dictionary.SelectedIndex == 0)
                {
                    DictionaryBookSeller bookSeller = GetDictionaryBookSeller(ref errorList);
                    //判断是否添加订单成功
                    if (maintainaceBll.AddDicBookSeller(bookSeller, ref errorList))
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
                else if (comboBox_Dictionary.SelectedIndex == 1)
                {
                    DictionaryPublishingHouse publishingHouse = GetDictionaryPublishingHouse(ref errorList);
                    //判断是否添加订单成功
                    if (maintainaceBll.AddDicPublishingHouse(publishingHouse, ref errorList))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //textWritableChange();
            DataBind();
        }
        /// <summary>
        /// 增添按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Createlog_click(object sender, System.EventArgs e)
        {
            //textWritableChange();
            textBindclear();
            ChangeControlEnableState();
        }
        /// <summary>
        /// 退出按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void UpdateLog_Click(object sender, System.EventArgs e)
        {
            ChangeControlEnableState();
        }
        private void SaveLog_Click(object sender, System.EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                if (comboBox_Dictionary.SelectedIndex == 0)
                {
                    DictionaryBookSeller bookSeller = GetDictionaryBookSeller(ref errorList);
                    //判断是否添加订单成功
                    if (maintainaceBll.UpdateDicBookSeller(bookSeller, ref errorList))
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
                else if (comboBox_Dictionary.SelectedIndex == 1)
                {
                    DictionaryPublishingHouse publishingHouse = GetDictionaryPublishingHouse(ref errorList);
                    //判断是否添加订单成功
                    if (maintainaceBll.UpdateDicPublishingHouse(publishingHouse, ref errorList))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLog_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否删除该条记录", "删除确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                if (dialogResult == DialogResult.Yes)
                {
                    if (comboBox_Dictionary.SelectedIndex == 0)
                    {

                        //判断是否删除书商成功
                        if (maintainaceBll.DeleteDicBookSeller(currentID))
                        {
                            MessageBox.Show("删除成功");
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
                    else if (comboBox_Dictionary.SelectedIndex == 1)
                    {

                        //判断是否删除成功
                        if (maintainaceBll.DeleteDicPublishingHouse(currentID))
                        {
                            MessageBox.Show("删除成功");
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataBind();
        }
        /// <summary>
        /// 上一条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousLog_Click(object sender, EventArgs e)
        {
            try
            {
                //若不选择整行，selectRows是没有元素的，所以需要进行判断
                int index;
                if (dataGV_DictionaryShow.SelectedRows.Count > 0)
                {
                    index = dataGV_DictionaryShow.SelectedRows[0].Index;
                }
                else
                {
                    index = dataGV_DictionaryShow.CurrentRow.Index;
                }
                dataGV_DictionaryShow.Rows[index].Selected = false;//放弃选择当前行
                index = index - 1 <= 0 ? 0 : index - 1;
                dataGV_DictionaryShow.Rows[index].Selected = true;//选择上一行
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 下一条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextLog_Click(object sender, EventArgs e)
        {
            try
            {
                //若不选择整行，selectRows是没有元素的，所以需要进行判断
                int index;
                if (dataGV_DictionaryShow.SelectedRows.Count > 0)
                {
                    index = dataGV_DictionaryShow.SelectedRows[0].Index;
                }
                else
                {
                    index = dataGV_DictionaryShow.CurrentRow.Index;
                }
                dataGV_DictionaryShow.Rows[index].Selected = false;//放弃选择当前行
                index = index + 1 >= dataGV_DictionaryShow.RowCount ? dataGV_DictionaryShow.RowCount - 1 : index + 1;
                dataGV_DictionaryShow.Rows[index].Selected = true;//选择下一行
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
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
                dataGV_DictionaryShow.DataSource = maintainaceBll.getAllDicBookSeller();
            }
            if (comboBox_Dictionary.SelectedIndex == 1)
            {
                dataGV_DictionaryShow.DataSource = maintainaceBll.getAllDicPublishingHouse();
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
                this.showSelect(dataGV_DictionaryShow.SelectedRows[0]);
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
        private void ChangeControlEnableState()
        {
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.addButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.changeButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.emptyButton);
            scriptUserControl1.ContorlEnabledChange(ScriptUserControl.ControlNames.saveButton);
        }
        private void textBox_Remark_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGV_DictionaryShow_CurrentCellChanged(object sender, EventArgs e)
        {

        }
    }
}
