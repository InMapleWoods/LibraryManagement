namespace LibraryManagement.UserManagement
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
            this.SuspendLayout();
            // 
            // btn_AddReader
            // 
            this.btn_AddReader.Location = new System.Drawing.Point(138, 117);
            this.btn_AddReader.Name = "btn_AddReader";
            this.btn_AddReader.Size = new System.Drawing.Size(118, 82);
            this.btn_AddReader.TabIndex = 0;
            this.btn_AddReader.Text = "添加读者或修改读者信息";
            this.btn_AddReader.UseVisualStyleBackColor = true;
            this.btn_AddReader.Click += new System.EventHandler(this.btn_AddReader_Click);
            // 
            // btn_ChangeReaderLevel
            // 
            this.btn_ChangeReaderLevel.Location = new System.Drawing.Point(373, 117);
            this.btn_ChangeReaderLevel.Name = "btn_ChangeReaderLevel";
            this.btn_ChangeReaderLevel.Size = new System.Drawing.Size(118, 82);
            this.btn_ChangeReaderLevel.TabIndex = 1;
            this.btn_ChangeReaderLevel.Text = "修改读者权限";
            this.btn_ChangeReaderLevel.UseVisualStyleBackColor = true;
            this.btn_ChangeReaderLevel.Click += new System.EventHandler(this.btn_ChangeReaderLevel_Click);
            // 
            // UserManagementAdminChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 328);
            this.Controls.Add(this.btn_ChangeReaderLevel);
            this.Controls.Add(this.btn_AddReader);
            this.Name = "UserManagementAdminChoice";
            this.Text = "UserManagementAdminChoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagementAdminChoice_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddReader;
        private System.Windows.Forms.Button btn_ChangeReaderLevel;
    }
}