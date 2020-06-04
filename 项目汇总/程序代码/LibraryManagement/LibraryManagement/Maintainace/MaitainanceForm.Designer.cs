namespace LibraryManagement.Maintainace
{
    partial class MaitainanceForm
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
            this.Btn_dictionaryEdit = new System.Windows.Forms.Button();
            this.Btn_statisticalEdit = new System.Windows.Forms.Button();
            this.Btn_backups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_dictionaryEdit
            // 
            this.Btn_dictionaryEdit.Location = new System.Drawing.Point(224, 178);
            this.Btn_dictionaryEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_dictionaryEdit.Name = "Btn_dictionaryEdit";
            this.Btn_dictionaryEdit.Size = new System.Drawing.Size(133, 125);
            this.Btn_dictionaryEdit.TabIndex = 0;
            this.Btn_dictionaryEdit.Text = "字典编辑";
            this.Btn_dictionaryEdit.UseVisualStyleBackColor = true;
            this.Btn_dictionaryEdit.Click += new System.EventHandler(this.Btn_dictionaryEdit_Click);
            // 
            // Btn_statisticalEdit
            // 
            this.Btn_statisticalEdit.Location = new System.Drawing.Point(449, 178);
            this.Btn_statisticalEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_statisticalEdit.Name = "Btn_statisticalEdit";
            this.Btn_statisticalEdit.Size = new System.Drawing.Size(133, 125);
            this.Btn_statisticalEdit.TabIndex = 1;
            this.Btn_statisticalEdit.Text = "统计打印格式设计";
            this.Btn_statisticalEdit.UseVisualStyleBackColor = true;
            this.Btn_statisticalEdit.Click += new System.EventHandler(this.Btn_statisticalEditor_Click);
            // 
            // Btn_backups
            // 
            this.Btn_backups.Location = new System.Drawing.Point(708, 178);
            this.Btn_backups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_backups.Name = "Btn_backups";
            this.Btn_backups.Size = new System.Drawing.Size(133, 125);
            this.Btn_backups.TabIndex = 2;
            this.Btn_backups.Text = "系统备份/还原";
            this.Btn_backups.UseVisualStyleBackColor = true;
            // 
            // MaitainanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.Btn_backups);
            this.Controls.Add(this.Btn_statisticalEdit);
            this.Controls.Add(this.Btn_dictionaryEdit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MaitainanceForm";
            this.Text = "MaitainanceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaitainanceForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_dictionaryEdit;
        private System.Windows.Forms.Button Btn_statisticalEdit;
        private System.Windows.Forms.Button Btn_backups;
    }
}