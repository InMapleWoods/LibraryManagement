namespace LibraryManagement.Interview
{
    partial class InterviewForm
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
            this.InterviewListButton = new System.Windows.Forms.Button();
            this.AcceptanceListButton = new System.Windows.Forms.Button();
            this.ReturnInformationButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InterviewListButton
            // 
            this.InterviewListButton.Location = new System.Drawing.Point(82, 156);
            this.InterviewListButton.Name = "InterviewListButton";
            this.InterviewListButton.Size = new System.Drawing.Size(75, 75);
            this.InterviewListButton.TabIndex = 0;
            this.InterviewListButton.Text = "采访清单";
            this.InterviewListButton.UseVisualStyleBackColor = true;
            this.InterviewListButton.Click += new System.EventHandler(this.InterviewListButton_Click);
            // 
            // AcceptanceListButton
            // 
            this.AcceptanceListButton.Location = new System.Drawing.Point(463, 156);
            this.AcceptanceListButton.Name = "AcceptanceListButton";
            this.AcceptanceListButton.Size = new System.Drawing.Size(75, 75);
            this.AcceptanceListButton.TabIndex = 1;
            this.AcceptanceListButton.Text = "验收清单";
            this.AcceptanceListButton.UseVisualStyleBackColor = true;
            this.AcceptanceListButton.Click += new System.EventHandler(this.AcceptanceListButton_Click);
            // 
            // ReturnInformationButton
            // 
            this.ReturnInformationButton.Location = new System.Drawing.Point(647, 156);
            this.ReturnInformationButton.Name = "ReturnInformationButton";
            this.ReturnInformationButton.Size = new System.Drawing.Size(75, 75);
            this.ReturnInformationButton.TabIndex = 3;
            this.ReturnInformationButton.Text = "退货信息";
            this.ReturnInformationButton.UseVisualStyleBackColor = true;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(264, 156);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(75, 75);
            this.OrderButton.TabIndex = 4;
            this.OrderButton.Text = "订购新书";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(366, 303);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 50);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "返回";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // InterviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.ReturnInformationButton);
            this.Controls.Add(this.AcceptanceListButton);
            this.Controls.Add(this.InterviewListButton);
            this.MaximizeBox = false;
            this.Name = "InterviewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采访子系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterviewForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InterviewListButton;
        private System.Windows.Forms.Button AcceptanceListButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button ReturnInformationButton;
    }
}