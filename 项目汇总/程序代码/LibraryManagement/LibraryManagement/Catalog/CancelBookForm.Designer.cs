namespace LibraryManagement.Catalog
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
            this.cancelApplyBtn.Location = new System.Drawing.Point(120, 124);
            this.cancelApplyBtn.Name = "cancelApplyBtn";
            this.cancelApplyBtn.Size = new System.Drawing.Size(125, 75);
            this.cancelApplyBtn.TabIndex = 0;
            this.cancelApplyBtn.Text = "注销报损申请";
            this.cancelApplyBtn.UseVisualStyleBackColor = true;
            // 
            // cancelAuditBtn
            // 
            this.cancelAuditBtn.Location = new System.Drawing.Point(332, 124);
            this.cancelAuditBtn.Name = "cancelAuditBtn";
            this.cancelAuditBtn.Size = new System.Drawing.Size(125, 75);
            this.cancelAuditBtn.TabIndex = 1;
            this.cancelAuditBtn.Text = "注销报损审核";
            this.cancelAuditBtn.UseVisualStyleBackColor = true;
            // 
            // cancelHandleBtn
            // 
            this.cancelHandleBtn.Location = new System.Drawing.Point(551, 124);
            this.cancelHandleBtn.Name = "cancelHandleBtn";
            this.cancelHandleBtn.Size = new System.Drawing.Size(125, 75);
            this.cancelHandleBtn.TabIndex = 2;
            this.cancelHandleBtn.Text = "注销报损处理";
            this.cancelHandleBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelHandleBtn);
            this.Controls.Add(this.cancelAuditBtn);
            this.Controls.Add(this.cancelApplyBtn);
            this.Name = "CancelBookForm";
            this.Text = "注销报损";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelApplyBtn;
        private System.Windows.Forms.Button cancelAuditBtn;
        private System.Windows.Forms.Button cancelHandleBtn;
    }
}