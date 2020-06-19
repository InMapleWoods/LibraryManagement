using LibraryManagement.Bll;
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
    }
}
