﻿using System;
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
    public partial class UserManagementForm : Form
    {
        Form parentForm;
        public UserManagementForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            var form = new AdminOperationForm(this);
            form.Show();
            Hide();
        }

        private void UserManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
