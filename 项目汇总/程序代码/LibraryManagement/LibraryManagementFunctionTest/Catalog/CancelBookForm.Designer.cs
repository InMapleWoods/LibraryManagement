namespace LibraryManagementFunctionTest.Catalog
{
    partial class CancelBookForm
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
            this.cancelApplyBtn = new System.Windows.Forms.Button();
            this.cancelAuditBtn = new System.Windows.Forms.Button();
            this.cancelHandleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelApplyBtn
            // 
            this.cancelApplyBtn.Location = new System.Drawing.Point(107, 103);
            this.cancelApplyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelApplyBtn.Name = "cancelApplyBtn";
            this.cancelApplyBtn.Size = new System.Drawing.Size(111, 62);
            this.cancelApplyBtn.TabIndex = 0;
            this.cancelApplyBtn.Text = "注销报损申请";
            this.cancelApplyBtn.UseVisualStyleBackColor = true;
            // 
            // cancelAuditBtn
            // 
            this.cancelAuditBtn.Location = new System.Drawing.Point(295, 103);
            this.cancelAuditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelAuditBtn.Name = "cancelAuditBtn";
            this.cancelAuditBtn.Size = new System.Drawing.Size(111, 62);
            this.cancelAuditBtn.TabIndex = 1;
            this.cancelAuditBtn.Text = "注销报损审核";
            this.cancelAuditBtn.UseVisualStyleBackColor = true;
            // 
            // cancelHandleBtn
            // 
            this.cancelHandleBtn.Location = new System.Drawing.Point(490, 103);
            this.cancelHandleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelHandleBtn.Name = "cancelHandleBtn";
            this.cancelHandleBtn.Size = new System.Drawing.Size(111, 62);
            this.cancelHandleBtn.TabIndex = 2;
            this.cancelHandleBtn.Text = "注销报损处理";
            this.cancelHandleBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 375);
            this.Controls.Add(this.cancelHandleBtn);
            this.Controls.Add(this.cancelAuditBtn);
            this.Controls.Add(this.cancelApplyBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CancelBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注销报损";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CancelBookForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelApplyBtn;
        private System.Windows.Forms.Button cancelAuditBtn;
        private System.Windows.Forms.Button cancelHandleBtn;
    }
}