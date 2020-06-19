using LibraryManagement.Bll;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagement.Periodical
{
    public partial class PeriodicalBindingForm : Form
    {
        Form parentForm;//父窗体
        PeriodicalBll periodicalBll = new PeriodicalBll();//期刊用户操作类

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form">父窗体</param>
        public PeriodicalBindingForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        /// <summary>
        /// 窗体加载函数
        /// </summary>
        private void PeriodicalBindingForm_Load(object sender, EventArgs e)
        {
            DataBind();//数据绑定
        }

        /// <summary>
        /// 窗体关闭函数
        /// </summary>
        private void PeriodicalBindingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();//显示上层窗体
            Hide();//隐藏当前窗体
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind()
        {
            dataGridView_Periodical.DataSource = periodicalBll.GetAllUnbindedPeriodical();
            dataGridView_Binding.DataSource = periodicalBll.GetAllPeriodBindings();
            DataGridViewCheckBoxColumn checkBtn = new DataGridViewCheckBoxColumn
            {
                Name = "btnCheck",
                HeaderText = "选择",
                Width = 50
            };
            checkBtn.DefaultCellStyle.NullValue = false;
            if (!dataGridView_Periodical.Columns.Contains("btnCheck"))
            {
                dataGridView_Periodical.Columns.Insert(0, checkBtn);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = new List<string>();//创建一个错误列表
                //获取根据当前页面内容生成的订单（若有错误会被添加到错误列表中）
                PeriodicalBinding binding = GetPeriodicalBinding(ref errorList);
                //判断是否添加订单成功
                if (periodicalBll.AddPeriodicalBinding(binding, ref errorList))
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

        private void button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否删除该条记录", "删除确认", MessageBoxButtons.YesNoCancel);//设置弹出窗体的格式
                if (dialogResult == DialogResult.Yes)//如果选择确认按钮
                {
                    int id;
                    if (!int.TryParse(textBox_Id.Text, out id))//将其转换为数字失败
                    {
                        MessageBox.Show("合订编号错误");
                        return;
                    }
                    if (periodicalBll.DeletePeriodicalBinding(id))//调用登到删除方法
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
            DataBind();
        }

        private void dataGridView_Periodical_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Periodical.CurrentCell == null)
            {
                return;
            }
            if (dataGridView_Periodical.CurrentCell.ColumnIndex == 0)
            {
                //获取DataGridView中CheckBox的Cell
                var dgvCheck = (DataGridViewCheckBoxCell)dataGridView_Periodical.Rows[dataGridView_Periodical.CurrentCell.RowIndex].Cells[0];
                //根据单击时，Cell的值进行处理。EditedFormattedValue和Value均可以
                //若单击时，CheckBox没有被勾上
                if (!Convert.ToBoolean(dgvCheck.EditedFormattedValue))
                {
                    dgvCheck.Value = true;
                }

                //若单击时，CheckBox已经被勾上
                else
                {
                    dgvCheck.Value = false;
                }
            }
        }

        /// <summary>
        /// 获取当前窗体所表示的合订记录
        /// </summary>
        /// <param name="error">错误列表</param>
        /// <returns>期刊合订记录</returns>
        private PeriodicalBinding GetPeriodicalBinding(ref List<string> error)
        {
            List<string> errorList = new List<string>();//错误列表
            //根据页面内容构造合订记录
            PeriodicalBinding binding = new PeriodicalBinding()
            {
                BindingName = textBox_bindingName.Text,
                BindingIdList = GetBindList()
            };
            error = errorList;//返回错误列表
            return binding;//返回合订
        }

        private string GetBindList()
        {
            List<string> ls = new List<string>();
            if (dataGridView_Periodical.Rows.Count <= 0)
            {
                throw new Exception("error");
            }
            foreach (DataGridViewRow i in dataGridView_Periodical.Rows)
            {
                var dgvCheck = (DataGridViewCheckBoxCell)i.Cells[0];
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue))
                {
                    ls.Add(i.Cells[1].Value.ToString());
                }
            }
            return PeriodicalBinding.GetBindingListString(ls);
        }


        private void dataGridView_Periodical_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView_Periodical.CurrentRow != null)
            {
                textBox_Id.Text = "";//编号
                textBox_bindingName.Text = "";//合订本名称
            }
        }

        private void dataGridView_Periodical_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Periodical.SelectedRows.Count > 0)
            {
                textBox_Id.Text = "";//编号
                textBox_bindingName.Text = "";//合订本名称
            }
        }
        private void dataGridView_Binding_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView_Binding.CurrentRow != null)
            {
                textBox_Id.Text = dataGridView_Binding.CurrentRow.Cells["编号"].Value.ToString();//编号
                textBox_bindingName.Text = dataGridView_Binding.CurrentRow.Cells["合订本名称"].Value.ToString();//合订本名称
            }
        }

        private void dataGridView_Binding_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Binding.SelectedRows.Count > 0)
            {
                textBox_Id.Text = dataGridView_Binding.SelectedRows[0].Cells["编号"].Value.ToString();//编号
                textBox_bindingName.Text = dataGridView_Binding.SelectedRows[0].Cells["合订本名称"].Value.ToString();//合订本名称
            }
        }
    }
}
