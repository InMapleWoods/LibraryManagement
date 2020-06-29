namespace LibraryManagement
{
    partial class AdminForm
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
            this.userManagementSystemButton = new System.Windows.Forms.Button();
            this.catalogSystemBtn = new System.Windows.Forms.Button();
            this.maintainaceSystemButton = new System.Windows.Forms.Button();
            this.statisticalSystemButton = new System.Windows.Forms.Button();
            this.interviewSystemButton = new System.Windows.Forms.Button();
            this.circulationSystemButton = new System.Windows.Forms.Button();
            this.periodicalSystemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userManagementSystemButton
            // 
            this.userManagementSystemButton.Location = new System.Drawing.Point(283, 247);
            this.userManagementSystemButton.Name = "userManagementSystemButton";
            this.userManagementSystemButton.Size = new System.Drawing.Size(100, 75);
            this.userManagementSystemButton.TabIndex = 9;
            this.userManagementSystemButton.Text = "用户管理子系统";
            this.userManagementSystemButton.UseVisualStyleBackColor = true;
            this.userManagementSystemButton.Click += new System.EventHandler(this.userManagementSystemButton_Click);
            // 
            // catalogSystemBtn
            // 
            this.catalogSystemBtn.Location = new System.Drawing.Point(283, 128);
            this.catalogSystemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catalogSystemBtn.Name = "catalogSystemBtn";
            this.catalogSystemBtn.Size = new System.Drawing.Size(100, 75);
            this.catalogSystemBtn.TabIndex = 8;
            this.catalogSystemBtn.Text = "编目子系统";
            this.catalogSystemBtn.UseVisualStyleBackColor = true;
            this.catalogSystemBtn.Click += new System.EventHandler(this.catalogSystemBtn_Click);
            // 
            // maintainaceSystemButton
            // 
            this.maintainaceSystemButton.Location = new System.Drawing.Point(127, 247);
            this.maintainaceSystemButton.Name = "maintainaceSystemButton";
            this.maintainaceSystemButton.Size = new System.Drawing.Size(100, 75);
            this.maintainaceSystemButton.TabIndex = 3;
            this.maintainaceSystemButton.Text = "系统维护子系统";
            this.maintainaceSystemButton.UseVisualStyleBackColor = true;
            this.maintainaceSystemButton.Click += new System.EventHandler(this.maintainaceSystemButton_Click);
            // 
            // statisticalSystemButton
            // 
            this.statisticalSystemButton.Location = new System.Drawing.Point(573, 247);
            this.statisticalSystemButton.Name = "statisticalSystemButton";
            this.statisticalSystemButton.Size = new System.Drawing.Size(100, 75);
            this.statisticalSystemButton.TabIndex = 4;
            this.statisticalSystemButton.Text = "统计子系统";
            this.statisticalSystemButton.UseVisualStyleBackColor = true;
            this.statisticalSystemButton.Click += new System.EventHandler(this.statisticalSystemButton_Click);
            // 
            // interviewSystemButton
            // 
            this.interviewSystemButton.Location = new System.Drawing.Point(127, 128);
            this.interviewSystemButton.Name = "interviewSystemButton";
            this.interviewSystemButton.Size = new System.Drawing.Size(100, 75);
            this.interviewSystemButton.TabIndex = 5;
            this.interviewSystemButton.Text = "采访子系统";
            this.interviewSystemButton.UseVisualStyleBackColor = true;
            this.interviewSystemButton.Click += new System.EventHandler(this.interviewSystemButton_Click);
            // 
            // circulationSystemButton
            // 
            this.circulationSystemButton.Location = new System.Drawing.Point(427, 128);
            this.circulationSystemButton.Name = "circulationSystemButton";
            this.circulationSystemButton.Size = new System.Drawing.Size(100, 75);
            this.circulationSystemButton.TabIndex = 6;
            this.circulationSystemButton.Text = "流通子系统";
            this.circulationSystemButton.UseVisualStyleBackColor = true;
            this.circulationSystemButton.Click += new System.EventHandler(this.circulationSystemButton_Click);
            // 
            // periodicalSystemButton
            // 
            this.periodicalSystemButton.Location = new System.Drawing.Point(573, 128);
            this.periodicalSystemButton.Name = "periodicalSystemButton";
            this.periodicalSystemButton.Size = new System.Drawing.Size(100, 75);
            this.periodicalSystemButton.TabIndex = 7;
            this.periodicalSystemButton.Text = "期刊子系统";
            this.periodicalSystemButton.UseVisualStyleBackColor = true;
            this.periodicalSystemButton.Click += new System.EventHandler(this.periodicalSystemButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userManagementSystemButton);
            this.Controls.Add(this.catalogSystemBtn);
            this.Controls.Add(this.maintainaceSystemButton);
            this.Controls.Add(this.statisticalSystemButton);
            this.Controls.Add(this.interviewSystemButton);
            this.Controls.Add(this.circulationSystemButton);
            this.Controls.Add(this.periodicalSystemButton);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userManagementSystemButton;
        private System.Windows.Forms.Button catalogSystemBtn;
        private System.Windows.Forms.Button maintainaceSystemButton;
        private System.Windows.Forms.Button statisticalSystemButton;
        private System.Windows.Forms.Button interviewSystemButton;
        private System.Windows.Forms.Button circulationSystemButton;
        private System.Windows.Forms.Button periodicalSystemButton;
    }
}