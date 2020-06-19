using LibraryManagement.Bll;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Maintainace
{
    public partial class StatisticalEditForm : Form
    {
        Form parentForm;
        int currentId = -1;
        DataTable currentTable = null;
        MaintainaceBll maintainaceBll = new MaintainaceBll();
        public StatisticalEditForm(Form form)
        {
            
            InitializeComponent();
            parentForm = form;
        }
        private void StatisticalEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void btn_Excude_Click(object sender, EventArgs e)
        {
            dataGridView_StatisticalInfo.DataSource =maintainaceBll.getPreviewResult(textBox_Option.Text.ToString());
            ChangeBtnState();
        }

        private void StatisticalEditForm_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                                                            //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                StatisticalInfo statisticalInfo = GetStatisticalInfo(ref errorList);
                //判断是否添加订单成功
                if (maintainaceBll.AddStatisticalInfo(statisticalInfo, ref errorList))
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
                ChangeBtnState();
                DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private StatisticalInfo GetStatisticalInfo(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            StatisticalInfo statisticalInfo = new StatisticalInfo()
            {
                Id = currentId,
                TableName = comboBox_TableName.Text.ToString().Trim(),
                Operation = textBox_Option.Text.ToString()
            };
            error = errorList;
            return statisticalInfo;
        }
        private void ChangeBtnState()
        {
            if (btn_Add.Enabled == false)
            {
                btn_Add.Enabled = true;
            }
            else
            {
                btn_Add.Enabled = false;
            }   
        }
        private void DataBind()
        {
            currentTable = maintainaceBll.getStatisticalInfo();
            BindingSource bs_TableName = new BindingSource();
            bs_TableName.DataSource = currentTable;
            comboBox_TableName.DataSource = bs_TableName;
            comboBox_TableName.ValueMember = "表名称";
            comboBox_TableName.DisplayMember = "表名称";
        }

        private void comboBox_TableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TableName.SelectedIndex >= 0 && currentTable != null)
            {
                currentId = int.Parse(currentTable.Rows[comboBox_TableName.SelectedIndex][0].ToString());
                textBox_Option.Text = currentTable.Rows[comboBox_TableName.SelectedIndex][2].ToString();
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                                                            //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                StatisticalInfo statisticalInfo = GetStatisticalInfo(ref errorList);
                //判断是否添加订单成功
                if (maintainaceBll.UpdateStatisticalInfo(statisticalInfo, ref errorList))
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
                DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();
                StatisticalInfo statisticalInfo = GetStatisticalInfo(ref errorList);
                DialogResult dialogResult = MessageBox.Show("是否删除该条记录", "删除确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if(dialogResult == DialogResult.Yes)
                {
                    if (maintainaceBll.DeleteStatisticalInfo(statisticalInfo))
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");

                    }
                }

                DataBind();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
