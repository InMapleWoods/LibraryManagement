namespace LibraryManagementFunctionTest.Catalog
{
    partial class SerialNumberForm
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
            this.getInterviewBookBtn = new System.Windows.Forms.Button();
            this.cnkiBtn = new System.Windows.Forms.Button();
            this.classificationoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getInterviewBookBtn
            // 
            this.getInterviewBookBtn.Location = new System.Drawing.Point(68, 112);
            this.getInterviewBookBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getInterviewBookBtn.Name = "getInterviewBookBtn";
            this.getInterviewBookBtn.Size = new System.Drawing.Size(111, 62);
            this.getInterviewBookBtn.TabIndex = 0;
            this.getInterviewBookBtn.Text = "取采访书目";
            this.getInterviewBookBtn.UseVisualStyleBackColor = true;
            this.getInterviewBookBtn.Click += new System.EventHandler(this.getInterviewBookBtn_Click);
            // 
            // cnkiBtn
            // 
            this.cnkiBtn.Location = new System.Drawing.Point(270, 112);
            this.cnkiBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cnkiBtn.Name = "cnkiBtn";
            this.cnkiBtn.Size = new System.Drawing.Size(111, 62);
            this.cnkiBtn.TabIndex = 1;
            this.cnkiBtn.Text = "查重";
            this.cnkiBtn.UseVisualStyleBackColor = true;
            this.cnkiBtn.Click += new System.EventHandler(this.cnkiBtn_Click);
            // 
            // classificationoBtn
            // 
            this.classificationoBtn.Location = new System.Drawing.Point(471, 112);
            this.classificationoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classificationoBtn.Name = "classificationoBtn";
            this.classificationoBtn.Size = new System.Drawing.Size(111, 62);
            this.classificationoBtn.TabIndex = 2;
            this.classificationoBtn.Text = "分类";
            this.classificationoBtn.UseVisualStyleBackColor = true;
            this.classificationoBtn.Click += new System.EventHandler(this.classificationoBtn_Click);
            // 
            // SerialNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 375);
            this.Controls.Add(this.classificationoBtn);
            this.Controls.Add(this.cnkiBtn);
            this.Controls.Add(this.getInterviewBookBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SerialNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerialNumberForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getInterviewBookBtn;
        private System.Windows.Forms.Button cnkiBtn;
        private System.Windows.Forms.Button classificationoBtn;
    }
}