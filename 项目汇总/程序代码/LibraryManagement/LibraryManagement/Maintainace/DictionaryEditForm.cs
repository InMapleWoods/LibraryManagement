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
        public int dicType=0;//0为书商字典，1为出版社字典
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
            if (comboBox_Dictionary.Text.ToString().Equals("书商字典"))
            {
                lab_CorPL.Text = "联系人";
                dicType = 0;
            }
            if (comboBox_Dictionary.Text.ToString().Equals("出版社字典"))
            {
                lab_CorPL.Text = "出版地";
                dicType = 1;
            }
            

        }

        private void Addlog_click(object sender,System.EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                if (dicType == 0)
                {
                    DictionaryBookSeller bookSeller = GetDictionaryBookSeller(ref errorList);
                    //判断是否添加订单成功
                    if (maintainaceBll.AddDicBookSeller(bookSeller,ref errorList)){
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
                else if(dicType == 1)
                {
                    DictionaryPublishingHouse publishingHouse =GetDictionaryPublishingHouse(ref errorList);
                    //判断是否添加订单成功
                    if (maintainaceBll.AddDicPublishingHouse(publishingHouse, ref errorList)){
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
            DataBind(dicType);
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

        private void DataBind(int dicType)
        {
            if(dicType==0)
            {
                dataGV_DictionaryShow.DataSource = maintainaceBll.getAllDicBookSeller();
            }
            if(dicType==1)
            {
                //dataGV_DictionaryShow.DataSource = maintainaceBll.getAllDicPublishingHouse();
            }
           
        }
        private void lab_Location_Click(object sender, System.EventArgs e)
        {

        }

        private void DictionaryEditForm_Load(object sender, EventArgs e)
        {
            DataBind(dicType);
        }
    }
}
