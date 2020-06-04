namespace LibraryManagement.Maintainace.DictionaryAdd
{
    partial class DictionaryPublishingHouseAdd
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
            this.lab_PhName = new System.Windows.Forms.Label();
            this.lab_Adress = new System.Windows.Forms.Label();
            this.textBox_PhName = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.btn_commit = new System.Windows.Forms.Button();
            this.textBox_Call = new System.Windows.Forms.TextBox();
            this.label_Call = new System.Windows.Forms.Label();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.label_Contact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_PhName
            // 
            this.lab_PhName.AutoSize = true;
            this.lab_PhName.Location = new System.Drawing.Point(41, 42);
            this.lab_PhName.Name = "lab_PhName";
            this.lab_PhName.Size = new System.Drawing.Size(65, 12);
            this.lab_PhName.TabIndex = 0;
            this.lab_PhName.Text = "出版社名称";
            // 
            // lab_Adress
            // 
            this.lab_Adress.AutoSize = true;
            this.lab_Adress.Location = new System.Drawing.Point(77, 80);
            this.lab_Adress.Name = "lab_Adress";
            this.lab_Adress.Size = new System.Drawing.Size(29, 12);
            this.lab_Adress.TabIndex = 1;
            this.lab_Adress.Text = "地址";
            // 
            // textBox_PhName
            // 
            this.textBox_PhName.Location = new System.Drawing.Point(112, 39);
            this.textBox_PhName.Name = "textBox_PhName";
            this.textBox_PhName.Size = new System.Drawing.Size(100, 21);
            this.textBox_PhName.TabIndex = 2;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(112, 77);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(100, 21);
            this.textBox_Adress.TabIndex = 3;
            // 
            // btn_commit
            // 
            this.btn_commit.Location = new System.Drawing.Point(112, 255);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(92, 28);
            this.btn_commit.TabIndex = 4;
            this.btn_commit.Text = "提交";
            this.btn_commit.UseVisualStyleBackColor = true;
            // 
            // textBox_Call
            // 
            this.textBox_Call.Location = new System.Drawing.Point(112, 146);
            this.textBox_Call.Name = "textBox_Call";
            this.textBox_Call.Size = new System.Drawing.Size(100, 21);
            this.textBox_Call.TabIndex = 12;
            // 
            // label_Call
            // 
            this.label_Call.AutoSize = true;
            this.label_Call.Location = new System.Drawing.Point(71, 149);
            this.label_Call.Name = "label_Call";
            this.label_Call.Size = new System.Drawing.Size(35, 12);
            this.label_Call.TabIndex = 11;
            this.label_Call.Text = "电 话";
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Location = new System.Drawing.Point(112, 112);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.Size = new System.Drawing.Size(100, 21);
            this.textBox_Contact.TabIndex = 10;
            // 
            // label_Contact
            // 
            this.label_Contact.AutoSize = true;
            this.label_Contact.Location = new System.Drawing.Point(65, 115);
            this.label_Contact.Name = "label_Contact";
            this.label_Contact.Size = new System.Drawing.Size(41, 12);
            this.label_Contact.TabIndex = 9;
            this.label_Contact.Text = "联系人";
            // 
            // DictionaryPublishingHouseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 352);
            this.Controls.Add(this.textBox_Call);
            this.Controls.Add(this.label_Call);
            this.Controls.Add(this.textBox_Contact);
            this.Controls.Add(this.label_Contact);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_PhName);
            this.Controls.Add(this.lab_Adress);
            this.Controls.Add(this.lab_PhName);
            this.Name = "DictionaryPublishingHouseAdd";
            this.Text = "增添出版社";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_PhName;
        private System.Windows.Forms.Label lab_Adress;
        private System.Windows.Forms.TextBox textBox_PhName;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.TextBox textBox_Call;
        private System.Windows.Forms.Label label_Call;
        private System.Windows.Forms.TextBox textBox_Contact;
        private System.Windows.Forms.Label label_Contact;
    }
}