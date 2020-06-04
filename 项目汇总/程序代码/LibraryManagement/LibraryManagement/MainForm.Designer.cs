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
            this.periodicalSystemButton = new System.Windows.Forms.Button();
            this.statisticalSystemButton = new System.Windows.Forms.Button();
            this.interviewSystemButton = new System.Windows.Forms.Button();
            this.maintainaceSystemButton = new System.Windows.Forms.Button();
            this.catalogSystemBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // periodicalSystemButton
            // 
            this.periodicalSystemButton.Location = new System.Drawing.Point(616, 109);
            this.periodicalSystemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.periodicalSystemButton.Name = "periodicalSystemButton";
            this.periodicalSystemButton.Size = new System.Drawing.Size(119, 90);
            this.periodicalSystemButton.TabIndex = 0;
            this.periodicalSystemButton.Text = "期刊子系统";
            this.periodicalSystemButton.UseVisualStyleBackColor = true;
            this.periodicalSystemButton.Click += new System.EventHandler(this.periodicalSystemButton_Click);
            // 
            // statisticalSystemButton
            // 
            this.statisticalSystemButton.Location = new System.Drawing.Point(616, 252);
            this.statisticalSystemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statisticalSystemButton.Name = "statisticalSystemButton";
            this.statisticalSystemButton.Size = new System.Drawing.Size(119, 90);
            this.statisticalSystemButton.TabIndex = 0;
            this.statisticalSystemButton.Text = "统计子系统";
            this.statisticalSystemButton.UseVisualStyleBackColor = true;
            this.statisticalSystemButton.Click += new System.EventHandler(this.statisticalSystemButton_Click);
            // 
            // interviewSystemButton
            // 
            this.interviewSystemButton.Location = new System.Drawing.Point(73, 109);
            this.interviewSystemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interviewSystemButton.Name = "interviewSystemButton";
            this.interviewSystemButton.Size = new System.Drawing.Size(119, 90);
            this.interviewSystemButton.TabIndex = 0;
            this.interviewSystemButton.Text = "采访子系统";
            this.interviewSystemButton.UseVisualStyleBackColor = true;
            this.interviewSystemButton.Click += new System.EventHandler(this.interviewSystemButton_Click);
            // 
            // maintainaceSystemButton
            // 
            this.maintainaceSystemButton.Location = new System.Drawing.Point(73, 252);
            this.maintainaceSystemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maintainaceSystemButton.Name = "maintainaceSystemButton";
            this.maintainaceSystemButton.Size = new System.Drawing.Size(119, 90);
            this.maintainaceSystemButton.TabIndex = 0;
            this.maintainaceSystemButton.Text = "系统维护子系统";
            this.maintainaceSystemButton.UseVisualStyleBackColor = true;
            this.maintainaceSystemButton.Click += new System.EventHandler(this.maintainaceSystemButton_Click);
            // 
            // catalogSystemBtn
            // 
            this.catalogSystemBtn.Location = new System.Drawing.Point(361, 149);
            this.catalogSystemBtn.Name = "catalogSystemBtn";
            this.catalogSystemBtn.Size = new System.Drawing.Size(75, 23);
            this.catalogSystemBtn.TabIndex = 1;
            this.catalogSystemBtn.Text = "button1";
            this.catalogSystemBtn.UseVisualStyleBackColor = true;
            this.catalogSystemBtn.Click += new System.EventHandler(this.catalogSystemBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.catalogSystemBtn);
            this.Controls.Add(this.maintainaceSystemButton);
            this.Controls.Add(this.statisticalSystemButton);
            this.Controls.Add(this.interviewSystemButton);
            this.Controls.Add(this.periodicalSystemButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button periodicalSystemButton;
        private System.Windows.Forms.Button statisticalSystemButton;
        private System.Windows.Forms.Button interviewSystemButton;
        private System.Windows.Forms.Button maintainaceSystemButton;
        private System.Windows.Forms.Button catalogSystemBtn;
    }
}