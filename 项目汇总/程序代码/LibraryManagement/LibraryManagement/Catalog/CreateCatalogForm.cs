﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Catalog
{
    public partial class CreateCatalogForm : Form
    {
        public CreateCatalogForm()
        {
            InitializeComponent();
        }

        private void CreateCatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Hide();
        }
    }
}
