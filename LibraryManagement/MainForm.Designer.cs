namespace LibraryManagement
{
    partial class MainForm
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
            this.getAllBookButton = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getAllBookButton
            // 
            this.getAllBookButton.Location = new System.Drawing.Point(142, 121);
            this.getAllBookButton.Name = "getAllBookButton";
            this.getAllBookButton.Size = new System.Drawing.Size(97, 98);
            this.getAllBookButton.TabIndex = 1;
            this.getAllBookButton.Text = "全部图书";
            this.getAllBookButton.UseVisualStyleBackColor = true;
            this.getAllBookButton.Click += new System.EventHandler(this.getAllBookButton_Click);
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(397, 121);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(99, 98);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 375);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.getAllBookButton);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书馆管理系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getAllBookButton;
        private System.Windows.Forms.Button button_Login;
    }
}