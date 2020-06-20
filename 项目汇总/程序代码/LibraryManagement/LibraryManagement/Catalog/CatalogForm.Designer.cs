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
            this.directCatalogBtn = new System.Windows.Forms.Button();
            this.catalogingTransferBtn = new System.Windows.Forms.Button();
            this.cancelBookBtn = new System.Windows.Forms.Button();
            this.catalogQueryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directCatalogBtn
            // 
            this.directCatalogBtn.Location = new System.Drawing.Point(96, 114);
            this.directCatalogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.directCatalogBtn.Name = "directCatalogBtn";
            this.directCatalogBtn.Size = new System.Drawing.Size(112, 90);
            this.directCatalogBtn.TabIndex = 0;
            this.directCatalogBtn.Text = "直接编目";
            this.directCatalogBtn.UseVisualStyleBackColor = true;
            this.directCatalogBtn.Click += new System.EventHandler(this.createCatalogBtn_Click);
            // 
            // catalogingTransferBtn
            // 
            this.catalogingTransferBtn.Location = new System.Drawing.Point(280, 114);
            this.catalogingTransferBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catalogingTransferBtn.Name = "catalogingTransferBtn";
            this.catalogingTransferBtn.Size = new System.Drawing.Size(112, 90);
            this.catalogingTransferBtn.TabIndex = 1;
            this.catalogingTransferBtn.Text = "编目移送";
            this.catalogingTransferBtn.UseVisualStyleBackColor = true;
            this.catalogingTransferBtn.Click += new System.EventHandler(this.newBookBtn_Click);
            // 
            // cancelBookBtn
            // 
            this.cancelBookBtn.Location = new System.Drawing.Point(665, 114);
            this.cancelBookBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBookBtn.Name = "cancelBookBtn";
            this.cancelBookBtn.Size = new System.Drawing.Size(112, 90);
            this.cancelBookBtn.TabIndex = 2;
            this.cancelBookBtn.Text = "注销报损";
            this.cancelBookBtn.UseVisualStyleBackColor = true;
            this.cancelBookBtn.Click += new System.EventHandler(this.cancelBookBtn_Click);
            // 
            // catalogQueryBtn
            // 
            this.catalogQueryBtn.Location = new System.Drawing.Point(454, 114);
            this.catalogQueryBtn.Name = "catalogQueryBtn";
            this.catalogQueryBtn.Size = new System.Drawing.Size(138, 90);
            this.catalogQueryBtn.TabIndex = 3;
            this.catalogQueryBtn.Text = "编目查询";
            this.catalogQueryBtn.UseVisualStyleBackColor = true;
            this.catalogQueryBtn.Click += new System.EventHandler(this.catalogQueryBtn_Click_1);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.catalogQueryBtn);
            this.Controls.Add(this.cancelBookBtn);
            this.Controls.Add(this.catalogingTransferBtn);
            this.Controls.Add(this.directCatalogBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CatalogForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button directCatalogBtn;
        private System.Windows.Forms.Button catalogingTransferBtn;
        private System.Windows.Forms.Button cancelBookBtn;
        private System.Windows.Forms.Button catalogQueryBtn;
    }
}