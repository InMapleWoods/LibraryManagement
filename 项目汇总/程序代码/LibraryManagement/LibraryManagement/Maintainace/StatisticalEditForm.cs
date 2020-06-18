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
        int currentId = -1;
        MaintainaceBll maintainaceBll = new MaintainaceBll();
        public StatisticalEditForm()
        {
            InitializeComponent();
        }

        private void btn_Excude_Click(object sender, EventArgs e)
        {
            dataGridView_StatisticalInfo.DataSource =maintainaceBll.getPreviewResult(textBox_Option.Text.ToString());
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
                Opration = textBox_Option.Text.ToString()
            };
            error = errorList;
            return statisticalInfo;
        }
    }
}
