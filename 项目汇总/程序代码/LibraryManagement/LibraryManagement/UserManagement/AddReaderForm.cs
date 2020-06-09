using LibraryManagement.Dal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.UserManagement
{
    public partial class AddReaderForm : Form
    {
        Form parentForm;
        public AddReaderForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void AddReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 借书证号 LibraryCardNumber
            string libraryCardNum = txb_LibraryCardNum.Text;
            // 读者编号
            string userNumber = txb_UserNumber.Text;
            // 姓名
            string userName = txb_UserName.Text;
            // 性别
            string gender = (string)cbb_Gender.Text;
            // 出生日期
            DateTime birthday = dtp_Birthday.Value;
            // 地址
            string address = (string)cbb_BuildingNo.Text + "#" + txb_DormitoryNo.Text;
            // 联系电话
            string contact = txb_Contact.Text;
            // 院系编号
            string department = (string)cbb_Department.Text;

            SQLHelper Helper = new SQLHelper();
            // 向 tb_BasicInformation 表添加数据
            string sqlBasic = "INSERT INTO tb_BasicInformation" +
                "(UserName," +
                "UserNumber" +
                "Gender" +
                "Birthday" +
                "Address" +
                "Contact) " +
                "VALUES(" +
                userName + "," +
                userNumber + "," +
                gender + "," +
                birthday + "," +
                address + "," +
                contact + ")";
            MySqlParameter[] paraBasic = new MySqlParameter[] { };
            int countBasicInformation = Helper.ExecuteNonQuery(sqlBasic, paraBasic, CommandType.Text);

            // 从 tb_BasicInformation 表获取新添加读者的用户ID UserId
            string sqlUserId = "SELECT UserId FROM tb_BasicInformation WHERE UserNumber =" + userNumber;
            MySqlParameter[] paraUserId = new MySqlParameter[] { };
            DataTable dtUserId = Helper.ExecuteQuery(sqlUserId, paraUserId, CommandType.Text);
            string userId = (string)dtUserId.Rows[0][0];

            // 从 tb_ReaderDepartment 表获取新添加读者的院系编号 departmentId
            string sqlDepartmentId = "SELECT Id FROM tb_ReaderInformation WHERE DepartmentName =" + department;
            MySqlParameter[] paraDepartmentId = new MySqlParameter[] { };
            DataTable dtDepartmentId = Helper.ExecuteQuery(sqlDepartmentId, paraDepartmentId, CommandType.Text);
            string departmentId = (string)dtDepartmentId.Rows[0][0];

            // 向 tb_ReaderInformation 表添加数据
            string sqlReader = "INSERT INTO tb_ReaderInformation" +
                "(LibraryCardNum," +
                "UserId" +
                "DepartmentId)" +
                "VALUES(" +
                libraryCardNum + "," +
                userId + "," +
                departmentId + ")";
            MySqlParameter[] paraReader = new MySqlParameter[] { };
            int countReaderInformation = Helper.ExecuteNonQuery(sqlReader, paraReader, CommandType.Text);

            // 向 tb_Login 表添加数据
            string sqlLogin = "INSERT INTO tb_Login (UserId, Password) VALUES (" + userId + "," + contact.Substring(5,11) + ")";
            MySqlParameter[] paraLogin = new MySqlParameter[] { };
            int countLogin = Helper.ExecuteNonQuery(sqlLogin, paraLogin, CommandType.Text);

            if (countBasicInformation > 0 && countReaderInformation > 0 && countLogin > 0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}
