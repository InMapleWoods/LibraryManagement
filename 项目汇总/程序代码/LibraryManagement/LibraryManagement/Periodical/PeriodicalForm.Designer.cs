namespace LibraryManagement.Periodical
{
    partial class PeriodicalForm
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
            this.orderButton = new System.Windows.Forms.Button();
            this.arriveButton = new System.Windows.Forms.Button();
            this.bindiButton = new System.Windows.Forms.Button();
            this.reportFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(120, 101);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(100, 100);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "期刊订购";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // arriveButton
            // 
            this.arriveButton.Location = new System.Drawing.Point(277, 101);
            this.arriveButton.Name = "arriveButton";
            this.arriveButton.Size = new System.Drawing.Size(94, 100);
            this.arriveButton.TabIndex = 2;
            this.arriveButton.Text = "期刊登到";
            this.arriveButton.UseVisualStyleBackColor = true;
            this.arriveButton.Click += new System.EventHandler(this.arriveButton_Click);
            // 
            // bindiButton
            // 
            this.bindiButton.Location = new System.Drawing.Point(437, 101);
            this.bindiButton.Name = "bindiButton";
            this.bindiButton.Size = new System.Drawing.Size(94, 100);
            this.bindiButton.TabIndex = 3;
            this.bindiButton.Text = "期刊装订";
            this.bindiButton.UseVisualStyleBackColor = true;
            this.bindiButton.Click += new System.EventHandler(this.bindiButton_Click);
            // 
            // reportFormButton
            // 
            this.reportFormButton.Location = new System.Drawing.Point(589, 101);
            this.reportFormButton.Name = "reportFormButton";
            this.reportFormButton.Size = new System.Drawing.Size(94, 100);
            this.reportFormButton.TabIndex = 4;
            this.reportFormButton.Text = "报表查询";
            this.reportFormButton.UseVisualStyleBackColor = true;
            // 
            // PeriodicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportFormButton);
            this.Controls.Add(this.bindiButton);
            this.Controls.Add(this.arriveButton);
            this.Controls.Add(this.orderButton);
            this.Name = "PeriodicalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "期刊子系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PeriodicalForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button arriveButton;
        private System.Windows.Forms.Button bindiButton;
        private System.Windows.Forms.Button reportFormButton;
    }
}