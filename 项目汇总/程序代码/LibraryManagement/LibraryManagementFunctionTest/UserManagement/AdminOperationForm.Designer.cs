namespace LibraryManagementFunctionTest.UserManagement
{
    partial class AdminOperationForm
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
            this.addReaderButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.searchReaderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addReaderButton
            // 
            this.addReaderButton.Location = new System.Drawing.Point(649, 35);
            this.addReaderButton.Name = "addReaderButton";
            this.addReaderButton.Size = new System.Drawing.Size(109, 56);
            this.addReaderButton.TabIndex = 0;
            this.addReaderButton.Text = "新增读者";
            this.addReaderButton.UseVisualStyleBackColor = true;
            this.addReaderButton.Click += new System.EventHandler(this.addNewReaderButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 121);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 330);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // searchReaderButton
            // 
            this.searchReaderButton.Location = new System.Drawing.Point(480, 35);
            this.searchReaderButton.Name = "searchReaderButton";
            this.searchReaderButton.Size = new System.Drawing.Size(109, 56);
            this.searchReaderButton.TabIndex = 2;
            this.searchReaderButton.Text = "读者查询";
            this.searchReaderButton.UseVisualStyleBackColor = true;
            // 
            // AdminOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchReaderButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.addReaderButton);
            this.Name = "AdminOperationForm";
            this.Text = "AdminOperationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminOperationForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addReaderButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button searchReaderButton;
    }
}