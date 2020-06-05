namespace LibraryManagement.Catalog
{
    partial class CreateCatalogForm
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
            this.catalogNumberBtn = new System.Windows.Forms.Button();
            this.receiveBtn = new System.Windows.Forms.Button();
            this.pringBtn = new System.Windows.Forms.Button();
            this.catalogQueryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catalogNumberBtn
            // 
            this.catalogNumberBtn.Location = new System.Drawing.Point(115, 92);
            this.catalogNumberBtn.Name = "catalogNumberBtn";
            this.catalogNumberBtn.Size = new System.Drawing.Size(100, 75);
            this.catalogNumberBtn.TabIndex = 0;
            this.catalogNumberBtn.Text = "编号";
            this.catalogNumberBtn.UseVisualStyleBackColor = true;
            this.catalogNumberBtn.Click += new System.EventHandler(this.serialNumberBtn_Click);
            // 
            // receiveBtn
            // 
            this.receiveBtn.Location = new System.Drawing.Point(255, 92);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(100, 75);
            this.receiveBtn.TabIndex = 1;
            this.receiveBtn.Text = "移送";
            this.receiveBtn.UseVisualStyleBackColor = true;
            this.receiveBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pringBtn
            // 
            this.pringBtn.Location = new System.Drawing.Point(387, 92);
            this.pringBtn.Name = "pringBtn";
            this.pringBtn.Size = new System.Drawing.Size(100, 75);
            this.pringBtn.TabIndex = 2;
            this.pringBtn.Text = "条码打印";
            this.pringBtn.UseVisualStyleBackColor = true;
            this.pringBtn.Click += new System.EventHandler(this.pringBtn_Click);
            // 
            // catalogQueryBtn
            // 
            this.catalogQueryBtn.Location = new System.Drawing.Point(538, 92);
            this.catalogQueryBtn.Name = "catalogQueryBtn";
            this.catalogQueryBtn.Size = new System.Drawing.Size(100, 75);
            this.catalogQueryBtn.TabIndex = 3;
            this.catalogQueryBtn.Text = "编目查询";
            this.catalogQueryBtn.UseVisualStyleBackColor = true;
            this.catalogQueryBtn.Click += new System.EventHandler(this.catalogQueryBtn_Click);
            // 
            // CreateCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catalogQueryBtn);
            this.Controls.Add(this.pringBtn);
            this.Controls.Add(this.receiveBtn);
            this.Controls.Add(this.catalogNumberBtn);
            this.Name = "CreateCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新书编目";
            this.ResumeLayout(false);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateCatalogForm_FormClosing);
        }

        #endregion

        private System.Windows.Forms.Button catalogNumberBtn;
        private System.Windows.Forms.Button receiveBtn;
        private System.Windows.Forms.Button pringBtn;
        private System.Windows.Forms.Button catalogQueryBtn;
    }
}