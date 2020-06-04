namespace LibraryManagement.Maintainace.DictionaryAdd
{
    partial class DictionaryBookmanAdd
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
            this.lab_BmName = new System.Windows.Forms.Label();
            this.lab_Address = new System.Windows.Forms.Label();
            this.textBox_BmName = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.btn_commit = new System.Windows.Forms.Button();
            this.label_Contact = new System.Windows.Forms.Label();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.label_Call = new System.Windows.Forms.Label();
            this.textBox_Call = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_BmName
            // 
            this.lab_BmName.AutoSize = true;
            this.lab_BmName.Location = new System.Drawing.Point(65, 64);
            this.lab_BmName.Name = "lab_BmName";
            this.lab_BmName.Size = new System.Drawing.Size(53, 12);
            this.lab_BmName.TabIndex = 0;
            this.lab_BmName.Text = "书商名称";
            // 
            // lab_Address
            // 
            this.lab_Address.AutoSize = true;
            this.lab_Address.Location = new System.Drawing.Point(83, 101);
            this.lab_Address.Name = "lab_Address";
            this.lab_Address.Size = new System.Drawing.Size(35, 12);
            this.lab_Address.TabIndex = 1;
            this.lab_Address.Text = "地 址";
            // 
            // textBox_BmName
            // 
            this.textBox_BmName.Location = new System.Drawing.Point(124, 61);
            this.textBox_BmName.Name = "textBox_BmName";
            this.textBox_BmName.Size = new System.Drawing.Size(100, 21);
            this.textBox_BmName.TabIndex = 2;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(124, 101);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(100, 21);
            this.textBox_Adress.TabIndex = 3;
            // 
            // btn_commit
            // 
            this.btn_commit.Location = new System.Drawing.Point(203, 289);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(75, 23);
            this.btn_commit.TabIndex = 4;
            this.btn_commit.Text = "提交";
            this.btn_commit.UseVisualStyleBackColor = true;
            // 
            // label_Contact
            // 
            this.label_Contact.AutoSize = true;
            this.label_Contact.Location = new System.Drawing.Point(77, 139);
            this.label_Contact.Name = "label_Contact";
            this.label_Contact.Size = new System.Drawing.Size(41, 12);
            this.label_Contact.TabIndex = 5;
            this.label_Contact.Text = "联系人";
            this.label_Contact.Click += new System.EventHandler(this.label_Contact_Click);
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Location = new System.Drawing.Point(124, 136);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.Size = new System.Drawing.Size(100, 21);
            this.textBox_Contact.TabIndex = 6;
            // 
            // label_Call
            // 
            this.label_Call.AutoSize = true;
            this.label_Call.Location = new System.Drawing.Point(83, 173);
            this.label_Call.Name = "label_Call";
            this.label_Call.Size = new System.Drawing.Size(35, 12);
            this.label_Call.TabIndex = 7;
            this.label_Call.Text = "电 话";
            this.label_Call.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Call
            // 
            this.textBox_Call.Location = new System.Drawing.Point(124, 170);
            this.textBox_Call.Name = "textBox_Call";
            this.textBox_Call.Size = new System.Drawing.Size(100, 21);
            this.textBox_Call.TabIndex = 8;
            // 
            // DictionaryBookmanAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 353);
            this.Controls.Add(this.textBox_Call);
            this.Controls.Add(this.label_Call);
            this.Controls.Add(this.textBox_Contact);
            this.Controls.Add(this.label_Contact);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_BmName);
            this.Controls.Add(this.lab_Address);
            this.Controls.Add(this.lab_BmName);
            this.Name = "DictionaryBookmanAdd";
            this.Text = "增添书商";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_BmName;
        private System.Windows.Forms.Label lab_Address;
        private System.Windows.Forms.TextBox textBox_BmName;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.Label label_Contact;
        private System.Windows.Forms.TextBox textBox_Contact;
        private System.Windows.Forms.Label label_Call;
        private System.Windows.Forms.TextBox textBox_Call;
    }
}