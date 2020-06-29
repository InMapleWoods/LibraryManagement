using LibraryManagement.Bll;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement.Statistical
{
    public partial class StatisticalForm : Form
    {
        Form parentForm;
        StatisticalBll statisticalBll = new StatisticalBll();
        DataTable statisticalInfo = new DataTable();
        public StatisticalForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void StatisticalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void Databind()
        {
            statisticalInfo = statisticalBll.getStatisticalInfo();
            BindingSource bs_chooseTableTool = new BindingSource();
            bs_chooseTableTool.DataSource = statisticalInfo;
            comboBox_ChooseTable.DataSource = bs_chooseTableTool;
            comboBox_ChooseTable.ValueMember = "表名称";
            comboBox_ChooseTable.DisplayMember = "表名称";
            if (comboBox_ChooseTable.SelectedIndex >= 0 && statisticalInfo != null)
            {
                dataGV_showStatisticalData.DataSource = statisticalBll.getStatisticalResult(statisticalInfo.Rows[comboBox_ChooseTable.SelectedIndex][2].ToString());
            }
        }

        private void StatisticalForm_Load(object sender, System.EventArgs e)
        {
            Databind();
        }

        private void comboBox_ChooseTable_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox_ChooseTable.SelectedIndex >= 0 && statisticalInfo != null)
            {
                dataGV_showStatisticalData.DataSource = statisticalBll.getStatisticalResult(statisticalInfo.Rows[comboBox_ChooseTable.SelectedIndex][2].ToString());
            }
        }

        private void btn_Print_Click(object sender, System.EventArgs e)
        {
            try
            {
                Tools.PrintService print = new Tools.PrintService((DataTable)dataGV_showStatisticalData.DataSource);
                if (print.PrintDataTable())//打印datagridview中的内容
                {
                    MessageBox.Show("打印成功");
                }
                else
                {
                    MessageBox.Show("打印失败");
                }
                Focus();//该窗体获取焦点
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
