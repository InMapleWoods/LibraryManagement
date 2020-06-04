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
            this.SuspendLayout();
            // 
            // createCatalogBtn
            // 
            this.createCatalogBtn.Location = new System.Drawing.Point(318, 114);
            this.createCatalogBtn.Name = "createCatalogBtn";
            this.createCatalogBtn.Size = new System.Drawing.Size(75, 75);
            this.createCatalogBtn.TabIndex = 0;
            this.createCatalogBtn.Text = "新书编目";
            this.createCatalogBtn.UseVisualStyleBackColor = true;
            this.createCatalogBtn.Click += new System.EventHandler(this.createCatalogBtn_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createCatalogBtn);
            this.Name = "CatalogForm";
            this.Text = "CatalogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createCatalogBtn;
    }
}