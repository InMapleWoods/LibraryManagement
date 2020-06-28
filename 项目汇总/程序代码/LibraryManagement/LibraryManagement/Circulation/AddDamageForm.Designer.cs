namespace LibraryManagement.Circulation
{
    partial class AddDamageForm
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
            this.btn_save = new System.Windows.Forms.Button();
            this.richTextBox_detail = new System.Windows.Forms.RichTextBox();
            this.textBox_checkerNum = new System.Windows.Forms.TextBox();
            this.label_checker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(265, 286);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(147, 61);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // richTextBox_detail
            // 
            this.richTextBox_detail.Location = new System.Drawing.Point(12, 120);
            this.richTextBox_detail.Name = "richTextBox_detail";
            this.richTextBox_detail.Size = new System.Drawing.Size(660, 160);
            this.richTextBox_detail.TabIndex = 1;
            this.richTextBox_detail.Text = "";
            // 
            // textBox_checkerNum
            // 
            this.textBox_checkerNum.Location = new System.Drawing.Point(265, 28);
            this.textBox_checkerNum.Name = "textBox_checkerNum";
            this.textBox_checkerNum.Size = new System.Drawing.Size(276, 25);
            this.textBox_checkerNum.TabIndex = 2;
            // 
            // label_checker
            // 
            this.label_checker.AutoSize = true;
            this.label_checker.Location = new System.Drawing.Point(177, 31);
            this.label_checker.Name = "label_checker";
            this.label_checker.Size = new System.Drawing.Size(82, 15);
            this.label_checker.TabIndex = 3;
            this.label_checker.Text = "检查人账号";
            // 
            // AddDamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 359);
            this.Controls.Add(this.label_checker);
            this.Controls.Add(this.textBox_checkerNum);
            this.Controls.Add(this.richTextBox_detail);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDamageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "书籍损坏";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDamageForm_FormClosing);
            this.Load += new System.EventHandler(this.AddDamageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RichTextBox richTextBox_detail;
        private System.Windows.Forms.TextBox textBox_checkerNum;
        private System.Windows.Forms.Label label_checker;
    }
}