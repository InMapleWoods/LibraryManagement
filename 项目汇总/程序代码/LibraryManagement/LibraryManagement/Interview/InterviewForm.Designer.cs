﻿namespace LibraryManagement.Interview
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
            this.CataloguingListButton = new System.Windows.Forms.Button();
            this.OrderModificationButton = new System.Windows.Forms.Button();
            this.OrderInformationButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InterviewListButton
            // 
            this.InterviewListButton.Location = new System.Drawing.Point(217, 126);
            this.InterviewListButton.Name = "InterviewListButton";
            this.InterviewListButton.Size = new System.Drawing.Size(75, 75);
            this.InterviewListButton.TabIndex = 0;
            this.InterviewListButton.Text = "采访清单";
            this.InterviewListButton.UseVisualStyleBackColor = true;
            // 
            // CataloguingListButton
            // 
            this.CataloguingListButton.Location = new System.Drawing.Point(362, 126);
            this.CataloguingListButton.Name = "CataloguingListButton";
            this.CataloguingListButton.Size = new System.Drawing.Size(75, 75);
            this.CataloguingListButton.TabIndex = 1;
            this.CataloguingListButton.Text = "编目清单";
            this.CataloguingListButton.UseVisualStyleBackColor = true;
            // 
            // OrderModificationButton
            // 
            this.OrderModificationButton.Location = new System.Drawing.Point(506, 126);
            this.OrderModificationButton.Name = "OrderModificationButton";
            this.OrderModificationButton.Size = new System.Drawing.Size(75, 75);
            this.OrderModificationButton.TabIndex = 2;
            this.OrderModificationButton.Text = "订单修改";
            this.OrderModificationButton.UseVisualStyleBackColor = true;
            // 
            // OrderInformationButton
            // 
            this.OrderInformationButton.Location = new System.Drawing.Point(656, 126);
            this.OrderInformationButton.Name = "OrderInformationButton";
            this.OrderInformationButton.Size = new System.Drawing.Size(75, 75);
            this.OrderInformationButton.TabIndex = 3;
            this.OrderInformationButton.Text = "订单信息";
            this.OrderInformationButton.UseVisualStyleBackColor = true;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(79, 126);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(75, 75);
            this.OrderButton.TabIndex = 4;
            this.OrderButton.Text = "订购新书";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // InterviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.OrderInformationButton);
            this.Controls.Add(this.OrderModificationButton);
            this.Controls.Add(this.CataloguingListButton);
            this.Controls.Add(this.InterviewListButton);
            this.Name = "InterviewForm";
            this.ShowIcon = false;
            this.Text = "采访子系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InterviewListButton;
        private System.Windows.Forms.Button CataloguingListButton;
        private System.Windows.Forms.Button OrderModificationButton;
        private System.Windows.Forms.Button OrderInformationButton;
        private System.Windows.Forms.Button OrderButton;
    }
}