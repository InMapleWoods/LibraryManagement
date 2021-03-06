﻿namespace LibraryManagementFunctionTest.UserManagement
{
    partial class UserManagementAdminChoice
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
            this.btn_AddReader = new System.Windows.Forms.Button();
            this.btn_ChangeReaderLevel = new System.Windows.Forms.Button();
            this.button_addAdmin = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddReader
            // 
            this.btn_AddReader.Location = new System.Drawing.Point(31, 121);
            this.btn_AddReader.Name = "btn_AddReader";
            this.btn_AddReader.Size = new System.Drawing.Size(118, 82);
            this.btn_AddReader.TabIndex = 0;
            this.btn_AddReader.Text = "添加读者或修改读者信息";
            this.btn_AddReader.UseVisualStyleBackColor = true;
            this.btn_AddReader.Click += new System.EventHandler(this.btn_AddReader_Click);
            // 
            // btn_ChangeReaderLevel
            // 
            this.btn_ChangeReaderLevel.Location = new System.Drawing.Point(200, 121);
            this.btn_ChangeReaderLevel.Name = "btn_ChangeReaderLevel";
            this.btn_ChangeReaderLevel.Size = new System.Drawing.Size(118, 82);
            this.btn_ChangeReaderLevel.TabIndex = 1;
            this.btn_ChangeReaderLevel.Text = "修改读者权限";
            this.btn_ChangeReaderLevel.UseVisualStyleBackColor = true;
            this.btn_ChangeReaderLevel.Click += new System.EventHandler(this.btn_ChangeReaderLevel_Click);
            // 
            // button_addAdmin
            // 
            this.button_addAdmin.Location = new System.Drawing.Point(358, 121);
            this.button_addAdmin.Name = "button_addAdmin";
            this.button_addAdmin.Size = new System.Drawing.Size(118, 82);
            this.button_addAdmin.TabIndex = 1;
            this.button_addAdmin.Text = "增加管理员";
            this.button_addAdmin.UseVisualStyleBackColor = true;
            this.button_addAdmin.Click += new System.EventHandler(this.button_addAdmin_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(518, 121);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(118, 82);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "管理员登陆";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // UserManagementAdminChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 346);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.button_addAdmin);
            this.Controls.Add(this.btn_ChangeReaderLevel);
            this.Controls.Add(this.btn_AddReader);
            this.Name = "UserManagementAdminChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作内容选择";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagementAdminChoice_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddReader;
        private System.Windows.Forms.Button btn_ChangeReaderLevel;
        private System.Windows.Forms.Button button_addAdmin;
        private System.Windows.Forms.Button btn_login;
    }
}