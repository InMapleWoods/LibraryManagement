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
        public DictionaryEditForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
            scriptUserControl1.AddContorlClickMethod(Addlog_click, ScriptUserControl.ControlNames.addButton);
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
            }
            if (comboBox_Dictionary.SelectedIndex == 1)
            {
                lab_CorPL.Text = "出版地";
            }


        }

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
            DataBind();
        }
        private DictionaryBookSeller GetDictionaryBookSeller(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            //规则判断
            //生成对象
            DictionaryBookSeller bookSeller = new DictionaryBookSeller()
            {
                //书商名称
                BookSeller = textBox_Name.Text.Trim(),
                //地址
                Location = textBox_Adress.Text.Trim(),
                //联系人
                Contact = textBox_CorPL.Text.Trim(),
                //电话
                Call = textBox_Call.Text.Trim(),
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

        private DictionaryPublishingHouse GetDictionaryPublishingHouse(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            //规则判断
            //生成对象
            DictionaryPublishingHouse publishingHouse = new DictionaryPublishingHouse()
            {
                //出版社名称
                PublishingHouse = textBox_Name.Text.Trim(),
                //地址
                Location = textBox_Adress.Text.Trim(),
                //出版地
                PublishingLocation = textBox_CorPL.Text.Trim(),
                //电话
                Call = textBox_Call.Text.Trim(),
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
            this.showSelect();
        }
        private void textBindclear()
        {
            textBox_Name.Text = null;
            textBox_Adress.Text = null;
            textBox_CorPL.Text = null;
            textBox_Call.Text = null;
            textBox_BankName.Text = null;
            textBox_Postcodes.Text =null;
            textBox_Remark.Text = null;
        }
        private void showSelect()
        {
            if (dicType == 0 && dataGV_DictionaryShow.SelectedRows.Count > 0)
            {
                textBox_Name.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["书商名字"].Value.ToString();
                textBox_Adress.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["地址"].Value.ToString();
                textBox_CorPL.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["联系人"].Value.ToString();
                textBox_Call.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["电话"].Value.ToString();
                textBox_BankName.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["开户行"].Value.ToString();
                textBox_Postcodes.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["邮编"].Value.ToString();
                textBox_Remark.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["备注"].Value.ToString();
            }
            else if (dicType == 1 && dataGV_DictionaryShow.SelectedRows.Count > 0)
            {
                textBox_Name.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["出版社名字"].Value.ToString();
                textBox_Adress.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["地址"].Value.ToString();
                textBox_CorPL.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["出版地"].Value.ToString();
                textBox_Call.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["电话"].Value.ToString();
                textBox_BankName.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["开户行"].Value.ToString();
                textBox_Postcodes.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["邮编"].Value.ToString();
                textBox_Remark.Text = this.dataGV_DictionaryShow.SelectedRows[0].Cells["备注"].Value.ToString();
            }
        }
    }
}
