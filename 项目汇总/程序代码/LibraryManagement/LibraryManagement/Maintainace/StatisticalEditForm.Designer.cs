﻿namespace LibraryManagement.Maintainace
{
    partial class StatisticalEditForm
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.textBox_Option = new System.Windows.Forms.TextBox();
            this.dataGridView_StatisticalInfo = new System.Windows.Forms.DataGridView();
            this.lab_TableName = new System.Windows.Forms.Label();
            this.lab_Option = new System.Windows.Forms.Label();
            this.btn_PreView = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.comboBox_TableName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StatisticalInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.Location = new System.Drawing.Point(416, 24);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "增加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // textBox_Option
            // 
            this.textBox_Option.Location = new System.Drawing.Point(109, 107);
            this.textBox_Option.Name = "textBox_Option";
            this.textBox_Option.Size = new System.Drawing.Size(586, 21);
            this.textBox_Option.TabIndex = 2;
            // 
            // dataGridView_StatisticalInfo
            // 
            this.dataGridView_StatisticalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StatisticalInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_StatisticalInfo.Location = new System.Drawing.Point(0, 165);
            this.dataGridView_StatisticalInfo.Name = "dataGridView_StatisticalInfo";
            this.dataGridView_StatisticalInfo.RowTemplate.Height = 23;
            this.dataGridView_StatisticalInfo.Size = new System.Drawing.Size(800, 285);
            this.dataGridView_StatisticalInfo.TabIndex = 3;
            // 
            // lab_TableName
            // 
            this.lab_TableName.AutoSize = true;
            this.lab_TableName.Location = new System.Drawing.Point(28, 54);
            this.lab_TableName.Name = "lab_TableName";
            this.lab_TableName.Size = new System.Drawing.Size(53, 12);
            this.lab_TableName.TabIndex = 4;
            this.lab_TableName.Text = "统计表名";
            // 
            // lab_Option
            // 
            this.lab_Option.AutoSize = true;
            this.lab_Option.Location = new System.Drawing.Point(34, 110);
            this.lab_Option.Name = "lab_Option";
            this.lab_Option.Size = new System.Drawing.Size(47, 12);
            this.lab_Option.TabIndex = 5;
            this.lab_Option.Text = "sql语句";
            // 
            // btn_PreView
            // 
            this.btn_PreView.Location = new System.Drawing.Point(315, 24);
            this.btn_PreView.Name = "btn_PreView";
            this.btn_PreView.Size = new System.Drawing.Size(75, 23);
            this.btn_PreView.TabIndex = 6;
            this.btn_PreView.Text = "预览";
            this.btn_PreView.UseVisualStyleBackColor = true;
            this.btn_PreView.Click += new System.EventHandler(this.btn_Excude_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(611, 24);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(512, 24);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "更改";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.FormattingEnabled = true;
            this.comboBox_TableName.Location = new System.Drawing.Point(109, 54);
            this.comboBox_TableName.Name = "comboBox_TableName";
            this.comboBox_TableName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_TableName.TabIndex = 9;
            // 
            // StatisticalEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_TableName);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_PreView);
            this.Controls.Add(this.lab_Option);
            this.Controls.Add(this.lab_TableName);
            this.Controls.Add(this.dataGridView_StatisticalInfo);
            this.Controls.Add(this.textBox_Option);
            this.Controls.Add(this.btn_Add);
            this.Name = "StatisticalEditForm";
            this.Text = "StatisticalEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StatisticalInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox textBox_Option;
        private System.Windows.Forms.DataGridView dataGridView_StatisticalInfo;
        private System.Windows.Forms.Label lab_TableName;
        private System.Windows.Forms.Label lab_Option;
        private System.Windows.Forms.Button btn_PreView;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox comboBox_TableName;
    }
}