namespace LibraryManagement
{
    partial class MainForm
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
            this.periodicalSystemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // periodicalSystemButton
            // 
            this.periodicalSystemButton.Location = new System.Drawing.Point(439, 101);
            this.periodicalSystemButton.Name = "periodicalSystemButton";
            this.periodicalSystemButton.Size = new System.Drawing.Size(106, 75);
            this.periodicalSystemButton.TabIndex = 0;
            this.periodicalSystemButton.Text = "期刊子系统";
            this.periodicalSystemButton.UseVisualStyleBackColor = true;
            this.periodicalSystemButton.Click += new System.EventHandler(this.periodicalSystemButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.periodicalSystemButton);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button periodicalSystemButton;
    }
}