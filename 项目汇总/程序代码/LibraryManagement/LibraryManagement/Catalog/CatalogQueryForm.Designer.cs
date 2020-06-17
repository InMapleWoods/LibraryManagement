namespace LibraryManagement.Catalog
{
    partial class CatalogQueryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
            this.idLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.positiveTitleLabel = new System.Windows.Forms.Label();
            this.firstAuthorLabel = new System.Windows.Forms.Label();
            this.publishingHouseLabel = new System.Windows.Forms.Label();
            this.documentTypeLabel = new System.Windows.Forms.Label();
            this.primaryLiabilityLabel = new System.Windows.Forms.Label();
            this.catalogerLabel = new System.Windows.Forms.Label();
            this.catalogingDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(195, 396);
            this.dataGridView1.TabIndex = 1;
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(984, 118);
            this.scriptUserControl1.TabIndex = 0;
            this.scriptUserControl1.Load += new System.EventHandler(this.scriptUserControl1_Load);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(253, 133);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 18);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(253, 167);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(62, 18);
            this.isbnLabel.TabIndex = 3;
            this.isbnLabel.Text = "ISBN号";
            // 
            // positiveTitleLabel
            // 
            this.positiveTitleLabel.AutoSize = true;
            this.positiveTitleLabel.Location = new System.Drawing.Point(253, 201);
            this.positiveTitleLabel.Name = "positiveTitleLabel";
            this.positiveTitleLabel.Size = new System.Drawing.Size(62, 18);
            this.positiveTitleLabel.TabIndex = 4;
            this.positiveTitleLabel.Text = "正题名";
            // 
            // firstAuthorLabel
            // 
            this.firstAuthorLabel.AutoSize = true;
            this.firstAuthorLabel.Location = new System.Drawing.Point(253, 235);
            this.firstAuthorLabel.Name = "firstAuthorLabel";
            this.firstAuthorLabel.Size = new System.Drawing.Size(80, 18);
            this.firstAuthorLabel.TabIndex = 5;
            this.firstAuthorLabel.Text = "第一作者";
            // 
            // publishingHouseLabel
            // 
            this.publishingHouseLabel.AutoSize = true;
            this.publishingHouseLabel.Location = new System.Drawing.Point(253, 268);
            this.publishingHouseLabel.Name = "publishingHouseLabel";
            this.publishingHouseLabel.Size = new System.Drawing.Size(62, 18);
            this.publishingHouseLabel.TabIndex = 6;
            this.publishingHouseLabel.Text = "出版社";
            // 
            // documentTypeLabel
            // 
            this.documentTypeLabel.AutoSize = true;
            this.documentTypeLabel.Location = new System.Drawing.Point(253, 300);
            this.documentTypeLabel.Name = "documentTypeLabel";
            this.documentTypeLabel.Size = new System.Drawing.Size(80, 18);
            this.documentTypeLabel.TabIndex = 7;
            this.documentTypeLabel.Text = "文献类型";
            // 
            // primaryLiabilityLabel
            // 
            this.primaryLiabilityLabel.AutoSize = true;
            this.primaryLiabilityLabel.Location = new System.Drawing.Point(253, 333);
            this.primaryLiabilityLabel.Name = "primaryLiabilityLabel";
            this.primaryLiabilityLabel.Size = new System.Drawing.Size(80, 18);
            this.primaryLiabilityLabel.TabIndex = 8;
            this.primaryLiabilityLabel.Text = "第一责任";
            // 
            // catalogerLabel
            // 
            this.catalogerLabel.AutoSize = true;
            this.catalogerLabel.Location = new System.Drawing.Point(253, 367);
            this.catalogerLabel.Name = "catalogerLabel";
            this.catalogerLabel.Size = new System.Drawing.Size(80, 18);
            this.catalogerLabel.TabIndex = 9;
            this.catalogerLabel.Text = "编目人员";
            // 
            // catalogingDateLabel
            // 
            this.catalogingDateLabel.AutoSize = true;
            this.catalogingDateLabel.Location = new System.Drawing.Point(253, 405);
            this.catalogingDateLabel.Name = "catalogingDateLabel";
            this.catalogingDateLabel.Size = new System.Drawing.Size(80, 18);
            this.catalogingDateLabel.TabIndex = 10;
            this.catalogingDateLabel.Text = "编目日期";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(348, 398);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(392, 28);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 28);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(348, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(392, 28);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(348, 198);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(392, 28);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(348, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(392, 28);
            this.textBox4.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(348, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(392, 26);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(348, 297);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(392, 26);
            this.comboBox2.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(348, 330);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(392, 28);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(348, 364);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(392, 28);
            this.textBox6.TabIndex = 19;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // CatalogQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 514);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.catalogingDateLabel);
            this.Controls.Add(this.catalogerLabel);
            this.Controls.Add(this.primaryLiabilityLabel);
            this.Controls.Add(this.documentTypeLabel);
            this.Controls.Add(this.publishingHouseLabel);
            this.Controls.Add(this.firstAuthorLabel);
            this.Controls.Add(this.positiveTitleLabel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.scriptUserControl1);
            this.Name = "CatalogQueryForm";
            this.Text = "编目查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label positiveTitleLabel;
        private System.Windows.Forms.Label firstAuthorLabel;
        private System.Windows.Forms.Label publishingHouseLabel;
        private System.Windows.Forms.Label documentTypeLabel;
        private System.Windows.Forms.Label primaryLiabilityLabel;
        private System.Windows.Forms.Label catalogerLabel;
        private System.Windows.Forms.Label catalogingDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}