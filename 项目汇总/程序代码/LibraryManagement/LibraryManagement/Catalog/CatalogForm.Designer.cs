namespace LibraryManagement.Catalog
{
    partial class CatalogForm
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
            this.createCatalogBtn = new System.Windows.Forms.Button();
            this.newBookBtn = new System.Windows.Forms.Button();
            this.cancelBookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createCatalogBtn
            // 
            this.createCatalogBtn.Location = new System.Drawing.Point(283, 95);
            this.createCatalogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createCatalogBtn.Name = "createCatalogBtn";
            this.createCatalogBtn.Size = new System.Drawing.Size(100, 75);
            this.createCatalogBtn.TabIndex = 0;
            this.createCatalogBtn.Text = "新书编目";
            this.createCatalogBtn.UseVisualStyleBackColor = true;
            this.createCatalogBtn.Click += new System.EventHandler(this.createCatalogBtn_Click);
            // 
            // newBookBtn
            // 
            this.newBookBtn.Location = new System.Drawing.Point(84, 95);
            this.newBookBtn.Name = "newBookBtn";
            this.newBookBtn.Size = new System.Drawing.Size(100, 75);
            this.newBookBtn.TabIndex = 1;
            this.newBookBtn.Text = "新书通报";
            this.newBookBtn.UseVisualStyleBackColor = true;
            this.newBookBtn.Click += new System.EventHandler(this.newBookBtn_Click);
            // 
            // cancelBookBtn
            // 
            this.cancelBookBtn.Location = new System.Drawing.Point(477, 96);
            this.cancelBookBtn.Name = "cancelBookBtn";
            this.cancelBookBtn.Size = new System.Drawing.Size(100, 75);
            this.cancelBookBtn.TabIndex = 2;
            this.cancelBookBtn.Text = "注销报损";
            this.cancelBookBtn.UseVisualStyleBackColor = true;
            this.cancelBookBtn.Click += new System.EventHandler(this.cancelBookBtn_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBookBtn);
            this.Controls.Add(this.newBookBtn);
            this.Controls.Add(this.createCatalogBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CatalogForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createCatalogBtn;
        private System.Windows.Forms.Button newBookBtn;
        private System.Windows.Forms.Button cancelBookBtn;
    }
}